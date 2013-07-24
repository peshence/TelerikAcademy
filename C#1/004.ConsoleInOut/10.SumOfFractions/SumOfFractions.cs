using System;

class SumOfFractions
{
    static void Main()
    {
        decimal sum = 1;
        decimal oldsum = 0;
        decimal difference = sum - oldsum;
        decimal i = -2;
        while (Math.Abs(difference) > 0.001m)
        {
            if (i%2==0)
            {
                i = i*(-1);
                oldsum = sum;
                sum += (1 / i);
                difference = sum - oldsum;
                i=i+1;
            }
            else
            {
                i = i*(-1);
                oldsum = sum;
                sum += (1 / i);
                difference = sum - oldsum;
                i = i - 1;
            }
        }
        Console.WriteLine("Sum: {0:0.000}",sum);
    }
}

