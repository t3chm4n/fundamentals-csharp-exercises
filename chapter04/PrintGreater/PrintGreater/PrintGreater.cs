/*
Chapter 4 - Exercise 6
Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using
conditional statements.
*/

using System;                

namespace PrintGreater
{
    class PrintGreater
    {
        protected PrintGreater()
        {

        }

        static void Main()
        {
            int number1;
            int number2;

            Console.WriteLine("Enter 2 integers: ");
            int.TryParse(Console.ReadLine(), out number1);
            int.TryParse(Console.ReadLine(), out number2);

            Console.WriteLine("Greater: {0}", Math.Max(number1, number2));
        }
    }
}
