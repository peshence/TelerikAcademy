using System;

class SumOfN
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        double nnumber = 0d;
        double sum = 0d;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Enter next number: ");
            nnumber = double.Parse(Console.ReadLine());
            sum = sum + nnumber;
        }
        Console.WriteLine("The sum of the numebrs is: " + sum);
    }
}

