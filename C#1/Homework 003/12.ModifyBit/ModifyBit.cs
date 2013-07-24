using System;

class ProgrModifyBitam
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int maskIf = (mask & n) != 0 ? 1 : 0; //determine the bit in position p

        if (maskIf == 0)
        {
            Console.WriteLine(n | (1 << p));
        }
        else
        {
            Console.WriteLine(n & ~(1 << p));
        }

    }
}

