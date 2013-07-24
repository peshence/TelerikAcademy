using System;

class FibonacciSum
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        int sum = 0;
        for (int i = 1; i < n; i++)
        {
            if (b > a)
            {
                sum = sum + b;
                a = a + b;
            }
            else
            {
                sum = sum + a;
                b = a + b;
            }
        }
        Console.WriteLine("Sum of first {0} Fibonacci members is {1}",n,sum);
    }
}

