using System;

//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.

class ReturnIndexWithPrevious
{
    static void Main()
    {
        Random randomize = new Random();

        int n = randomize.Next(5, 15);
        Console.WriteLine("Random array length = " + n);

        int[] arr = new int[n];
        Console.WriteLine("Random array (by index): ");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = randomize.Next(5);
            Console.WriteLine("{0}. {1}", i, arr[i]);
        }
        Console.WriteLine();

        ReturnIndex(arr);
    }
    static bool CheckNeighbours(int index, int[] arr)
    {
        if (index < arr.Length - 1 && index > 0)
        {
            if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1]) return true;
        }
        else if (index == 0 && arr[0] > arr[1]) return true;
        else if (index == arr.Length - 1 && arr[arr.Length - 1] > arr[arr.Length - 2]) return true;
        return false;
    }
    static void ReturnIndex(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (CheckNeighbours(i,arr))
            {
                Console.WriteLine(i);
                return;
            }
        }
        Console.WriteLine(-1);
    }
}

