using System;

class Quotes
{
    static void Main()
    {
        string a = "The \"use\" of quotations causes difficulties. \n"; // unquoted
        string b = @"The ""use"" of quotations causes difficulties."; // quoted
        Console.WriteLine(a+b);
    }
}

