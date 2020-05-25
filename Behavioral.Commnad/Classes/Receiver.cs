using System;

namespace Behavioral.Commnad.Classes
{
  // The Receiver classes contain some important business logic. They know how
  // to perform all kinds of operations, associated with carrying out a
  // request. In fact, any class may serve as a Receiver.
  public class Receiver
  {
    public void DoSomething(string task)
    {
      Console.WriteLine($"Receiver: Working on ({task}.)");
    }

    public void DoSomethingElse(string task)
    {
      Console.WriteLine($"Receiver: Also working on ({task}.)");
    }
  }
}
