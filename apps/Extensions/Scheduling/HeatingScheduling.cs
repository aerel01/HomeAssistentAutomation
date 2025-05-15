using System.Linq;
using System.Reactive.Concurrency;
using Microsoft.Extensions.Options;
using NetDaemon.Extensions.Scheduler;
using TibberSmartPlug.apps.Models;
using TibberSmartPlug.apps.Services;

namespace TibberSmartPlug.apps.Extensions.Scheduling
{
    [NetDaemonApp]
    public class HeatingScheduling
    {
        private readonly TibberService _tibber;
        private readonly PoolSchedulingSettings _config;
        private readonly SmartPlugScheduler _scheduler;
        private readonly PumpScheduling _pump;

        public HeatingScheduling(
            IScheduler cron,
            TibberService tibber,
            IOptions<PoolSchedulingSettings> config,
            SmartPlugScheduler scheduler,
            PumpScheduling extraDevice)
        {
            _tibber = tibber;
            _config = config.Value;
            _scheduler = scheduler;
            _pump = extraDevice;

            cron.ScheduleCron("10 0 * * *", Schedule);
            Schedule();
        }

        private void Schedule()
        {
            var prices = _tibber.GetCurrentSubscription().GetAwaiter().GetResult().PriceInfo.Today
                .Where(p => p.Total.HasValue).ToList();

            var sorted = prices.OrderBy(p => p.Total.Value).ToList();
            var turnOn = sorted.Where(p => p.Total.Value <= _config.RunningPrice).ToList();
            if (turnOn.Count < _config.HoursToRun)
                turnOn.AddRange(sorted.Except(turnOn).Take(_config.HoursToRun - turnOn.Count));

            var turnOff = sorted.Except(turnOn);
            var offTimes = turnOff.Select(p => DateTimeOffset.Parse(p.StartsAt));
            _pump.RegisterMainDeviceOffTimes(offTimes);

            _scheduler.ScheduleDevice(
                _config.HeatingDeviceEntityId,
                _config.RunningPrice,
                _config.HoursToRun,
                prices
            );
        }
    }
}