using System;
using MessageService;

namespace MessageClient
{
    public class ClientCallback : IMyMessageCallbak
    {
        public void OnCallback(string message)
        {
            Console.WriteLine("CLIENT: Message from server, {0}.", message);
        }
    }
}
