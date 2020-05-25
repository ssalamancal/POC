using System;

namespace Threading._05_Performance_and_Thread_Pooling
{
  public static class BasicOperations
  {
    public static void EvenNumbersSum(object o)
    {
      double Evensum = 0;
      for (int count = 0; count <= 999999999; count++)
      {
        if (count % 2 == 0)
        {
          Evensum += count;
        }
      }
      Console.WriteLine($"Sum of even numbers = {Evensum}");
    }

    public static void OddNumbersSum(object o)
    {
      double Oddsum = 0;
      for (int count = 0; count <= 999999999; count++)
      {
        if (count % 2 == 1)
        {
          Oddsum += count;
        }
      }
      Console.WriteLine($"Sum of odd numbers = {Oddsum}");
    }
  }
}