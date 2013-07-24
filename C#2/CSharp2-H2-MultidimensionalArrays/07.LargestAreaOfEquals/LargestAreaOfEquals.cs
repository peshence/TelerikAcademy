using System;
//this doesn't work, I have no idea why. Honestly I would have been suprised if it did.
//*Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size. 

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

class LargestAreaOfEquals
{
    static void Main()
    {
        Random randomize = new Random();
        int rows = randomize.Next(3, 6);
        int cols = randomize.Next(3, 6);

        Matrix m = new Matrix(rows, cols);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                m[i, j] = randomize.Next(5);
            }
        }

        int maxArea = 0;
        int maxElement = 0;
        int curArea = 0;
        int curElement = 0;
        for (int i = 0; i < m.rows; i++)
        {
            for (int j = 0; j < m.cols; j++)
            {
                curElement = m[i, j];
                FindMaxArea(m, maxArea, maxElement, curArea, curElement, i, j, 4);
            }
        }
        Console.WriteLine("{0} - {1} times", maxElement, maxArea);
    }

    static void FindMaxArea(Matrix m, int maxArea, int maxElement, int curArea, int curElement, int i, int j,int source)
    {
        if (m[i, j] != 0)
        {
            if (j + 1 <= m.cols && m[i, j + 1] != 0 && source != 2)//right
            {
                if (m[i, j + 1] == curElement)
                {
                    curArea++;
                    FindMaxArea(m, maxArea, maxElement, curArea, curElement, i, j + 1,0);
                }
            }
            if (i + 1 <= m.rows && m[i + 1, j] != 0 && source != 3)//down
            {
                if (m[i + 1, j] == curElement)
                {
                    curArea++;
                    FindMaxArea(m, maxArea, maxElement, curArea, curElement, i + 1, j,1);
                }
            }
            if (j - 1 >= 0 && m[i, j - 1] != 0 && source != 0)//left
            {
                if (m[i, j - 1] == curElement)
                {
                    curArea++;
                    FindMaxArea(m, maxArea, maxElement, curArea, curElement, i, j - 1, 2);
                }
            }
            if (i - 1 >= 0 && m[i - 1, j] != 0 && source != 1)
            {
                if (m[i - 1, j] == curElement)
                {
                    curArea++;
                    FindMaxArea(m, maxArea, maxElement, curArea, curElement, i - 1, j, 3);
                }
            }
        }
        if (curArea > maxArea)
        {
            maxArea = curArea;
            maxElement = curElement;
        }
        
    }
}

