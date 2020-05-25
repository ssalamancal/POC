using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Commnad.Classes
{
  // However, some commands can delegate more complex operations to other objects, called "receivers.
  public class ComplexCommand: ICommand
  {
    private Receiver _receiver;

    // Context data, required for launching the receiver's methods.
    private string _taskA;

    private string _taskB;

    // Complex commands can accept one or several receiver objects along
    // with any context data via the constructor.
    public ComplexCommand(Receiver receiver, string taskA, string taskB)
    {
      this._receiver = receiver;
      this._taskA = taskA;
      this._taskB = taskB;
    }

    // Commands can delegate to any methods of a receiver.
    public void Execute()
    {
      Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
      this._receiver.DoSomething(this._taskA);
      this._receiver.DoSomethingElse(this._taskB);
    }
  }
}
