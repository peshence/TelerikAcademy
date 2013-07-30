using System;

//Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

class MaxInt
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine(GetMax(GetMax(a,b),c));
    }

    static int GetMax(int a, int b)
    {
        if (a > b) return a;
        else return b;
    }
}

