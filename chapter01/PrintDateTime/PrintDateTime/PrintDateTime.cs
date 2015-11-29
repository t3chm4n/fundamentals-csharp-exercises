/*
Chapter 1 - Exercise 7
Write a program that prints on the console the current date and time.
*/

using System;

namespace PrintDateTime
{
    class PrintDateTime
    {
        protected PrintDateTime()
        {

        }

        static void Main()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
