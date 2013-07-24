using System;

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

class MaxSumThreeByThree
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());
        Console.WriteLine("Making random matrix with said dimensions: ");

        int[,] matrix = new int[rows, cols];
        Random randomize = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int k = 0; k < cols; k++)
            {
                matrix[i, k] = randomize.Next(10);//this could be 100, but it's easier to check with smaller values
                Console.Write("{0} ", matrix[i,k]);
            }
            Console.WriteLine();
        }

        //now we have an input matrix

        int maxSum = int.MinValue;
        int curSum = 0;
        int startRow = 0;
        int startCol = 0;

        for (int i = 0; i < rows - 2; i++)
        {
            for (int k = 0; k < cols - 2; k++)
            {
                for (int j = i; j < i + 3; j++)//could be done without these two loops, but they add flexibility
                {
                    for (int n = k; n < k+3; n++)
                    {
                        curSum += matrix[j, n];
                    }
                }
                if (curSum > maxSum)
                {
                    maxSum = curSum;
                    startRow = i;
                    startCol = k;
                }
                curSum = 0;
            }
        }
        //we've found the max sum and know the starting indexes of the 3x3 matrix
        Console.WriteLine("The max sum is: {0}", maxSum);
        for (int j = startRow; j < startRow + 3; j++)
        {
            Console.Write("{");
            for (int n = startCol; n < startCol + 3; n++)
            {
                Console.Write("{0:00.} ", matrix[j, n]);
            }
            Console.WriteLine("\b}");
        }

    }
}

