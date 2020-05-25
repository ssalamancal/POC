/*
 * Run command in package manager console: install-package microsoft.aspnet.webapi.owinselfhost
 * Create class Startup
 *  Add a web api controller
 */


using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;

namespace OwinSelfhostSample
{
  class Program
  {
    static void Main(string[] args)
    {
      var baseAddress = "http://localhost:9010/";

      using (WebApp.Start<Startup>(url: baseAddress))
      {
        var client = new HttpClient();

        var response = client.GetAsync($"{baseAddress}api/values").Result;

        Console.WriteLine(response);
        Console.WriteLine(response.Content.ReadAsStringAsync().Result);
        Console.ReadLine();
      }
    }
  }
}
