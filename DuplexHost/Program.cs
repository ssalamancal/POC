using System;
using System.ServiceModel;

namespace DuplexHost
{
    class Program
    {
        internal static ServiceHost serviceHost = null;

        private static void StartService()
        {
            serviceHost = new ServiceHost(typeof(MessageService.MessageService));
            serviceHost.Open();
        }

        private static void StopService()
        {
            if (serviceHost.State != CommunicationState.Closed)
                serviceHost.Close();
        }

        static void Main(string[] args)
        {
            StartService();
            Console.WriteLine("HOST: Service running; press return to exit");
            
            Console.ReadLine();
            StopService();
            Console.WriteLine("HOST: Service Stoped");
        }
    }
}
