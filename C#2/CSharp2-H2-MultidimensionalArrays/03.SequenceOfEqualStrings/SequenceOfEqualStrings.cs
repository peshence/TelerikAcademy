using System;

//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. 

class SequenceOfEqualStrings
{
    static void Main()
    {
        string[,] matrix = { { "ha", "fifi", "ho", "hi" }, 
                           { "fo", "ha", "hi", "xx" }, 
                           { "xxx", "ho", "ha", "xx" } };
        // string[,] matrix = { { "s", "qq", "s" }, { "pp", "pp", "s" }, { "pp", "qq", "s" } };

        int maxLength = 1;
        string maxString = null;
        int curLength = 0;
        string curString = matrix[0,0];
        int direction = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                curString = matrix[i, j];
                for (int k = j; k < matrix.GetLength(1); k++)//check right
                {
                    if (matrix[i, k] == matrix[i, j])
                    {
                        curLength++;
                    }
                    else
                        break;
                }
                if (curLength > maxLength)
                {
                    maxLength = curLength;
                    maxString = curString;
                    direction = 0;
                }
                curLength = 0;
                for (int k = i; k < matrix.GetLength(0); k++)// check down
                {
                    if (matrix[k, j] == matrix[i, j])
                    {
                        curLength++;
                    }
                    else
                        break;
                }
                if (curLength > maxLength)
                {
                    maxLength = curLength;
                    maxString = curString;
                    direction = 1;
                }
                curLength = 0;
                int row = i;
                int col = j;
                while (col < matrix.GetLength(1) && row >= 0)// check upward diagonal
                {
                    if (matrix[row, col] == matrix[i, j])
                    {
                        curLength++;
                        row--;
                        col++;
                    }
                    else
                        break;
                }
                if (curLength > maxLength)
                {
                    maxLength = curLength;
                    maxString = curString;
                    direction = 2;
                }
                curLength = 0;
                row = i;
                col = j;
                while (col < matrix.GetLength(1) && row < matrix.GetLength(0))// check downward diagonal
                {
                    if (matrix[row, col] == matrix[i, j])
                    {
                        curLength++;
                        row++;
                        col++;
                    }
                    else
                        break;
                }
                if (curLength > maxLength)
                {
                    maxLength = curLength;
                    maxString = curString;
                    direction = 3;
                }
                curLength = 0;
            }
        }
        for (int i = 0; i < maxLength; i++)
			{
			    Console.Write("{0}, ", maxString);
			}
        Console.Write("\b\b");
        switch (direction)
        {
            case 0:
                Console.WriteLine(" - horizontal");
                break;
            case 1:
                Console.WriteLine(" - vertical");
                break;
            case 2:
                Console.WriteLine(" - upward diagonal");
                break;
            case 3:
                Console.WriteLine(" - downward diagonal");
                break;
        }
    }
}

