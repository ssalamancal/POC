using System;
using System.Threading;

namespace Threading._02_Contructor__Parameters_and_Return
{
  public class StartThreadWithUnsafeParameters : IThreadProbeOfConcept
  {
    public void Execute()
    {
      Thread t1 = new Thread(BasicOperations.DisplayNumbersUnsafeType);
      t1.Start(28);
      Console.Read();
    }

    private static class BasicOperations
    {
      //the parameter type must be object
      public static void DisplayNumbersUnsafeType(object max)
      {
        int Number = Convert.ToInt32(max);
        for (int i = 1; i <= Number; i++)
        {
          Console.WriteLine("Method1 :" + i);
        }
      }
    }
  }
}
