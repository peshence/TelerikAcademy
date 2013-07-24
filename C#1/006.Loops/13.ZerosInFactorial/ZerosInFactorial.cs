using System;
class ZerosInFactorial
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        while (true)
        {
            int zeros = n / 5;
            if (zeros != 0)
            {
                count = count + zeros;
                n = zeros;
            }
            else
            {
                Console.WriteLine("Zeros: "+count);
                break;
            }
        }
    }
}

