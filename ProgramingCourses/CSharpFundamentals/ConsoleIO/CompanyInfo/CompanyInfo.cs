//A company has name, address, phone number, fax number, web site and manager.The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.
//info input
//Company name:	Telerik Academy
//Company address:	31 Al.Malinov, Sofia
//Phone number:	+359 888 55 55 555
//Fax number:	
//Web site:	http://telerikacademy.com/
//Manager first name:	Nikolay
//Manager last name:	Kostov
//Manager age:	25
//Manager phone:	+359 2 981 981

using System;

class CompanyInfo
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string faxNumber = Console.ReadLine();
        string webSite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();

        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}",companyAddress);
        Console.WriteLine("Tel. {0}",phoneNumber);
        if (string.IsNullOrEmpty(faxNumber))
        {
            Console.WriteLine("Fax: (no fax)");
        }
        else
        {
            Console.WriteLine("Fax: {0}", faxNumber);
        }
        
        Console.WriteLine("Web site: {0}",webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",managerFirstName,managerLastName,age,managerPhone);
         
    }
}

