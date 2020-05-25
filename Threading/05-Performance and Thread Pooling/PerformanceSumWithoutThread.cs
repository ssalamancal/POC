using System;
using System.Diagnostics;

namespace Threading._05_Performance_and_Thread_Pooling
{
  public class PerformanceSumWithoutThread : IThreadProbeOfConcept
  {
    public void Execute()
    {
      var stopwatch = Stopwatch.StartNew();

      BasicOperations.EvenNumbersSum(null);
      BasicOperations.OddNumbersSum(null);

      stopwatch.Stop();
      Console.WriteLine($"Total time without threads in milliseconds : {stopwatch.ElapsedMilliseconds}");
    }
  }
}