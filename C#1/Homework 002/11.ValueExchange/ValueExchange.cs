using System;

class ValueExchange
{
    static void Main()
    {
        /*
         * I guess this is the task at hand but it's not actually a program
         * so I'm making it a program outside of the quote
         * also using an alternate solution
        int a = 5;
        int b = 10;
        a = a + b;
        b = a - b;
        a = a - b; */

        Console.WriteLine("Enter a value for variable a (for example 5): ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value for variable b (for example 10): ");
        int b = int.Parse(Console.ReadLine());
        int c = b;
        b = a;
        a = c;
        Console.WriteLine("Variable a's value is now {0} and variable b's value is now {1}",a,b);
    }
}

