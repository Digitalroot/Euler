using System;
using System.Collections.Generic;

namespace Euler_Problem_0000003
{
  class Program
  {
    static readonly List<long> PrimeNumbers = new List<long>();

    static void Main()
    {
      const long target = 600851475143;

      PrimeNumbers.Add(2);

      for (long i = 3; i < Math.Sqrt(target); i += 2)
      {
        if (i % 5 != 0)
          if (IsPrime(i))
            PrimeNumbers.Add(i);
      }

      for (int i = PrimeNumbers.Count - 1; i > 0; i--)
      {
        if (target % PrimeNumbers[i] == 0)
        {
          Console.WriteLine(PrimeNumbers[i]);
          break;
        }
      }
      Console.Read();
    }

    static bool IsPrime(long number)
    {
      foreach (long i in PrimeNumbers)
      {
        if (i <= Math.Sqrt(number))
        {
          if (number % i == 0)
            return false;
        }
        else
          break;
      }
      return true;
    }
  }
}
