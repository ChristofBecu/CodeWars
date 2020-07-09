//Given two arrays a and b write a function comp(a, b) (compSame(a, b) in Clojure) 
//    that checks whether the two arrays have the "same" elements,
//    with the same multiplicities. "Same" means, here, that the elements in b are the 
//        elements in a squared, regardless of the order.

using System;
using System.Linq;

namespace AreTheyTheSame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            bool r = comp(a, b); // True

            Console.WriteLine(r);
            Console.ReadLine();
        }

        public static bool comp(int[] a, int[] b)
        {
            try
            {
                var size = a.Length;
                Array.Sort(a);
                Array.Sort(b);

                for (int i = 0; i < size; i++)
                    a[i] *= a[i];

                return Enumerable.SequenceEqual(a, b);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
