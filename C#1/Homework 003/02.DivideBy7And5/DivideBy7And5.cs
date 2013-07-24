using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Enter the number you wish to check: ");
        int n = int.Parse(Console.ReadLine());
        /*if (n % 35 == 0)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }*/
        Console.WriteLine(n%35==0);
    }
}

