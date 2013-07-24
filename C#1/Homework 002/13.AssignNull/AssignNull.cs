using System;

class AssignNull
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("Nullable int:" + a + '\n' + b + "Nullable double:");
        a = a + null;
        b = b + null;
        Console.WriteLine("The variables with the null literal added:"+a+b);
        a = a + 5;
        b = b + 8;
        Console.WriteLine("The variables with random values added:"+a+b);
        Console.WriteLine("Conclusion: adding a value to a null variable doesn't affect the variable.");
    }
}
