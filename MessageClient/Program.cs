using System;
using System.ServiceModel;
using System.Timers;

namespace MessageClient
{
  class Program
  {
    private static MessageService.IMyMessage messageChanel;
    private static bool establishedConnection = false;
    private const int maxRetries = 10;
    private const int timeOutSeconds = 30;
    private static int retries = 0;

    static void Main(string[] args)
    {
      Console.WriteLine("CLIENT: Client - Press return to continue...");
      Console.ReadLine();

      DuplexSample();

      Console.WriteLine("CLIENT: Client - Press return to exit");
      Console.ReadLine();
    }

    private static void DuplexSample()
    {
      var binding = new WSDualHttpBinding();
      var address = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/Duplex");

      ++retries;

      while (!establishedConnection && retries <= maxRetries)
      {
        try
        {
          var clientCallback = new ClientCallback();
          var context = new InstanceContext(clientCallback);

          var factory = new DuplexChannelFactory<MessageService.IMyMessage>(context, binding, address);
          factory.Faulted += new EventHandler(ServiceFactory_Faulted);
          messageChanel = factory.CreateChannel();
          ((IClientChannel)((ICommunicationObject)messageChanel)).OperationTimeout = TimeSpan.FromSeconds(timeOutSeconds);
          ((ICommunicationObject)messageChanel).Opened += new EventHandler(DuplexChannel_Opened);
          ((ICommunicationObject)messageChanel).Faulted += new EventHandler(DuplexChannel_Faulted);
          ((ICommunicationObject)messageChanel).Closed += new EventHandler(DuplexChannel_Closed);

          Console.WriteLine("Calling WCF service...");
          messageChanel.MessageToServer($"CLIENT: Retry: {retries}.");
          Console.WriteLine("Call to WCF service finished.");

        }
        catch (Exception e)
        {
          PrintMessage($"CLIENT: Exception: {e.Message}", false);
          DuplexSample();
        }
      }
    }

    private static void DuplexChannel_Opened(object sender, EventArgs e)
    {
      PrintMessage("CLIENT: DuplexChannel_Opened", true);
      retries = 0;
    }

    private static void ServiceFactory_Faulted(object sender, EventArgs e)
    {
      PrintMessage("CLIENT: ServiceFactory_Faulted", false);
      DuplexSample();
    }

    private static void DuplexChannel_Faulted(object sender, EventArgs e)
    {
      PrintMessage("CLIENT: DuplexChannel_Faulted", false);
      DuplexSample();
    }

    private static void DuplexChannel_Closed(object sender, EventArgs e)
    {
      PrintMessage("CLIENT: DuplexChannel_Closed", false);
      DuplexSample();
    }

    private static void PrintMessage(string eventName, bool connected)
    {
      Console.WriteLine(eventName);
      Console.WriteLine($"CLIENT: channel status {((ICommunicationObject)messageChanel).State}");
      establishedConnection = connected;
      System.Threading.Thread.Sleep(2000);
    }
  }
}
