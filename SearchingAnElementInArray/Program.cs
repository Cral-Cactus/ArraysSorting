using System;
using System.Linq;

namespace SearchingAnElementInArray
{
    internal class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int searchedNumber = int.Parse(Console.ReadLine());
            
            bool isFound = false;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchedNumber)
                {
                    isFound = true;
                    break;
                }
            }
            
            Console.WriteLine(isFound ? "Yes" : "No");
        }
    }
}