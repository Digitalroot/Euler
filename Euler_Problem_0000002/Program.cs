using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler_Problem_0000002
{
  internal class Program
  {
    private static void Main()
    {
      var validIntList = new List<Int64>();
      Int64 j = 0;
      Int64 i = 1;

      while (i < 4000000)
      {
        if (IsEven(i))
        {
          validIntList.Add(i);
        }
        Int64 g = i;
        i = j + i;
        j = g;
      }

      if (validIntList.Count > 0)
      {
        Int64 total = validIntList.Aggregate<long, long>(0, (current, l) => current + l);
        Console.WriteLine(total);
      }

      Console.ReadLine();
    }

    private static bool IsEven(Int64 i)
    {
      return i%2 == 0;
    }
  }
}