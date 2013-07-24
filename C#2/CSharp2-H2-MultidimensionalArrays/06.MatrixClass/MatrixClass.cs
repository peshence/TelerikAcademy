using System;

class Matrix
{
    public int rows, cols;
    private int[,] matrix;

    //constructor
    public Matrix(int i, int j)
    {
        matrix = new int[i, j];
        rows = i;
        cols = j;
    }

    //indexer
    public int this[int x, int y]
    {
        get
        {
            return matrix[x, y];
        }
        set
        {
            matrix[x, y] = value;
        }
    }

    //adder
    public static Matrix operator +(Matrix x, Matrix y)
    {
        if (x.cols == y.cols && x.rows == y.rows)
        {
            Matrix z = new Matrix(x.rows, x.cols);
            for (int i = 0; i < x.rows; i++)
            {
                for (int k = 0; k < x.cols; k++)
                {
                    z[i, k] = x[i, k] + y[i, k];
                }
            }
            return z;
        }
        else throw new FormatException("Matrices have different sizes");
    }

    //subtractor
    public static Matrix operator -(Matrix x, Matrix y)
    {
        if (x.cols == y.cols && x.rows == y.rows)
        {
            Matrix z = new Matrix(x.rows, x.cols);
            for (int i = 0; i < x.rows; i++)
            {
                for (int k = 0; k < x.cols; k++)
                {
                    z[i, k] = x[i, k] - y[i, k];
                }
            }
            return z;
        }
        else throw new FormatException("Matrices have different sizes");
    }

    //multiplier of two matrices
    public static Matrix operator *(Matrix x, Matrix y)
    {
        if (x.cols == y.rows)
        {
            Matrix result = new Matrix(x.rows, y.cols);
            for (int i = 0; i < x.rows; i++)
            {
                for (int j = 0; j < y.cols; j++)
                {
                    for (int k = 0; k < x.cols; k++)
                    {
                        result[i, j] += x[i, k] * y[k, j];
                    }
                }
            }
            return result;
        }
        else
        {
            throw new FormatException("Number of rows in first matrix isn't equal to number of columns in second matrix");
        }
    }

    //multiplier of a matrix and an integer
    public static Matrix operator *(int a, Matrix m)
    {
        for (int i = 0; i < m.rows; i++)
        {
            for (int j = 0; j < m.cols; j++)
            {
                m[i, j] *= a;
            }
        }
        return m;
    }

    public override string ToString()
    {
        string result = null;
        for (int i = 0; i < this.rows; i++)
        {
            for (int j = 0; j < this.cols; j++)
            {
                result += this[i, j].ToString() + "  ";
            }
            result += "\n";
        }
        return result;
    }
}

class MatrixClass
{
    static void Main()
    {
        Random randomize = new Random();

        //Matrix a = new Matrix(randomize.Next(10), randomize.Next(10));
        //Matrix b = new Matrix(randomize.Next(10), randomize.Next(10));
        //these are to check the exceptions

        Matrix a = new Matrix(4, 4);
        Matrix b = new Matrix(4, 4);

        for (int i = 0; i < a.rows; i++)
        {
            for (int j = 0; j < a.cols; j++)
            {
                a[i, j] = randomize.Next(10);
            }
        }
        for (int i = 0; i < b.rows; i++)
        {
            for (int j = 0; j < b.cols; j++)
            {

                b[i, j] = randomize.Next(10);
            }
        }
        // now we have two random 4x4 matrices
        // two loops, for the exception checks to work

        Console.WriteLine("Matrix A: ");
        Console.WriteLine(a);
        Console.WriteLine("Matrix B: ");
        Console.WriteLine(b);

        Console.WriteLine("A + B = ");
        Console.WriteLine(a + b);

        Console.WriteLine("A - B = ");
        Console.WriteLine(a - b);

        Console.WriteLine("A * B = ");
        Console.WriteLine(a * b);
        // you can check the multiplication here http://www.bluebit.gr/matrix-calculator/matrix_multiplication.aspx , if you want
    }
}

