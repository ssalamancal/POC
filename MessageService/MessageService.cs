using System;
using System.ServiceModel;
using System.Threading.Tasks;

namespace MessageService
{
  public class MessageService : IMyMessage
  {
    public void MessageToServer(string message)
    {
      Console.WriteLine("SERVICE: Message from the client: {0}", message);

      IMyMessageCallbak callback = OperationContext.Current.GetCallbackChannel<IMyMessageCallbak>();
      callback.OnCallback("SERVICE: Message from the server.");

      TaskCallback(callback, message);
    }

    private void TaskCallback(object callback, string clientMessage)
    {
      IMyMessageCallbak messageCallback = callback as IMyMessageCallbak;

      for (int i = 1; i <= 10; i++)
      {
        messageCallback.OnCallback($"SERVICE: message {i.ToString()}, Client Message: {clientMessage}");
        System.Threading.Thread.Sleep(3000);
        if (i == 8)
        {
          throw new Exception();
        }
      }
    }
  }
}
