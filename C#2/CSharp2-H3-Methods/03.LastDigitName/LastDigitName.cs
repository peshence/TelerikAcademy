using System;

//Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".

class LastDigitName
{
    static void Main()
    {
        Console.WriteLine("Enter your number: ");

        Console.WriteLine(LastDigit(int.Parse(Console.ReadLine())));

    }

    static string LastDigit(int n)
    {
        n = Math.Abs(n % 10);//so it works with negative integers too
        switch (n)
        {
            case 0:
                return "zero";
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";
            case 5:
                return "five";
            case 6:
                return "six";
            case 7:
                return "seven";
            case 8:
                return "eight";
            case 9:
                return "nine";
            default:
                return "wtf";
        }
    }
}

