using System;

namespace PrimeNumber
{
    class PrimeNumber
    {
        protected PrimeNumber()
        {

        }

        static void Main()
        {
            int number;
            int divCounter = 0;

            Console.Write("Enter a number between 1 and 100: ");
            int.TryParse(Console.ReadLine(), out number);


            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                divCounter += number % i == 0 ? 1 : 0;
            }

            Console.WriteLine("Is prime: " + (divCounter > 0 ? "false" : "true"));
        }
    }
}
