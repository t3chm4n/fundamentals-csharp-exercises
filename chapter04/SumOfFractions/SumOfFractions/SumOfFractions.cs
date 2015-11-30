/*
Chapter 4 - Exercise 12
Write a program that calculates the sum (with precision of 0.001) of the following sequence: 
1 + 1/2 - 1/3 + 1/4 - 1/5 + …
*/
using System;                

namespace SumOfFractions
{
    class SumOfFractions
    {
        protected SumOfFractions()
        {

        }

        static void Main()
        {
            float sum = 0;
            float sumTest = 1;
            float fraction = 2F; 

            while (Math.Abs(sumTest - sum) > 0.001)
            {
                sum = sumTest;
                if (fraction % 2 == 0)
                {
                    sumTest = sum + (1 / fraction);
                } else
                {
                    sumTest = sum - (1 / fraction);
                }
                fraction++;
            }

            Console.WriteLine("Result: {0}", sum);
        }
    }
}
