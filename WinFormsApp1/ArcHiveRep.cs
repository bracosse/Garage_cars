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

        public int? SearchPart(int partId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();
                    string SQLQuery = "select Quantity from SparePart where PartID=@PartID";
                    using (SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        command.Parameters.AddWithValue("@PartID", partId);
                        object result = command.ExecuteScalar();
                        if (result != null)
                            return Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error searching part: " + e.Message);
            }
            return null;
        }

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

        public void UpdateQuality(int partId, int newQuantity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();
                    string SQLQuery = "update SparePart set Quantity=@Quantity where PartID=@PartID";
                    using (SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Quantity", newQuantity);
                        command.Parameters.AddWithValue("@PartID", partId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error updating part: " + e.Message);
            }
        }
    }
}
