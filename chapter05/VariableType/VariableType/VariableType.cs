/*
Chapter 5 - Exercise 8
Write a program that, depending on the user’s choice, inputs int, double or string variable. If the variable is int or 
double, the program increases it by 1. If the variable is a string, the program appends "*" at the end. Print the 
result at the console. Use switch statement.
*/

using System;

namespace VariableType
{
    class VariableType
    {
        protected VariableType()
        {

        }

        static void Main()
        {
            byte variableType;

            Console.WriteLine("Enter the type of variable (0=integer, 1=double, 2=string):");
            byte.TryParse(Console.ReadLine(), out variableType);

            if (variableType == 0 || variableType == 1 || variableType == 2)
            {
                Console.WriteLine("Enter the value: ");

                switch (variableType)
                {
                    case 0: //integer
                        int intValue;
                        int.TryParse(Console.ReadLine(), out intValue);
                        Console.WriteLine("Integer value + 1: {0}", ++intValue);
                        break;
                    case 1: //double
                        double doubleValue;
                        double.TryParse(Console.ReadLine(), out doubleValue);
                        Console.WriteLine("Double value + 1: {0}", doubleValue + 1);
                        break;
                    case 2: //string
                        string stringValue = Console.ReadLine();
                        Console.WriteLine("String value + 1: {0}", stringValue + '*');
                        break;
                }
            } else
            {
                Console.WriteLine("Error.");
            }
        }
    }
}
