/*
Chapter 4 - Exercise 5
Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, 
such that the remainder of their division by 5 is 0. Example: in the range (14, 25) there are 3 such numbers: 15, 20 
and 25.
*/

using System;

namespace NumbersBetween
{
    class NumbersBetween
    {
        protected NumbersBetween()
        {

        }

        static void Main()
        {
            const int DIVISOR = 5;
            int number1;
            int number2;
            int counter = 0;

            Console.WriteLine("Enter 2 integers: ");
            int.TryParse(Console.ReadLine(), out number1);
            int.TryParse(Console.ReadLine(), out number2);

            for(int i = number1; i <= number2; i++)
            {
                if (i % DIVISOR == 0){counter++;}
            }

            Console.WriteLine("There are {0} numbers between {1} and {2} that are divisible by {3}", counter, number1, 
                number2, DIVISOR);
        }
    }
}
