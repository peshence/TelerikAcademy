using System;

class ThirdDigit7
{
    static void Main()
    {
        Console.WriteLine("Enter your number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n/100%10==7||n/100%10==-7);
    }
}
