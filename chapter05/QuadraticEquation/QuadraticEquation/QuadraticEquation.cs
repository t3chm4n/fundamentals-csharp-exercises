/*
Chapter 5 - Exercise 6
Write a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c, calculates and prints its 
real roots (if they exist). Quadratic equations may have 0, 1 or 2 real roots.
*/
using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        protected QuadraticEquation()
        {

        }

        static void Main()
        {
            int a;
            int b;
            int c;
            double d;

            Console.WriteLine("Enter the coeficients a, b and c for a quadratic equation (ax2 + bx + c):");
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            int.TryParse(Console.ReadLine(), out c);

            d = Math.Pow(b, 2) - 4 * a * c;

            if (d == 0)
            {
                Console.WriteLine("Discriminant = 0, one real root: {0}.", -b / (2 * a));
            } else if (d < 0)
            {
                Console.WriteLine("Discriminant is negative, no real roots.");
            } else //d > 0
            {
                Console.WriteLine("Discriminant is positive, two real roots {0} and {1}.", 
                    (-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a),
                    (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a));
            }
        }
    }
}
