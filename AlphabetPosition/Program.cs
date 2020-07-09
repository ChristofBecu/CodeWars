//In this kata you are required to, given a string, replace every letter with its position in the alphabet.

//If anything in the text isn't a letter, ignore it and don't return it.

//"a" = 1, "b" = 2, etc.

using System;

namespace AlphabetPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "The sunset sets at twelve o' clock.";
            string result = AlphabetPosition(text);
            string expected = "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11";
            Console.WriteLine(result);
            Console.WriteLine(expected);
            Console.WriteLine(result.Equals(expected));
            Console.ReadLine();
        }

        public static string AlphabetPosition(string text)
        {
            try
            {
                char[] arr = text.ToLower().ToCharArray();
                arr = Array.FindAll(arr, c => char.IsLetter(c));
                text = null;
                foreach (char ch in arr)
                    text += ch - 96 + " ";
                return text.Remove(text.Length - 1);
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
