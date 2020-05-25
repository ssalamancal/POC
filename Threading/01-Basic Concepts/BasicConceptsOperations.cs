using System;
using System.Threading;

namespace Threading._01_BasicConcepts
{
  public abstract class BasicConceptsOperations
  {
    protected static void Method1()
    {
      Console.WriteLine("Method1 Started using " + Thread.CurrentThread.Name);
      for (int i = 1; i <= 5; i++)
      {
        Console.WriteLine("Method1 :" + i);
      }
      Console.WriteLine("Method1 Ended using " + Thread.CurrentThread.Name);
    }

    protected static void Method2()
    {
      Console.WriteLine("Method2 Started using " + Thread.CurrentThread.Name);
      for (int i = 1; i <= 5; i++)
      {
        Console.WriteLine("Method2 :" + i);
        if (i == 3)
        {
          Console.WriteLine("Performing the Database Operation Started");
          //Sleep for 10 seconds
          Thread.Sleep(10000);
          Console.WriteLine("Performing the Database Operation Completed");
        }
      }
      Console.WriteLine("Method2 Ended using " + Thread.CurrentThread.Name);
    }

    protected static void Method3()
    {
      Console.WriteLine("Method3 Started using " + Thread.CurrentThread.Name);
      for (int i = 1; i <= 5; i++)
      {
        Console.WriteLine("Method3 :" + i);
      }
      Console.WriteLine("Method3 Ended using " + Thread.CurrentThread.Name);
    }
  }
}
