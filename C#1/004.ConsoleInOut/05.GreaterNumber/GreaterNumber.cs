﻿using System;

class GreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is: " + Math.Max(a,b));
    }
}

