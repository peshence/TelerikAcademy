using System;

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.


class SelectionSort
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
        int temp = 0;
        int min = 0;
        for (int i = 1; i < length; i++)
        {
            for (int k = i; k < length; k++)
            {
                if (arr[k] < arr[min])
                {
                    min = k;
                }
            }
            temp = arr[i - 1];
            arr[i - 1] = arr[min];
            arr[min] = temp;
            min = i;
        }
        Console.WriteLine("Sorted array: ");
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}

