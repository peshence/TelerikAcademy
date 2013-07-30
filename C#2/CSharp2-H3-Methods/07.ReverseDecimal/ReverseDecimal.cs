using System;

//Write a method that reverses the digits of given decimal number. Example: 256  652

class ReverseDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter decimal value: ");
        decimal m = decimal.Parse(Console.ReadLine());
        m = Reverse(m);
        Console.WriteLine("Reversed: " + m);
    }

    static decimal Reverse(decimal m)
    {
        string digits = m.ToString();
        char[] result = new char[digits.Length];
        result = digits.ToCharArray();
        Array.Reverse(result);
        digits = new string(result);
        m = decimal.Parse(digits);
        return m;
    }
}

