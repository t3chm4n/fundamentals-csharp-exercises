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
