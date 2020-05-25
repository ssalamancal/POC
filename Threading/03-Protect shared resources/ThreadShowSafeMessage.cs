using System;

namespace Threading._03_Protect_shared_resources
{
  public class ThreadShowSafeMessage : IThreadProbeOfConcept
  {
    public void Execute()
    {
      System.Threading.Thread thread1 = new System.Threading.Thread(BasicOperations.ShowSafeMessage);
      System.Threading.Thread thread2 = new System.Threading.Thread(BasicOperations.ShowSafeMessage);
      System.Threading.Thread thread3 = new System.Threading.Thread(BasicOperations.ShowSafeMessage);

      thread1.Start();
      thread2.Start();
      thread3.Start();
    }

    private static class BasicOperations
    {
      private static object _lock = new object();

      public static void ShowSafeMessage()
      {
        lock (_lock)
        {
          Console.Write("[Hello ");
          System.Threading.Thread.Sleep(1000);
          Console.WriteLine("world!]");
        }
      }
    }
  }
}
