/*
Chapter 6 - Exercise 4
Write a program that prints all possible cards from a standard deck of cards, without jokers (there are 52 cards: 4 
suits of 13 cards).
*/

using System;      

namespace DeckOfCards
{
    class DeckOfCards
    {
        protected DeckOfCards()
        {

        }

        static void Main()
        {
            Console.WriteLine("Print all 52 cards of a deck");

            for (int suit = 1; suit <= 4; suit++)
            {
                switch (suit)
                {
                    case 1:
                        Console.Write("Cards of Club: ");
                        break;
                    case 2:
                        Console.Write("Cards of Heart: ");
                        break;
                    case 3:
                        Console.Write("Cards of Spades: ");
                        break;
                    case 4:
                        Console.Write("Cards of Diamond: ");
                        break;
                    default:
                        Console.Write("Not a suit");
                        break;
                }
                for (int card = 2; card <= 14; card++)
                {
                    switch(card)
                    {
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                            Console.Write(" {0},", card);
                            break;
                        case 11:
                            Console.Write(" J,");
                            break;
                        case 12:
                            Console.Write(" Q,");
                            break;
                        case 13:
                            Console.Write(" K,");
                            break;
                        case 14:
                            Console.WriteLine(" A");
                            break;
                        default:
                            Console.Write("Not a card");
                            break;
                    }
                }
            }
        }
    }
}
