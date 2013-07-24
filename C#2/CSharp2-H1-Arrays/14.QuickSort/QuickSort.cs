using System;

//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

class QuickSort
{
    static void Main()
    {
        Console.WriteLine("Enter array's length: ");
        int length = int.Parse(Console.ReadLine());
        string[] arr = new string[length];
        Console.WriteLine("Enter array: ");
        for (int i = 0; i < length; i++)
        {
            arr[i] = Console.ReadLine();
        }
        int start = 0;
        int end = arr.Length;
        arr = Sort(arr, start, end);
        Console.WriteLine("Sorted list: ");
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    static string[] Sort(string[] arr, int start, int end)
    {

        string[] temp = (string[])arr.Clone();
        
        if ((end - start) <= 1)
        {
            return arr;
        }
        

        int pivot = (end + start) / 2;
        string tempstr = arr[pivot];
        arr[pivot] = arr[end - 1];
        arr[end - 1] = tempstr;
        int newend = start;
        int newstart = end;

        for (int i = start; i < end - 1; i++)
        {
            if (arr[i].CompareTo(arr[end-1]) <= 0)
            {
                newend++;
                temp[newend-1] = arr[i];
            }
            else
            {
                newstart--;
                temp[newstart] = arr[i];
            }
            
        }
        temp[newend] = arr[end - 1];
        arr = temp;

        arr = Sort(arr, start, newend);
        arr = Sort(arr, newstart, end);

        return arr;
    }
}

