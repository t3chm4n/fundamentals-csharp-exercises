/*
Chapter 2 - Exercise 8
Declare two variables of type string and give them values "Hello" and "World". Assign the value obtained by the 
concatenation of the two variables of type string (do not miss the space in the middle) to a variable of type object. 
Declare a third variable of type string and initialize it with the value of the variable of type object (you should use
type casting).
*/

using System;

namespace HelloWorldTypeCast
{
    class HelloWorldTypeCast
    {
        protected HelloWorldTypeCast()
        {

        }

        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            string strHelloWorld = (string)helloWorld;

            Console.WriteLine(strHelloWorld);
        }
    }
}
