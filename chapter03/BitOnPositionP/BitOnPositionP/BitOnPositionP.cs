/*
Chapter 3 - Exercise 12
Write a Boolean expression that checks if the bit on position p in the integer v has the value 1. Example v=5, 
p=1 -> false.
*/
using System;

namespace BitOnPositionP
{
    class BitOnPositionP
    {
        protected BitOnPositionP()
        {

        }

        static void Main()
        {
            int number;
            int position;
            int i = 1;
            int mask;
            int bit;

            Console.Write("Enter a integer: ");
            int.TryParse(Console.ReadLine(), out number);

            Console.Write("Enter a position: ");
            int.TryParse(Console.ReadLine(), out position);

            // Move the 1-st bit left by n positions
            mask = i << position;

            // If number & mask are positive then the p-th bit of n is 1
            bit = ((number & mask) == 0 ? 0 : 1);

            //output for exercise 11
            Console.WriteLine("The bit on the given position is " + bit);

            //output for exercise 12
            Console.WriteLine("Result: " + (bit == 1 ? "true" : "false"));
        }
    }
}
