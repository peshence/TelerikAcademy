﻿using System;

//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.

class HelloName
{
    static void Main()
    {
        Hello();
    }

    static void Hello()
    {
        Console.WriteLine("What's your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!",name);
    }
}

