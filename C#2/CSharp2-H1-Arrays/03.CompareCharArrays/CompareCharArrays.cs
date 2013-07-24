using System;

//Write a program that compares two char arrays lexicographically (letter by letter).


class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Enter first array's length: ");
        int lengthA = int.Parse(Console.ReadLine());
        char[] a = new char[lengthA];

        Console.WriteLine("Now enter the array: ");
        for (int i = 0; i < lengthA; i++)
        {
            a[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter second array's length: ");
        int lengthB = int.Parse(Console.ReadLine());
        char[] b = new char[lengthB];

        Console.WriteLine("Now enter the array: ");
        for (int i = 0; i < lengthB; i++)
        {
            b[i] = char.Parse(Console.ReadLine());
        }

        bool check = true;
        if (lengthA == lengthB)
        {
            for (int i = 0; i < lengthA; i++)
            {
                if (a[i] != b[i])
                {
                    check = false;
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine("Arrays are equal");
            }
            else
            {
                Console.WriteLine("Arrays are not equal");
            }
        }
        else
        {
            Console.WriteLine("Arrays aren't the same length.");
        }
    }
}

