using System;

namespace CompareRealNumbers
{
    class CompareRealNumbers
    {
        protected CompareRealNumbers()
        {

        }

        static void Main()
        {
            double n1;
            double n2;
            const double PRECISION = 0.000001;

            Console.Write("Enter the first number: ");
            double.TryParse(Console.ReadLine(), out n1);
            Console.Write("Enter the second number: ");
            double.TryParse(Console.ReadLine(), out n2);

            bool equal = Math.Abs(n1 - n2) < PRECISION;

            Console.WriteLine("The numbers are " + (equal ? "equal." : "different."));

            //switch (n1.CompareTo(n2))
            //{
            //    case -1:
            //        Console.WriteLine("First number is smaller than second one.");
            //        break;
            //    case 0:
            //        Console.WriteLine("Both are equals.");
            //        break;
            //    case 1:
            //        Console.WriteLine("Second number is smaller than first one.");
            //        break;
            //    default:
            //        Console.WriteLine("Error.");
            //        break;
            //}
        }
    }
}
