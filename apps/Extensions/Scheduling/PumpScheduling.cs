using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using Microsoft.Extensions.Options;
using NetDaemon.Extensions.Scheduler;
using TibberSmartPlug.apps.Models;
using TibberSmartPlug.apps.Services;

namespace TibberSmartPlug.apps.Extensions.Scheduling
{
    [NetDaemonApp]
    public class PumpScheduling
    {
        private readonly TibberService _tibber;
        private readonly PoolSchedulingSettings _config;
        private readonly SmartPlugScheduler _scheduler;
        private readonly HashSet<DateTimeOffset> _mainOffTimes = new();

        public PumpScheduling(
            IHaContext ha,
            IScheduler cron,
            INetDaemonScheduler scheduler,
            ILogger<PumpScheduling> logger,
            TibberService tibber,
            IOptions<PoolSchedulingSettings> config)
        {
            _tibber = tibber;
            _config = config.Value;
            _scheduler = new SmartPlugScheduler(ha, scheduler, logger);

            cron.ScheduleCron("15 0 * * *", Schedule);

            ha.Entity(_config.HeatingDeviceEntityId).StateChanges()
                .Where(e => e.New?.State == "on")
                .Subscribe(_ =>
                {
                    ha.CallService("switch", "turn_on", data: new { entity_id = _config.PumpDeviceEntityId });
                });

            Schedule();
        }

        public void RegisterMainDeviceOffTimes(IEnumerable<DateTimeOffset> times)
        {
            foreach (var t in times)
                _mainOffTimes.Add(t);
        }

        private void Schedule()
        {
            var prices = _tibber.GetCurrentSubscription().GetAwaiter().GetResult().PriceInfo.Today
                .Where(p => p.Total.HasValue).ToList();

            _scheduler.ScheduleDevice(
                _config.PumpDeviceEntityId,
                _config.PumpDeviceRunningPrice,
                _config.PumpDeviceHoursToRun,
                prices,
                delayIfOffTimes: _mainOffTimes,
                delay: TimeSpan.FromMinutes(10)
            );
        }
    }

}