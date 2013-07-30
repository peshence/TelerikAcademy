using System;
using System.Collections.Generic;

class ArithmeticsOfSetsModified
{
    static void Main()
    {
        Console.WriteLine("This is the set: 1,234 4,4563 345,134 53,45 165,98");
        Console.WriteLine("Minimum of set is: " + Min(1.234, 4.4563, 345.134, 53.45, 165.98));
        Console.WriteLine("Maximum of set is: " + Max(1.234, 4.4563, 345.134, 53.45, 165.98));
        Console.WriteLine("Average of set is: " + Average(1.234, 4.4563, 345.134, 53.45, 165.98));
        Console.WriteLine("Sum of set is: " + Sum(1.234, 4.4563, 345.134, 53.45, 165.98));
        Console.WriteLine("Product of set is: " + Product(1.234, 4.4563, 345.134, 53.45, 165.98));
    }
    static void PrintArray<T>(params T[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0} ",arr[i]);
        }
        Console.WriteLine();
    }
    static T Min<T>(params T[] arr)
    {
        dynamic min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min) min = arr[i];
        }
        return min;
    }
    static T Max<T>(params T[] arr)
    {
        dynamic max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
        }
        return max;
    }
    static T Average<T>(params T[] arr)
    {
        dynamic average = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            average += arr[i];
        }
        average /= arr.Length;
        return average;
    }
    static T Sum<T>(params T[] arr)
    {
        dynamic sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
    static T Product<T>(params T[] arr)
    {
        dynamic product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        return product;
    }
}



