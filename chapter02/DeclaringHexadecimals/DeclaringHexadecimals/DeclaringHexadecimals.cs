/*
Chapter 2 - Exercise 4
Initialize a variable of type int with a value of 256 in hexadecimal format (256 is 100 in a numeral system with base 
16).
*/

using System;

namespace DeclaringHexadecimals
{
    class DeclaringHexadecimals
    {
        protected DeclaringHexadecimals()
        {

        }

        static void Main()
        {
            int n1 = 0x100;

            Console.WriteLine(n1); //imprime base 10
            Console.WriteLine(n1.ToString("X")); //imprime hexadecimal
        }
    }
}
