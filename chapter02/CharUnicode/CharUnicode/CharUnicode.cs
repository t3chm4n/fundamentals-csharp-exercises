/*
Chapter 2 - Exercise 5
Declare a variable of type char and assign it as a value the character, which has Unicode code, 72 (use the Windows 
calculator in order to find hexadecimal representation of 72).
*/

using System;

namespace CharUnicode
{
    class CharUnicode
    {
        protected CharUnicode()
        {

        }

        static void Main()
        {
            char ch = (char)0x48;
            Console.WriteLine(ch);
        }
    }
}
