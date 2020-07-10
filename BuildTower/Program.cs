//Build Tower by the following given argument:
//number of floors(integer and always greater than 0).
// https://www.codewars.com/kata/576757b1df89ecf5bd00073b/train/csharp

using System;
using System.Collections.Generic;
using System.Text;

namespace BuildTower
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = 5;
            var result = TowerBuilder(floors);
            foreach (var item in result)
            {
                Console.Write(item);
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static string[] TowerBuilder(int nFloors)
        {
            try
            {
                string[] tower = new string[nFloors];
                int nSpaces = nFloors - 1;
                int nStars = 1;

                int row = 0;
                while (row < nFloors)
                {
                    string rowBuilder = "";
                    rowBuilder += new string(' ', nSpaces);
                    rowBuilder += new string('*', nStars);
                    rowBuilder += new string(' ', nSpaces);
                    nStars += 2;
                    nSpaces--;
                    tower[row] = rowBuilder;
                    row++;
                }

                return tower;
            }
            catch (Exception)
            {
                return new string[0];
            }       
        }
    }
}
