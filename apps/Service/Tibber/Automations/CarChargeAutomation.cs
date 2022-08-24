using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using HomeAssistantGenerated;
using Tibber.Sdk;

namespace NetDaemonApps.apps.Service.Tibber.Automations;

public class CarChargeAutomation
{
    private readonly IHaContext _ha;
    private readonly ILogger<CarChargeAutomation> _logger;
    private readonly Entities _myEntities;
    private int _chargeCount;
    private readonly CarSettings _settings;

    private readonly decimal _kostnadpermil = 0;

    //överföringspris 22,25 öre
    //Energiskatt 45 öre
    //13,7/4*X =16

    public CarChargeAutomation(IHaContext ha, ILogger<CarChargeAutomation> logger, CarSettings settings)
    {
        _logger = logger;
        _settings = settings;
        _ha = ha;
        _myEntities = new Entities(_ha);
        _kostnadpermil = (_settings.FulePrice * 0.8m * 4) / 13.7m;
    }

    public void HandleChargeCarOnNigth(Subscription subscription)
    {
        _logger.LogDebug($"ChargeHour run {_chargeCount}, Max price to use for charging {_kostnadpermil} or Max price to use if charging at plingot {_settings.PlingotPrice}");
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
                x.StartTid <= DateTime.Today.AddDays(value: 1).AddHours(value: 7));

            CalculateIfCharge(activeHours, currentPrice);
        } else if (DateTime.Now < DateTime.Today.AddHours(value: 7))
        {
            //om klockan är innan klockan 7 på morgonen så ska alla tider mellan nu och klockan 7 användas
            var activeHours = translatedPrisLista.Where(x =>
                x.StartTid >= DateTime.Today.AddHours(DateTime.Now.Hour) &&
                x.StartTid <= DateTime.Today.AddHours(value: 7));
            CalculateIfCharge(activeHours, currentPrice);
        } else
        {
            _logger.LogInformation("ChargeCount nollställs");
            _chargeCount = 0;
        }
    }

    private void CalculateIfCharge(IEnumerable<Pris> activeHours, Pris currentPris)
    {
        //vi vill bara ha tider som totalt är lägre än 
        var ladtid = new List<Pris>();
        if (_settings.SkipFulePrice)
        {
            _logger.LogDebug("Hämtar alla");
            ladtid = activeHours.OrderBy(x => x.Total).Take(6 - _chargeCount).ToList();
        }else if (_settings.SkipPlingotPrice)
        {
            _logger.LogDebug("Hämtar bara billigare än bensinpris");
            ladtid = activeHours.Where(x => x.TotalPriceInkElnat < _kostnadpermil).OrderBy(x => x.TotalPriceInkElnat).Take(6 - _chargeCount).ToList();
        } else
        {
            _logger.LogDebug("Hämtar bara billigare än Plingot pris");
            ladtid = activeHours.Where(x => x.Total < _settings.PlingotPrice).OrderBy(x => x.TotalPriceInkElnat).Take(6 - _chargeCount).ToList();
        }
        
        _logger.LogDebug(
            $"Ladtider kvar ({6 - _chargeCount}st) {JsonSerializer.Serialize(ladtid.Select(x => new {x.StartsAt, x.TotalPriceInkElnat }))}");
        _logger.LogInformation(
            $"Pris inkl. elnät {currentPris.TotalPriceInkElnat}{currentPris.Currency}. Pris exkl. elnät {currentPris.TotalPriceInkElnat}{currentPris.Currency}");
        if (ladtid.Select(x => x.StartsAt).Contains(currentPris.StartsAt) &&
            activeHours.Count(x => x.Level == PriceLevel.Cheap || x.Level == PriceLevel.VeryCheap) >= 5 - _chargeCount)
        {
            _logger.LogInformation($"Bil laddas. Laddcount: {_chargeCount}");
            _logger.LogDebug($"Ladning drar just nu {_myEntities.Sensor.UtomhusplugPower2.State}w");
            _logger.LogDebug($"Enhet var i state {_myEntities.Switch.Device88.State}");
            _myEntities.Switch.Device88.TurnOn();
            _chargeCount++;
        } else
        {
            _logger.LogInformation("Billadning stängs av.");
            _logger.LogDebug($"Ladning drog innan avstängning {_myEntities.Sensor.UtomhusplugPower2.State}w");
            _logger.LogDebug($"Enhet var i state {_myEntities.Switch.Device88.State}");
            _myEntities.Switch.Device88.TurnOff();
        }
    }

    private class Pris : Price
    {
        private static readonly decimal Overforingsavgift = 0.2225m; //överföringsavgift nätavgift
        private static readonly decimal Energiskatt = 0.45m; //energiskatt på nätavgift

        public Pris(Price price)
        {
            Currency = price.Currency;
            Energy = price.Energy;
            Level = price.Level;
            StartsAt = price.StartsAt;
            Tax = price.Tax;
            Total = price.Total;
        }

        public DateTime StartTid => DateTime.Parse(StartsAt);
        public decimal? TotalPriceInkElnat => Total + Overforingsavgift + Energiskatt;
    }
}
