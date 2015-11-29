using System;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        protected FourDigitNumber()
        {

        }

        static void Main()
        {
            short number;
            byte a;
            byte b;
            byte c;
            byte d;

            Console.Write("Enter a four-digit number: ");
            short.TryParse(Console.ReadLine(), out number);

            a = (byte) (number / 1000);

            b = (byte)((number - a * 1000) / 100);

            c = (byte)(((number - a * 1000) - b * 100) / 10);

            d = (byte)(((number - a * 1000) - b * 100) - c * 10);

            Console.WriteLine("Sum of the digits: " + (a + b + c + d));
            Console.WriteLine("Reversed order: " + d + c + b + a);
            Console.WriteLine("Last digit first: " + d + a + b + c);
            Console.WriteLine("Exchange second and third digit: " + a + c + b + d);
        }
    }
}
