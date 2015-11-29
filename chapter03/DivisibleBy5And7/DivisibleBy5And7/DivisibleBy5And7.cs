/*
Chapter 3 - Exercise 3
Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.
*/

using System;

namespace DivisibleBy5And7
{
    class DivisibleBy5And7
    {
        protected DivisibleBy5And7()
        {

        }

        static void Main()
        {
            int number = 0;

            Console.Write("Enter an integer: ");
            int.TryParse(Console.ReadLine(), out number);

            Console.WriteLine("The number " + (number % 35 == 0 ? "is" : "isn't") + " divisible by 5 and 7.");
        }
    }
}
