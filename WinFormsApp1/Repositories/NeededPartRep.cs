using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Repositories
{
    internal class NeededPartRep
    {
        private readonly string DBConnection = "Data Source=localhost\\sqlexpress;Initial Catalog=GarageDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public DataTable Fillcomboboxcarrep()
        {
            using (SqlConnection connection = new SqlConnection(DBConnection))
            {
                connection.Open();
                string SQLQuery = "select CarId from Car";
                using (SqlCommand command = new SqlCommand(SQLQuery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable Fillcomboboxapartrep()
        {
            using (SqlConnection connection = new SqlConnection(DBConnection))
            {
                connection.Open();
                string SQLQuery = "select PartID from SparePart";
                using (SqlCommand command = new SqlCommand(SQLQuery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public int GetPartQuantity(int partId)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection))
            {
                connection.Open();
                string query = "select Quantity from SparePart where PartID = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", partId);
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public (string PartName, string PartProvider, int Price) GetPartInfo(int partId)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection))
            {
                connection.Open();
                string query = "select PartName, PartProvider, Price from SparePart where PartID = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", partId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (reader["PartName"].ToString(), reader["PartProvider"].ToString(), int.Parse(reader["Price"].ToString()));
                        }
                        else
                        {
                            return (string.Empty, string.Empty, 0);
                        }
                    }
                }
            }
        }

        public (string FirstName, string LastName, int EmpId) GetCustInfo(int CarID)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection))
            {
                connection.Open();
                string query = "select c.FirstName, c.LastName, c.EmpID from Customer c join Car ca on ca.CustID = c.CustId where ca.CarId = @Carid";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Carid", CarID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (reader["FirstName"].ToString(), reader["LastName"].ToString(), int.Parse(reader["EmpId"].ToString()));
                        }
                        else
                        {
                            return ("last name ","last name", 0);
                        }
                    }
                }

            }
        }
    }
}