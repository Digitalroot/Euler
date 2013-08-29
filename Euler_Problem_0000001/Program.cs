using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler_Problem_0000001
{
  internal class Program
  {
    private static void Main()
    {
      var validIntList = new List<int>();
      for (var i = 1; i < 1000; i++)
      {
        if (IsMultipleOfThreeOrFive(i))
        {
          validIntList.Add(i);
        }
      }

      if (validIntList.Count > 0)
      {
        var total = validIntList.Aggregate(0, (current, i) => current + i);
        Console.WriteLine(total);
      }

      Console.ReadLine();
    }

    private static bool IsMultipleOfThreeOrFive(int i)
    {
      return i%3 == 0 || i%5 == 0;
    }
  }
}