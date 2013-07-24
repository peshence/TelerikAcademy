using System;

class SignOfProduct
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        double c = double.Parse(Console.ReadLine());
// using a sequence of if statements.
        if (a > 0 && b>0 && c>0)
        {
            Console.WriteLine("The sign of the product is +");
        }
//using else if so the program stops checking after it reaches a correct solution
        else if (a > 0 && b < 0 && c < 0)
        {
            Console.WriteLine("The sign of the product is +");
        }
        else if (a < 0 && b > 0 && c < 0)
        {
            Console.WriteLine("The sign of the product is +");
        }
        else if (a < 0 && b < 0 && c > 0)
        {
            Console.WriteLine("The sign of the product is +");
        }
        else if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The product is equal to 0 (zero).");
        }
/* all the ways for the product to be positive or 0 are checked,
 * so every other option will result in a negative answer*/
        else
        {
            Console.WriteLine("The sign of the product is -");
        }
    }
}

