using System;
using System.Threading;

namespace TaskBasicAsync._01___Basic_Concepts
{
  public static class BasicOperations
  {    
    public static void PrintCounter()
    {
      Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} Started");
      for (int count = 1; count <= 3; count++)
      {
        Console.WriteLine($"count value: {count}");
      }
      Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} Completed\n");
    }
  }
}
