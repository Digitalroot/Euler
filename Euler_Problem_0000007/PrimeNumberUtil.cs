using System;
using System.Collections.Generic;

namespace Euler_Problem_0000007
{
  internal class PrimeNumberUtil
  {
    private readonly List<long> _primeNumbers = new List<long>();

    /// <summary>
    /// Returns the a list of prime numbers up to the max number passed
    /// </summary>
    /// <param name="max">Range. 2 until max</param>
    /// <returns></returns>
    public List<long> GetPrimesTo(long max)
    {
      _primeNumbers.Clear();
      _primeNumbers.Add(2);
      _primeNumbers.Add(3);
      _primeNumbers.Add(5);

      for (long i = 7; i < Math.Sqrt(max); i += 2)
      {
        if (i%5 != 0)
        {
          if (IsPrime(i))
          {
            _primeNumbers.Add(i);
          }
        }
      }
      return _primeNumbers;
    }


    /// <summary>
    /// Returns the a list of prime numbers.
    /// </summary>
    /// <param name="count">How many prime numbers to return starting at 2.</param>
    /// <returns></returns>
    public List<long> GetPrimes(long count)
    {
      _primeNumbers.Clear();
      _primeNumbers.Add(2);
      _primeNumbers.Add(3);
      _primeNumbers.Add(5);

      long i = 7;
      while (_primeNumbers.Count < count)
      {
        if (i%5 != 0)
        {
          if (IsPrime(i))
          {
            _primeNumbers.Add(i);
          }
        }
        i += 2;
      }
      return _primeNumbers;
    }

    private bool IsPrime(long number)
    {
      foreach (long i in _primeNumbers)
      {
        if (i <= Math.Sqrt(number))
        {
          if (number%i == 0)
            return false;
        }
        else
          break;
      }
      return true;
    }
  }
}