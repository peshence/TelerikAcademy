using System;

class CopyrightTriangle
{
    static void Main()
    {
        char c = '\u00a9';
        Console.WriteLine("   " + c);
        Console.WriteLine("  {0} {0}",c);
        Console.WriteLine(" {0}   {0}", c);
        Console.WriteLine("{0} {0} {0} {0}",c);
    }
}

