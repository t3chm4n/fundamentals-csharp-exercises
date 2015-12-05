/*
Chapter 5 - Exercise 9
We are given 5 integer numbers. Write a program that finds those subsets whose sum is 0. Examples:
- If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 is 0.
- If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets with sum 0.
*/

using System;

namespace SumSubset
{
    class SumSubset
    {
        protected SumSubset()
        {

        }

        static void Main()
        {
            int number1;
            int number2;
            int number3;
            int number4;
            int number5;
            byte counter = 0;

            Console.WriteLine("Enter 5 integers: ");
            int.TryParse(Console.ReadLine(), out number1);
            int.TryParse(Console.ReadLine(), out number2);
            int.TryParse(Console.ReadLine(), out number3);
            int.TryParse(Console.ReadLine(), out number4);
            int.TryParse(Console.ReadLine(), out number5);

            Console.WriteLine("number1: {1}{0}number2: {2}{0}number3: {3}{0}number4: {4}{0}number5: {5}{0}",
                Environment.NewLine, number1, number2, number3, number4, number5);

            //brute force
            //only with if statements (until here in the book, i.e. without arrays) it was the way that I figured out 
            //how to do it.
            //00001
            if (number1 == 0) 
            {
                Console.WriteLine("number1 = 0.");
                counter++;
            }

            //00011
            if (number1 + number2 == 0)
            {
                Console.WriteLine("number1 + number2 = 0.");
                counter++;
            }

            //00010
            if (number2 == 0)
            {
                Console.WriteLine("number2 = 0.");
                counter++;
            }

            //00100
            if (number3 == 0)
            {
                Console.WriteLine("number3 = 0.");
                counter++;
            }

            //00101
            if (number1 + number3 == 0)
            {
                Console.WriteLine("number1 + number3 = 0.");
                counter++;
            }

            //00110
            if (number2 + number3 == 0)
            {
                Console.WriteLine("number2 + number3 = 0.");
                counter++;
            }

            //00111
            if (number1 + number2 + number3 == 0)
            {
                Console.WriteLine("number1 + number2 + number3 = 0.");
                counter++;
            }

            //01000
            if (number4 == 0)
            {
                Console.WriteLine("number4 = 0.");
                counter++;
            }

            //01001
            if (number1 + number4 == 0)
            {
                Console.WriteLine("number1 + number4 = 0.");
                counter++;
            }

            //01010
            if (number2 + number4 == 0)
            {
                Console.WriteLine("number2 + number4 = 0.");
                counter++;
            }

            //01011
            if (number1 + number2 + number4 == 0)
            {
                Console.WriteLine("number1 + number2 + number4 = 0.");
                counter++;
            }

            //01100
            if (number3 + number4 == 0)
            {
                Console.WriteLine("number3 + number4 = 0.");
                counter++;
            }

            //01101
            if (number1 + number3 + number4 == 0)
            {
                Console.WriteLine("number1 + number3 + number4 = 0.");
                counter++;
            }

            //01110
            if (number2 + number3 + number4 == 0)
            {
                Console.WriteLine("number2 + number3 + number4 = 0.");
                counter++;
            }

            //01111
            if (number1 + number2 + number3 + number4 == 0)
            {
                Console.WriteLine("number1 + number2 + number3 + number4 = 0.");
                counter++;
            }

            //10000
            if (number5 == 0)
            {
                Console.WriteLine("number5 = 0.");
                counter++;
            }

            //10001
            if (number1 + number5 == 0)
            {
                Console.WriteLine("number1 + number5 = 0.");
                counter++;
            }

            //10010
            if (number2 + number5 == 0)
            {
                Console.WriteLine("number2 + number5 = 0.");
                counter++;
            }

            //10011
            if (number1 + number2 + number5 == 0)
            {
                Console.WriteLine("number1 + number2 + number5 = 0.");
                counter++;
            }

            //10100
            if (number3 + number5 == 0)
            {
                Console.WriteLine("number3 + number5 = 0.");
                counter++;
            }

            //10101
            if (number1 + number3 + number5 == 0)
            {
                Console.WriteLine("number1 + number3 + number5 = 0.");
                counter++;
            }

            //10110
            if (number2 + number3 + number5 == 0)
            {
                Console.WriteLine("number2 + number3 + number5 = 0.");
                counter++;
            }

            //10111
            if (number1 + number2 + number3 + number5 == 0)
            {
                Console.WriteLine("number1 + number2 + number3 + number5 = 0.");
                counter++;
            }

            //11000
            if (number4 + number5 == 0)
            {
                Console.WriteLine("number4 + number5 = 0.");
                counter++;
            }

            //11001
            if (number1 + number4 + number5 == 0)
            {
                Console.WriteLine("number1 + number4 + number5 = 0.");
                counter++;
            }

            //11010
            if (number2 + number4 + number5 == 0)
            {
                Console.WriteLine("number2 + number4 + number5 = 0.");
                counter++;
            }

            //11011
            if (number1 + number2 + number4 + number5 == 0)
            {
                Console.WriteLine("number1 + number2 + number4 + number5 = 0.");
                counter++;
            }

            //11100
            if (number3 + number4 + number5 == 0)
            {
                Console.WriteLine("number3 + number4 + number5 = 0.");
                counter++;
            }

            //11101
            if (number1 + number3 + number4 + number5 == 0)
            {
                Console.WriteLine("number1 + number3 + number4 + number5 = 0.");
                counter++;
            }

            //11110
            if (number2 + number3 + number4 + number5 == 0)
            {
                Console.WriteLine("number2 + number3 + number4 + number5 = 0.");
                counter++;
            }

            //11111
            if (number1 + number2 + number3 + number4 + number5 == 0)
            {
                Console.WriteLine("number1 + number2 + number3 + number4 + number5 = 0.");
                counter++;
            }

            if (counter == 0)
            {
                Console.WriteLine("No subsets with sum = zero found.");
            } else
            {
                Console.WriteLine("Total of {0} subsets found.", counter);
            }                                                       
        }
    }
}
