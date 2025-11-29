using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    internal class ArcHiveRep
    {
        private readonly string DBConnection = "Data Source=localhost\\sqlexpress;Initial Catalog=GarageDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";


        public void AddToArchive(Archive Arc)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();
                    string SQLQuery = "insert into Archive (EmployeeID, CustomerID, FirstName, LastName, CarID, Issue, PartName, PartProvider, Quantity, ServicePrice, FinalPrice) VALUES (@EmployeeID, @CustomerID, @FirstName, @LastName, @CarID, @Issue, @PartName, @PartProvider, @Quantity, @ServicePrice, @FinalPrice)";
                    using (SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", Arc.EmployeeID);
                        command.Parameters.AddWithValue("@CustomerID", Arc.CustomerID);
                        command.Parameters.AddWithValue("@FirstName", Arc.FirstName);
                        command.Parameters.AddWithValue("@LastName", Arc.LastName);
                        command.Parameters.AddWithValue("@CarID", Arc.CarID);
                        command.Parameters.AddWithValue("@Issue", Arc.Issue);
                        command.Parameters.AddWithValue("@PartName", Arc.PartName);
                        command.Parameters.AddWithValue("@PartProvider", Arc.PartProvider);
                        command.Parameters.AddWithValue("@Quantity", Arc.Quantity);
                        command.Parameters.AddWithValue("@ServicePrice", Arc.ServicePrice);
                        command.Parameters.AddWithValue("@FinalPrice", Arc.FinalPrice);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Add " + e);
            }
        }
    }
}
