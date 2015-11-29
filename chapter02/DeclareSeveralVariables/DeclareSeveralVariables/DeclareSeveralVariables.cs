/*
Chapter 2 - Exercise 1
Declare several variables by selecting for each one of them the most appropriate of the types sbyte, byte, short, 
ushort, int, uint, long and ulong in order to assign them the following values: 52,130; -115; 4825932; 97; -10000; 
20000; 224; 970,700,000; 112; -44; -1,000,000; 1990; 123456789123456789
*/

namespace DeclareSeveralVariables
{
    class DeclareSeveralVariables
    {
        protected DeclareSeveralVariables()
        {

        }

        static void Main()
        {
            ushort n1 = 52130;
            sbyte n2 = -115;
            uint n3 = 4825932;
            byte n4 = 97;
            short n5 = -10000;
            ushort n6 = 20000;
            byte n7 = 224;
            uint n8 = 970700000;
            byte n9 = 112;
            sbyte n10 = -44;
            int n11 = -1000000;
            ushort n12 = 1990;
            ulong n13 = 123456789123456789;
        }
    }
}
