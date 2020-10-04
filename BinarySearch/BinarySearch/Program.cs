using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search");

            var arr = new int[] { 4, 5, 9, 10, 12, 15, 18, 21 };
            var target = 15;

            Console.WriteLine(Binary.Search(arr, target));
        }
    }
}
