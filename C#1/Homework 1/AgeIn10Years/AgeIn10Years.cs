using System;

class AgeIn10Years
{
    static void Main()
    {
        Console.WriteLine("Enter Your Age");
        int i=int.Parse(Console.ReadLine());
        i = i + 10;
        Console.WriteLine("In 10 years you will be "+i+" years old");
    }
}

