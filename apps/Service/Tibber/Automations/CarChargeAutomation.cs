using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using HomeAssistantGenerated;
using NetDaemonApps.apps.Service.Tibber.Models;
using Tibber.Sdk;

namespace NetDaemonApps.apps.Service.Tibber.Automations;

public class CarChargeAutomation
{
    private readonly decimal _kostnadpermil;
    private readonly ILogger<CarChargeAutomation> _logger;
    private readonly Entities _myEntities;
    private readonly CarSettings _settings;
    private int _chargeCount;

    //överföringspris 22,25 öre
    //Energiskatt 45 öre
    //13,7/4*X =16

    public CarChargeAutomation(IHaContext ha, ILogger<CarChargeAutomation> logger, CarSettings settings)
    {
        _logger = logger;
        _settings = settings;
        _myEntities = new Entities(ha);
        _kostnadpermil = _settings.FulePrice * settings.FuleConsumption * settings.ElectricDistance / 13.7m;
    }

    public void HandleChargeCarOnNigth(Subscription subscription)
    {
        _logger.LogDebug(
            $"ChargeHour run {_chargeCount}, Max price to use for charging {_kostnadpermil} or Max price to use if charging at plingot {_settings.PlingotPrice}");
        var priceInfo = subscription.PriceInfo;
        var prislista = priceInfo.Today.ToList();
        prislista.AddRange(priceInfo.Tomorrow);
        var translatedPrisLista = prislista.Select(x => new Pris(x));
        var currentPrice = new Pris(subscription.PriceInfo.Current);
        _logger.LogInformation($"Totalt pris inklusive nätavgift {currentPrice.TotalPriceInkElnat}");
        if (DateTime.Now > DateTime.Today.AddHours(value: 17))
        {
            //Om klockan är efter 17 så ska alla tider mellan nu och kl 7 i morgon på morgonen användas
            var activeHours = translatedPrisLista.Where(x =>
                x.StartTid >= DateTime.Today.AddHours(DateTime.Now.Hour) &&
                x.StartTid <= DateTime.Today.AddDays(value: 1).AddHours(value: 7)).ToList();

            CalculateIfCharge(activeHours, currentPrice);
        } else if (DateTime.Now < DateTime.Today.AddHours(value: 8))
        {
            //om klockan är innan klockan 7 på morgonen så ska alla tider mellan nu och klockan 7 användas
            var activeHours = translatedPrisLista.Where(x =>
                x.StartTid >= DateTime.Today.AddHours(DateTime.Now.Hour) &&
                x.StartTid <= DateTime.Today.AddHours(value: 7)).ToList();
            CalculateIfCharge(activeHours, currentPrice);
        } else
        {
            //låt den vara på om priset är low eller verry low
            if (currentPrice.Level is PriceLevel.VeryCheap or PriceLevel.Cheap)
            {
                _myEntities.Switch.Device88.TurnOn();
                _logger.LogDebug(
                    $"price is low, turn on switch. currentPrice {currentPrice.TotalPriceInkElnat}{currentPrice.Currency}");
            } else if (_myEntities.Sensor.UtomhusplugPower2.State > 200) //om bilen ladar så ska den inte slås av
            {
                _logger.LogDebug($"Bil laddas, rör inte. {_myEntities.Sensor.UtomhusplugPower2.State}W");
            } else
            {
                _myEntities.Switch.Device88.TurnOff();
                _logger.LogDebug(
                    $"Bil laddas inte så brytare stängs av. {_myEntities.Sensor.UtomhusplugPower2.State}W");
            }

            _logger.LogInformation("ChargeCount nollställs");
            _chargeCount = 0;
        }
    }

    private void CalculateIfCharge(IList<Pris> activeHours, Pris currentPris)
    {
        //vi vill bara ha tider som totalt är lägre än 
        List<Pris> ladtid;
        if (_settings.SkipFulePrice)
        {
            _logger.LogDebug("Hämtar alla");
            ladtid = activeHours.OrderBy(x => x.Total).Take(6 - _chargeCount).ToList();
        } else if (_settings.SkipPlingotPrice)
        {
            _logger.LogDebug($"Hämtar bara billigare än bensinpris {_kostnadpermil}");
            ladtid = activeHours.Where(x => x.TotalPriceInkElnat < _kostnadpermil).OrderBy(x => x.TotalPriceInkElnat)
                .Take(6 - _chargeCount).ToList();
        } else
        {
            _logger.LogDebug($"Hämtar bara billigare än Plingot pris {_settings.PlingotPrice}");
            ladtid = activeHours.Where(x => x.Total < _settings.PlingotPrice).OrderBy(x => x.TotalPriceInkElnat)
                .Take(6 - _chargeCount).ToList();
        }

        _logger.LogDebug(
            $"Ladtider kvar ({6 - _chargeCount}st) {JsonSerializer.Serialize(ladtid.Select(x => new {x.StartsAt, x.TotalPriceInkElnat}))}");
        _logger.LogInformation(
            $"Pris inkl. elnät {currentPris.TotalPriceInkElnat}{currentPris.Currency}. Pris exkl. elnät {currentPris.Total}{currentPris.Currency}. current time {currentPris.StartsAt}");
        if (ladtid.Select(x => x.StartsAt).Contains(currentPris.StartsAt))
        {
            _logger.LogInformation($"Bil laddas. Laddcount: {_chargeCount}");
            _logger.LogDebug($"Ladning drar just nu {_myEntities.Sensor.UtomhusplugPower2.State}w");
            _logger.LogDebug($"Enhet var i state {_myEntities.Switch.Device88.State}");
            _myEntities.Switch.Device88.TurnOn();
            Thread.Sleep(millisecondsTimeout: 2000);
            _logger.LogDebug($"Enhet är nu i state {_myEntities.Switch.Device88.State}");
            _logger.LogDebug($"Ladning drar just nu {_myEntities.Sensor.UtomhusplugPower2.State}w");
            _chargeCount++;
        } else
        {
            _logger.LogInformation("Billadning stängs av.");
            _logger.LogDebug($"Ladning drog innan avstängning {_myEntities.Sensor.UtomhusplugPower2.State}w");
            _logger.LogDebug($"Enhet var i state {_myEntities.Switch.Device88.State}");
            _myEntities.Switch.Device88.TurnOff();
            Thread.Sleep(millisecondsTimeout: 2000);
            _logger.LogDebug($"Enhet är nu i state {_myEntities.Switch.Device88.State}");
        }
    }
}
