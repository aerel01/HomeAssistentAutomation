using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDaemonApps.apps.Service.Easee {
  public static class ConfigureEasee {
    public static IServiceCollection UseEasee(this IServiceCollection service, HostBuilderContext context) {
      service.AddHttpClient<EaseeApiService>(c => {
        c.BaseAddress = new Uri("");
        c.DefaultRequestHeaders.Add("accept", "application/json");
        c.DefaultRequestHeaders.Add("content-type", "application/*+json");
        c.DefaultRequestHeaders.Add("appkey", "piaSettings.AppKey");
        //var token = Task.Run(async () => await AuthenticationHelper.GetAuthenticationToken("piaSettings")).Result;
        //c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
      });
    }
  }
}
