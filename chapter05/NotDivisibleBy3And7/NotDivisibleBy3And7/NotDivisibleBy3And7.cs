/*
Chapter 6 - Exercise 2
Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. 
The number N should be read from the standard input.
*/

using System;                

namespace NotDivisibleBy3And7
{
    class NotDivisibleBy3And7
    {
        static void Main()
        {
            Console.WriteLine("Print numbers from 1 to the given number, not divisible by 3 and 7.");

            Console.WriteLine("Enter a number:");
            int number;
            int.TryParse(Console.ReadLine(), out number);

            for (int i = 1; i <= number; i++)
            {
                if (i % (3*7) != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
