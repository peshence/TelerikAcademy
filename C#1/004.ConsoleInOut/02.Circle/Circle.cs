using System;

class Circle
{
    static void Main()
    {
        Console.WriteLine("Enter the radius of the circle");
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine("Circle perimeter is: " + 2*Math.PI*r);
        Console.WriteLine("Circle area is: " + Math.PI*r*r);
    }
}

