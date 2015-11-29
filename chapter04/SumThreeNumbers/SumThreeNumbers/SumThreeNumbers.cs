using System;

namespace SumThreeNumbers
{
    class SumThreeNumbers
    {
        protected SumThreeNumbers()
        {

        }

        static void Main()
        {
            int number1;
            int number2;
            int number3;

            Console.WriteLine("Enter 3 numbers (with ENTER between them): ");

            int.TryParse(Console.ReadLine(), out number1);
            int.TryParse(Console.ReadLine(), out number2);
            int.TryParse(Console.ReadLine(), out number3);

            Console.WriteLine("The sum is: " + (number1 + number2 + number3));
        }
    }
}
