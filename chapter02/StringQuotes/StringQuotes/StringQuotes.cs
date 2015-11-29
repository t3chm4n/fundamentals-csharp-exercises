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
