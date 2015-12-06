/*
Chapter 6 - Exercise 3
Write a program that reads from the console a series of integers and prints the smallest and largest of them.
*/
using System;                                                                                                

namespace SmallestAndLargest
{
    class SmallestAndLargest
    {
        protected SmallestAndLargest()
        {

        }

        static void Main()
        {
            Console.WriteLine("Find the smallest and the largest of a series of numbers");
            Console.WriteLine("Enter how much numbers you want to compare: ");
            int quantity;
            int.TryParse(Console.ReadLine(), out quantity);

            int smallest = int.MaxValue;
            int largest = int.MinValue;
            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine("Enter the number {0}: ", i);
                int number;
                int.TryParse(Console.ReadLine(), out number);

                if (number < smallest)
                {
                    smallest = number;
                }

                if (number > largest)
                {
                    largest = number;
                }
            }

            Console.WriteLine("Smallest: {1}{0}Largest: {2}", Environment.NewLine, smallest, largest);
        }
    }
}
