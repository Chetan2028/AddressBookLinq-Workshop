using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

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

            table.Rows.Add("Chetan", "Malagoudar", "Mahantesh Nagar", "Belgaum", "Karnataka", 590016, "8951604950", "bmchetan2028@gmail.com");
            table.Rows.Add("Pranav", "Mare", "Chinchwad", "Pune", "Maharastra", 568916, "7412589635", "pranavmare@gmail.com");
            table.Rows.Add("Ibraheem", "Khaleel", "sector-12", "Wayand", "Kerala", 595716, "9632147857", "ibraheemkhaleel@gmail.com");
            table.Rows.Add("Shiva", "Reddy", "Ameerpet", "Hyderabad", "Telangana", 597516, "963214785", "shivareddy8@gmail.com");
            table.Rows.Add("Abhilash", "Itnal", "Near RedFort", "Chandini Chowk", "New Delhi", 594316, "9632145875", "abhilashitnal@gmail.com");
            table.Rows.Add("Ameysingh", "Rajput", "MG Road", "Surat", "Gujarat", 518016, "8523691475", "ameyrajput@gmail.com");
        }

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
    }
}
