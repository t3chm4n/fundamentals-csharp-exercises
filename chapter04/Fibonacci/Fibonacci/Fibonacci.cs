/*
Chapter 4 - Exercise 11
Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 
21, 34, 55, 89, 144, 233, …
*/
using System;            

namespace Fibonacci
{
    class Fibonacci
    {
        protected Fibonacci()
        {

        }

        static void Main()
        {
            uint fibonacciSequence = 100;
            //using decimal due to the largest values
            decimal previous = 0;
            decimal actual = 1;
            decimal aux = 0;

            Console.WriteLine("Printing first {0} numbers of Fibonacci sequence:");
            Console.WriteLine(previous);
            Console.WriteLine(actual);
            for (uint i = 3; i <= fibonacciSequence - 3; i++)
            {
                aux = previous + actual;
                Console.WriteLine(aux);
                previous = actual;
                actual = aux;
            }
        }
    }
}
