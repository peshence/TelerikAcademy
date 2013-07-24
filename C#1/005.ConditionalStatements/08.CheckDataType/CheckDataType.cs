using System;

class CheckDataType
{
    static void Main()
    {
        Console.WriteLine("Enter 0 for int, 1 for double or 2 for string: ");
        byte type = byte.Parse(Console.ReadLine());
        Console.WriteLine("Now enter the data: ");
        switch (type)
        {
            case 0:
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine(i+1);
                break;
            case 1:
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine(d+1);
                break;
            case 2:
                Console.WriteLine(Console.ReadLine() + "*");
                break;
            default:
                Console.WriteLine("Your argument is invalid.");
                break;
        }
    }
}

