using System;
using System.Linq;

namespace Sorting
{
    internal class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(array);

            foreach (int num in array)
            {
                Console.Write($"{num} ");
            }
        }
    }
}