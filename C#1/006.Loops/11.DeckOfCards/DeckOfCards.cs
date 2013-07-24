using System;

class DeckOfCards
{
    static void Main()
    {
        string color = null;
        string name = null;
        for (int k = 1; k < 5; k++)
        {
            switch (k)
            {
                case 1:
                    color = "Clubs";
                    break;
                case 2:
                    color = "Diamonds";
                    break;
                case 3:
                    color = "Hearts";
                    break;
                case 4:
                    color = "Spades";
                    break;
            }
            for (int i = 2; i < 15; i++)
            {
                switch (i)
                {
                    case 2:
                        name = "Two";
                        break;
                    case 3:
                        name = "Three";
                        break;
                    case 4:
                        name = "Four";
                        break;
                    case 5:
                        name = "Five";
                        break;
                    case 6:
                        name = "Six";
                        break;
                    case 7:
                        name = "Seven";
                        break;
                    case 8:
                        name = "Eight";
                        break;
                    case 9:
                        name = "Nine";
                        break;
                    case 10:
                        name = "Ten";
                        break;
                    case 11:
                        name = "Jack";
                        break;
                    case 12:
                        name = "Queen";
                        break;
                    case 13:
                        name = "King";
                        break;
                    case 14:
                        name = "Ace";
                        break;
                }
                Console.WriteLine("{0} of {1}", name, color);
            }
        }
    }
}

