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
            addressBookManagement.CreateTable(table);

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Press 1 to AddContact \nPress 2 to View Contact \nPress 3 to Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addressBookManagement.AddContact(table);
                        break;
                    case 2:
                        addressBookManagement.ViewDataTable(table);
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter valid choice");
                        break;
                }
            }
        }
    }
}
