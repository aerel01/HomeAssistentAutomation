using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetDaemonApps.apps.Service.Tibber;
using Tibber.Sdk;
using TibberSmartPlug.apps.Services;

namespace TibberSmartPlug.apps.Configurations
{
    internal static class ConfigureTibber
    {
        public static IServiceCollection UseTibber(this IServiceCollection service, HostBuilderContext context)
        {
            var tibberSettings = new TibberSettings();
            context.Configuration.GetSection(TibberSettings.Name).Bind(tibberSettings);

            var userAgent = new ProductInfoHeaderValue("My-home-automation-system", "1.2");
            service.AddScoped(_ => new TibberApiClient(tibberSettings.Token, userAgent));
            service.AddScoped<TibberService>();
            return service;
        }
    }
}