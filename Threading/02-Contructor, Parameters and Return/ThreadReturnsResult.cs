using System;
using System.Threading;

namespace Threading._02_Contructor__Parameters_and_Return
{
  public class ThreadReturnsResult : IThreadProbeOfConcept
  {
    public void Execute()
    {
      //Set the value of the parameter
      BasicOperations.MaxNumber = 8;
      //Set the delegate to call when thread finished execution
      BasicOperations.ResultCallbackExampleDelegate = ShowSumResult;

      //Create thread for a method without parameter but inside it operates with the previos setted value
      Thread t1 = new Thread(BasicOperations.CalculateSumAndInvokeDelegate);
      t1.Start();
      Console.Read();
    }

    private void ShowSumResult(int result)
    {
      Console.WriteLine($"Sum result equals to {result}.");
    }

    private delegate void ResultCallbackExampleDelegate(int result);

    private static class BasicOperations
    {
      public static int MaxNumber { get; set; } = 5;
      public static ResultCallbackExampleDelegate ResultCallbackExampleDelegate { get; set; }

      public static void CalculateSumAndInvokeDelegate()
      {
        int Result = 0;
        for (int i = 1; i <= MaxNumber; i++)
        {
          Result += i;
        }
        //Before the end of the thread function call the callback method
        ResultCallbackExampleDelegate?.Invoke(Result);
      }
    }
  }
}
