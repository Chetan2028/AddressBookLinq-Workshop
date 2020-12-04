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
        }
    }
}
