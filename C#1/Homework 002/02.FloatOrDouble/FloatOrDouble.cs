using System;

class FloatOrDouble
{
    static void Main()
    {
        double a = 34.567839023d;
        float b = 12.345f;
        double c = 8923.1234857d;
        float d = 3456.091f;
        Console.WriteLine("{0} and {2} can only be assigned to a variable of type double; {1} and {3} can be assigned to both float and double types", a,b,c,d);
    }
}

