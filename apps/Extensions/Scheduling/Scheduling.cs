using NetDaemon.Extensions.Scheduler;
using NetDaemonApps.apps.Service.Tibber;
using NetDaemonApps.apps.Service.Tibber.Automations;
using System.Threading.Tasks;

// Use unique namespaces for your apps if you going to share with others to avoid
// conflicting names
namespace NetDaemonApps.apps.Extensions.Scheduling;

/// <summary>
///     Showcase the scheduling capabilities of NetDaemon
/// </summary>
[NetDaemonApp]
public class SchedulingApp {
  public SchedulingApp(IHaContext ha, INetDaemonScheduler scheduler, TibberService tibberService, TibberAutomation tibberAutomation, CarChargeAutomation carChargeAutomation, ILogger<SchedulingApp> logger, FloorHeatAutomation floorHeatAutomation) {
    var now = DateTime.Now;
    var starttime = DateTime.Today.AddHours(now.Hour + 1).AddMinutes(3);
    scheduler.RunEvery(TimeSpan.FromHours(1), new DateTimeOffset(starttime), () => {

      var subscription = Task.Run(async () => await tibberService.GetCurrentSubscription()).Result;
      if(subscription == null) {
        logger.LogError("Didnt get any subscription from tibber");
        return;
      }
      //tibberAutomation.CurrentPriceAutomations(subscription);
      //carChargeAutomation.HandleChargeCarOnNigth(subscription);
      floorHeatAutomation.HandleFloreHeat(subscription);
      logger.LogInformation($"This is a scheduled action! run at {DateTime.Now} and current price is {subscription?.PriceInfo?.Current?.Total}{subscription?.PriceInfo?.Current?.Currency}");
    });
  }
}
