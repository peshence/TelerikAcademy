using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int m = int.Parse(Console.ReadLine());
        while (n != m)
        {
            if (n > m)
            {
                n = n - m;
            }
            else
            {
                m = m - n;
            }
        }
        Console.WriteLine("Greatest common divisor is: "+n);
    }
}

