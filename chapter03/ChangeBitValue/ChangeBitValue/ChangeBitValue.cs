using System;

namespace ChangeBitValue
{
    class ChangeBitValue
    {
        protected ChangeBitValue()
        {

        }

        static void Main()
        {
            int number;
            int position;
            int value;

            Console.Write("Enter a integer: ");
            int.TryParse(Console.ReadLine(), out number);

            Console.Write("Enter a value (0 or 1): ");
            int.TryParse(Console.ReadLine(), out value);

            Console.Write("Enter a position: ");
            int.TryParse(Console.ReadLine(), out position);

            //Reset the bit at position
            number = number & (~(1 << position));

            //Write the new value
            number = number | (value << position);

            //output for exercise 11
            Console.WriteLine("New number: " + number);
        }
    }
}
