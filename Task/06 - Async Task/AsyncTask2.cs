using System;
using System.Threading.Tasks;
using TaskBasicAsync;

namespace TaskBasedAsync._06___Async_Task
{
  public class AsyncTask2 : ITaskProbeOfConcept
  {
    public void Execute()
    {
      DisplayCurrentInfo().Wait();
      Console.WriteLine("Press any key to exist.");
    }

    static async Task DisplayCurrentInfo()
    {
      var taskInfo = WaitAndApologize();

      await taskInfo;

      Console.WriteLine($"Today is {DateTime.Now:D}");
      Console.WriteLine($"The current time is {DateTime.Now.TimeOfDay:t}");
      Console.WriteLine("The current temperature is 76 degrees.");
    }
    static async Task WaitAndApologize()
    {
      // Task.Delay is a placeholder for actual work.  
      await Task.Delay(2000);
      // Task.Delay delays the following line by two seconds.  
      Console.WriteLine("\nSorry for the delay. . . .\n");
    }
  }
}
