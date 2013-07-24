using System;

//Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter sorted array's length: ");
        int length = int.Parse(Console.ReadLine());

        int[] arr = new int[length+1];

        Console.WriteLine("Enter sorted array: ");
        for (int i = 1; i <= length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter element whose index you want: ");
        int element = int.Parse(Console.ReadLine());
        int count = 2;
        int index = arr[length/2];

        while (true)
        {
            count = count*2;
            if (element > arr[index])
            {
                index += length / count;
                if (length / count == 0)
                {
                    index++;
                }
            }
            else if (element < arr[index])
            {
                index -= length / count;
                if (length / count == 0)
                {
                    index--;
                }
            }
            else
            {
                Console.WriteLine("{0}'s index is {1}",element,index-1);
                break;
            }
        }
    }
}

