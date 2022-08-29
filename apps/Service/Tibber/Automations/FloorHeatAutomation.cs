using NetDaemonApps.apps.Service.Tibber.Models;
using Tibber.Sdk;

namespace NetDaemonApps.apps.Service.Tibber.Automations;

public class FloorHeatAutomation
{
    private readonly IHaContext _ha;
    private readonly ILogger<FloorHeatAutomation> _logger;

    public FloorHeatAutomation(IHaContext ha, ILogger<FloorHeatAutomation> logger)
    {
        _logger = logger;
        _ha = ha;
    }

    public void HandleFloreHeat(Subscription subscription)
    {
        var currentPrice = new Pris(subscription.PriceInfo.Current);
        var dayOfWeek = DateTime.Today.DayOfWeek;

        _logger.LogInformation(
            $"Price level is {currentPrice.Level} price is {currentPrice.TotalPriceInkElnat}{currentPrice.Currency}");
        if (currentPrice.Level == PriceLevel.VeryCheap || currentPrice.Level == PriceLevel.Cheap)
        {
            if (dayOfWeek == DayOfWeek.Sunday || dayOfWeek == DayOfWeek.Saturday)
            {
                if (DateTime.Now > DateTime.Today.AddDays(value: 7) && DateTime.Now < DateTime.Today.AddDays(value: 21))
                {
                    _logger.LogInformation(
                        $"Price is {currentPrice.TotalPriceInkElnat}{currentPrice.Currency} golvvärme sätts på");
                    _ha.Entity("switch.shellyplug_s_de1fef").CallService("turn_on");
                } else
                {
                    _logger.LogInformation(
                        $"Price is {currentPrice.TotalPriceInkElnat}{currentPrice.Currency} golvvärme stängs av");
                    _ha.Entity("switch.shellyplug_s_de1fef").CallService("turn_off");
                }
            } else
            {
                if ((DateTime.Now > DateTime.Today.AddDays(value: 5) &&
                     DateTime.Now < DateTime.Today.AddDays(value: 7)) ||
                    (DateTime.Now > DateTime.Today.AddDays(value: 15) &&
                     DateTime.Now < DateTime.Today.AddDays(value: 21)))
                {
                    _logger.LogInformation(
                        $"Price is {currentPrice.TotalPriceInkElnat}{currentPrice.Currency} golvvärme sätts på");
                    _ha.Entity("switch.shellyplug_s_de1fef").CallService("turn_on");
                } else
                {
                    _logger.LogInformation(
                        $"Price is {currentPrice.TotalPriceInkElnat}{currentPrice.Currency} golvvärme stängs av");
                    _ha.Entity("switch.shellyplug_s_de1fef").CallService("turn_off");
                }
            }
        } else
        {
            _logger.LogInformation(
                $"Price is {currentPrice.TotalPriceInkElnat}{currentPrice.Currency} golvvärme stängs av");
            _ha.Entity("switch.shellyplug_s_de1fef").CallService("turn_off");
        }
    }
}
