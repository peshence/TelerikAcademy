using System;

//Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.
//NOTE: 'A' is intenionally indexed with 0

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[26];
        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)(i + 65);
        }

        Console.WriteLine("Enter your word (capitals only): ");
        string word = Console.ReadLine();

        int letter = 0;

        for (int i = 0; i < word.Length; i++)
        {
            letter = Array.BinarySearch<char>(alphabet, word[i]);
            Console.WriteLine(letter);
        }
    }
}

