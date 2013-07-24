using System;

class RectangleArea
{
    static void Main()
    {
        Console.WriteLine("Enter rectangle height: ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter rectangle width: ");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("The area of the rectangle is: " + height*width);
    }
}
