using System;
using System.Linq;
using System.Threading.Tasks;
using TaskBasicAsync;

namespace TaskBasedAsync._06___Async_Task
{
  public class AsyncTask : ITaskProbeOfConcept
  {
    public void Execute()
    {
      Console.WriteLine(ShowTodaysInfo().Result);
      Console.WriteLine("Press any key to exist.");
      Console.ReadKey();
    }

    private static async Task<string> ShowTodaysInfo()
    {
      var infoTask = GetLeisureHours();

      string ret = $"Today is {DateTime.Today:D}\n" +
                   "Today's hours of leisure: " +
                   $"{await infoTask}";
      return ret;
    }

    static async Task<int> GetLeisureHours()
    {
      // Task.FromResult is a placeholder for actual work that returns a string.  
      var today = await Task.FromResult(DateTime.Now.DayOfWeek.ToString());

      // The method then can process the result in some way.  
      int leisureHours;
      if (today.First() == 'S')
        leisureHours = 16;
      else
        leisureHours = 5;
      return leisureHours;
    }
  }
}
