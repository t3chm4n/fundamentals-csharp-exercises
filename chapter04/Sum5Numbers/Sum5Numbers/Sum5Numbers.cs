/*
Chapter 4 - Exercise 7
Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program 
should prompt the user to enter another number.
*/
using System;

namespace Sum5Numbers
{
    class Sum5Numbers
    {
        protected Sum5Numbers()
        {

        }

        static void Main()
        {
            int[] number;
            number = new int[5];
            long sum=0;

            for (int i=0; i<=number.Length - 1; i++)
            {
                do
                {
                    Console.WriteLine("Enter an integer ({0} of 5)", i + 1);
                } while (!int.TryParse(Console.ReadLine(), out number[i]));

                sum += number[i];
            }

            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
