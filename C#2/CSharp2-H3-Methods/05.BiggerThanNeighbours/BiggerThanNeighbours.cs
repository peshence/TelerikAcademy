using System;

//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

class BiggerThanNeighbours
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

        Console.WriteLine("Which number would you like to check? Enter it's index.");
        int index = int.Parse(Console.ReadLine());

        Console.WriteLine(CheckNeighbours(index, arr));
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
}

    //This is a more thorough method. After reading the next task I realized it's unnecessary
    /*static void CheckNeighbours(int index, int[] arr)
    {
        if (index == arr.Length - 1)
        {
            Console.WriteLine("It's the last member.");
            if (arr[index] > arr[index - 1]) Console.WriteLine("It's bigger than it's neighbour.");
            else Console.WriteLine("It's not bigger than it's neighbour.");
        }
        else if (index == 0)
        {
            Console.WriteLine("It's the first member.");
            if (arr[index] > arr[index + 1]) Console.WriteLine("It's bigger than it's neighbour.");
            else Console.WriteLine("It's not bigger than it's neighbour.");
        }
        else
        {
            if (arr[index] > arr[index - 1])
                if (arr[index] > arr[index + 1]) Console.WriteLine("Bigger than both neighbours.");
                else Console.WriteLine("Only bigger than previous member.");
            else if (arr[index] > arr[index + 1])
                Console.WriteLine("Only bigger than following member.");
            else Console.WriteLine("Both neighbours are larger or equal.");
        }
    }
}*/

