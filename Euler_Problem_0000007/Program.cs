using System;
using System.Collections.Generic;

namespace Euler_Problem_0000007
{
  internal class Program
  {
    private static void Main()
    {
      List<long> pList = new PrimeNumberUtil().GetPrimes(10001);
      Console.WriteLine(pList[10000]);
      Console.ReadKey();
    }
  }
}