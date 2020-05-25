using System;
using System.Threading;
using Threading._01_BasicConcepts;

namespace Threading._01_Basic_Concepts
{
  public class MultiThread : BasicConceptsOperations, IThreadProbeOfConcept
  {
    public void Execute()
    {
      Console.WriteLine("Main Thread Started");

      //Creating Threads
      Thread t1 = new Thread(Method1)
      {
        Name = "Thread1"
      };

      Thread t2 = new Thread(Method2)
      {
        Name = "Thread2"
      };
      Thread t3 = new Thread(Method3)
      {
        Name = "Thread3"
      };

      //Executing the methods
      t1.Start();
      t2.Start();
      t3.Start();
      Console.WriteLine("Main Thread Ended");
    }
  }
}
