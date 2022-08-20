using HomeAssistantGenerated;
using System.Collections.Generic;
using System.Linq;
using Tibber.Sdk;

namespace NetDaemonApps.apps.Service.Tibber.Automations
{
    public class CarChargeAutomation
    {
        private readonly ILogger<CarChargeAutomation> _logger;
        private readonly IHaContext _ha;
        private readonly Entities _myEntities;
        private int _chargeCount = 0;
        public CarChargeAutomation(IHaContext ha, ILogger<CarChargeAutomation> logger)
        {
            _logger = logger;
            _ha = ha;
            _myEntities = new Entities(_ha);
        }
        public void HandleChargeCarOnNigth(Subscription subscription)
        {
            _logger.LogDebug($"ChargeHour left {_chargeCount}");
            var priceInfo = subscription.PriceInfo;
            var prislista = priceInfo.Today.ToList();
            prislista.AddRange(priceInfo.Tomorrow);
            var translatedPrisLista = prislista.Select(x => new Pris(x));
            

            if (DateTime.Now > DateTime.Today.AddHours(17))
            {
                var activeHours = translatedPrisLista.Where(x => x.StartTid >= DateTime.Today.AddHours(DateTime.Now.Hour) && x.StartTid <= DateTime.Today.AddDays(1).AddHours(7));
                CalculateIfCharge(activeHours, subscription);
            } else if (DateTime.Now < DateTime.Today.AddHours(7))
            {
                var activeHours = translatedPrisLista.Where(x => x.StartTid >= DateTime.Today.AddHours(DateTime.Now.Hour));
                CalculateIfCharge(activeHours, subscription);
            } else
            {
                _logger.LogInformation($"ChargeCount nollställs");
                _chargeCount = 0;
            }
        }

        private void CalculateIfCharge(IEnumerable<Price> activeHours, Subscription subscription)
        {
            var current = subscription.PriceInfo.Current;
            var ladtid = activeHours.OrderBy(x => x.Total).Take(6 - _chargeCount);
            if (ladtid.Select(x => x.StartsAt).Contains(current.StartsAt) && activeHours.Count(x => x.Level == PriceLevel.Cheap || x.Level == PriceLevel.VeryCheap) >= 5 - _chargeCount)
            {
                _logger.LogInformation($"Bil laddas. Pris {current.Total}{current.Currency} laddcount: {_chargeCount}");
                _myEntities.Switch.Device88.TurnOn();
                _chargeCount++;
            } else
            {
                _logger.LogInformation($"Billadning stängs av. Pris {current.Total}{current.Currency}");
                _myEntities.Switch.Device88.TurnOff();
            }
        }
        class Pris : Price
        {
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
        }
    }
}
