using System;

class Trapezoid
{
    static void Main()
    {
        Console.WriteLine("Enter side a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height h: ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("The area of the trapezoid is " + ((a+b)*h/2));
    }
}
