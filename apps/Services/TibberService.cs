using System.Linq;
using System.Threading.Tasks;
using Tibber.Sdk;

namespace TibberSmartPlug.apps.Services
{
    /// <summary>
    /// Interface for the Tibber service to allow easy mocking in tests.
    /// </summary>
    public interface ITibberService
    {
        Task<Subscription?> GetCurrentSubscription();
    }

    /// <summary>
    /// Concrete Tibber API service to fetch pricing and subscription data.
    /// </summary>
    public class TibberService : ITibberService
    {
        private readonly TibberApiClient _tibberApiClient;
        private readonly ILogger<TibberService> _logger;
        private Guid? _homeId;

        public TibberService(TibberApiClient tibberApiClient, ILogger<TibberService> logger)
        {
            _tibberApiClient = tibberApiClient;
            _logger = logger;
        }

        /// <summary>
        /// Retrieves the current Tibber subscription including pricing info.
        /// </summary>
        public async Task<Subscription?> GetCurrentSubscription()
        {
            if (_homeId == null)
            {
                _logger.LogInformation("Fetching home ID for the first time.");
                _homeId = await GetHomeId();
            }

            if (_homeId == null)
            {
                _logger.LogError("HomeId is null. Cannot continue with subscription query.");
                return null;
            }

            _logger.LogInformation("Building subscription query for homeId {HomeId}.", _homeId);

            var subscriptionQueryBuilder = new SubscriptionQueryBuilder()
                .WithAllScalarFields()
                .WithSubscriber(new LegalEntityQueryBuilder().WithAllFields())
                .WithPriceInfo(new PriceInfoQueryBuilder()
                    .WithCurrent(new PriceQueryBuilder().WithAllFields())
                    .WithTomorrow(new PriceQueryBuilder().WithAllFields())
                    .WithToday(new PriceQueryBuilder().WithAllFields()));

            var customQueryBuilder = new TibberQueryBuilder()
                .WithAllScalarFields()
                .WithViewer(new ViewerQueryBuilder()
                    .WithHome(new HomeQueryBuilder()
                        .WithCurrentSubscription(subscriptionQueryBuilder), _homeId));

            try
            {
                var query = customQueryBuilder.Build();
                _logger.LogDebug("Sending GraphQL query to Tibber API.");
                var result = await _tibberApiClient.Query(query);

                if (result?.Data?.Viewer?.Home?.CurrentSubscription == null)
                {
                    _logger.LogWarning("Subscription data is null in Tibber response.");
                }
                else
                {
                    _logger.LogInformation("Successfully retrieved current subscription data.");
                }

                return result.Data?.Viewer?.Home?.CurrentSubscription;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error querying Tibber API for subscription data.");
                return null;
            }
        }

        /// <summary>
        /// Fetches the home ID from Tibber's basic viewer query.
        /// </summary>
        private async Task<Guid?> GetHomeId()
        {
            try
            {
                _logger.LogDebug("Requesting basic viewer data to resolve home ID.");
                var basicData = await _tibberApiClient.GetBasicData();
                var homeId = basicData?.Data?.Viewer?.Homes?.FirstOrDefault()?.Id;

                if (homeId == null)
                    _logger.LogError("Could not retrieve homeId from Tibber basic data.");
                else
                    _logger.LogInformation("Retrieved homeId: {HomeId}", homeId);

                return homeId;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception while retrieving homeId");
                return null;
            }
        }
    }
}
