/*
Chapter 3 - Exercise 11
We are given a number n and a position p. Write a sequence of operations that prints the value of the bit on the 
position p in the number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, p=6 -> 0.

Chapter 3 - Exercise 13
We are given the number n, the value v (v = 0 or 1) and the position p. write a sequence of operations that changes the
value of n, so the bit on the position p has the value of v. Example: n=35, p=5, v=0 -> n=3. Another example: n=35, 
p=2, v=1 -> n=39.
*/
using System;

namespace ChangeBitValue
{
    class ChangeBitValue
    {
        protected ChangeBitValue()
        {

        }

        static void Main()
        {
            int number;
            int position;
            int value;

            Console.Write("Enter a integer: ");
            int.TryParse(Console.ReadLine(), out number);

            Console.Write("Enter a value (0 or 1): ");
            int.TryParse(Console.ReadLine(), out value);

            Console.Write("Enter a position: ");
            int.TryParse(Console.ReadLine(), out position);

            //Reset the bit at position
            number = number & (~(1 << position));

            //Write the new value
            number = number | (value << position);

            //output for exercise 11
            Console.WriteLine("New number: " + number);
        }
    }
}
