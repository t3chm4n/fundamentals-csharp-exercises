/*
Chapter 5 - Exercise 11
* Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. 
Examples:
- 0 --> "Zero"
- 12 --> "Twelve"
- 98 --> "Ninety eight"
- 273 --> "Two hundred seventy three"
- 400 --> "Four hundred"
- 501 --> "Five hundred and one"
- 711 --> "Seven hundred and eleven"
*/

using System;                  

namespace NumberIntoWords
{
    class NumberIntoWords
    {
        protected NumberIntoWords()
        {

        }

        static string GetDigit(int number)
        {
            switch(number)
            {
                case 1:
                    return "one";
                    break;
                case 2:
                    return "two";
                    break;
                case 3:
                    return "three";
                    break;
                case 4:
                    return "four";
                    break;
                case 5:
                    return "five";
                    break;
                case 6:
                    return "six";
                    break;
                case 7:
                    return "seven";
                    break;
                case 8:
                    return "eight";
                    break;
                case 9:
                    return "nine";
                    break;
                default:
                    return "errorGetDigit";
                    break;
            }                      
        }

        static void Main()
        {
            int number;      
            Console.WriteLine("Enter a number (0-999): ");
            int.TryParse(Console.ReadLine(), out number);
                             
            string word = "";

            if (number == 0)
            {
                word = "zero";
            } else
            {
                if (number / 100 > 0)
                {
                    word = GetDigit(number / 100);
                    word += " hundred";
                }

                if (number % 100 > 0 && number % 100 <= 9)
                {
                    word += number >= 100 ? " and " + GetDigit(number % 100) : GetDigit(number % 100);
                }
                else if (number % 100 >= 10 && number % 100 <= 19)
                {
                    if (number >= 100)
                    {                   
                        word += " and ";
                    }

                    switch (number % 100)
                    {
                        case 10:
                            word += "ten";
                            break;
                        case 11:
                            word += "eleven";
                            break;
                        case 12:
                            word += "twelve";
                            break;
                        case 13:
                            word += "thirdteen";
                            break;
                        case 14:
                            word += "fourteen";
                            break;
                        case 15:
                            word += "fifteen";
                            break;
                        case 16:
                            word += "sixteen";
                            break;
                        case 17:
                            word += "seventeen";
                            break;
                        case 18:
                            word += "eighteen";
                            break;
                        case 19:
                            word += "nineteen";
                            break;
                        default:
                            word += "error10to19";
                            break;
                    }
                } else if (number % 100 >= 20)
                {
                    if (number >= 100)
                    {               
                        word += " ";
                    }

                    switch ((number % 100) / 10)
                    {
                        case 2:
                            word += "twenty";
                            break;
                        case 3:
                            word += "thirty";
                            break;
                        case 4:
                            word += "fourty";
                            break;
                        case 5:
                            word += "fifty";
                            break;
                        case 6:
                            word += "sixty";
                            break;
                        case 7:
                            word += "seventy";
                            break;
                        case 8:
                            word += "eighty";
                            break;
                        case 9:
                            word += "ninety";
                            break;
                        default:
                            word += "errorTens";
                            break;
                    }

                    if ((number % 100) % 10 > 0)
                    {
                        word += " " + GetDigit((number % 100) % 10);
                    }  
                }
            }

            //capitalize first letter
            Console.WriteLine(word.Remove(1).ToUpper() + word.Substring(1));                    
        }
    }
}