using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;
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
        private readonly TibberService _tibberService;
        private readonly PoolSchedulingSettings _poolSchedulingSettings;
        private readonly INetDaemonScheduler _runScheduler;
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
            _tibberService = tibberService;
            _poolSchedulingSettings = config.Value;
            _runScheduler = runScheduler;
            _ha = ha;
            _logger = logger;

            cronScheduler.ScheduleCron("10 0 * * *", () =>
            {
                _logger.LogInformation("Kör daglig schemaläggning 00:10");
                _ = ScheduleSmartPlugAsync();
            });

            // Kör även direkt vid uppstart
            _ = ScheduleSmartPlugAsync();
        }

        private async Task ScheduleSmartPlugAsync()
        {
            try
            {
                var subscription = await _tibberService.GetCurrentSubscription();
                var priceInfo = subscription.PriceInfo;

                var prislista = priceInfo.Today
                    .Where(p => p.Total.HasValue)
                    .OrderBy(p => p.Total.Value)
                    .ToList();

                // Välj alla under maxpris
                var turnOn = prislista
                    .Where(p => p.Total.Value <= _poolSchedulingSettings.RunningPrice)
                    .ToList();

                // Komplettera med billigaste om för få
                if (turnOn.Count < _poolSchedulingSettings.HoursToRun)
                {
                    var extra = prislista.Except(turnOn).Take(_poolSchedulingSettings.HoursToRun - turnOn.Count);
                    turnOn.AddRange(extra);
                }

                var turnOff = prislista.Except(turnOn).ToList();

                _logger.LogInformation(
                    "Regelverk poolvärme: Maxpris={RunningPrice:F3}, Min drifttid={HoursToRun}h",
                    _poolSchedulingSettings.RunningPrice,
                    _poolSchedulingSettings.HoursToRun);

                CleanupScheduledTimes();
                LogScheduledPrices(turnOn, "påslagen");
                LogScheduledPrices(turnOff, "avstängd");

                foreach (var price in turnOn)
                    ScheduleAction(price, true);

                foreach (var price in turnOff)
                    ScheduleAction(price, false);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Kunde inte schemalägga pool-pluggen utifrån Tibber-priser");
            }
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
            _runScheduler.RunAt(runAt, () =>
            {
                _logger.LogInformation("Slår {Action} pluggen kl {Time}, pris: {Price}",
                    turnOn ? "PÅ" : "AV", runAt, price.Total);

                SetPlugState(turnOn);
            });
        }

        private void SetPlugState(bool turnOn)
        {
            var service = turnOn ? "turn_on" : "turn_off";
            _ha.CallService("switch", service, data: new { entity_id = SmartPlugEntityId });
        }

        private void CleanupScheduledTimes()
        {
            _scheduledTimes.RemoveWhere(t => t <= DateTimeOffset.Now);
        }

        private void LogScheduledPrices(IEnumerable<Price> prices, string actionLabel)
        {
            foreach (var price in prices
                .OrderBy(p => DateTimeOffset.TryParse(p.StartsAt, out var startsAt) ? startsAt : DateTimeOffset.MaxValue))
            {
                if (!DateTimeOffset.TryParse(price.StartsAt, out var startsAt))
                {
                    _logger.LogInformation("Schemalagd {Action} tid {Time} pris {Price}",
                        actionLabel, price.StartsAt, FormatPriceForLog(price.Total));
                    continue;
                }

                _logger.LogInformation("Schemalagd {Action} tid {Time} pris {Price}",
                    actionLabel, startsAt.ToString("yyyy-MM-dd HH:mm"), FormatPriceForLog(price.Total));
            }
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
