using System;
using System.Diagnostics;
using System.Threading;

namespace Threading._05_Performance_and_Thread_Pooling
{
  public class PerformanceSumWithThread : IThreadProbeOfConcept
  {
    public void Execute()
    {
      var thread1 = new Thread(BasicOperations.EvenNumbersSum);
      var thread2 = new Thread(BasicOperations.OddNumbersSum);

      var stopwatch = Stopwatch.StartNew();

      thread1.Start();
      thread2.Start();

      thread1.Join();
      thread2.Join();

      stopwatch.Stop();
      Console.WriteLine($"Total time with threads in milliseconds : {stopwatch.ElapsedMilliseconds}");
    }
  }
}
