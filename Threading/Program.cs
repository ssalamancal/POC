using System;
using Threading._01_Basic_Concepts;

namespace Threading
{
  class Program
  {
    static void Main(string[] args)
    {
      ThreadExamplesFactory.Create(ThreadConcept.PerformanceSumWithoutThread).Execute();

      Console.WriteLine(Environment.NewLine);

      ThreadExamplesFactory.Create(ThreadConcept.PerformanceSumWithThread).Execute();

      Console.WriteLine(Environment.NewLine);

      ThreadExamplesFactory.Create(ThreadConcept.PerformanceSumWithThreadPool).Execute();

      Console.Read();
    }
  }
}
