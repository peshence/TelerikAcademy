using System;

//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

class SortAndBinSearch
{
    static void Main()
    {
        Console.WriteLine("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter array length: ");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("Now enter array: ");
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);

        int check = Array.BinarySearch(arr, k);

        Console.Write("Largest number smaller than or equal to K in the array is ");
        if (check >= 0)
        {
            Console.WriteLine(arr[check]);
        }
        else
        {
            Console.WriteLine(arr[(~check) - 1]);
        }
    }
}

