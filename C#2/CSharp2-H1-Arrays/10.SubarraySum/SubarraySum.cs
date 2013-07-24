using System;

//Write a program that finds in given array of integers a sequence of given sum S (if present). Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

class SubarraySum
{
    static void Main()
    {
        Console.WriteLine("Enter array length: ");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];

        Console.WriteLine("Enter array: ");
        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter  sum to look for: ");
        int sum = int.Parse(Console.ReadLine());

        int cursum = 0;
        bool check = false;

        for (int i = 0; i < length; i++)
        {
            for (int k = i; k < length; k++)
            {
                cursum += arr[k];
                if (cursum == sum)
                {
                    Console.Write("{");
                    for (int j = i; j < k; j++)
                    {
                        Console.Write("{0}, ", arr[j]);
                    }
                    Console.WriteLine(arr[k] + "}");
                    check = true;
                }
            }
            cursum = 0;
        }

        if (!check)
        {
            Console.WriteLine("There is no subarray with sum {0}", sum);
        }
    }
}

