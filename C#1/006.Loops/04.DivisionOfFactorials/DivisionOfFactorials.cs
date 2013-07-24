using System;

class DivisionOfFactorials
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        decimal product = 1;
        if (n > k)
        {
            for (int i = k + 1; i <= n; i++)
            {
                product = product * i;
            }
        }
        else
        {
            for (int i = n+1; i<=k; i++)
            {
                product = product / i;
            }
        }
        Console.WriteLine(product);
    }
}

