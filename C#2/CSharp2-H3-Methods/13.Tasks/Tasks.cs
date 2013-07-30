using System;
using System.Collections.Generic;

/*Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
		Create appropriate methods.
		Provide a simple text-based menu for the user to choose which task to solve.
		Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
*/

class Tasks
{
    static void Main()
    {
        Menu();
    }
    static void Menu()
    {
        Console.WriteLine("Hi! These are the functions of this program: \n");
        Console.WriteLine("1. Reverse the digits of a number");
        Console.WriteLine("2. Calculate the average of a sequence of integers");
        Console.WriteLine("3. Solve a linear quation (a*x + b = 0)");
        Console.Write("Enter the number of the function you want: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Reverse();
                break;
            case 2:
                Average();
                break;
            case 3:
                LinearEquation();
                break;
        }
        Console.WriteLine("Are you finished? (Y/N)");
        if (Console.ReadLine() == "n" || Console.ReadLine() == "N") Menu();
    }
    static void Reverse()
    {
        Console.WriteLine("Enter decimal value: ");
        decimal m = decimal.Parse(Console.ReadLine());
        if (m < 0)
        {
            Console.WriteLine("Value should be non-negative! ");
            Reverse();
            return;
        }
        string digits = m.ToString();
        char[] result = new char[digits.Length];
        result = digits.ToCharArray();
        Array.Reverse(result);
        digits = new string(result);
        m = decimal.Parse(digits);
        Console.WriteLine("Reversed number is: ");
        Console.WriteLine(m);
    }
    static void Average()
    {
        Console.WriteLine("Enter sequence of integers separated by spaces: ");
        string s = Console.ReadLine();
        if (s == null)
        {
            Console.WriteLine("Empty sequence!");
            Average();
            return;
        }
        string[] temp = s.Split(' ');
        int[] arr = new int[temp.Length];
        double average = 0;
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            arr[i] = int.Parse(temp[arr.Length - 1 - i]);
            average += arr[i];
        }
        average /= arr.Length;
        Console.WriteLine("Average is: " + average);
    }
    static void LinearEquation()
    {
        Console.WriteLine("You want to solve: \na*x + b = 0\nEnter a: ");
        double a = double.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("a should not be equal to zero! (every value of x is a solution)");
            LinearEquation();
            return;
        }
        Console.WriteLine("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("The solution to {0}*x + {1} = 0 is:",a,b);
        Console.WriteLine("x = " + (-b/a));
    }
}

