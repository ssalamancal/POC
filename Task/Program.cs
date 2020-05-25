using System;

namespace TaskBasicAsync
{
  class Program
  {
    static void Main(string[] args)
    {
      TaskExamplesFactory.Create(TaskConcept.WaitTask).Execute();

      Console.ReadLine();
    }
  }
}
