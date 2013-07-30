using System;

//Write a method that return the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order.

class SortAscendingDescending
{
    static void Main()
    {
        Random randomize = new Random();
        int[] arr = new int[randomize.Next(5,15)];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = randomize.Next(100);
        }
        Console.WriteLine("Random array: ");
        Print(arr);
        Console.WriteLine("Sorted ascending array: ");
        Print(Sort(arr,true));
        Console.WriteLine("Sorted descending array: ");
        Print(Sort(arr,false));
    }

    static int FindMax(int[] arr, int index)
    {
        int max = int.MinValue;
        int maxindex = 0;

        for (int i = index; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
                maxindex = i;
            }
        }
        return maxindex;
    }
    static int[] Sort(int[] arr, bool ascend)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Swap(arr, i, FindMax(arr, i));
        }
        if (ascend) Array.Reverse(arr);
        return arr;
    }
    static void Swap(int[] arr, int index, int maxIndex)
    {
        int temp = arr[index];
        arr[index] = arr[maxIndex];
        arr[maxIndex] = temp;
    }
    static void Print(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}

