/*
Chapter 4 - Exercise 10
Write a program that reads an integer number n from the console and prints all numbers in the range [1…n], each on a 
separate line.
*/

using System;                

namespace AllNumbersInRange
{
    class AllNumbersInRange
    {
        protected AllNumbersInRange()
        {

        }

        static void Main()
        {
            uint number;

            do
            {
                Console.WriteLine("Enter an positive integer: ");
            } while (!uint.TryParse(Console.ReadLine(), out number));

            Console.WriteLine("Printing 1 to {0}: ", number);
            for(int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
