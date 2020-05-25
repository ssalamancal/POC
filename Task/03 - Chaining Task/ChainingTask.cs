using System;
using System.Threading.Tasks;
using TaskBasicAsync;

namespace TaskBasedAsync._03___Chaining_Task
{
  public class ChainingTask : ITaskProbeOfConcept
  {
    public void Execute()
    {
      Task<string> taskExample = Task.Run(() =>
      {
        return 18;
      }).ContinueWith((Task<int> antecedent) =>
      {
        return $"The Square of {antecedent.Result} is: {antecedent.Result * antecedent.Result}";
      });

      Console.WriteLine(taskExample.Result);
    }
  }
}
