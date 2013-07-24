using System;

class Company
{
    static void Main()
    {
        Console.WriteLine("Enter company name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter company address:");
        string address = Console.ReadLine();
        Console.WriteLine("Enter company phone number:");
        string phnumber = Console.ReadLine();
        Console.WriteLine("Enter company fax number:");
        string fnumber = Console.ReadLine();
        Console.WriteLine("Enter company web site:");
        string website = Console.ReadLine();
        Console.WriteLine("Enter company manager's first name:");
        string mfname = Console.ReadLine();
        Console.WriteLine("Enter company manager's last name:");
        string mlname = Console.ReadLine();
        Console.WriteLine("Enter company manager's age:");
        string mage= Console.ReadLine();
        Console.WriteLine("Enter company manager's phone number:");
        string mphnumber= Console.ReadLine();
        Console.WriteLine(" Company name: {0} \n Company address {1} \n Company phone number {2} \n Company fax number: {3} \n Company website: {4} \n Company manager's first name: {5} \n Company manager's last name: {6} \n Company manager's age: {7} \n Company manager's phone number: {8}",name,address,phnumber,fnumber,website,mfname,mlname,mage,mphnumber);
    }
}

