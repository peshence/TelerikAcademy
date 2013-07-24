using System;

class ReadNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a number between 0 and 999");
        int n = int.Parse(Console.ReadLine());

        if (n / 100 != 0)
        {
            int hundreds = n / 100;
            string hundreds_name=null;
            switch (hundreds)
            {
                case 1:
                    hundreds_name = "One";
                    break;
                case 2:
                    hundreds_name = "Two";
                    break;
                case 3:
                    hundreds_name = "Three";
                    break;
                case 4:
                    hundreds_name = "Four";
                    break;
                case 5:
                    hundreds_name = "Five";
                    break;
                case 6:
                    hundreds_name = "Six";
                    break;
                case 7:
                    hundreds_name = "Seven";
                    break;
                case 8:
                    hundreds_name = "Eight";
                    break;
                case 9:
                    hundreds_name = "Nine";
                    break;
                default:
                    Console.WriteLine("Invalid argument");
                    break;
            }
            n = n % 100;
            if (n / 10 != 0 && n / 10 != 1)
            {
                int tens = n / 10;
                string tens_name = null;
                switch (tens)
                {
                    case 2:
                        tens_name = "Twenty";
                        break;
                    case 3:
                        tens_name = "Thirty";
                        break;
                    case 4:
                        tens_name = "Fourty";
                        break;
                    case 5:
                        tens_name = "Fifty";
                        break;
                    case 6:
                        tens_name = "Sixty";
                        break;
                    case 7:
                        tens_name = "Seventy";
                        break;
                    case 8:
                        tens_name = "Eighty";
                        break;
                    case 9:
                        tens_name = "Ninety";
                        break;
                }
                int ones = n % 10;
                string ones_name=null;
                switch (ones)
                {
                    case 1:
                        ones_name = "One";
                        break;
                    case 2:
                        ones_name = "Two";
                        break;
                    case 3:
                        ones_name = "Three";
                        break;
                    case 4:
                        ones_name = "Four";
                        break;
                    case 5:
                        ones_name = "Five";
                        break;
                    case 6:
                        ones_name = "Six";
                        break;
                    case 7:
                        ones_name = "Seven";
                        break;
                    case 8:
                        ones_name = "Eight";
                        break;
                    case 9:
                        ones_name = "Nine";
                        break;
                }
                Console.WriteLine("{0} Hundred {1} {2}", hundreds_name, tens_name, ones_name);
            }
            else
            {
                int ones = n % 100;
                string ones_name=null;
                switch (ones)
                {
                    case 1:
                        ones_name = "One";
                        break;
                    case 2:
                        ones_name = "Two";
                        break;
                    case 3:
                        ones_name = "Three";
                        break;
                    case 4:
                        ones_name = "Four";
                        break;
                    case 5:
                        ones_name = "Five";
                        break;
                    case 6:
                        ones_name = "Six";
                        break;
                    case 7:
                        ones_name = "Seven";
                        break;
                    case 8:
                        ones_name = "Eight";
                        break;
                    case 9:
                        ones_name = "Nine";
                        break;
                    case 10:
                        ones_name = "Ten";
                        break;
                    case 11:
                        ones_name = "Eleven";
                        break;
                    case 12:
                        ones_name = "Twelve";
                        break;
                    case 13:
                        ones_name = "Thirteen";
                        break;
                    case 14:
                        ones_name = "Fourteen";
                        break;
                    case 15:
                        ones_name = "Fifteen";
                        break;
                    case 16:
                        ones_name = "Sixteen";
                        break;
                    case 17:
                        ones_name = "Seventeen";
                        break;
                    case 18:
                        ones_name = "Eighteen";
                        break;
                    case 19:
                        ones_name = "Nineteen";
                        break;
                    default:
                        Console.WriteLine("{0} Hundred", hundreds_name);
                        Environment.Exit(4);
                        break;
                }
                Console.WriteLine("{0} Hundred and {1}", hundreds_name, ones_name);
            }

        }
        else
        {
            if (n / 10 != 0 && n / 10 != 1)
            {
                int tens = n / 10;
                string tens_name=null;
                switch (tens)
                {
                    case 2:
                        tens_name = "Twenty";
                        break;
                    case 3:
                        tens_name = "Thirty";
                        break;
                    case 4:
                        tens_name = "Fourty";
                        break;
                    case 5:
                        tens_name = "Fifty";
                        break;
                    case 6:
                        tens_name = "Sixty";
                        break;
                    case 7:
                        tens_name = "Seventy";
                        break;
                    case 8:
                        tens_name = "Eighty";
                        break;
                    case 9:
                        tens_name = "Ninety";
                        break;
                }
                int ones = n % 10;
                string ones_name = null;
                switch (ones)
                {
                    case 1:
                        ones_name = "One";
                        break;
                    case 2:
                        ones_name = "Two";
                        break;
                    case 3:
                        ones_name = "Three";
                        break;
                    case 4:
                        ones_name = "Four";
                        break;
                    case 5:
                        ones_name = "Five";
                        break;
                    case 6:
                        ones_name = "Six";
                        break;
                    case 7:
                        ones_name = "Seven";
                        break;
                    case 8:
                        ones_name = "Eight";
                        break;
                    case 9:
                        ones_name = "Nine";
                        break;
                }
                Console.WriteLine("{0} {1}",tens_name, ones_name);
            }
            else
            {
                int ones = n % 100;
                string ones_name=null;
                switch (ones)
                {
                    case 1:
                        ones_name = "One";
                        break;
                    case 2:
                        ones_name = "Two";
                        break;
                    case 3:
                        ones_name = "Three";
                        break;
                    case 4:
                        ones_name = "Four";
                        break;
                    case 5:
                        ones_name = "Five";
                        break;
                    case 6:
                        ones_name = "Six";
                        break;
                    case 7:
                        ones_name = "Seven";
                        break;
                    case 8:
                        ones_name = "Eight";
                        break;
                    case 9:
                        ones_name = "Nine";
                        break;
                    case 10:
                        ones_name = "Ten";
                        break;
                    case 11:
                        ones_name = "Eleven";
                        break;
                    case 12:
                        ones_name = "Twelve";
                        break;
                    case 13:
                        ones_name = "Thirteen";
                        break;
                    case 14:
                        ones_name = "Fourteen";
                        break;
                    case 15:
                        ones_name = "Fifteen";
                        break;
                    case 16:
                        ones_name = "Sixteen";
                        break;
                    case 17:
                        ones_name = "Seventeen";
                        break;
                    case 18:
                        ones_name = "Eighteen";
                        break;
                    case 19:
                        ones_name = "Nineteen";
                        break;
                    default:
                        ones_name = "Zero";
                        break;
                }
                Console.WriteLine(ones_name);
            }
        }
    }
}

