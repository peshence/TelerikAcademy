using System;

class BitExtraction
{
    static void Main()
    {
        Console.WriteLine("Enter integer i: ");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit number b: ");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;

        Console.WriteLine((i & mask) != 0 ? 1 : 0);
    }
}
