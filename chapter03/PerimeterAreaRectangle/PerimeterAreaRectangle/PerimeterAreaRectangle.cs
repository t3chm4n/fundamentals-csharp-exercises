/*
Chapter 3 - Exercise 6
Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered 
by the user.
*/

using System;

namespace PerimeterAreaRectangle
{
    class PerimeterAreaRectangle
    {
        protected PerimeterAreaRectangle()
        {

        }

        static void Main()
        {
            double side;
            double height;

            Console.Write("Enter the side of the Rectangle: ");
            double.TryParse(Console.ReadLine(), out side);

            Console.Write("Enter the height of the Rectangle: ");
            double.TryParse(Console.ReadLine(), out height);

            Console.WriteLine("The perimeter of the Rectangle is " + ((side * 2) + (height * 2)));
            Console.WriteLine("The area of the Rectangle is " + (side * height));
        }
    }
}
