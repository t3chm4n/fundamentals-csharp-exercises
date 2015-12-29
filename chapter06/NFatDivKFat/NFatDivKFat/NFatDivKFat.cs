/*
Chapter 6 - Exercise 6
Write a program that calculates N!/K! for given N and K (1<K<N).
*/

using System;

namespace NFatDivKFat
{
    class NFatDivKFat
    {
        protected NFatDivKFat()
        {

        }

        static void Main()
        {
            Console.WriteLine("Program that calculates N!/K!");
            Console.WriteLine("Enter N and K: ");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            int k;
            int.TryParse(Console.ReadLine(), out k);

            if (1 < k && k < n)
            {
                decimal result = 1;
                for (int i = k+1; i <= n; i++)
                {
                    result *= i;
                }
                Console.WriteLine("Result: {0}", result);
            } else
            {
                Console.WriteLine("K must be > 1 and N must be > K.");
            }
        }
    }
}
