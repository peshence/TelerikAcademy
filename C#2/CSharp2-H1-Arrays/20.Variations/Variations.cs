using System;
using System.Collections.Generic;

//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
//N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}


class Variations
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        int[] result = new int[k];

        Variate(result, n, 0);

    }

    static void Variate(int[] result, int n, int count)
    {
        int[] arr = (int[])result.Clone();
        if (count >= arr.Length)
        {
            Console.Write("{");
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j] + ", ");
            }
            Console.WriteLine("\b\b}");
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            arr[count] = i;

            Variate(arr, n, count + 1);
        }
    }
}

