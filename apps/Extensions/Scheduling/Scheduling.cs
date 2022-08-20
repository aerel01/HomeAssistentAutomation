using NetDaemon.Extensions.Scheduler;
using NetDaemonApps.apps.Service.Tibber;
using Tibber.Sdk;

// Use unique namespaces for your apps if you going to share with others to avoid
// conflicting names
namespace Extensions.Scheduling;

/// <summary>
///     Showcase the scheduling capabilities of NetDaemon
/// </summary>
[NetDaemonApp]
public class SchedulingApp
{
    public SchedulingApp(IHaContext ha, INetDaemonScheduler scheduler,TibberService tibberService, TibberAutomation tibberAutomation)
    {
        var count = 0;
        var now = DateTime.Now;
        var starttime = DateTime.Today.AddHours(now.Hour+1).AddMinutes(3);
        scheduler.RunEvery(TimeSpan.FromHours(1), new DateTimeOffset(starttime), () => {
            
            var price = tibberService.GetCurrentPriceAsync().Result;
            tibberAutomation.CurrentPriceAutomations(price);
            ha.CallService("notify", "persistent_notification",
                data: new { message = $"This is a scheduled action! run at {DateTime.Now} and current price is {price?.Total}{price?.Currency}", title = "Schedule!" });
        });
    }
}