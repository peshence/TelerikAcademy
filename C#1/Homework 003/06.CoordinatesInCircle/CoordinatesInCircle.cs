using System;

class CoordinatesInCircle
{
    static void Main()
    {
        Console.WriteLine("Enter coordinate x");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coordinate y");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine("Is the point on the line of the circle K(0,5)?");
        Console.WriteLine((Math.Sqrt(x * x + y * y)) == 5); // This shows if the point is on the line of the circle
        Console.WriteLine("Is the point within the area of the circle K(0,5)?");
        Console.WriteLine((Math.Sqrt(x * x + y * y)) <= 5); // This shows if the point is within the area of the circle
    }
}

