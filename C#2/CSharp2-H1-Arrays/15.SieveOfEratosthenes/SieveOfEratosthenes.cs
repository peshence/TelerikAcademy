using System;

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).


class SieveOfEratosthenes
{
    static void Main()
    {
        bool[] prime = new bool[10000000];//10 000 000 is obviously not prime, so no need to check it explicitly

        for (int i = 2; i*i < prime.Length; i++)
        {
            if (!prime[i])
            {
                for (int j = i; (j * i) < prime.Length; j++)
                {
                    prime[i * j] = true;
                }
            }
        }

        for (int i = 2; i < prime.Length; i++)
        {
            if (!prime[i])
            {
                Console.WriteLine(i);
            }
        }
    }
}

