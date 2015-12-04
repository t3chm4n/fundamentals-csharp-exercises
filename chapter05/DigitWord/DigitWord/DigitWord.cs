/*
Chapter 5 - Exercise 5
Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Use a 
switch statement.
*/

using System;

namespace DigitWord
{
    class DigitWord
    {
        protected DigitWord()
        {

        }

        static void Main()
        {
            char digit;
            string word;

            Console.WriteLine("Enter a digit (0-9): ");
            char.TryParse(Console.ReadLine(), out digit);

            switch (digit)
            {
                case '0':
                    word = "zero";
                    break;
                case '1':
                    word = "one";
                    break;
                case '2':
                    word = "two";
                    break;
                case '3':
                    word = "three";
                    break;
                case '4':
                    word = "four";
                    break;
                case '5':
                    word = "five";
                    break;
                case '6':
                    word = "six";
                    break;
                case '7':
                    word = "seven";
                    break;
                case '8':
                    word = "eight";
                    break;
                case '9':
                    word = "nine";
                    break;
                default:
                    word = "error";
                    break;
            }

            Console.WriteLine(word);
        }
    }
}
