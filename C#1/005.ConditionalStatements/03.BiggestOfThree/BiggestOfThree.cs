using System;

class BiggestOfThree
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        int c = int.Parse(Console.ReadLine());
//using nested if statements as told in the task

//I know I don't account for equal numbers, but the program TECHNICALLY gets the largest number.
     //Or at least one of them.
        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("The first number is the biggest.");
            }
            else
            {
                Console.WriteLine("The third number is the biggest.");
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine("The second number is the biggest.");
            }
            else
            {
                Console.WriteLine("The third number is the biggest.");
            }
        }
    }
}

