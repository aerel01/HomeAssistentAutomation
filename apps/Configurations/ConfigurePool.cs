using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TibberSmartPlug.apps.Extensions.Scheduling;
using TibberSmartPlug.apps.Models;

namespace TibberSmartPlug.apps.Configurations
{
    internal static class ConfigurePool
    {
        public static IServiceCollection UsePool(this IServiceCollection service, HostBuilderContext context)
        {
            service.Configure<PoolSchedulingSettings>(
                context.Configuration.GetSection(PoolSchedulingSettings.Name));
            service.AddSingleton<SmartPlugScheduler>();
            return service;
        }

    }
}