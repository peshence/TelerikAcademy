using System;
using System.Collections.Generic;

//Write a program that finds the sequence of maximal sum in given array. Example:
//{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//Can you do it with only one loop (with single scan through the elements of the array)?


class MaxSumSequence
{
    static void Main()
    {
        Console.WriteLine("Enter array length: ");
        int length = int.Parse(Console.ReadLine());
        int[] arr= new int[length];
        int currentBiggest = 0;
        int biggest = int.MinValue;
        int currCount = 1;
        int count = 1;
        int lastIndex = 1;
        Console.WriteLine("Enter array: ");
        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            if (currentBiggest <= 0)
            {
                currentBiggest = arr[i];
                currCount = 1;
            }
            else
            {
                currentBiggest += arr[i];
                currCount++;
            }
            if (currentBiggest > biggest)
            {
                biggest = currentBiggest;
                count = currCount;
                lastIndex = i;
            }
        }
        //Console.WriteLine("{0}  {1}  {2}",biggest,count,lastIndex);
        Console.Write("{");
        for (int i = lastIndex - count + 1; i < lastIndex; i++)
        {
            Console.Write("{0}, ", arr[i]);
        }
        Console.WriteLine(arr[lastIndex] + "}");
    }
}

