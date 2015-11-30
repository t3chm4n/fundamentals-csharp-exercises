/*
Chapter 4 - Exercise 9
Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints
their sum.
*/

using System;

namespace SumNNumbers
{
    class SumNNumbers
    {
        protected SumNNumbers()
        {

        }

        static void Main()
        {
            int[] number;
            int quantity;
            long sum = 0;

            do
            {   
                Console.WriteLine("Enter how much numbers you want to sum: ");
            } while (!int.TryParse(Console.ReadLine(), out quantity));

            number = new int[quantity];

            for (int i = 0; i <= number.Length - 1; i++)
            {
                do
                {
                    Console.WriteLine("Enter an integer ({0} of {1})", i + 1, quantity);
                } while (!int.TryParse(Console.ReadLine(), out number[i]));

                sum += number[i];
            }

            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
