using System;

class DivideableBy5
{
    static void Main()
    {
        int count = 0;
        Console.WriteLine("Enter first integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int m = int.Parse(Console.ReadLine());
        if (n > m) // This is in case somebody writes the bigger number first
        {
            n = n + m;
            m = n - m;
            n = n - m;
        }
        for (int i = n; i <= m; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine("There are {0} numbers between {1} and {2} divisable by 5.", count,n,m);
    }
}

