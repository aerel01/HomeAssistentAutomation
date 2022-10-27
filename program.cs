using Microsoft.Extensions.Hosting;
using NetDaemon.Extensions.Logging;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.Extensions.Tts;
using NetDaemon.Runtime;
using NetDaemonApps.apps.Service.Tibber;
using System.Reflection;


#pragma warning disable CA1812

try {
  await Host.CreateDefaultBuilder(args)
      .UseNetDaemonAppSettings()
      .UseNetDaemonDefaultLogging()
      .UseNetDaemonRuntime()
      .UseNetDaemonTextToSpeech()
      .ConfigureServices((host, services) =>
          services
              .AddAppsFromAssembly(Assembly.GetExecutingAssembly())
              .AddNetDaemonStateManager()
              .AddNetDaemonScheduler()
              .UseTibber(host)
     //        .AddLogging(loggerFactory =>
     //loggerFactory.AddConsole().AddConfiguration(host.Configuration.GetSection("Logging")))
     )
      .Build()
      .RunAsync()
      .ConfigureAwait(false);
} catch(Exception e) {
  Console.WriteLine($"Failed to start host... {e}");
  throw;
}