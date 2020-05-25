using System;
using System.Threading;

namespace Threading._03_Protect_shared_resources
{
  public class ProcessBlockedBySemaphore : IThreadProbeOfConcept
  {
    public void Execute()
    {
      for (int i = 1; i <= 10; i++)
      {
        Thread threadObject = new Thread(BasicOperations.DoSomeTask)
        {
          Name = "Thread " + i.ToString().PadLeft(2, '0')
        };
        threadObject.Start();
      }
    }

    private static class BasicOperations
    {
      private static Semaphore semaphore = new Semaphore(3, 3);
      public static void DoSomeTask()
      {
        Console.WriteLine($"{Thread.CurrentThread.Name} Wants to Enter into Critical Section for processing");
        try
        {
          //Blocks the current thread until the current WaitHandle receives a signal.   
          semaphore.WaitOne();
          Console.WriteLine($"Success: {Thread.CurrentThread.Name} is Doing its work");
          Thread.Sleep(5000);
          Console.WriteLine($"{Thread.CurrentThread.Name} Exit.");
        }
        finally
        {
          //Release() method to releage semaphore  
          semaphore.Release();
        }
      }
    }
  }
}
