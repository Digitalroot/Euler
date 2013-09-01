using System;

namespace Euler_Problem_0000006
{
  internal class Program
  {
    private static void Main()
    {
      double sumOfSquares = SumSquares(1, 100);
      double squareOfSums = SquareSums(1, 100);

      double diff = squareOfSums - sumOfSquares;

      Console.WriteLine(diff);
      Console.ReadKey();
    }

    private static double SquareSums(int min, int max)
    {
      double sum = 0;
      for (int i = min; i <= max; i++)
      {
        sum += i;
      }
      return Math.Pow(sum, 2);
    }

    private static double SumSquares(int min, int max)
    {
      double sum = 0;
      for (int i = min; i <= max; i++)
      {
        sum = sum + Math.Pow(i, 2);
      }
      return sum;
    }
  }
}