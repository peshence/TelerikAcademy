using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        long f1 = 1;
        long f2 = 1;
        for (int i = n + 2; i <= 2 * n; i++)
        {
            f1 = f1 * i;
        }
        for (int i = 1; i <= n; i++)
        {
            f2 = f2 * i;
        }
        decimal cn = f1 / f2;
        Console.WriteLine(cn);
    }
}

