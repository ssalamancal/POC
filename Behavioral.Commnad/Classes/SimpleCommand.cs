﻿using System;

namespace Behavioral.Commnad.Classes
{
  // Some commands can implement simple operations on their own.
  public class SimpleCommand : ICommand
  {
    private string _payload = string.Empty;

    public SimpleCommand(string payload)
    {
      this._payload = payload;
    }

    public void Execute()
    {
      Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({this._payload})");
    }
  }
}
