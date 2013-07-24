using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter the number you wish to check: ");
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
    }
}

