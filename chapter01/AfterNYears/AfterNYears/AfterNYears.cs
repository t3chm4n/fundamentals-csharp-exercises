using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterNYears
{
    class AfterNYears
    {
        protected AfterNYears()
        {

        }

        static void Main()
        {
            const int AFTER_N_YEARS = 10;
            byte actualAge = 0;
            Console.Write("Enter your actual age: ");
            byte.TryParse(Console.ReadLine(), out actualAge);
            actualAge += AFTER_N_YEARS;
            Console.WriteLine("Your age in {0} years will be {1}.", AFTER_N_YEARS, actualAge);
        }
    }
}
