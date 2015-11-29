/*
Chapter 3 - Exercise 10
Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:
- Calculates the sum of the digits (in our example 2+0+1+1 = 4).
- Prints on the console the number in reversed order: dcba (in our example 1102).
- Puts the last digit in the first position: dabc (in our example 1201).
- Exchanges the second and the third digits: acbd (in our example 2101).
*/

using System;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        protected FourDigitNumber()
        {

        }

        static void Main()
        {
            short number;
            byte a;
            byte b;
            byte c;
            byte d;

            Console.Write("Enter a four-digit number: ");
            short.TryParse(Console.ReadLine(), out number);

            a = (byte) (number / 1000);

            b = (byte)((number - a * 1000) / 100);

            c = (byte)(((number - a * 1000) - b * 100) / 10);

            d = (byte)(((number - a * 1000) - b * 100) - c * 10);

            Console.WriteLine("Sum of the digits: " + (a + b + c + d));
            Console.WriteLine("Reversed order: " + d + c + b + a);
            Console.WriteLine("Last digit first: " + d + a + b + c);
            Console.WriteLine("Exchange second and third digit: " + a + c + b + d);
        }
    }
}
