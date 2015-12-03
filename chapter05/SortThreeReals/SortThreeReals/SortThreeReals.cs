/*
Chapter 5 - Exercise 4
Sort 3 real numbers in descending order. Use nested if statements.
*/

using System;

namespace SortThreeReals
{
    class SortThreeReals
    {
        protected SortThreeReals()
        {

        }

        static void Main()
        {
            float number1;
            float number2;
            float number3; 
            float aux;
            

            Console.WriteLine("Enter 3 real numbers: ");
            float.TryParse(Console.ReadLine(), out number1);
            float.TryParse(Console.ReadLine(), out number2);
            float.TryParse(Console.ReadLine(), out number3);

            if (number1 < number2 && number1 < number3)
            {
                aux = number1;
                number1 = number3;
                number3 = aux;

                if (number1 < number2)
                {
                    aux = number1;
                    number1 = number2;
                    number2 = aux;
                }

            } else if (number2 < number1 && number2 < number3)
            {
                aux = number2;
                number2 = number3;
                number3 = aux;

                if (number1 < number2)
                {
                    aux = number1;
                    number1 = number2;
                    number2 = aux;
                }
            }
            else 
            {
                if (number1 < number2)
                {
                    aux = number1;
                    number1 = number2;
                    number2 = aux;
                }
            }

            Console.WriteLine("{0}, {1}, {2}", number1, number2, number3);
        }
    }
}
