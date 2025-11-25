using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Repositories
{
    internal class CarRep
    {
        private readonly string DBConnection = "Data Source=localhost\\sqlexpress;Initial Catalog=GarageDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";


        public DataTable Fillcomboboxcustorep()
        {
            using (SqlConnection connection = new SqlConnection(DBConnection))
            {
                connection.Open();
                string SQLQuery = "select CustId from Customer";
                using (SqlCommand command = new SqlCommand(SQLQuery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

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
        public List<Car> GetCar()
        {
            var cars = new List<Car>();
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();

                    string SQLQuery = "select * from Car order by CarId ASC";
                    using (SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var car = new Car();
                                car.CarId = reader.GetInt32(0);
                                car.CustID = reader.GetInt32(1);     
                                car.CarName = reader.GetString(2);
                                car.Brand = reader.GetString(3);
                                car.Color = reader.GetString(4);
                                car.HorsePower = reader.GetInt32(5);
                                car.Issue = reader.GetString(6);
                                car.Fixed = reader.GetString(7);

                                cars.Add(car);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error get " + e);
            }
            return cars;
        }


        public Car? SearchCar(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();
                    string SQLQuery = "select * from Car where CarId=@CarId";
                    using (SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CarId", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var car = new Car();
                                car.CarId = reader.GetInt32(0);
                                car.CustID = reader.GetInt32(1);
                                car.CarName = reader.GetString(2);
                                car.Brand = reader.GetString(3);
                                car.Color = reader.GetString(4);
                                car.HorsePower = reader.GetInt32(5);
                                car.Issue = reader.GetString(6);
                                car.Fixed = reader.GetString(7);

                                return car;
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


        public void AddCar(Car car)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();
                    string SQLQuery = "insert into Car (CustID, CarName, Brand, Color, HorsePower, Issue, Fixed) VALUES (@CustID, @CarName, @Brand, @Color, @HorsePower, @Issue, @Fixed)";
                    using (SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CustID", car.CustID);
                        command.Parameters.AddWithValue("@CarName", car.CarName);
                        command.Parameters.AddWithValue("@Brand", car.Brand);
                        command.Parameters.AddWithValue("@Color", car.Color);
                        command.Parameters.AddWithValue("@HorsePower", car.HorsePower);
                        command.Parameters.AddWithValue("@Issue", car.Issue);
                        command.Parameters.AddWithValue("@Fixed", car.Fixed);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Add " + e);
            }
        }


        public void UpdateCar(Car car)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();
                    string SQLQuery = "update Car set CustID=@CustID, CarName=@CarName, Brand=@Brand, Color=@Color, HorsePower=@HorsePower, Issue=@Issue, Fixed=@Fixed where CarId=@CarId";
                    using (SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CustID", car.CustID);
                        command.Parameters.AddWithValue("@CarName", car.CarName);
                        command.Parameters.AddWithValue("@Brand", car.Brand);
                        command.Parameters.AddWithValue("@Color", car.Color);
                        command.Parameters.AddWithValue("@HorsePower", car.HorsePower);
                        command.Parameters.AddWithValue("@Issue", car.Issue);
                        command.Parameters.AddWithValue("@Fixed", car.Fixed);
                        command.Parameters.AddWithValue("@CarId", car.CarId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Update " + e);
            }
        }


        public void DeleteCaR(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();
                    string SQLQuery = "delete from Car where CarId=@CarId";

                    using (SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CarId", id);

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
