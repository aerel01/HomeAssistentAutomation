using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TibberSmartPlug.apps.Models;

namespace TibberSmartPlug.apps.Configurations
{
    internal static class ConfigurePool
    {
        public static IServiceCollection UsePool(this IServiceCollection service, HostBuilderContext context)
        {

            var poolSchedulingSettings = new PoolSchedulingSettings();
            context.Configuration.GetSection(PoolSchedulingSettings.Name).Bind(poolSchedulingSettings);
            return service;
        }

    }
}