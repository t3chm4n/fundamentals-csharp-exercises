/*
Chapter 2 - Exercise 12
A company dealing with marketing wants to keep a data record of its employees. Each record should have the following 
characteristic – first name, last name, age, gender (‘m’ or ‘f’) and unique employee number (27560000 to 27569999). 
Declare appropriate variables needed to maintain the information for an employee by using the appropriate data types 
and attribute names.
*/             

namespace MarketingEmployees
{
    class MarketingEmployees
    {
        protected MarketingEmployees()
        {

        }

        static void Main()
        {
            string firstName;
            string lastName;
            byte age;
            char gender;
            uint employeeNumber = 27560000;
        }
    }
}
