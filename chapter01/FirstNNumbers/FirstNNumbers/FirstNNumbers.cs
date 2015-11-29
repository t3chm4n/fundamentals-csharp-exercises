/*
Chapter 1 - Exercise 10
Write a program that prints the first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8.
*/
using System;

namespace FirstNNumbers
{
    class FirstNNumbers
    {
        protected FirstNNumbers()
        {

        }

        static void Main()
        {
            const int FIRST_N_NUMBERS = 100;

            for (int i = 2; i <= FIRST_N_NUMBERS + 1; i++)
            {
                Console.WriteLine(i % 2 == 0 ? i : i * -1);
            }
        }
    }
}
