using System;

class SortThree
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        double c = double.Parse(Console.ReadLine());
        if (a > b)
        {
            if (a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("{0}\n{1}\n{2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0}\n{1}\n{2}", a, c, b);
                }
            }
            else
            {
                Console.WriteLine("{0}\n{1}\n{2}", c, a, b);
            }
        }
        else if (b > c)
        {
            if (a > c)
            {
                Console.WriteLine("{0}\n{1}\n{2}", b, a, c);
            }
            else
            {
                Console.WriteLine("{0}\n{1}\n{2}", b, c, a);
            }
        }
        else
        {
            Console.WriteLine("{0}\n{1}\n{2}", c, b, a);
        }
    }
}

