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
            //Using the Pithagorean Theorem (a² + b² = c²),
            //or if coordX² + coordY² <= radius² the point is within the circle area

            byte radius = 5;
            byte coordX;
            byte coordY;

            Console.WriteLine("Find if a coordinate is within the circle area.");
            Console.WriteLine();
            Console.Write("Enter the coordinate X:");
            byte.TryParse(Console.ReadLine(), out coordX);

            Console.Write("Enter the coordinate Y:");
            byte.TryParse(Console.ReadLine(), out coordY);

            Console.WriteLine("The coordinate " + (((coordX * coordX) + (coordY * coordY)) <= (radius * radius) ? "is" : "isn't" ) + " within the circle area.");


        }
    }
}
