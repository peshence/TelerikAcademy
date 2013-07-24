using System;

class Fibonacci100
{
    static void Main()
    {
        Console.WriteLine("The first 100 members of the Fibonacci sequence are: ");
        decimal n = 0m;
        decimal m = 1m;
        Console.WriteLine(n);
        Console.WriteLine(m);
        for (int i = 1; i <= 98; i++)
//This prints exactly 100 fibanocci series members.
        {
            Console.WriteLine(n+m);
            if (n < m)
            {
                n = n + m;
            }
            else
            {
                m = n + m;
            }
        }
    }
}

