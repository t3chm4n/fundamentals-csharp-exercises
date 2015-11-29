/*
Chapter 4 - Exercice 3
A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and 
phone number. Write a program that reads information about the company and its manager and then prints it on the 
console.
*/

using System;

namespace CompanyInformation
{
    class CompanyInformation
    {
        protected CompanyInformation()
        {

        }

        static void Main()
        {
            string companyName;
            string companyAddress;
            ulong companyPhoneNumber;
            ulong companyFaxNumber;
            string companyWebSite;
            string managerName;
            string managerSurname;
            ulong managerPhoneNumber;

            Console.WriteLine("Enter the company name, address, phone number, fax number and website: ");
            companyName = Console.ReadLine();
            companyAddress = Console.ReadLine();
            ulong.TryParse(Console.ReadLine(), out companyPhoneNumber);
            ulong.TryParse(Console.ReadLine(), out companyFaxNumber);
            companyWebSite = Console.ReadLine();

            Console.WriteLine("Enter the manager name, surname and phone number: ");
            managerName = Console.ReadLine();
            managerSurname = Console.ReadLine();
            ulong.TryParse(Console.ReadLine(), out managerPhoneNumber);

            Console.WriteLine("Company Name: {1}{0}Company Address: {2}{0}Company Phone Number: {3:(00)0000-0000}{0}" +
                "Company Fax Number: {4:(00)0000-0000}{0}Company Website: {5}{0}Company Manager Name: {6} {7}{0}" +
                "Manager Phone Number: {8:(00)0000-0000}", Environment.NewLine, companyName, companyAddress, 
                companyPhoneNumber, companyFaxNumber, companyWebSite, managerName, managerSurname, managerPhoneNumber);

        }
    }
}
