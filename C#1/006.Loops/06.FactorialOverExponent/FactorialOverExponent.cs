using System;

class FactorialOverExponent
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter X: ");
        int x = int.Parse(Console.ReadLine());
        double s = 1;
        double f = 1;
        for (int i = 1; i <= n; i++)
        {
            f = 1;
            for (int k = 1; k <= i; k++)
            {
                f=f*k;
            }
            s = s + f / (Math.Pow(x,i));
        }
        Console.WriteLine("S = {0}",s);
    }
}

