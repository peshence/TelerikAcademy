using System;
using System.Collections.Generic;

//Write a program that finds the most frequent number in an array. Example:
//{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

class MostFrequent
{
    static void Main()
    {
        Console.WriteLine("Enter array length: ");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        Console.WriteLine("Enter array: ");
        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        int curCount = 1;
        int curValue = arr[0];
        int count = 1;
        int value = arr[0];
        for (int i = 1; i < length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                curCount++;
            }
            else
            {
                curCount = 1;
                curValue = arr[i];
            }
            if (curCount > count)
            {
                count = curCount;
                value = curValue;
            }
        }
        Console.WriteLine("{0} ({1} times)",value,count);
    }
}

