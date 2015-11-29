using System;

namespace CirclePerimeterArea
{
    class CirclePerimeterArea
    {
        protected CirclePerimeterArea()
        {

        }

        static void Main()
        {
            double radius;

            Console.WriteLine("Enter the radius of a circle: ");
            double.TryParse(Console.ReadLine(), out radius);

            double circlePerimeter = 2 * Math.PI * radius;
            double circleArea = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("Perimeter: " + circlePerimeter);
            Console.WriteLine("Area: " + circleArea);

        }
    }
}
