using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Repositories
{
    internal class SparePartRep
    {
        private readonly string DBConnection = "Data Source=localhost\\sqlexpress;Initial Catalog=GarageDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";


        public DataTable Fillcomboboxpartrep()
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



        public List<SparePart> GetPart()
        {
            var parts = new List<SparePart>();
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();

                    string SQLQuery = "select * from SparePart order by PartID ASC";
                    using (SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var part = new SparePart();
                                part.PartID = reader.GetInt32(0);
                                part.PartName = reader.GetString(1);
                                part.PartProvider = reader.GetString(2);
                                part.Quantity = reader.GetInt32(3);
                                part.Price = reader.GetInt32(4);

                                parts.Add(part);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error get " + e);
            }
            return parts;
        }


        public SparePart? SearchPart(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();
                    string SQLQuery = "select * from SparePart where PartID=@PartID";
                    using (SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        command.Parameters.AddWithValue("@PartID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var part = new SparePart();
                                part.PartID = reader.GetInt32(0);
                                part.PartName = reader.GetString(1);
                                part.PartProvider = reader.GetString(2);
                                part.Quantity = reader.GetInt32(3);
                                part.Price = reader.GetInt32(4);

                                return part;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error search " + e);
            }
            return null;
        }


        public void AddPart(SparePart part)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();
                    string SQLQuery = "insert into SparePart (PartName, PartProvider, Quantity, Price) VALUES (@PartName, @PartProvider, @Quantity, @Price)";
                    using (SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        command.Parameters.AddWithValue("@PartName", part.PartName);
                        command.Parameters.AddWithValue("@PartProvider", part.PartProvider);
                        command.Parameters.AddWithValue("@Quantity", part.Quantity);
                        command.Parameters.AddWithValue("@Price", part.Price);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Add " + e);
            }
        }


        public void UpdatePart(SparePart part)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();
                    string SQLQuery = "update SparePart set PartName=@PartName, PartProvider=@PartProvider, Quantity=@Quantity, Price=@Price where PartID=@PartID";
                    using (SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        command.Parameters.AddWithValue("@PartName", part.PartName);
                        command.Parameters.AddWithValue("@PartProvider", part.PartProvider);
                        command.Parameters.AddWithValue("@Quantity", part.Quantity);
                        command.Parameters.AddWithValue("@Price", part.Price);
                        command.Parameters.AddWithValue("@PartID", part.PartID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Update " + e);
            }
        }


        public void DeleteParT(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();
                    string SQLQuery = "delete from SparePart where PartID=@PartID";

                    using (SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        command.Parameters.AddWithValue("@PartID", id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
            }
        }
    }
}