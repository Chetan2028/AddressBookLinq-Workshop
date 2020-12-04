using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookLinq_Workshop
{
    public class AddressBookManagement
    {
        /// <summary>
        /// UC2
        /// Adds the data to table.
        /// </summary>
        /// <param name="table">The table.</param>
        public void AddDataToTable(DataTable table)
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
            table.Rows.Add("Ibraheem", "Khaleel", "Near Wayand park", "Wayand", "Kerala", 595716, "9632147857", "ibraheemkhaleel@gmail.com");
            table.Rows.Add("Shiva", "Reddy", "Ameerpet", "Hyderabad", "Telangana", 597516, "963214785", "shivareddy8@gmail.com");
            table.Rows.Add("Abhilash", "Itnal", "Near Chandini Chowk", "Chandini Chowk", "New Delhi", 594316, "9632145875", "abhilashitnal@gmail.com");
            table.Rows.Add("Ameysingh", "Rajput", "MG Road", "Surat", "Gujarat", 518016, "8523691475", "ameyrajput@gmail.com");
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
            }
        }
    }
}
