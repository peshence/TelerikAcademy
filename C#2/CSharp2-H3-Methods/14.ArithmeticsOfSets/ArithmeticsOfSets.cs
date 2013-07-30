using System;

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.

class ArithmeticsOfSets
{
    static void Main()
    {
        int[] arr = RandomArray();
        Console.WriteLine("Here's a random array: ");
        PrintArray(arr);
        Console.WriteLine("Minimum of set is: " + Min(arr));
        Console.WriteLine("Maximum of set is: " + Max(arr));
        Console.WriteLine("Average of set is: " + Average(arr));
        Console.WriteLine("Sum of set is: " + Sum(arr));
        Console.WriteLine("Product of set is: " + Product(arr));
    }
    static int[] RandomArray()
    {
        Random randomize = new Random();
        int[] arr = new int[randomize.Next(3, 10)];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = randomize.Next(10);
        }
        return arr;
    }
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0} ",arr[i]);
        }
        Console.WriteLine();
    }
    static int Min(params int[] arr)
    {
        int min = int.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min) min = arr[i];
        }
        return min;
    }
    static int Max(params int[] arr)
    {
        int max = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
        }
        return max;
    }
    static double Average(params int[] arr)
    {
        double average = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            average += arr[i];
        }
        average /= arr.Length;
        return average;
    }
    static int Sum(params int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
    static long Product(params int[] arr)
    {
        long product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        return product;
    }
}


