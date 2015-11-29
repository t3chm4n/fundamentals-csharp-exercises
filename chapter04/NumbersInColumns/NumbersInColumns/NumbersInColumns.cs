/*
Chapter 4 - Exercise 4
Write a program that prints three numbers in three virtual columns on the console. Each column should have a width of 
10 characters and the numbers should be left aligned. The first number should be an integer in hexadecimal the second 
should be fractional positive; and the third – a negative fraction. The last two numbers have to be rounded to the 
second decimal place.
*/
using System;

namespace NumbersInColumns
{
    class NumbersInColumns
    {
        protected NumbersInColumns()
        {

        }

        static void Main()
        {
            int number1;
            float number2;
            float number3;

            Console.WriteLine("Enter 3 numbers:");
            int.TryParse(Console.ReadLine(), out number1);
            float.TryParse(Console.ReadLine(), out number2);
            float.TryParse(Console.ReadLine(), out number3);

            Console.WriteLine("{0,-10:X}{1,-10:0.00}{2,-10:-0.00}", number1, number2, number3);
        }
    }
}
