/*
Chapter 1 - Exercise 11
Write a program that reads your age from the console and prints your age after 10 years.
*/

using System;

namespace AfterNYears
{
    class AfterNYears
    {
        protected AfterNYears()
        {

        }

        static void Main()
        {
            const int AFTER_N_YEARS = 10;
            byte actualAge = 0;

            Console.Write("Enter your actual age: ");
            byte.TryParse(Console.ReadLine(), out actualAge);

            actualAge += AFTER_N_YEARS;

            Console.WriteLine("Your age in {0} years will be {1}.", AFTER_N_YEARS, actualAge);
        }
    }
}
