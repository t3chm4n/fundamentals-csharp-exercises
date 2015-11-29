/*
Chapter 3 - Exercise 3
Write an expression that looks for a given integer if its third digit(right to left) is 7.
*/
using System;

namespace ThirdDigit
{
    class ThirdDigit
    {
        protected ThirdDigit()
        {

        }

        static void Main()
        {
            Console.Write("Enter an integer: ");
            string number = Console.ReadLine();

            Console.WriteLine("The third digit " + (number.Length >= 3 && number[number.Length - 3].Equals('7') ? "is" 
                : "isn't") + " 7.");
        }
    }
}
