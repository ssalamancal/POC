using System;
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
        _ => throw new NotImplementedException(),
      };
    }
  }
}
