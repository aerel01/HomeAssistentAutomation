using System.Linq;
using System.Threading.Tasks;
using Tibber.Sdk;

namespace NetDaemonApps.apps.Service.Tibber
{
    public class TibberService
    {
        private readonly TibberApiClient _tibberApiClient;
        private readonly ILogger<TibberService> _logger;
        public TibberService(TibberApiClient tibberApiClient, ILogger<TibberService> logger)
        {
            _tibberApiClient = tibberApiClient;
            _logger = logger;
        }

        public async Task<Price?> GetCurrentPriceAsync()
        {
            var basicData = await _tibberApiClient.GetBasicData();
            var homeId = basicData?.Data?.Viewer?.Homes?.FirstOrDefault()?.Id.Value;
            if (homeId == null)
            {
                _logger.LogError("Couldent get homeId and basic data");
                return null;
            }
            var customQueryBuilder =
            new TibberQueryBuilder()
               .WithAllScalarFields()
               .WithViewer(
                   new ViewerQueryBuilder()
                       .WithHome(
                           new HomeQueryBuilder()
                               .WithCurrentSubscription(
                                   new SubscriptionQueryBuilder()
                                       .WithPriceInfo(
                                           new PriceInfoQueryBuilder()
                                           .WithCurrent(new PriceQueryBuilder().WithAllFields())
                                           )
                               ),
                           homeId
                       )
               );
            var customQuery = customQueryBuilder.Build(); // produces plain GraphQL query text
            var result = await _tibberApiClient.Query(customQuery);
            var priceInfo = result.Data.Viewer.Home.CurrentSubscription.PriceInfo;
            var current = priceInfo.Current;
            return current;
        }
    }
}
