using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First100Numbers
{
    class FirstNNumbers
    {
        protected FirstNNumbers()
        {
        }

        static void Main()
        {
            const int FIRST_N_NUMBERS = 100;
            for(int i = 2; i <= FIRST_N_NUMBERS + 1; i++)
            {
                Console.WriteLine(i % 2 == 0 ? i : i * -1);
            }
        }
    }
}
