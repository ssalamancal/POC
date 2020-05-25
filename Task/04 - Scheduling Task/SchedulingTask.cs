using System;
using System.Threading.Tasks;
using TaskBasicAsync;

namespace TaskBasedAsync._04___Scheduling_Task
{
  public class SchedulingTask : ITaskProbeOfConcept
  {
    public void Execute()
    {
      Task<int> taskExample = Task.Run(() => { return 3; });

      taskExample.ContinueWith((x) => { Console.WriteLine("Task canceled"); }, TaskContinuationOptions.OnlyOnCanceled);
      taskExample.ContinueWith((x) => { Console.WriteLine("Task faulted"); }, TaskContinuationOptions.OnlyOnFaulted);
      taskExample.ContinueWith((x) => { Console.WriteLine("Task completed"); }, TaskContinuationOptions.OnlyOnRanToCompletion);

      taskExample.Wait();
    }
  }
}
