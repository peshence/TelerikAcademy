using System;

class MinMaxOfN
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter first number: ");
        int check = int.Parse(Console.ReadLine());
        int max = check;
        int min = check;
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine("Enter next number: ");
            check = int.Parse(Console.ReadLine());
            if (max < check)
            {
                max = check;
            }
            if (min > check)
            {
                min = check;
            }
        }
        Console.WriteLine(" Maximal is: {0} \n Minimal is: {1}",max,min);
    }
}

