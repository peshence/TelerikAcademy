using System;
using System.Collections.Generic;

//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

class SortStringArray
{
    class StringComparer : IComparer<string>
    {
        public int Compare(string str1, string str2)
        {
            return str1.Length.CompareTo(str2.Length);
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter array length: ");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("Now enter array: ");
        string[] arr = new string[length];

        for (int i = 0; i < length; i++)
        {
            arr[i] = Console.ReadLine();
        }
        Array.Sort(arr, new StringComparer());
        Console.WriteLine("Sorted by string length: ");
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}

