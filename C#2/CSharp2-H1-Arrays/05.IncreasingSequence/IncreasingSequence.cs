using System;
using System.Collections.Generic;

//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

// won't work if there are more than 1 biggest sequences
class IncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Enter array's length: ");
        int length = int.Parse(Console.ReadLine());
        int[] a = new int[length];

        int count = 1;
        int biggestCount = 0;
        int value = a[0];
        int maxvalue = 0;

        Console.WriteLine("Now enter the array: ");
        for (int i = 0; i < length; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
            if (i != 0)
            {
                if (a[i] == a[i - 1]+1)
                {
                    if (count == 1)
                    {
                        value = a[i-1];
                    }
                    count++;
                }
                else
                {
                    if (biggestCount < count)
                    {
                        biggestCount = count;
                        maxvalue = value;
                    }
                    count = 1;
                }
            }
        }
        Console.Write("{");
        for (int i = 0; i < biggestCount - 1; i++)
        {
            Console.Write(value + ",");
            value++;
        }
        Console.WriteLine(value + "}");
    }
}

