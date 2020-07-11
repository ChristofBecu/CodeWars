//https://www.codewars.com/kata/5552101f47fc5178b1000050/train/csharp
//Some numbers have funny properties.For example:

//    89 --> 8¹ + 9² = 89 * 1

//    695 --> 6² + 9³ + 5⁴= 1390 = 695 * 2

//    46288 --> 4³ + 6⁴+ 2⁵ + 8⁶ + 8⁷ = 2360688 = 46288 * 51

//Given a positive integer n written as abcd... (a, b, c, d...being digits) and a positive integer p

//    we want to find a positive integer k, if it exists, such as the sum of the digits of n taken to the successive powers of p is equal to k* n.

//In other words:

//    Is there an integer k such as : (a ^ p + b ^ (p+1) + c ^(p+2) + d ^ (p+3) + ...) = n* k

//If it is the case we will return k, if not return -1.

//Note: n and p will always be given as strictly positive integers.

//digPow(89, 1) should return 1 since 8¹ + 9² = 89 = 89 * 1
//digPow(92, 1) should return -1 since there is no k such as 9¹ + 2² equals 92 * k
//digPow(695, 2) should return 2 since 6² + 9³ + 5⁴= 1390 = 695 * 2
//digPow(46288, 3) should return 51 since 4³ + 6⁴+ 2⁵ + 8⁶ + 8⁷ = 2360688 = 46288 * 51

using System;
using System.Linq;

namespace PlayingWithDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int expected = 51;
            int number = 46288;
            int power = 3;
            long result = digPow(number, power);
            Console.WriteLine(result);
            Console.WriteLine(result == expected);
            Console.ReadKey();
        }

        public static long digPow(int n, int p)
        {
            long result = 0;
            double sumOfPowers = 0;
            foreach (byte digit in n
                .ToString()
                .ToCharArray()
                .Select(c => byte.Parse(c.ToString()))
                .ToArray())
                sumOfPowers += Math.Pow(digit, p++);

            result = (long)(sumOfPowers / n);
            return result * n == sumOfPowers ? result : -1;
        }
    }
}
