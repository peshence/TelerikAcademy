using System;

class GreatestOf5
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter fourth number: ");
        double d = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter fifth number: ");
        double e = double.Parse(Console.ReadLine());
        if (a < b)
        {
            a = b;
        }
        if (a < c)
        {
            a = c;
        }
        if (a < d)
        {
            a = d;
        }
        if (a < e)
        {
            a = e;
        }
        Console.WriteLine("The greatest number is: " + a);
    }
}

