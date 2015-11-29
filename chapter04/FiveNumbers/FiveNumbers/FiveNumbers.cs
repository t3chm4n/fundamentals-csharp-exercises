/*
Chapter 4 - Exercise 7
Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program 
should prompt the user to enter another number.

Chapter 4 - Exercise 8
Write a program that reads five numbers from the console and prints the greatest of them.
*/

using System;

namespace FiveNumbers
{
    class FiveNumbers
    {
        protected FiveNumbers()
        {

        }

        static void Main()
        {
            int[] number;
            number = new int[5];
            long sum=0;
            int greater = int.MinValue;

            for (int i=0; i<=number.Length - 1; i++)
            {
                do
                {
                    Console.WriteLine("Enter an integer ({0} of 5)", i + 1);
                } while (!int.TryParse(Console.ReadLine(), out number[i]));

                //Exercise 8
                if (number[i] > greater)
                {
                    greater = number[i];
                }

                sum += number[i];
            }

            Console.WriteLine("Sum: {0}", sum);

            //Exercise 8
            Console.WriteLine("Greater: {0}", greater);
        }
    }
}
