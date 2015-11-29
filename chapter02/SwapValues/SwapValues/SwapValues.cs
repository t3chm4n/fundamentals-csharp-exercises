using System;

namespace SwapValues
{
    class SwapValues
    {
        protected SwapValues()
        {

        }

        static void Main()
        {
            int n1 = 10;
            int n2 = 5;
            int aux;

            Console.WriteLine("n1: " + n1);
            Console.WriteLine("n2: " + n2);

            Console.WriteLine();
            Console.WriteLine("Swaping.................................... ");
            Console.WriteLine();

            //not recommended
            //n1 += n2;
            //n2 = n1 - n2;
            //n1 -= n2;

            //not recommended
            //XOR swap
            //if used with referenced variables (e.g. arrays), you need to test if
            //the indexes of the array are different, or you will see a logic error
            //n1 = n1 ^ n2;
            //n2 = n2 ^ n1;
            //n1 = n1 ^ n2;

            //easy to write and understand. Recommended
            aux = n1;
            n1 = n2;
            n2 = aux;

            Console.WriteLine();
            Console.WriteLine("n1: " + n1);
            Console.WriteLine("n2: " + n2);
            Console.WriteLine();
        }
    }
}
