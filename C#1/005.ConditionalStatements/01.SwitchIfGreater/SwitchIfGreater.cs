using System;

class SwitchIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter value of variable a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of variable b: ");
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        Console.WriteLine("The value of a is now: " + a);
        Console.WriteLine("The value of b is now: " + b);
    }
}

