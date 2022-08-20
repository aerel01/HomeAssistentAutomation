using HomeAssistantGenerated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Tibber.Sdk;

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
            var price = subscription?.PriceInfo?.Current;
            if (price == null)
            {
                _logger.LogError("Price is null");
                return;
            }
            var utomhusplug = _myEntities.Switch.Device88;
            var allaDekoration1 = _myEntities.Light.GruppTavlor;
            var allaDekoration2 = _myEntities.Light.GruppTavlor2;
            var golvvärme = _myEntities.Switch.GolvvarmeTimer;
            switch (price.Level)
            {
                case PriceLevel.VeryCheap:
                    //slå bara på golvvärmen på morgonen mellan kl 5-8
                    if (DateTime.UtcNow.AddHours(2).Hour >= 5 && DateTime.UtcNow.AddHours(2).Hour <= 8)
                    {
                        golvvärme.TurnOn();
                    }
                    break;
                case PriceLevel.Cheap:
                    utomhusplug.TurnOn();
                    //slå bara på golvvärmen på morgonen
                    if (DateTime.UtcNow.AddHours(2).Hour >= 5 && DateTime.UtcNow.AddHours(2).Hour <= 8)
                    {
                        golvvärme.TurnOn();
                    }
                    break;
                case PriceLevel.Normal:
                    utomhusplug.TurnOff();
                    break;
                case PriceLevel.Expensive:
                    utomhusplug.TurnOff();
                    break;
                case PriceLevel.VeryExpensive:
                    utomhusplug.TurnOff();
                    allaDekoration1.TurnOff();
                    allaDekoration2.TurnOff();
                    break;
            }
        }




    }

}
