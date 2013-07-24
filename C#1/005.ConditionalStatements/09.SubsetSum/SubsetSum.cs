using System;

class SubsetSum
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter fourth number: ");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter fifth number: ");
        int e = int.Parse(Console.ReadLine());
        int[] array = new int[] { a, b, c, d, e };
        int count = 0;
        for (int i = 1; i < 32; i++)
        {
            int sum = 0;
            for (int k = 0; k < 5; k++)
            {
                sum += ((i >> k & 1) * array[k]);
            }
            if (sum == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count + " Subset Sums are equal to 0");
    }
}

