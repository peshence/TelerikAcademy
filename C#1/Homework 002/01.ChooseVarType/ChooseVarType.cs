using System;

class ChooseVarType
{
    static void Main()
    {
        ushort a = 52130;
        sbyte b = -115;
        int c = 4825932;
        byte d = 97;
        short e = -10000;
        // I decided to print the variables and their types.
        Console.WriteLine(a + "'s data type is " + a.GetType());
        Console.WriteLine(b + "'s data type is " + b.GetType());
        Console.WriteLine(c + "'s data type is " + c.GetType());
        Console.WriteLine(d + "'s data type is " + d.GetType());
        Console.WriteLine(e + "'s data type is " + e.GetType());
    }
}

