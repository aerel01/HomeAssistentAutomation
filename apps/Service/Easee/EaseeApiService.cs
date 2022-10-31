using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NetDaemonApps.apps.Service.Easee {
  internal class EaseeApiService {
    private readonly HttpClient _httpClient;

    public EaseeApiService(HttpClient httpClient) => _httpClient = httpClient;

    public Task<string> Autenticate() {
      //var client = new HttpClient(); RestClient("https://api.easee.cloud/api/accounts/login");
      //_httpClient.BaseAddress("https://api.easee.cloud/api/accounts/login")

      //var request = new RestRequest(Method.Post);
      //request.AddHeader("accept", "application/json");
      //request.AddHeader("content-type", "application/*+json");
      //request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCIsImN0eSI6IkpXVCJ9.eyJBY2NvdW50SWQiOjYwNjY5NSwiVXNlcklkIjo1NjM3MTgsInVuaXF1ZV9uYW1lIjoiQW5kcmVhcyBFa2Vyb3RoIiwicm9sZSI6IlVzZXIiLCJuYmYiOjE2NjY4OTUwMTIsImV4cCI6MTY2Njk4MTQxMiwiaWF0IjoxNjY2ODk1MDEyfQ.e27EIe93_CLmcIl7zfUYNvfPyGuT6Uk_opp0HU4bQFE");
      //var response = await client.ExecuteAsync(request);
      //return response.Content
      return Task.FromResult("");
    }
  }
}
