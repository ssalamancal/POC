using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskBasicAsync._01___Basic_Concepts
{
  public class CreateTask : ITaskProbeOfConcept
  {
    public void Execute()
    {
      BasicCreation();
      FactoryCreation();
      TaskRun();
    }

    private void BasicCreation()
    {
      Console.WriteLine("Basic task creation...");
      Console.WriteLine($"BasicCreation Thread : {Thread.CurrentThread.ManagedThreadId} Started");
      Task basic = new Task(BasicOperations.PrintCounter);
      basic.Start();
      Console.WriteLine($"BasicCreation Thread : {Thread.CurrentThread.ManagedThreadId} Completed\n");
    }

    private void FactoryCreation()
    {
      Console.WriteLine("Factory task creation...");
      Console.WriteLine($"FactoryCreation Thread : {Thread.CurrentThread.ManagedThreadId} Started");
      Task factory = Task.Factory.StartNew(BasicOperations.PrintCounter);
      Console.WriteLine($"FactoryCreation Thread : {Thread.CurrentThread.ManagedThreadId} Completed\n");
    }

    private void TaskRun()
    {
      Console.WriteLine("Task.Run creation...");
      Console.WriteLine($"TaskRun Thread : {Thread.CurrentThread.ManagedThreadId} Started");
      Task taskRun = Task.Run(() => BasicOperations.PrintCounter());
      Console.WriteLine($"TaskRun Thread : {Thread.CurrentThread.ManagedThreadId} Completed\n ");
    }

  }
}
