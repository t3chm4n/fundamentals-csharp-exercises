/*
Chapter 6 - Exercise 5
Write a program that reads from the console number N and print the sum
of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8,
13, 21, 34, 55, 89, 144, 233, 377, …
*/

using System;

namespace FibonacciSum
{
    class FibonacciSum
    {
        protected FibonacciSum()
        {

        }

        static void Main()
        {
            Console.WriteLine("Sum the N members of Fibonacci sequence");

            Console.WriteLine("How much members of Fibonacci sequence you want to sum?");
            int quantity;
            int.TryParse(Console.ReadLine(), out quantity);

            long prevMember = 0;
            long actualMember = 1;
            long auxMember = 0;
            decimal sum = 1M;

            if (quantity == 1)
            {
                sum = 0;
            } else if (quantity == 2)
            {
                sum = 1;
            } else
            {
                for (int i = 3; i <= quantity; i++)
                {
                    auxMember = actualMember;
                    actualMember += prevMember;
                    prevMember = auxMember;
                    sum += actualMember;
                }
            }
            Console.WriteLine("Sum of first {0} Fibonacci members: {1}", quantity, quantity != 0 ? sum : 0);
        }
    }
}
