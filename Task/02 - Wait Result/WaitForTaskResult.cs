using System;
using System.Threading.Tasks;
using TaskBasicAsync;

namespace TaskBasedAsync._02___Wait_Result
{
  public class WaitForTaskResult : ITaskProbeOfConcept
  {
    public void Execute()
    {
      Console.WriteLine($"Main Thread Started");

      Task<double> taskExample = Task.Factory.StartNew(() => CalculateSum(10));

      Console.WriteLine($"Sum is: {taskExample.Result}");
      Console.WriteLine($"Main Thread Completed");
    }

    static double CalculateSum(int num)
    {
      double sum = 0;
      for (int count = 1; count <= num; count++)
      {
        sum += count;
      }
      return sum;
    }
  }
}
