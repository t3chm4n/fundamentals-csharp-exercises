/*
Chapter 2 - Exercise 11
Write a program that prints on the console isosceles triangle which sides consist of the copyright character "©".
*/
using System;

namespace ASCIIIsoscelesTriangle
{
    class ASCIIIsoscelesTriangle
    {
        protected ASCIIIsoscelesTriangle()
        {

        }

        static void Main()
        {
            Console.WriteLine("      ©");
            Console.WriteLine();
            Console.WriteLine("     © ©");
            Console.WriteLine();
            Console.WriteLine("    ©   ©");
            Console.WriteLine();
            Console.WriteLine("   ©     ©");
            Console.WriteLine();
            Console.WriteLine("  ©       ©");
            Console.WriteLine();
            Console.WriteLine(" ©         ©");
            Console.WriteLine();
            Console.WriteLine("© © © © © © ©");
        }
    }
}
