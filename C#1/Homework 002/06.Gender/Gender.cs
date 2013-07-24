using System;

class Gender
{
    static void Main()
    {
        Console.WriteLine("Enter the letter \"f\" if you're female, the letter \"m\" if you're male or another character if you're something else.");
        string gender = Console.ReadLine();
        bool isFemale = gender=="f";
        Console.WriteLine("Statement \"You are female\" is " + isFemale);
    }
}

