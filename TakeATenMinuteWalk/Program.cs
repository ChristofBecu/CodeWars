//https://www.codewars.com/kata/54da539698b8a2ad76000228/train/csharp
//You live in the city of Cartesia where all roads are laid out in a perfect grid.
//You arrived ten minutes too early to an appointment, 
//so you decided to take the opportunity to go for a short walk.
//The city provides its citizens with a Walk Generating App on their phones 
//-- everytime you press the button it sends you an array of one-letter strings 
//representing directions to walk (eg. ['n', 's', 'w', 'e']). 
//You always walk only a single block in a direction and you know it takes you 
//one minute to traverse one city block, so create a function that will return true 
//if the walk the app gives you will take you exactly ten minutes 
//(you don't want to be early or late!) and will, of course, return you to 
//your starting point. Return false otherwise.

//   Note: you will always receive a valid array containing a random assortment 
//of direction letters ('n', 's', 'e', or 'w' only). 
//It will never give you an empty array(that's not a walk, that's standing still!).



using System;
using System.Linq;
using System.Collections.Generic;

namespace TakeATenMinuteWalk
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] walk = new string[] { "e", "w", "e", "w", "n", "s", "n", "s", "e", "w" };
            bool result = IsValidWalk(walk);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public static bool IsValidWalk(string[] walk)
        {
            int minutes = 10;
            if (walk.Length == minutes)
            {
                int ns = 0;
                int ew = 0;

                foreach (var step in walk)
                {
                    switch (step)
                    {
                        case "n":
                            ns++;
                            break;
                        case "s":
                            ns--;
                            break;
                        case "e":
                            ew++;
                            break;
                        case "w":
                            ew--;
                            break;
                        default:
                            break;
                    }
                }
                return ns == 0 && ew == 0;
            }
            return false;
        }
    }
}

