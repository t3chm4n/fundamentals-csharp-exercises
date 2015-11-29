/*
Chapter 2 - Exercise 2
Which of the following values can be assigned to variables of type float, double and decimal: 5, -5.01, 34.567839023; 
12.345; 8923.1234857; 3456.091124875956542151256683467?
*/

using System;

namespace DeclaringRealTypes
{
    class DeclaringRealTypes
    {
        protected DeclaringRealTypes()
        {

        }

        static void Main()
        {
            // float has 7-digit precision, integer and fractional parts together

            // double has 15-digit precision, integer and fractional parts together

            // decimal has 29-digit, integer and fractional parts together

            /* 
               decimal is ideal for financial operations due its enormous precision, but it works with base 10, so 
               every calculation is done in software layer instead at the microprocessor, so it is tens of thousands 
               times lower than float and double (that work with binary operation inside microprocessor). Use it only 
               if really necessary
            */

            float r1 = 5F;
            float r2 = -5.01F;
            double r3 = 34.567839023D; // double don't need to have the D
            float r4 = 12.345F;
            double r5 = 8923.1234857D;                      
            decimal r6 = 3456.091124875956542151256683467M; //31 dígits, even decimal will lose precision:    
            Console.WriteLine("r1 = " + r1);
            Console.WriteLine("r2 = " + r2);
            Console.WriteLine("r3 = " + r3);
            Console.WriteLine("r4 = " + r4);
            Console.WriteLine("r5 = " + r5);
            Console.WriteLine("r6 = " + r6);
        }
    }
}
