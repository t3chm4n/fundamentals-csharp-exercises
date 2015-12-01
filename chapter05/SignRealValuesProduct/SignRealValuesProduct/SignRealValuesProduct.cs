/*
Chapter 5 - Exercise 2
Write a program that shows the sign (+ or -) of the product of three real numbers, without calculating it. Use a 
sequence of if operators.
*/

using System;

namespace SignRealValuesProduct
{
    class SignRealValuesProduct
    {
        protected SignRealValuesProduct()
        {

        }

        static void Main()
        {
            float number1;
            float number2;
            float number3;
            byte countNegative = 0;

            Console.WriteLine("Enter 3 real number:");
            float.TryParse(Console.ReadLine(), out number1);
            float.TryParse(Console.ReadLine(), out number2);
            float.TryParse(Console.ReadLine(), out number3);

            //not elegant but works
            if (number1 < 0)
            {
                countNegative++;
            }
            if (number2 < 0)
            {
                countNegative++;
            }
            if (number3 < 0)
            {
                countNegative++;
            }

            if (countNegative % 2 == 0)
            {
                Console.WriteLine("+");
            } else
            {
                Console.WriteLine("-");
            }
        }
    }
}
