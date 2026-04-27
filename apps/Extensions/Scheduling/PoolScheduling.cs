using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using NetDaemon.Extensions.Scheduler;
using System.Reactive.Concurrency;
using Tibber.Sdk;
using TibberSmartPlug.apps.Services;
using TibberSmartPlug.apps.Models;
using Microsoft.Extensions.Options;

namespace TibberSmartPlug.apps.Extensions.Scheduling
{
    [NetDaemonApp]
    public class PoolScheduling
    {
        private readonly IHaContext _ha;
        private readonly ILogger<PoolScheduling> _logger;
        private readonly TibberService tibberService;
        private readonly PoolSchedulingSettings poolSchedulingSettings;
        private readonly INetDaemonScheduler runScheduler;
        private readonly HashSet<DateTimeOffset> _scheduledTimes = [];

        private const string SmartPlugEntityId = "switch.pool_power_switch";

        public PoolScheduling(
            IHaContext ha,
            IScheduler cronScheduler,
            INetDaemonScheduler runScheduler,
            ILogger<PoolScheduling> logger,
            TibberService tibberService,
            IOptions<PoolSchedulingSettings> config)
        {
            this.tibberService = tibberService;
            this.poolSchedulingSettings = config.Value;
            this.runScheduler = runScheduler;
            _ha = ha;
            _logger = logger;

            cronScheduler.ScheduleCron("10 0 * * *", () =>
            {
                _logger.LogInformation("Kör daglig schemaläggning 00:10");
                ScheduleSmartPlug();
            });

            // Kör även direkt vid uppstart
            ScheduleSmartPlug();
        }

        private void ScheduleSmartPlug()
        {
            var subscription = tibberService.GetCurrentSubscription().GetAwaiter().GetResult();
            var priceInfo = subscription.PriceInfo;

            var prislista = priceInfo.Today
                .Where(p => p.Total.HasValue)
                .OrderBy(p => p.Total.Value)
                .ToList();

            // Välj alla under maxpris
            var turnOn = prislista
                .Where(p => p.Total.Value <= poolSchedulingSettings.RunningPrice)
                .ToList();

            // Komplettera med billigaste om för få
            if (turnOn.Count < poolSchedulingSettings.HoursToRun)
            {
                var extra = prislista.Except(turnOn).Take(poolSchedulingSettings.HoursToRun - turnOn.Count);
                turnOn.AddRange(extra);
            }

            var turnOff = prislista.Except(turnOn).ToList();

            _logger.LogInformation(
                "Regelverk poolvärme: Maxpris={RunningPrice:F3}, Min drifttid={HoursToRun}h",
                poolSchedulingSettings.RunningPrice,
                poolSchedulingSettings.HoursToRun);

            foreach (var price in turnOn
                .OrderBy(p => DateTimeOffset.TryParse(p.StartsAt, out var startsAt) ? startsAt : DateTimeOffset.MaxValue)
                .ToList())
            {
                if (!DateTimeOffset.TryParse(price.StartsAt, out var startsAt))
                {
                    _logger.LogInformation("Schemalagd påslagen tid {Time} pris {Price}",
                        price.StartsAt, FormatPriceForLog(price.Total));
                    continue;
                }

                _logger.LogInformation("Schemalagd påslagen tid {Time} pris {Price}",
                    startsAt.ToString("yyyy-MM-dd HH:mm"), FormatPriceForLog(price.Total));
            }

            foreach (var price in turnOff
                .OrderBy(p => DateTimeOffset.TryParse(p.StartsAt, out var startsAt) ? startsAt : DateTimeOffset.MaxValue)
                .ToList())
            {
                if (!DateTimeOffset.TryParse(price.StartsAt, out var startsAt))
                {
                    _logger.LogInformation("Schemalagd avstängd tid {Time} pris {Price}",
                        price.StartsAt, FormatPriceForLog(price.Total));
                    continue;
                }

                _logger.LogInformation("Schemalagd avstängd tid {Time} pris {Price}",
                    startsAt.ToString("yyyy-MM-dd HH:mm"), FormatPriceForLog(price.Total));
            }

            foreach (var price in turnOn)
                ScheduleAction(price, true);

            foreach (var price in turnOff)
                ScheduleAction(price, false);
        }

        private void ScheduleAction(Price price, bool turnOn)
        {
            if (!DateTimeOffset.TryParse(price.StartsAt, out var runAt))
            {
                _logger.LogWarning("Kunde inte parsa StartsAt: {StartsAt}", price.StartsAt);
                return;
            }

            if (runAt <= DateTimeOffset.Now)
            {
                _logger.LogInformation("Hoppar över {Action} vid {Time} - redan passerad", turnOn ? "påslag" : "avstängning", runAt);
                return;
            }

            if (_scheduledTimes.Contains(runAt))
            {
                _logger.LogInformation("Hoppar över {Action} vid {Time} - redan schemalagd", turnOn ? "påslag" : "avstängning", runAt);
                return;
            }

            _scheduledTimes.Add(runAt);

            runScheduler.RunAt(runAt, () =>
            {
                _logger.LogInformation("Slår {Action} pluggen kl {Time}, pris: {Price}",
                    turnOn ? "PÅ" : "AV", runAt, price.Total);

                SetPlugState(turnOn, price.StartsAt, price.Total);
            });
        }

        private void SetPlugState(bool turnOn, string time, decimal? price)
        {
            var service = turnOn ? "turn_on" : "turn_off";
            _ha.CallService("switch", service, data: new { entity_id = SmartPlugEntityId });
        }

        private static string FormatPriceForLog(decimal? price)
        {
            if (!price.HasValue)
                return "okänt";

            if (price.Value < 1m)
                return $"{(price.Value * 100m).ToString("N1", CultureInfo.GetCultureInfo("sv-SE"))} öre";

            return $"{price.Value.ToString("N3", CultureInfo.GetCultureInfo("sv-SE"))} kr";
        }
    }
}
