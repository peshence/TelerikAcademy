using System;
using System.Collections.Generic;

//Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

class Factorial100
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        int[] result = Factorial(n);
        Console.Write("n! = ");
        Print(result);
    }
    static int[] Multiply(int[] result, int multiplier)
    {
        List<int> temp = new List<int>();
        int remainder = 0;
        for (int i = 0; i < result.Length; i++)
        {
            temp.Add(result[i] * multiplier + remainder);
            remainder = temp[i] / 10;
            temp[i] %= 10;
        }
        while (remainder != 0)
        {
            temp.Add(remainder % 10);
            remainder /= 10;
        }
        result = temp.ToArray();
        return result;
    }
    static int[] Factorial(int n)
    {
        int[] result = { 1 };
        for (int i = 2; i <= n; i++)
        {
            result = Multiply(result, i);            
        }
        Array.Reverse(result);
        return result;
    }
    static void Print(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }
}

