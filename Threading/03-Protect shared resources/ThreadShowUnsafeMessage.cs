using System;

namespace Threading._03_Protect_shared_resources
{
  public class ThreadShowUnsafeMessage : IThreadProbeOfConcept
  {
    public void Execute()
    {
      System.Threading.Thread thread1 = new System.Threading.Thread(BasicOperations.ShowUnsafeMessage);
      System.Threading.Thread thread2 = new System.Threading.Thread(BasicOperations.ShowUnsafeMessage);
      System.Threading.Thread thread3 = new System.Threading.Thread(BasicOperations.ShowUnsafeMessage);

      thread1.Start();
      thread2.Start();
      thread3.Start();
    }

    private static class BasicOperations
    {
      public static void ShowUnsafeMessage()
      {
        Console.Write("[Hello ");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("world!]");
      }
    }
  }
}
