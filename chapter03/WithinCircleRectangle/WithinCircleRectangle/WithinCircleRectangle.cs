using System;

namespace WithinCircleRetangle
{
    class WithinCircleRectangle
    {
        protected WithinCircleRectangle()
        {

        }

        static void Main()
        {
            //circle
            //central point={0,0}, radius=5
            const byte RADIUS = 5;

            //rectangle
            //coordinates=[{-1,1}{5,5}]
            const sbyte BOTTOMLEFTX = -1;
            const sbyte BOTTOMLEFTY = 1;
            const sbyte UPPERRIGHTX = 5;
            const sbyte UPPERRIGHTY = 5;

            sbyte coordX;
            sbyte coordY;
            bool insideCircle;
            bool insideRectangle;

            Console.WriteLine("Find if a coordinate is within the circle area and out of the rectangle area.");
            Console.WriteLine();

            Console.Write("Enter the coordinate X:");
            sbyte.TryParse(Console.ReadLine(), out coordX);

            Console.Write("Enter the coordinate Y:");
            sbyte.TryParse(Console.ReadLine(), out coordY);

            //To know if a point is inside a rectangle it need to be:
            //-right of the left wall and
            //-left of the right wall and
            //-beyond the upper parallel and
            //-above the bottom parallel
            insideRectangle = coordX >= BOTTOMLEFTX && coordY >= BOTTOMLEFTY && coordX <= UPPERRIGHTX && coordY <= UPPERRIGHTY;

            //Using the Pithagorean Theorem (a² + b² = c²),
            //or if coordX² + coordY² <= radius² the point is within the circle area
            insideCircle = coordX * coordX + coordY * coordY <= RADIUS * RADIUS;

            Console.WriteLine("The coordinate is " + ( insideCircle ? "inside" : "outside") + " the circle area and " + (insideRectangle ? "inside" : "outside") + " the rectangle area.");
        }
    }
}
