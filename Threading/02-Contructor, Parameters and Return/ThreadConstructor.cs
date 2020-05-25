using System;
using System.Threading;

namespace Threading._02_Contructor__Parameters_and_Return
{
  public class ThreadConstructor : IThreadProbeOfConcept
  {
    public void Execute()
    {
      Thread t1 = new Thread(BasicOperations.DisplayNumbers);
      t1.Start();
      Console.Read();
    }

    private static class BasicOperations
    {
      public static void DisplayNumbers()
      {
        for (int i = 1; i <= 5; i++)
        {
          Console.WriteLine("Method1 :" + i);
        }
      }
    }
  }
}
