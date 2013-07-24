using System;

class SoMuchFactorials
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K. It must be bigger than N!: ");
        int k = int.Parse(Console.ReadLine());
        decimal product = 1;
        for (int i = 1; i <= n; i++)
        {
            product = product * i;
        }
        for (int i = k-n+1; i <= k; i++)
        {
            product = product * i;
        }
        Console.WriteLine(product);
    }
}

