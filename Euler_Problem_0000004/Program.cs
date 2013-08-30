using System;
using System.Collections.Generic;
using System.Globalization;

namespace Euler_Problem_0000004
{
  class Program
  {
    static readonly List<long> PalindromeNumbers = new List<long>();
    static void Main()
    {
      // Find the largest palindrome made from the product of two 3-digit numbers
      const long max = 998001; // 999 * 999 
      const long min = 100000; // 100 * 100 = 10000 - Assume the answer is at least six digits. (This could be a wrong assumption.) 

      // Collect a list of all palindrome numbers from min to max. 

      for (var i = max; i > min; i--) 
      {
        if (IsPalindrome(i))
        {
          PalindromeNumbers.Add(i);
        }
      }

      foreach (var palindromeNumber in PalindromeNumbers)
      {
        for (long i = 999; i > 99; i--)
        {
          if (palindromeNumber % i == 0)
          {
            var q = palindromeNumber/i;

            if (q > 99 && q < 1000)
            {
              Console.WriteLine("{0}:{1} * {2}", palindromeNumber, i, q);
              Console.Read();
            }
          }
        }
      }
    }

    private static bool IsPalindrome(long l)
    {
      var s = l.ToString(CultureInfo.InvariantCulture);

      return s[0] == s[5] && s[1] == s[4] && s[2] == s[3];
    }
  }
}
