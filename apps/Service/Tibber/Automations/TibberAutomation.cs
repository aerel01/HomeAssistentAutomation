using HomeAssistantGenerated;
using Tibber.Sdk;
using NetDaemonApps.apps.Service.Tibber.Models;

namespace NetDaemonApps.apps.Service.Tibber.Automations
{
    public class TibberAutomation
    {
        private readonly ILogger<TibberAutomation> _logger;
        private readonly IHaContext _ha;
        private readonly Entities _myEntities;
        public TibberAutomation(IHaContext ha, ILogger<TibberAutomation> logger)
        {
            _logger = logger;
            _ha = ha;
            _myEntities = new Entities(_ha);
        }

        public void CurrentPriceAutomations(Subscription subscription)
        {
            
            if (subscription?.PriceInfo?.Current == null)
            {
                _logger.LogError("Price is null");
                return;
            }
            var price = new Pris(subscription.PriceInfo.Current);
            //var utomhusplug = _myEntities.Switch.Device88;
            var allaDekoration1 = _myEntities.Light.GruppTavlor;
            var allaDekoration2 = _myEntities.Light.GruppTavlor2;
            var golvvärme = _myEntities.Switch.GolvvarmeTimer;
            switch (price.Level)
            {
                case PriceLevel.VeryCheap:
                    //slå bara på golvvärmen på morgonen mellan kl 5-8
                    if (DateTime.UtcNow.AddHours(2).Hour >= 5 && DateTime.UtcNow.AddHours(2).Hour <= 8)
                    {
                        _logger.LogInformation($"Slå på golvvärme. priset är {price.TotalPriceInkElnat}");
                        golvvärme.TurnOn();
                    }
                    break;
                case PriceLevel.Cheap:
              //      utomhusplug.TurnOn();
                    //slå bara på golvvärmen på morgonen
                    if (DateTime.UtcNow.AddHours(2).Hour >= 5 && DateTime.UtcNow.AddHours(2).Hour <= 8)
                    {
                        _logger.LogInformation($"Slå på golvvärme. priset är {price.TotalPriceInkElnat}");
                        golvvärme.TurnOn();
                    }
                    break;
                case PriceLevel.Normal:
                    _logger.LogInformation($"Slå av golvvärme. priset är {price.TotalPriceInkElnat}");
                    golvvärme.TurnOff();
                    break;
                case PriceLevel.Expensive:
                    _logger.LogInformation($"Slå av golvvärme. priset är {price.TotalPriceInkElnat}");
                    golvvärme.TurnOff();
                    break;
                case PriceLevel.VeryExpensive:
                    _logger.LogInformation($"Slå av golvvärme, allaDekoration1, allaDekoration2. priset är {price.TotalPriceInkElnat}");
                    golvvärme.TurnOff();
                    allaDekoration1.TurnOff();
                    allaDekoration2.TurnOff();
                    break;
            }
        }




    }

}
