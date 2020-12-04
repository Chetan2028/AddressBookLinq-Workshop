using System;
using System.Data;

namespace AddressBookLinq_Workshop
{
    public class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Linq");
            AddressBookManagement addressBookManagement = new AddressBookManagement();

            //create Data table
            DataTable table = new DataTable();

            addressBookManagement.AddDataToTable(table);
            addressBookManagement.ViewDataTable(table);
        }
    }
}
