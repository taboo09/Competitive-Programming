using System;
using System.Collections.Generic;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quick Sort");

            var listOfArrs = new List<int[]>()
            {
                new int[] {1, 2, 3},
                new int[] {3, 2, 1},
                new int[] {},
                new int[] {3, 1, -1, 0, 2, 5},
                new int[] {2, 2, 1, 1, 0, 0, 4, 4, 2, 2, 2},
                new int[] {0},
                new int[] {3, -2, -1, 0, 2, 4, 1},
                new int[] {1, 2, 3, 4, 5, 6, 7},
                new int[] {2, 2, 2, 2, 2, 2, 2}
            };

            foreach (var arr in listOfArrs)
            {
                Console.Write("Quick Sort array: ");

                foreach(var item in Quick.Sort(arr))
                {   
                    Console.Write(" " + item);
                }

                Console.WriteLine();
            }
        }
    }
}
