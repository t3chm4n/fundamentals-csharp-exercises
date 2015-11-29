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
