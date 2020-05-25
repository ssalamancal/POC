using System;
using System.Threading;

namespace Threading._02_Contructor__Parameters_and_Return
{
  public class StartThreadWithSafeParameters : IThreadProbeOfConcept
  {
    public void Execute()
    {
      //Set the value of the parameter
      BasicOperations.MaxNumber = 31;
      //Create thread for a method without parameter but inside it operates with the previos setted value
      Thread t1 = new Thread(BasicOperations.DisplayNumbersSafeType);
      t1.Start();
      Console.Read();
    }

    private static class BasicOperations
    {
      public static int MaxNumber { get; set; }

      public static void DisplayNumbersSafeType()
      {
        for (int i = 1; i <= MaxNumber; i++)
        {
          Console.WriteLine("Method1 :" + i);
        }
      }
    }
  }
}
