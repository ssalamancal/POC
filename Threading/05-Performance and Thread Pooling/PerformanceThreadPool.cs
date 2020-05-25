using System;
using System.Diagnostics;
using System.Threading;

namespace Threading._05_Performance_and_Thread_Pooling
{
  public class PerformanceSumWithThreadPool : IThreadProbeOfConcept
  {
    public void Execute()
    {
      BadExample();

      GoodExample();
    }

    private void BadExample()
    {
      Console.WriteLine("Bad example thread pool...");

      var stopwatch = Stopwatch.StartNew();

      //Use thread pool has sense when you are gonna manipulate more than two thread...
      int toProcess = 2;
      using (ManualResetEvent resetEvent = new ManualResetEvent(false))
      {
        ThreadPool.QueueUserWorkItem(new WaitCallback((x) => { BasicOperations.EvenNumbersSum(x); if (Interlocked.Decrement(ref toProcess) == 0) resetEvent.Set(); }));
        ThreadPool.QueueUserWorkItem(new WaitCallback((x) => { BasicOperations.OddNumbersSum(x); if (Interlocked.Decrement(ref toProcess) == 0) resetEvent.Set(); }));

        resetEvent.WaitOne();
      }

      stopwatch.Stop();

      Console.WriteLine($"Total time with thread pool in milliseconds : {stopwatch.ElapsedMilliseconds}");
    }

    private void GoodExample()
    {
      Console.WriteLine("\nGood example thread pool...");

      for (int i = 0; i < 10; i++)
      {
        MethodWithThread();
        MethodWithThreadPool();
      }
      Stopwatch stopwatch = new Stopwatch();
      Console.WriteLine("Execution using Thread");
      stopwatch.Start();
      MethodWithThread();
      stopwatch.Stop();
      Console.WriteLine("Time consumed by MethodWithThread is : " +
                           stopwatch.ElapsedTicks.ToString());

      stopwatch.Reset();
      Console.WriteLine("Execution using Thread Pool");
      stopwatch.Start();
      MethodWithThreadPool();
      stopwatch.Stop();
      Console.WriteLine("Time consumed by MethodWithThreadPool is : " +
                           stopwatch.ElapsedTicks.ToString());

      Console.Read();
    }
    public static void MethodWithThread()
    {
      for (int i = 0; i < 10; i++)
      {
        Thread thread = new Thread(Test);
      }
    }
    public static void MethodWithThreadPool()
    {
      for (int i = 0; i < 10; i++)
      {
        ThreadPool.QueueUserWorkItem(new WaitCallback(Test));
      }
    }
    public static void Test(object obj)
    {
    }
  }
}
