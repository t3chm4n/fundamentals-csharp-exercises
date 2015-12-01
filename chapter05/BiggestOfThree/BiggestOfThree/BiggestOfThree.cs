/*
Chapter 3 - Exercise 3
Write a program that finds the biggest of three integers, using nested if statements.
*/

using System;

namespace BiggestOfThree
{
    class BiggestOfThree
    {
        protected BiggestOfThree()
        {

        }

        static void Main()
        {
            int number1;
            int number2;
            int number3;
            int biggest = int.MinValue;

            Console.WriteLine("Enter 3 integers:");
            int.TryParse(Console.ReadLine(), out number1);
            int.TryParse(Console.ReadLine(), out number2);
            int.TryParse(Console.ReadLine(), out number3);

            //It isn't the most elegant form, but the problem question says to use nested ifs so...
            if (number2 > number1 || number3 > number1)
            {
                if (number2 > number3)
                {
                    Console.WriteLine("Biggest: {0}", number2);
                } else
                {
                    Console.WriteLine("Biggest: {0}", number3);
                }
            }
            else
            {
                Console.WriteLine("Biggest: {0}", number1);
            }
        }
    }
}
