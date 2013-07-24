﻿using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter coefficient a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient c: ");
        double c = double.Parse(Console.ReadLine());
        double d = b * b - 4 * a * c;
        if (d > 0)
        {

            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("The roots of the quation are {0} and {1}",x1,x2);
        }
        else if (d == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("There is one real solution: " + x);
        }
        else
        {
            Console.WriteLine("There are no real solutions.");
        }
    }
}

