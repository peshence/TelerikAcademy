using System;

//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:

class AddPolynomials
{
    static void Main()
    {
        int[] input1 = Input("first");
        PrintPol(input1);
        int[] input2 = Input("second");
        PrintPol(input2);

        Console.WriteLine("The sum of the two polynomials is: ");
        PrintPol(AddPols(input1,input2));
    }
    static int[] Input(string count)
    {
        Console.WriteLine("Enter coefficients of {0} polynomial with spaces between them: ", count);
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
                Console.Write("({1}x^{0})",i,polynomial[i]);
            }
        }
        if (polynomial[0] != 0) Console.Write(" + {0}", polynomial[0]);
        Console.WriteLine();
    }
    static int[] AddPols(int[] input1, int[] input2)
    {
        if (input1.Length > input2.Length) 
            return AddPols(input2, input1);

        for (int i = 0; i < input1.Length; i++)
        {
            input2[i] += input1[i];
        }
        return input2;
    }
}

