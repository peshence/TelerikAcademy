using System;

class NumbersNotDivisibleBy21
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % (3*7) != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
