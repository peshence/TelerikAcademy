using System;

class SafeCompare
{
    static void Main()
    {
        // The program can compare any two numbers.

        Console.WriteLine("Enter the first number you wish to compare (Use a comma (,) as a decimal mark):");
        // If you use a point as a decimal mark the program doesn't work
        decimal a = decimal.Parse (Console.ReadLine());

        Console.Write("Enter the second number you wish to compare: (Use a comma (,) as a decimal mark)");
        // If you use a point as a decimal mark the program doesn't work
        decimal b = decimal.Parse (Console.ReadLine());

        bool compare = Math.Abs(a-b)< 0.000001m;
        Console.WriteLine(compare);
    }
}

