/*
Chapter 3 - Exercise 7
The gravitational field of the Moon is approximately 17% of that on the Earth.Write a program that calculates the 
weight of a man on the moon by a given weight on the Earth.
*/
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
