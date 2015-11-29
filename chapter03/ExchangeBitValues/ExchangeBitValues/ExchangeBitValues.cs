/*
Chapter 3 - Exercise 15
* Write a program that exchanges the values of the bits on positions 3, 4 and 5 with bits on positions 24, 25 and 26 of
a given 32-bit unsigned integer.

Chapter 3 - Exercise 16
* Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned 
integer.
*/
using System;

namespace ExchangeBitValues
{
    class ExchangeBitValues
    {
        protected ExchangeBitValues()
        {

        }

        static void Main()
        {
            uint number15;
            uint number16;

            Console.Write("Enter a number (32 bit unsigned int): ");
            uint.TryParse(Console.ReadLine(), out number15);
            number16 = number15;

            //Exercise 15 solution:
            uint bit3 = (number15 >> 3) & 1;
            uint bit24 = (number15 >> 24) & 1;
            number15 = (uint) (number15 & (~(1 << 24)) | (bit3 << 24));
            number15 = (uint) (number15 & (~(1 << 3)) | (bit24 << 3));

            uint bit4 = (number15 >> 4) & 1;
            uint bit25 = (number15 >> 25) & 1;
            number15 = (uint)(number15 & (~(1 << 25)) | (bit4 << 25));
            number15 = (uint)(number15 & (~(1 << 4)) | (bit25 << 4));

            uint bit5 = (number15 >> 5) & 1;
            uint bit26 = (number15 >> 26) & 1;
            number15 = (uint)(number15 & (~(1 << 26)) | (bit5 << 26));
            number15 = (uint)(number15 & (~(1 << 5)) | (bit26 << 5));

            Console.WriteLine("New number (Exercise 15): " + number15);

            //Exercise 16 solution:
            uint bitI;
            uint bitIPlus15;

            for (int i = 1; i <= 16; i++)
            {
                bitI = (number16 >> i) & 1;
                bitIPlus15 = (number16 >> (i + 16)) & 1;
                number16 = (uint)(number16 & (~(1 << (i + 16))) | (bitI << (i + 16)));
                number16 = (uint)(number16 & (~(1 << i)) | (bitIPlus15 << i));
            }

            Console.WriteLine("New number (Exercise 16): " + number16);
        }
    }
}
