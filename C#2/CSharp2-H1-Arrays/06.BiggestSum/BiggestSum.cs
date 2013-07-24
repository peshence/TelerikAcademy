using System;

//Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.


class BiggestSum
{
    static void Main()
    {
        Console.WriteLine("Enter array length: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of elements: ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Enter array: ");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);

        int sum = 0;
        Console.WriteLine("Biggest K elements are: ");
        for (int i = n - 1; i > n - k - 1; i--)
        {
            Console.WriteLine(array[i]);
            sum += array[i];
        }
        Console.WriteLine("Sum is {0}",sum);
    }
}

