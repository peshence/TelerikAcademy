﻿using System;

//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

class ValueTimes5
{
    static void Main()
    {
        int[] a = new int[20];
        for (int i = 0; i < 20; i++)
        {
            a[i] = i * 5;
            Console.WriteLine(a[i]);
        }
    }
}

