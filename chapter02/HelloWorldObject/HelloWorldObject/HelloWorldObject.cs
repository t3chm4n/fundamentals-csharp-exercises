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
