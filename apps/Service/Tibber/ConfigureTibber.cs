using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetDaemonApps.apps.Service.Tibber.Automations;
using System.Net.Http.Headers;
using Tibber.Sdk;

namespace NetDaemonApps.apps.Service.Tibber;

internal static class ConfigureTibber {
    public static IServiceCollection UseTibber(this IServiceCollection service, HostBuilderContext context) {
        var tibberSettings = new TibberSettings();
        context.Configuration.GetSection(TibberSettings.Name).Bind(tibberSettings);
        var carSettings = new CarSettings();
        context.Configuration.GetSection(CarSettings.Name).Bind(carSettings);
        service.AddScoped(_ => carSettings);
        var userAgent = new ProductInfoHeaderValue("My-home-automation-system", "1.2");
        service.AddScoped(_ => new TibberApiClient(tibberSettings.Token, userAgent));
        service.AddScoped<TibberService>();
        service.AddScoped<TibberAutomation>();
        service.AddScoped<CarChargeAutomation>();
        service.AddScoped<FloorHeatAutomation>();
        return service;
    }
}
