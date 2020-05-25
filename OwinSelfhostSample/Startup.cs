using Owin;
using System.Web.Http;

namespace OwinSelfhostSample
{
  public class Startup
  {
    // This code configures Web API. The Startup class is specified as a type
    // parameter in the WebApp.Start method.
    public void Configuration(IAppBuilder appBuilder)
    {
      var config = new HttpConfiguration();

      // Configure Web API for self-host.
      config.Routes.MapHttpRoute(
        name: "DefaultApi",
        routeTemplate: "api/{controller}/{id}",
        defaults: new { id = RouteParameter.Optional }
       );

      appBuilder.UseWebApi(config);
    }
  }
}
