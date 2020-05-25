using Behavioral.Commnad.Classes;
using System;

namespace Behavioral.Commnad
{
  class Program
  {
    static void Main(string[] args)
    {
      // The client code can parameterize an invoker with any commands.
      Invoker invoker = new Invoker();
      Receiver receiver = new Receiver();

      invoker.SetOnStart(new SimpleCommand("Say Hi!"));
      invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

      invoker.DoSomethingImportant();

      Console.WriteLine("\nPress enter to exit...");
      Console.ReadLine();
    }
  }
}
