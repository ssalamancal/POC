using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace DotNetTutorial
{
  /*
   * The are two ways to host the asp net core application, 
   * 1. InProccess: means that we are going to use one server to host the app, the app is hosted inside of the iis server,
   *  the iis worker process (w3wp.exe) run to do this 
   * 2. OutOfProcess: meand that we are going to use two servers, the internal server (kestrel) host the app and a external 
   * server (iis/apache/nginx) works as a reverse proxy server to handle the request from the client.
   * The OutOfProcess host method uses two web servers, the first one is the Kestrel Web Server that is cross plataform, 
   * this web server is used as edge server (the internet-facing wich directly processes the incoming http request from
   * the client), the procces is named dotnet.exe
   * 
   */
  public class Program
  {
    public static void Main(string[] args)
    {
      CreateWebHostBuilder(args).Build().Run();
    }


    /*
     * CreateDefaultBuilder does:
     * 1. Setting up the webserver
     * 2. Loading the host and application configuration from various configuration sources
     * 3. Configuring logging
     */
    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
  }
}
