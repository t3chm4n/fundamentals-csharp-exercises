using System;

namespace OddOrEven
{
    class OddOrEven
    {
        protected OddOrEven()
        {

        }

        static void Main()
        {
            int number = 0;

            Console.Write("Enter a integer: ");
            int.TryParse(Console.ReadLine(), out number);

            Console.WriteLine("The number is " + (number % 2 == 0 ? "odd." : "even."));
        }
    }
}
