using System;

class PointInCircleRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter coordinate x");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coordinate y");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine("Is it within the circle?");
        Console.WriteLine( Math.Sqrt((x-1) *(x-1) + (y-1) * (y-1)) <= 3 );
        Console.WriteLine("Is it within the rectangle?");
        Console.WriteLine(y>=-3 && x<=7 && x>=1 && y<=-1);
    }
}

