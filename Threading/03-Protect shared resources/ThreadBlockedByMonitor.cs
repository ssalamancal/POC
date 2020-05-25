using System;
using System.Threading;

namespace Threading._03_Protect_shared_resources
{
  public class ProcessBlockedByMonitor : IThreadProbeOfConcept
  {
    public void Execute()
    {
      Thread[] threads = new Thread[3];

      for (int i = 0; i < 3; i++)
      {
        threads[i] = new Thread(BasicOperations.PrintNumbers);
        threads[i].Name = "Child Thread " + i;
      }
      foreach (Thread t in threads)
      {
        t.Start();
      }
    }

    private static class BasicOperations
    {
      private static object _lock = new object();

      public static void PrintNumbers()
      {
        Console.WriteLine($"{Thread.CurrentThread.Name} Trying to enter into the critical section");
        Monitor.Enter(_lock);
        try
        {
          Console.WriteLine($"{Thread.CurrentThread.Name} Entered into the critical section");
          for (int i = 0; i < 5; i++)
          {
            Thread.Sleep(100);
            Console.Write(i + ",");
          }
          Console.WriteLine();
        }
        finally
        {
          Monitor.Exit(_lock);
          Console.WriteLine($"{Thread.CurrentThread.Name} Exit from critical section");
        }
      }
    }
  }
}
