using System;
using System.Threading;
using System.Threading.Tasks;
using TaskBasicAsync;

namespace TaskBasedAsync._05___Invoke_Threads
{
  public class InvokeThreads : ITaskProbeOfConcept
  {
    public void Execute()
    {
      Console.WriteLine($"Main Thread Started, Thread Id: {Thread.CurrentThread.ManagedThreadId}\n");

      ParallelOptions parallelOptions = new ParallelOptions() { MaxDegreeOfParallelism = 2 };

      Parallel.Invoke(
        parallelOptions,
        () => DoSomeTask(1),
        () => DoSomeTask(2),
        () => DoSomeTask(3),
        () => DoSomeTask(4),
        () => DoSomeTask(5),
        () => DoSomeTask(6),
        () => DoSomeTask(7));

      Console.WriteLine($"Main Thread Finished, Thread Id: {Thread.CurrentThread.ManagedThreadId}");
    }

    static void DoSomeTask(int number)
    {
      Console.WriteLine($"DoSomeTask {number} started by Thread {Thread.CurrentThread.ManagedThreadId}");
      //Sleep for 500 milliseconds
      Thread.Sleep(5000);
      Console.WriteLine($"DoSomeTask {number} completed by Thread {Thread.CurrentThread.ManagedThreadId}\n");
    }
  }
}
