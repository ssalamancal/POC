﻿using System;
using TaskBasedAsync._02___Wait_Result;
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
        _ => throw new NotImplementedException(),
      };
    }
  }
}
