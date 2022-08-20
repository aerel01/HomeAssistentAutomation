using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tibber.Sdk;

namespace NetDaemonApps.apps.Service.Tibber
{
    public class TibberService
    {
        private readonly TibberApiClient _tibberApiClient;
        private readonly ILogger<TibberService> _logger;
        private readonly Guid? _homeId;
        private readonly TibberQueryBuilder _customQueryBuilder;
        private SubscriptionQueryBuilder _subscriptionQueryBuilder;
        public TibberService(TibberApiClient tibberApiClient, ILogger<TibberService> logger)
        {
            _subscriptionQueryBuilder = new SubscriptionQueryBuilder();
            _tibberApiClient = tibberApiClient;
            _logger = logger;
            _homeId = GetHomeId().Result;
            _customQueryBuilder = new TibberQueryBuilder()
               .WithAllScalarFields()
               .WithViewer(
                   new ViewerQueryBuilder()
                       .WithHome(
                           new HomeQueryBuilder()
                               .WithCurrentSubscription(_subscriptionQueryBuilder),
                           _homeId
                       )
               );
        }
        public async Task<Subscription?> GetCurrentSubscription()
        {
            if (_homeId == null)
            {
                _logger.LogError("HomeId is null");
                return null;
            }
            _subscriptionQueryBuilder
                .WithAllScalarFields()
                                .WithSubscriber(new LegalEntityQueryBuilder().WithAllFields())
                                .WithPriceInfo(new PriceInfoQueryBuilder()
                                    .WithCurrent(new PriceQueryBuilder().WithAllFields())
                                    .WithTomorrow(new PriceQueryBuilder().WithAllFields())
                                    .WithToday(new PriceQueryBuilder().WithAllFields())
                                    );
            var customQuery = _customQueryBuilder.Build(); // produces plain GraphQL query text
            var result = await _tibberApiClient.Query(customQuery);
            return result.Data.Viewer.Home.CurrentSubscription;
        }
        public async Task<Price?> GetCurrentPriceAsync()
        {
            if (_homeId == null)
            {
                _logger.LogError("HomeId is null");
                return null;
            }
            _subscriptionQueryBuilder.WithPriceInfo(new PriceInfoQueryBuilder().WithCurrent(new PriceQueryBuilder().WithAllFields()));
            var customQuery = _customQueryBuilder.Build(); // produces plain GraphQL query text
            var result = await _tibberApiClient.Query(customQuery);
            var priceInfo = result.Data.Viewer.Home.CurrentSubscription.PriceInfo;
            var current = priceInfo.Current;
            return current;
        }

        public async Task<IList<Price>> GetAsync()
        {
            if (_homeId == null)
            {
                _logger.LogError("HomeId is null");
                return new List<Price>();
            }
            _subscriptionQueryBuilder
                .WithPriceInfo(
                    new PriceInfoQueryBuilder()
                        .WithToday(new PriceQueryBuilder().WithAllFields())
                        .WithTomorrow(new PriceQueryBuilder().WithAllFields()));
            var customQuery = _customQueryBuilder.Build(); // produces plain GraphQL query text
            var result = await _tibberApiClient.Query(customQuery);
            var priceInfo = result.Data.Viewer.Home.CurrentSubscription.PriceInfo;
            var today = priceInfo.Today.ToList();
            var tomarrow = priceInfo.Tomorrow.ToList();
            today.AddRange(tomarrow);
            return today;
        }
        private async Task<Guid?> GetHomeId()
        {
            var basicData = await _tibberApiClient.GetBasicData();
            var homeId = basicData?.Data?.Viewer?.Homes?.FirstOrDefault()?.Id.Value;
            if (homeId == null)
            {
                _logger.LogError("Couldent get homeId and basic data");
                return null;
            }
            return homeId;
        }
    }
}
