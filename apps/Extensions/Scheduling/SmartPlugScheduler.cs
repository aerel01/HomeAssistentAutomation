using System.Collections.Generic;
using System.Linq;
using NetDaemon.Extensions.Scheduler;
using Tibber.Sdk;

namespace TibberSmartPlug.apps.Extensions.Scheduling
{
    public class SmartPlugScheduler
    {
        private readonly IHaContext _ha;
        private readonly INetDaemonScheduler _scheduler;
        private readonly ILogger _logger;

        public SmartPlugScheduler(IHaContext ha, INetDaemonScheduler scheduler, ILogger logger)
        {
            _ha = ha;
            _scheduler = scheduler;
            _logger = logger;
        }

        public void ScheduleDevice(
            string entityId,
            decimal priceLimit,
            int minimumHours,
            IEnumerable<Price> prices,
            IEnumerable<DateTimeOffset>? delayIfOffTimes = null,
            TimeSpan? delay = null,
            Action<bool, DateTimeOffset>? onScheduled = null)
        {
            var sorted = prices
                .Where(p => p.Total.HasValue)
                .OrderBy(p => p.Total.Value)
                .ToList();

            var turnOn = sorted.Where(p => p.Total.Value <= priceLimit).ToList();

            if (turnOn.Count < minimumHours)
            {
                var extra = sorted.Except(turnOn).Take(minimumHours - turnOn.Count);
                turnOn.AddRange(extra);
            }

            var turnOff = sorted.Except(turnOn);

            foreach (var price in turnOn)
                Schedule(price, true);

            foreach (var price in turnOff)
                Schedule(price, false);

            void Schedule(Price price, bool turnOn)
            {
                if (!DateTimeOffset.TryParse(price.StartsAt, out var time) || time <= DateTimeOffset.Now)
                    return;

                if (!turnOn && delayIfOffTimes?.Contains(time) == true)
                    time = time.Add(delay ?? TimeSpan.Zero);

                _scheduler.RunAt(time, () =>
                {
                    var action = turnOn ? "turn_on" : "turn_off";
                    _logger.LogInformation("Enhet: {0} {1} kl {2} (pris: {3})", action, entityId, time, price.Total);
                    _ha.CallService("switch", action, data: new { entity_id = entityId });

                    onScheduled?.Invoke(turnOn, time);
                });
            }
        }
    }
}