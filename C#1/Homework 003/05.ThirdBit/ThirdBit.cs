using System;

class ThirdBit
{
    static void Main()
    {
        Console.WriteLine("Enter your number: ");
        int n = int.Parse(Console.ReadLine());
        int m = 1 << 3;
        Console.WriteLine((n&m)!=0);
    }
}

