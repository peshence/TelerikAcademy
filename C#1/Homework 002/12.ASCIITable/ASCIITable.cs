using System;

class ASCIITable
{
    static void Main(string[] args)
    {
        for (int a = 0; a < 127; a++)
        {
            Console.WriteLine(a + ". " + (char)a);
        }
    }
}

