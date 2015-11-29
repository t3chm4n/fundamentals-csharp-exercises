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
