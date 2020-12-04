using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;

namespace AddressBookLinq_Workshop
{
    public class AddressBookManagement
    {

        ContactValidator validator = new ContactValidator();

        /// <summary>
        /// UC2
        /// Adds the data to table.
        /// </summary>
        /// <param name="table">The table.</param>
        public void CreateTable(DataTable table)
        {
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("State", typeof(string));
            table.Columns.Add("Zip", typeof(int));
            table.Columns.Add("PhoneNumber", typeof(string));
            table.Columns.Add("Email", typeof(string));
        }

        /// <summary>
        /// Adds the contact.
        /// </summary>
        /// <param name="table">The table.</param>
        public void AddContact(DataTable table)
        {
            try
            {
                Console.WriteLine("Enter First Name");
                string firstName = Console.ReadLine();
                validator.ValidateFirstName(firstName);

                Console.WriteLine("Enter Last Name");
                string lastName = Console.ReadLine();
                validator.ValidateLastName(lastName);

                Console.WriteLine("Enter Address");
                string address = Console.ReadLine();
                validator.ValidateAddress(address);

                Console.WriteLine("Enter Zip");
                int zip = Convert.ToInt32(Console.ReadLine());
                validator.ValidateZip(zip);

                Console.WriteLine("Enter Phone Number");
                string phoneNumber = Console.ReadLine();
                validator.ValidatePhoneNumber(phoneNumber);

                Console.WriteLine("Enter City");
                string city = Console.ReadLine();
                validator.ValidateCity(city);

                Console.WriteLine("Enter State");
                string state = Console.ReadLine();
                validator.ValidateState(state);

                Console.WriteLine("Enter Your Email");
                string email = Console.ReadLine();
                validator.ValidateEmail(email);

                Contact contact = new Contact()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Address = address,
                    City = city,
                    State = state,
                    Zip = zip,
                    PhoneNumber = phoneNumber,
                    Email = email
                };
                table.Rows.Add(contact);
            }
            catch (AddressBookCustomException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Edits the contact.
        /// </summary>
        /// <param name="table">The table.</param>
        public void EditContact(DataTable table)
        {
            try
            {
                Console.WriteLine("Enter the First Name Which you want to edit");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter the Mobile Number which you want to edit");
                string phoneNumber = Console.ReadLine();

                foreach (DataRow row in table.Rows)
                {
                    for (int col = 0; col < table.Columns.Count; col++)
                    {
                        if (row.Field<string>("FirstName").Equals(firstName) && row.Field<string>("PhoneNumber").Equals(phoneNumber))
                        {
                            EditContactList(row);
                        }
                    }
                }

            }
            catch (AddressBookCustomException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Edits the contact list.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void EditContactList(DataRow contact)
        {
            Console.WriteLine("Press 1 to Edit FirstName \nPress 2 to Edit LastName \nPress 3 to Edit Address \nPress 4 to Edit City" +
                "\nPress 5 to Edit State \nPress 6 to Edit Zip \nPress 7 to Edit Email \nPress 8 to Edit PhoneNumber ");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter new First Name");
                        string firstName = Console.ReadLine();
                        validator.ValidateFirstName(firstName);
                        contact.SetField("FirstName", firstName);
                        break;
                    case 2:
                        Console.WriteLine("Enter new Last Name");
                        string lastName = Console.ReadLine();
                        validator.ValidateLastName(lastName);
                        contact.SetField("LastName", lastName);
                        break;
                    case 3:
                        Console.WriteLine("Enter new Address");
                        string address = Console.ReadLine();
                        validator.ValidateAddress(address);
                        contact.SetField("Address", address);
                        break;
                    case 4:
                        Console.WriteLine("Enter new City");
                        string city = Console.ReadLine();
                        validator.ValidateCity(city);
                        contact.SetField("City", city);
                        break;
                    case 5:
                        Console.WriteLine("Enter new State");
                        string state = Console.ReadLine();
                        validator.ValidateState(state);
                        contact.SetField("State", state);
                        break;
                    case 6:
                        Console.WriteLine("Enter new Zip");
                        int zip = Convert.ToInt32(Console.ReadLine());
                        validator.ValidateZip(zip);
                        contact.SetField("Zip", zip);
                        break;
                    case 7:
                        Console.WriteLine("Enter new Email");
                        string email = Console.ReadLine();
                        validator.ValidateEmail(email);
                        contact.SetField("Email", email);
                        break;
                    case 8:
                        Console.WriteLine("Enter new Phone Number");
                        string phoneNumber = Console.ReadLine();
                        validator.ValidatePhoneNumber(phoneNumber);
                        contact.SetField("PhoneNumber", phoneNumber);
                        break;
                    default:
                        Console.WriteLine("Enter a valid choice");
                        break;
                }
            }
            catch (AddressBookCustomException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Views the data table.
        /// </summary>
        /// <param name="table">The table.</param>
        public void ViewDataTable(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    Console.Write(row[col].ToString() + "\t");
                }
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            }
        }

        /// <summary>
        /// Deletes the contact.
        /// </summary>
        /// <param name="table">The table.</param>
        public void DeleteContact(DataTable table)
        {
            Console.WriteLine("Enter first name which you want to delete");
            string firstName = Console.ReadLine();

            for (int i = table.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = table.Rows[i];
                if (dr["FirstName"].ToString() == firstName)
                    dr.Delete();
            }
            table.AcceptChanges();
        }
    }
}
