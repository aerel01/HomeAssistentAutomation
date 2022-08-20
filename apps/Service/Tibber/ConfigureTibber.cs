using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;
using Tibber.Sdk;

namespace NetDaemonApps.apps.Service.Tibber
{
    internal static class ConfigureTibber
    {
        public static IServiceCollection UseTibber(this IServiceCollection service, IConfiguration config)
        {
            var tibberSettings = new TibberSettings();
            config.GetSection(TibberSettings.Name).Bind(tibberSettings);
            var userAgent = new ProductInfoHeaderValue("My-home-automation-system", "1.2");
            service.AddScoped(x => new TibberApiClient(tibberSettings.Token, userAgent));
            service.AddScoped<TibberService>();
            service.AddScoped<TibberAutomation>();
            return service;
        }
    }
}
