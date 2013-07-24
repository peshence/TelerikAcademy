using System;

class FourByFourMatrices
{
    static void Main()
    {
        MatrixA();
        MatrixB();
        MatrixC();
        MatrixD();
    }

    static void Print(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                Console.Write("{0:00.}  ", matrix[i, k]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n");
    }

    static void MatrixA()
    {
        Console.WriteLine("Enter size of matrix A: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                matrix[i, k] = (i + 1) + k * n;
            }
        }
        Print(matrix);
    }

    static void MatrixB()
    {
        Console.WriteLine("Enter size of matrix B: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        int count = 1;

        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                for (int k = 0; k < n; k++)
                {
                    matrix[k, i] = count;
                    count++;
                }
            }
            else
            {
                for (int k = n - 1; k >= 0; k--)
                {
                    matrix[k, i] = count;
                    count++;
                }
            }
        }
        Print(matrix);
    }

    static void MatrixC()
    {
        Console.WriteLine("Enter size of matrix C: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int count = 1;
        int row = 0;
        int col = 0;

        for (int i = n - 1; i >= 0; i--)
        {
            row = i;
            col = 0;
            while (row < n)
            {
                matrix[row, col] = count;
                count++;
                row++;
                col++;
            }
        }
        for (int i = 1; i < n; i++)
        {
            row = 0;
            col = i;
            while (col < n)
            {
                matrix[row, col] = count;
                count++;
                row++;
                col++;
            }
        }
        Print(matrix);
    }

    static void MatrixD()
    {
        Console.WriteLine("Enter size of matrix D: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int count = 1;
        int row = 0;
        int col = 0;
        while (true) // repeat the four operations
        {
            while (true)//going down
            {
                if (count == n*n + 1)//check if matrix is full
                {
                    break;
                }
                matrix[row, col] = count;
                count++;
                if (row + 1 == n || matrix[row + 1, col] != 0)//check if line is full
                {
                    col++;
                    break;
                }
                else
                {
                    row++;
                }
            }
            while (true)//going right
            {
                if (count == n * n + 1)//check if matrix is full
                {
                    break;
                }
                matrix[row, col] = count;
                count++;
                if (col + 1 == n || matrix[row, col + 1] != 0)//check if line is full
                {
                    row--;
                    break;
                }
                else
                {
                    col++;
                }
            }
            while (true)//going up
            {
                if (count == n * n + 1)//check if matrix is full
                {
                    break;
                }
                matrix[row, col] = count;
                count++;
                if (row - 1 < 0 || matrix[row - 1, col] != 0)//check if line is full
                {
                    col--;
                    break;
                }
                else
                {
                    row--;
                }
            }
            while (true)//going left
            {
                if (count == n * n + 1)//check if matrix is full
                {
                    break;
                }
                matrix[row, col] = count;
                count++;
                if (col - 1 < 0 || matrix[row, col - 1] != 0)//check if line is full
                {
                    row++;
                    break;
                }
                else
                {
                    col--;
                }
            }
            if (count == n * n + 1)//check if matrix is full
            {
                break;
            }
        }
        Print(matrix);
    }
}

