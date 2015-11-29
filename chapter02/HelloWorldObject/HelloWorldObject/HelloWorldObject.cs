/*
Chapter 2 - Chapter 7
Declare two variables of type string with values "Hello" and "World". Declare a variable of type object. Assign the 
value obtained of concatenation of the two string variables (add space if necessary) to this variable. Print the 
variable of type object.
*/

using System;

namespace HelloWorldObject
{
    class HelloWorldObject
    {
        protected HelloWorldObject()
        {

        }

        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;

            Console.WriteLine(helloWorld);
        }
    }
}
