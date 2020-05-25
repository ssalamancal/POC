using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskBasicAsync._01___Basic_Concepts
{
  public class WaitTask : ITaskProbeOfConcept
  {
    public void Execute()
    {
      Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Started\n");
      Task taskToWait = Task.Factory.StartNew(BasicOperations.PrintCounter);
      taskToWait.Wait();
      Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Completed");
    }
  }
}
