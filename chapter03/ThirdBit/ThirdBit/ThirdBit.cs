/*
Chapter 3 - Exercise 4
Write an expression that checks whether the third bit in a given integer is 1 or 0.
*/
using System;

namespace ThirdBit
{
    class ThirdBit
    {
        protected ThirdBit()
        {

        }

        static void Main()
        {
            int number;
            Console.Write("Enter an integer: ");
            int.TryParse(Console.ReadLine(), out number);

            //the book says the third bit of 8 is 1, but 8 is 1000, so I think the 3rd bit is 0. 4 in binary is 100, so
            //I think the 3rd bit of 4 is 1
            bool bit3 = (number & 4) != 0;

            Console.WriteLine("The third bit is " + (bit3 ? 1 : 0));
        }
    }
}
