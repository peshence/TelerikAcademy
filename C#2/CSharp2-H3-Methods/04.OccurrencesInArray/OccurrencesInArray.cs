using System;

class OccurrencesInArray
{
    static void Main()
    {
        Random randomize = new Random();

        int n = randomize.Next(5, 15);
        Console.WriteLine("Random array length = " + n);
        int[] arr = new int[n];
        Console.WriteLine("Random array: ");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = randomize.Next(5);
            Console.Write(arr[i] + "  ");
        }
        Console.WriteLine();

        Console.WriteLine("Which number's occurrences would you like to count?");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("It occurs " + CountOccurrences(arr, a) + " times.");
    }

    static int CountOccurrences(int[] arr, int a)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == a) count++;
        }
        return count;
    }
}