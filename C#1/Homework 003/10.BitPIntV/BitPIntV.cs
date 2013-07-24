using System;

class BitPIntV
{
    static void Main()
    {
        Console.WriteLine("Enter integer v: ");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position p: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        Console.WriteLine((v&mask) != 0);
    }
}

