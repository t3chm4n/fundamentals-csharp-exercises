/*
Chapter 3 - Exercise 8
Write an expression that checks for a given point {x, y} if it is within the circle K({ 0, 0}, R=5). Explanation: the 
point {0, 0} is the center of the circle and 5 is the radius.
*/
using System;

namespace WithinTheCircle
{
    class WithinTheCircle
    {
        protected WithinTheCircle()
        {

        }

        static void Main()
        {
            //Using the Pithagorean Theorem (a² + b² = c²), or if coordX² + coordY² <= radius² the point is within the 
            //circle area

            byte radius = 5;
            byte coordX;
            byte coordY;

            Console.WriteLine("Find if a coordinate is within the circle area.");
            Console.WriteLine();
            Console.Write("Enter the coordinate X:");
            byte.TryParse(Console.ReadLine(), out coordX);

            Console.Write("Enter the coordinate Y:");
            byte.TryParse(Console.ReadLine(), out coordY);

            Console.WriteLine("The coordinate " + (((coordX * coordX) + (coordY * coordY)) <= (radius * radius) ? "is" 
                : "isn't" ) + " within the circle area.");


        }
    }
}
