/*
Chapter 5 - Exercise 10
Write a program that applies bonus points to given scores in the range [1…9] by the following rules:
- If the score is between 1 and 3, the program multiplies it by 10.
- If the score is between 4 and 6, the program multiplies it by 100.
- If the score is between 7 and 9, the program multiplies it by 1000.
- If the score is 0 or more than 9, the program prints an error message.
*/

using System;

namespace BonusPoints
{
    class BonusPoints
    {
        protected BonusPoints()
        {

        }

        static void Main()
        {
            int score;
            string message;

            Console.WriteLine("Enter the score (1-9):");
            int.TryParse(Console.ReadLine(), out score);

            if (score >= 1 && score <= 9)
            {

                switch (score)
                {
                    case 1:
                    case 2:
                    case 3:
                        score *= 10;
                        break;
                    case 4:
                    case 5:
                    case 6:
                        score *= 100;
                        break;
                    case 7:
                    case 8:
                    case 9:
                        score *= 1000;
                        break;
                }
                Console.WriteLine("Final score: {0}", score);
            } else
            {
                Console.WriteLine("Error.");
            }
        }
    }
}
