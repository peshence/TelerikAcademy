using System;

class HelloWorld
{
    static void Main()
    {
        string a = "Hello";
        string b = "World";
        object sum = a + " " + b;
        string typecast = (string)sum;
        Console.WriteLine(typecast);
    }
}

