using System;

class PrimeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a number between 1 and 100 included: ");
        int prime = int.Parse(Console.ReadLine());
        Console.WriteLine("Is the number prime?");
        Console.WriteLine(prime % 2 != 0 && prime % 3 != 0 && prime % 5 != 0 && prime % 7 != 0);
        /* I only check these numbers because 11^2 (the next prime number) is bigger than 100,
         * meaning any non-prime number is divideable by one of the above.*/
    }
}

