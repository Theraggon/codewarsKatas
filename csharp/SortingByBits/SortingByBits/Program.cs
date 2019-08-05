using System;
using System.Numerics;

namespace SortingByBits
{
    class Kata
    {
        public static int PopCount(UInt32 number)
        {
            int count = 0;
            while (number > 0)
            {
                ++count;
                number = number & (number - 1);
            }
            return count;
        }
        public static void SortByBit(int [] array)
        {
            //Net.Core.3.0 solution
            //Array.Sort(array, delegate (int m, int n)
            // { return BitOperations.PopCount((UInt32) m) - BitOperations.PopCount((UInt32) n) != 0 ?
            //   BitOperations.PopCount((UInt32)m) - BitOperations.PopCount((UInt32)n) : m - n;
            // });
            Array.Sort(array, delegate (int m, int n)
            {
                return PopCount((UInt32)m) - PopCount((UInt32)n) != 0 ?
                PopCount((UInt32)m) - PopCount((UInt32)n) : m - n;
            });
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            SortingByBits.Kata.SortByBit(newArray);
            foreach (var element in newArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
