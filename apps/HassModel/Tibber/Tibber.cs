// Use unique namespaces for your apps if you going to share with others to avoid
// conflicting names
using NetDaemonApps.apps.Service.Tibber;
using NetDaemonApps;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Tibber.Sdk;
using NetDaemon.HassModel.Entities;
using HomeAssistantGenerated;
using NetDaemonApps.apps.Service.Tibber.Automations;

namespace Tibber;

/// <summary>
///     Hello world showcase using the new HassModel API
/// </summary>
//[NetDaemonApp]
public class TibberNotification
{
    //private readonly TibberService _tibberService;

    public TibberNotification(IHaContext ha, TibberService tibberService, TibberAutomation automation)
    {
        //var a = tibberService.GetCurrentSubscription().GetAwaiter().GetResult();
        //var b = DateTime.Parse(a.PriceInfo.Current.StartsAt);
        //for (int i = 0; i < 10; i++)
        //{
        //    automation.NormalPrice(a);
        //}
        //ha.CallService("notify", "persistent_notification", data: new { message = "Notify me", title = "Hello world!" });
        //var current = tibberService.GetCurrentPriceAsync().Result;
        //var _myEntities = new Entities(ha);
        //_myEntities.Sensor.PoolTemperature2 = new NumericSensorEntity(new Entity())        //Get(ha).Wait();

    }


    //https://github.com/tibber/Tibber.SDK.NET
    private async Task Get(IHaContext ha)
    {
        // Please set user agent so we can track different client implementations
        var userAgent = new ProductInfoHeaderValue("My-home-automation-system", "1.2");

        var client = new TibberApiClient("", userAgent);

        var basicData = await client.GetBasicData();
        var homeId = basicData.Data.Viewer.Homes.First().Id.Value;
        var consumption = await client.GetHomeConsumption(homeId, EnergyResolution.Monthly);

        var customQueryBuilder =
            new TibberQueryBuilder()
                .WithAllScalarFields()
                .WithViewer(
                    new ViewerQueryBuilder()
                        //.WithAllScalarFields()
                        //.WithAccountType()
                        .WithHome(
                            new HomeQueryBuilder()
                                //.WithAllScalarFields()
                                //.WithAddress(new AddressQueryBuilder().WithAllFields())
                                .WithCurrentSubscription(
                                    new SubscriptionQueryBuilder()
                                        //.WithAllScalarFields()
                                        //.WithSubscriber(new LegalEntityQueryBuilder().WithAllFields())
                                        .WithPriceInfo(
                                            new PriceInfoQueryBuilder()
                                            .WithToday(new PriceQueryBuilder().WithAllFields())
                                            .WithCurrent(new PriceQueryBuilder().WithAllFields())
                                            )

                                ),
                            //.WithOwner(new LegalEntityQueryBuilder().WithAllFields())
                            //.WithFeatures(new HomeFeaturesQueryBuilder().WithAllFields())
                            //.WithMeteringPointData(new MeteringPointDataQueryBuilder().WithAllFields()),
                            homeId
                        )
                );

        var customQuery = customQueryBuilder.Build(); // produces plain GraphQL query text
        var result = await client.Query(customQuery);
        var priceInfo = result.Data.Viewer.Home.CurrentSubscription.PriceInfo;
        var current = priceInfo.Current;

        ha.Entity("switch.device_88").CallService("turn_on");

        switch (current.Level)
        {
            case PriceLevel.VeryCheap:
                ha.Entity(UtomhusPlug).CallService("turn_on");
                if (DateTime.UtcNow.AddHours(2).Hour >= 5 && DateTime.UtcNow.AddHours(2).Hour <= 8)
                {
                    ha.Entity("switch.golvvarme_timer").CallService("turn_on");
                }
                break;
            case PriceLevel.Cheap:
                ha.Entity(UtomhusPlug).CallService("turn_on");
                if (DateTime.UtcNow.AddHours(2).Hour >= 5 && DateTime.UtcNow.AddHours(2).Hour <= 8)
                {
                    ha.Entity("switch.golvvarme_timer").CallService("turn_on");
                }
                break;
            case PriceLevel.Normal:
                ha.Entity(UtomhusPlug).CallService("turn_off");
                break;
            case PriceLevel.Expensive:
                ha.Entity(UtomhusPlug).CallService("turn_off");
                break;
            case PriceLevel.VeryExpensive:
                ha.Entity(UtomhusPlug).CallService("turn_off");
                ha.Entity("light.grupp_alla").CallService("turn_off");
                break;
        }


        // if (current.Level ==  PriceLevel.VeryCheap){
        //     ha.CallService("notify", "persistent_notification", data:  new { message = $"Hurra nu är det billigt {current.Total}kr", title = "Tibber Price!" });    
        // }
        // if (current.Level ==  PriceLevel.Cheap){
        //     ha.CallService("notify", "persistent_notification", data:  new { message = $"nu är  nu är det billigt {current.Total}{current.Currency}", title = "Tibber Price!" });    
        // }
        // var prise = result.Data.Viewer.Home.CurrentSubscription.PriceInfo.Today.OrderBy(x=> x.Level);
        // Console.Write(JsonSerializer.Serialize(prise));
        // ha.CallService("notify", "persistent_notification", data:  new { message = JsonSerializer.Serialize(prise), title = "Hello world!" });
    }

    private readonly string UtomhusPlug = "switch.device_88";
}