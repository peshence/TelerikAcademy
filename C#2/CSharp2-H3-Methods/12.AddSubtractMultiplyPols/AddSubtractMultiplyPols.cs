using System;

//Extend the program to support also subtraction and multiplication of polynomials.

class AddSubtractMultiplyPols
{
    static void Main()
    {
        int[] input1 = Input("first");
        PrintPol(input1);
        int[] input2 = Input("second");
        PrintPol(input2);

        Console.WriteLine("The sum of the two polynomials is: ");
        PrintPol(input1);
        Console.Write("+\n");
        PrintPol(input2);
        Console.WriteLine("=\n");
        PrintPol(AddPols(input1, input2));
        Console.WriteLine("The first polynomial minus the second one is: ");
        PrintPol(input1);
        Console.Write("-\n");
        PrintPol(input2);
        Console.WriteLine("=\n");
        PrintPol(SubtractPols(input1, input2));
        Console.WriteLine("The second polynomial minus the first one is: ");
        PrintPol(input2);
        Console.Write("-\n");
        PrintPol(input1);
        Console.WriteLine("=\n");
        PrintPol(SubtractPols(input2, input1));
        Console.WriteLine("The two polynomials multiplied: ");
        PrintPol(input1);
        Console.Write("*\n");
        PrintPol(input2);
        Console.WriteLine("=\n");
        PrintPol(MultiplyPols(input1, input2));
    }
    static int[] Input(string count)
    {
        Console.WriteLine("Enter coefficients of {0} polynomial with spaces between them (1 -32 0 32): ", count);
        string[] temp = Console.ReadLine().Split(' ');
        int[] arr = new int[temp.Length];
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            arr[i] = int.Parse(temp[arr.Length - 1 - i]);
        }
        return arr;
    }
    static void PrintPol(int[] polynomial)
    {
        for (int i = polynomial.Length - 1; i > 0; i--)
        {
            if (polynomial[i] != 0)
            {
                if (i < polynomial.Length - 1) Console.Write(" + ");
                Console.Write("({1}x^{0})", i, polynomial[i]);
            }
        }
        if (polynomial[0] != 0) Console.Write(" + {0}", polynomial[0]);
        Console.WriteLine("\n");
    }
    static int[] AddPols(int[] input1, int[] input2)
    {
        if (input1.Length > input2.Length)
            return AddPols(input2, input1);
        int[] temp = (int[])input2.Clone();
        for (int i = 0; i < input1.Length; i++)
        {
            temp[i] = input2[i] + input1[i];
        }
        return temp;
    }
    static int[] SubtractPols(int[] input1, int[] input2)
    {
        int[] temp = new int[input2.Length];
        for (int i = 0; i < input2.Length; i++)
        {
            temp[i] = input2[i] * -1;
        }
        return AddPols(input1, temp);
    }
    static int[] MultiplyPols(int[] input1, int[] input2)
    {
        int[] result = new int[input1.Length + input2.Length];
        for (int i = 0; i < input1.Length; i++)
        {
            for (int j = 0; j < input2.Length; j++)
            {
                result[i + j] += input1[i] * input2[j];
            }
        }
        return result;
    }
}

