using System;

namespace WeightMoon
{
    class WeightMoon
    {
        protected WeightMoon()
        {

        }

        static void Main()
        {
            double weight;

            Console.Write("Enter your weight: ");
            double.TryParse(Console.ReadLine(), out weight);

            Console.WriteLine("Your weight on the moon is " + (weight * 0.17));
        }
    }
}
