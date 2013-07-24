using System;
//Write a program that reads two arrays from the console and compares them element by element.

class ArrayComparison
{
    static void Main()
    {
        Console.WriteLine("Enter first array's length: ");
        int lengthA = int.Parse(Console.ReadLine());
        int[] a = new int[lengthA];

        Console.WriteLine("Now enter the array: ");
        for (int i = 0; i < lengthA; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter second array's length: ");
        int lengthB = int.Parse(Console.ReadLine());
        int[] b = new int[lengthB];

        Console.WriteLine("Now enter the array: ");
        for (int i = 0; i < lengthB; i++)
        {
            b[i] = int.Parse(Console.ReadLine());
        }

        bool check = true;

        if (lengthA == lengthB)
        {
            for (int i = 0; i < lengthA; i++)
            {
                if (a[i] > b[i])
                {
                    Console.WriteLine(a[i] + ">" + b[i]);
                    check = false;
                }
                else if (a[i] < b[i])
                {
                    Console.WriteLine(a[i] + "<" + b[i]);
                    check = false;
                }
                else
                {
                    Console.WriteLine(a[i] + "=" + b[i]);
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

