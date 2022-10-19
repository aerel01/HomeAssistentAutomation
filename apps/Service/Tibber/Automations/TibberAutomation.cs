using HomeAssistantGenerated;
using Tibber.Sdk;

namespace NetDaemonApps.apps.Service.Tibber.Automations;

public class TibberAutomation {
    private readonly ILogger<TibberAutomation> _logger;
    private readonly Entities _myEntities;

    public TibberAutomation(IHaContext ha, ILogger<TibberAutomation> logger) {
        _logger = logger;
        _myEntities = new Entities(ha);
    }

    public void CurrentPriceAutomations(Subscription subscription) {
        var price = subscription.PriceInfo.Current;
        if(price == null) {
            _logger.LogError("Price is null");
            return;
        }

        var allaDekoration1 = _myEntities.Light.GruppTavlor;
        var allaDekoration2 = _myEntities.Light.GruppTavlor2;
        switch(price.Level) {
            case PriceLevel.VeryCheap:
                break;
            case PriceLevel.Cheap:
                break;
            case PriceLevel.Normal:
                break;
            case PriceLevel.Expensive:
                break;
            case PriceLevel.VeryExpensive:
                allaDekoration1.TurnOff();
                allaDekoration2.TurnOff();
                break;
        }
    }
}
