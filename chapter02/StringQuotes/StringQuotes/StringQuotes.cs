/*
Chapter 2 - Exercise 9
Declare two variables of type string and assign them a value “The "use" of quotations causes difficulties.” (without 
the outer quotes). In one of the variables use quoted string and in the other do not use it.
*/

using System;

namespace StringQuotes
{
    class StringQuotes
    {
        protected StringQuotes()
        {

        }

        static void Main()
        {
            string noQuotes = "The \"use\" of quotations causes difficulties.";
            string quotes = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine(noQuotes);
            Console.WriteLine(quotes);
        }
    }
}
