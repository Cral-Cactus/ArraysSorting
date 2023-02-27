using System;
using System.Linq;

namespace AddNumberToArray
{
    internal class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            int[] newArray = new int[array.Length + 1];
            
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[array.Length] = number;
            array = newArray;

            Array.Sort(array);
            
            foreach (int num in array)
            {
                Console.Write($"{num} ");
            }
        }
    }
}