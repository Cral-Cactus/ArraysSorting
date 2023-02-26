using System;

public class Program
{
    public static void Main()
    {
        // 2 solutions of the task
        string input1 = Console.ReadLine().Replace(" ", "");
        string input2 = Console.ReadLine().Replace(" ", "");

        int compareResult = string.Compare(input1, input2);

        if (compareResult < 0)
        {
            Console.WriteLine(input1);
            Console.WriteLine(input2);
        }
        else
        {
            Console.WriteLine(input2);
            Console.WriteLine(input1);
        }

        //string input1 = Console.ReadLine().Replace(" ", "");
        //string input2 = Console.ReadLine().Replace(" ", "");

        //char[] arr1 = input1.ToCharArray();
        //char[] arr2 = input2.ToCharArray();

        //int minLength = Math.Min(arr1.Length, arr2.Length);
        //bool arraysAreEqual = true;

        //for (int i = 0; i < minLength; i++)
        //{
        //    if (arr1[i] < arr2[i])
        //    {
        //        Console.WriteLine(input1);
        //        Console.WriteLine(input2);
        //        arraysAreEqual = false;
        //        break;
        //    }
        //    else if (arr1[i] > arr2[i])
        //    {
        //        Console.WriteLine(input2);
        //        Console.WriteLine(input1);
        //        arraysAreEqual = false;
        //        break;
        //    }
        //}

        //if (arraysAreEqual)
        //{
        //    if (arr1.Length < arr2.Length)
        //    {
        //        Console.WriteLine(input1);
        //        Console.WriteLine(input2);
        //    }
        //    else
        //    {
        //        Console.WriteLine(input2);
        //        Console.WriteLine(input1);
        //    }
        //}
    }
}