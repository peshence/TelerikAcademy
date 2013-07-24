using System;
using System.Collections.Generic;

//* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).


class MergeSort
{
    static void Main()
    {
        Console.WriteLine("Enter array length: ");
        int length = int.Parse(Console.ReadLine());
        List<int> input = new List<int>();

        Console.WriteLine("Enter array: ");
        for (int i = 0; i < length; i++)
        {
            input.Add(int.Parse(Console.ReadLine()));
        }

        input = Separate(input);

        Console.WriteLine("Sorted array:");
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(input[i]);
        }

    }

    static List<int> Separate(List<int> arr)
    {
        if (arr.Count <= 1)
        {
            return arr;
        }

        List<int> left = new List<int>();
        for (int i = 0; i < arr.Count/2; i++)
        {
            left.Add(arr[i]);
        }

        List<int> right = new List<int>();
        for (int i = arr.Count/2; i < arr.Count; i++)
        {
            right.Add(arr[i]);
        }

        left = Separate(left);
        right = Separate(right);

        return Merge(left, right);
    }

    static List<int> Merge(List<int> left, List<int> right)
    {
        List<int> temp = new List<int>();

        while (left.Count > 0 || right.Count > 0)
        {
            if (left.Count > 0 && right.Count > 0)
            {
                if (left[0] <= right[0])
                {
                    temp.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    temp.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            else if (left.Count > 0)
            {
                temp.Add(left[0]);
                left.RemoveAt(0);
            }
            else
            {
                temp.Add(right[0]);
                right.RemoveAt(0);
            }
        }
        return temp;
    }
}

