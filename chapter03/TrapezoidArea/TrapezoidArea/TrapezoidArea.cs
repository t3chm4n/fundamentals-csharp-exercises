using System;

namespace TrapezoidArea
{
    class TrapezoidArea
    {
        protected TrapezoidArea()
        {

        }

        static void Main()
        {
            double side1;
            double side2;
            double height;
            double area;

            Console.Write("Enter side 1: ");
            double.TryParse(Console.ReadLine(), out side1);

            Console.Write("Enter side 2: ");
            double.TryParse(Console.ReadLine(), out side2);

            Console.Write("Enter height: ");
            double.TryParse(Console.ReadLine(), out height);

            //trapezoid area = ((side1 + side2) * height) / 2
            //              or 0.5 * (side1 + side2) * height

            area = 0.5 * ((side1 + side2) * height);

            Console.WriteLine("The area of trapezoid is " + area);
        }
    }
}
