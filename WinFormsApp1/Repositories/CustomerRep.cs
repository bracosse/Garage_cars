using Azure.Identity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WinFormsApp1.Models;

namespace WinFormsApp1.Repositories
{
    internal class CustomerRep
    {
        private readonly string DBConnection = "Data Source=localhost\\sqlexpress;Initial Catalog=GarageDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";



        public DataTable Fillcomboboxcustorep()
        {
            using(SqlConnection connection = new SqlConnection(DBConnection))
            {
                connection.Open();
                string SQLQuery = "select CustId from Customer";
                using(SqlCommand command = new SqlCommand(SQLQuery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable Fillcomboboxemprep()
        {
            using (SqlConnection connection = new SqlConnection(DBConnection))
            {
                connection.Open();
                string SQLQuery = "select EmpId from Employee";
                using(SqlCommand command = new SqlCommand(SQLQuery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public List<Customer> GetCustomer()
        {
            var customers = new List<Customer>();
            try
            {
                using(SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();

                    string SQLQuery = "select * from Customer order by CustId ASC";
                    using (SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var customer = new Customer();
                                customer.CustId = reader.GetInt32(0);
                                customer.FirstName = reader.GetString(1);
                                customer.LastName = reader.GetString(2);
                                customer.PhoneNumber = reader.GetInt32(3);
                                customer.Email = reader.GetString(4);
                                customer.Adress = reader.GetString(5);
                                customer.ArrivalDate = reader.GetDateTime(6);
                                customer.ReturnDate = reader.GetDateTime(7);
                                customer.EmpID = reader.GetInt32(8);

                                customers.Add(customer);
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Error get " + e);
            }
            return customers;
        }


        public Customer? SearchCustomer(int id)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();
                    string SQLQuery = "select * from Customer where CustId=@CustId";
                    using(SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CustId", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var customer = new Customer();
                                customer.CustId = reader.GetInt32(0);
                                customer.FirstName = reader.GetString(1);
                                customer.LastName = reader.GetString(2);
                                customer.PhoneNumber = reader.GetInt32(3);
                                customer.Email = reader.GetString(4);
                                customer.Adress = reader.GetString(5);
                                customer.ArrivalDate = reader.GetDateTime(6);
                                customer.ReturnDate = reader.GetDateTime(7);
                                customer.EmpID = reader.GetInt32(8);

                                return customer;
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


        public void AddCustomer(Customer cst)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();
                    string SQLQuery = "insert into Customer ( FirstName, LastName, PhoneNumber, Email, Adress, ArrivalDate, ReturnDate, EmpID) values (@FirstName, @LastName, @PhoneNumber, @Email, @Adress, @ArrivalDate, @ReturnDate, @EmpID)";
                    using(SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", cst.FirstName);
                        command.Parameters.AddWithValue("@LastName", cst.LastName);
                        command.Parameters.AddWithValue("@PhoneNumber", cst.PhoneNumber);
                        command.Parameters.AddWithValue("@Email", cst.Email);
                        command.Parameters.AddWithValue("@Adress", cst.Adress);
                        command.Parameters.AddWithValue("@ArrivalDate", cst.ArrivalDate);
                        command.Parameters.AddWithValue("@ReturnDate", cst.ReturnDate);
                        command.Parameters.AddWithValue("@EmpID", cst.EmpID);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Add " + e);
            }
        }


        public void UpdateCustomer(Customer cst)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();
                    string SQLQuery = "update Customer set FirstName=@FirstName, LastName=@LastName, PhoneNumber=@PhoneNumber, Email=@Email, Adress=@Adress, ArrivalDate=@ArrivalDate, ReturnDate=@ReturnDate, EmpID=@EmpID where CustId=@CustId";
                    using (SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", cst.FirstName);
                        command.Parameters.AddWithValue("@LastName", cst.LastName);
                        command.Parameters.AddWithValue("@PhoneNumber", cst.PhoneNumber);
                        command.Parameters.AddWithValue("@Email", cst.Email);
                        command.Parameters.AddWithValue("@Adress", cst.Adress);
                        command.Parameters.AddWithValue("@ArrivalDate", cst.ArrivalDate);
                        command.Parameters.AddWithValue("@ReturnDate", cst.ReturnDate);
                        command.Parameters.AddWithValue("@EmpID", cst.EmpID);
                        command.Parameters.AddWithValue("@CustId", cst.CustId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Update " + e);
            }
        }


        public void DeleteEmployee(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();
                    string SQLQuery = "delete from Customer where CustId=@CustId";

                    using (SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CustId", id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
            }
        }

        public object CustomerExist(string fname, int pnumber, DateTime aridate)
        {
            using(SqlConnection connection = new SqlConnection(DBConnection))
            {
                connection.Open();
                string SQLQuery = "select * from Customer where FirstName=@FirstName and PhoneNumber=PhoneNumber and ArrivalDate=@ArrivalDate";
                using(SqlCommand command = new SqlCommand(SQLQuery, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", fname);
                    command.Parameters.AddWithValue("@PhoneNumber", pnumber);
                    command.Parameters.AddWithValue("@ArrivalDate", aridate);

                    return command.ExecuteScalar();
                }
            }
        }
    }
}
