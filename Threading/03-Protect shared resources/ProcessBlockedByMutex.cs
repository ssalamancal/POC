using System;
using System.Threading;

namespace Threading._03_Protect_shared_resources
{
  public class ProcessBlockedByMutex : IThreadProbeOfConcept
  {
    public void Execute()
    {
      //Create multiple threads to understand Mutex
      for (int i = 1; i <= 5; i++)
      {
        Thread threadObject = new Thread(BasicOperations.MutexDemo);
        threadObject.Name = "Thread " + i;
        threadObject.Start();
      }
    }

    private static class BasicOperations
    {
      private static Mutex mutex = new Mutex();

      public static void MutexDemo()
      {
        Console.WriteLine(Thread.CurrentThread.Name + " Wants to Enter Critical Section for processing");
        try
        {
          //Blocks the current thread until the current WaitOne method receives a signal.  
          //Wait until it is safe to enter. 
          mutex.WaitOne();
          Console.WriteLine("Success: " + Thread.CurrentThread.Name + " is Processing now");
          Thread.Sleep(2000);
          Console.WriteLine("Exit: " + Thread.CurrentThread.Name + " is Completed its task");
        }
        finally
        {
          //Call the ReleaseMutex method to unblock so that other threads
          //that are trying to gain ownership of the mutex.  
          mutex.ReleaseMutex();
        }
      }
    }
  }
}
