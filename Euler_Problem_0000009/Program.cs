using System;

namespace Euler_Problem_0000009
{
  internal class Program
  {
    private static void Main()
    {
      const int sum = 1000;
      int a;
      for (a = 1; a <= sum/3; a++)
      {
        int b;
        for (b = a + 1; b <= sum/2; b++)
        {
          int c = sum - a - b;
          if (c > 0 && (a*a + b*b == c*c))
            Console.WriteLine("a={0}, b={1}, c={2}, prod={3}", a, b, c, a*b*c);
        }
      }
      Console.ReadKey();
    }
  }
}