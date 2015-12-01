/*
Chapter 5 - Exercise 1
Write an if-statement that takes two integer variables and exchanges their values if the first one is greater than the 
second one.
*/

using System;

namespace ExchangeValues
{
    class ExchangeValues
    {
        protected ExchangeValues()
        {

        }

        static void Main()
        {
            int number1;
            int number2;
            int aux;          

            Console.WriteLine("Enter 2 integers:");
            int.TryParse(Console.ReadLine(), out number1);
            int.TryParse(Console.ReadLine(), out number2);

            if (number1 > number2)
            {
                aux = number2;
                number2 = number1;
                number1 = aux;
                Console.WriteLine("The numbers were exchanged.");
            }
        }
    }
}
