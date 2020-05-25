using System;
using TaskBasedAsync._02___Wait_Result;
using TaskBasedAsync._03___Chaining_Task;
using TaskBasedAsync._04___Scheduling_Task;
using TaskBasedAsync._05___Invoke_Threads;
using TaskBasicAsync._01___Basic_Concepts;

namespace TaskBasicAsync
{
  public static class TaskExamplesFactory
  {
    public static ITaskProbeOfConcept Create(TaskConcept taskConcept)
    {
      return taskConcept switch
      {
        TaskConcept.CreateTask => new CreateTask(),
        TaskConcept.WaitTask => new WaitTask(),
        TaskConcept.WaitForTaskResult => new WaitForTaskResult(),
        TaskConcept.ChainingTask => new ChainingTask(),
        TaskConcept.SchedulingTask => new SchedulingTask(),
        TaskConcept.InvokeThreads => new InvokeThreads(),
        _ => throw new NotImplementedException(),
      };
    }
  }
}
