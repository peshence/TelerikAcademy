using System;

class MatrixNByN
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int k = i; k < n + i; k++)
            {
                Console.Write(k+"    ");
            }
            Console.WriteLine("\n");
        }
    }
}

