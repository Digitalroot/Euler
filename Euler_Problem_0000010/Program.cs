using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler_Problem_0000010
{
  internal class Program
  {
    private static void Main()
    {
      List<long> pList = new PrimeNumberUtil().GetPrimesTo(2000000);
      Console.WriteLine(pList.Sum());
      Console.ReadKey();
    }
  }
}