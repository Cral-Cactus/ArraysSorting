using System;
using System.Linq;

namespace MergingArrays
{
    internal class Program
    {
        static void Main()
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] merged = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    merged[k] = arr1[i];
                    i++;
                }
                else
                {
                    merged[k] = arr2[j];
                    j++;
                }
                k++;
            }

            while (i < arr1.Length)
            {
                merged[k] = arr1[i];
                i++;
                k++;
            }

            while (j < arr2.Length)
            {
                merged[k] = arr2[j];
                j++;
                k++;
            }

            Console.WriteLine(string.Join(" ", merged));
        }
    }
}