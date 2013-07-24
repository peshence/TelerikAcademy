using System;

//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
//N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

class Combinations
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[k];

        Combine(arr, 0, n, 1);
    }
    static void Combine(int[] arr, int count, int n, int j)
    {
        if (count == arr.Length)
        {
            Console.Write("{");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+", ");
            }
            Console.WriteLine("\b\b}");
            return;
        }

        for (int i = j; i <= n; i++)
        {
            arr[count] = i;
            Combine(arr, count + 1, n, i + 1);
        }
    }
}
