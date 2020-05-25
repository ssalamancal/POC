namespace Threading._03_Protect_shared_resources
{
  public class ThreadIncrementCount : IThreadProbeOfConcept
  {
    public void Execute()
    {
      System.Threading.Thread thread1 = new System.Threading.Thread(BasicOperations.IncremetCounter);
      System.Threading.Thread thread2 = new System.Threading.Thread(BasicOperations.IncremetCounter);
      System.Threading.Thread thread3 = new System.Threading.Thread(BasicOperations.IncremetCounter);

      thread1.Start();
      thread2.Start();
      thread3.Start();

      thread1.Join();
      thread2.Join();
      thread3.Join();

      System.Console.WriteLine($"Safe (locked) Counter equals to {BasicOperations.Count} and unsafe equals to {BasicOperations.UnsafeCount}.");
    }

    private static class BasicOperations
    {
      public static int Count { get; private set; }
      public static int UnsafeCount { get; private set; }
      private static object _lock = new object();

      public static void IncremetCounter()
      {
        for (int i = 1; i <= 1000000; i++)
        {
          UnsafeCount++;
          //Only protecting the shared Count variable
          lock (_lock)
          {
            Count++;
          }
        }
      }
    }
  }
}
