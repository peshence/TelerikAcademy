using System;
using System.Collections.Generic;

//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.

class AddArrays
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        string input1 = Console.ReadLine();
        Console.WriteLine("Enter second number: ");
        string input2 = Console.ReadLine();

        int[] number1 = new int[input1.Length];
        for (int i = input1.Length - 1; i >= 0; i--)
        {
            number1[i] = input1[input1.Length - 1 - i];
            number1[i] -= 48;
        }

        int[] number2 = new int[input2.Length];
        for (int i = input2.Length - 1; i >= 0; i--)
        {
            number2[i] = input2[input2.Length - 1 - i];
            number2[i] -= 48;
        }

        int[] result = Add(number1, number2);

        Console.Write("{0} + {1} = ", input1, input2);
        for (int i = result.Length - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }

    static int[] Add(int[] a, int[] b)
    {
        if (a.Length > b.Length)
            return Add(b, a);

        List<int> temp = new List<int>();
        bool remainder = false;

        for (int i = 0; i < a.Length; i++)
        {
            temp.Add(a[i] + b[i]);
            if (remainder) temp[i]++;
            if (temp[i] / 10 == 1) remainder = true;
            else remainder = false;
            temp[i] = temp[i] % 10;
        }

        for (int i = a.Length; i < b.Length; i++)
        {
            if (!remainder) temp.Add(b[i]);
            else
            {
                temp.Add(b[i] + 1);
                if (temp[i] == 10)
                {
                    remainder = true;
                    temp[i] = 0;
                }
                else remainder = false;
            }
        }
        if (remainder) temp.Add(1);
        int[] result = temp.ToArray();
        return result;
    }
}

