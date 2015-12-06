/*
Chapter 6 - Exercise 1
Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard 
input.
*/
using System;

namespace Number1ToN
{
    class Number1ToN
    {
        protected Number1ToN()
        {

        }

        static void Main()
        {
            Console.WriteLine("Print numbers from 1 to the given number.");

            Console.WriteLine("Enter a number:");
            int number;
            int.TryParse(Console.ReadLine(), out number);

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
