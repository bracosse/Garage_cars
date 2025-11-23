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
    internal class EmployeeRep
    {
        private readonly string DBConnection = "Data Source=localhost\\sqlexpress;Initial Catalog=GarageDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";


        public DataTable FillComboboxrep()
        {
            using (SqlConnection connection = new SqlConnection(DBConnection))
            {
                connection.Open();
                string query = "SELECT EmpId FROM Employee"; // Only IDs
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }


        ///get
        public List<Employee> GetEmployee()
        {
            var employees = new List<Employee>();
            try
            {
                using(SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();

                    string SQLQuery = "select * from Employee order by EmpId ASC";
                    using(SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var employee = new Employee();
                                employee.EmpId = reader.GetInt32(0);
                                employee.FirstName = reader.GetString(1);
                                employee.LastName = reader.GetString(2);
                                employee.PhoneNumber = reader.GetInt32(3);
                                employee.Email = reader.GetString(4);
                                employee.Adress = reader.GetString(5);
                                employee.ContractStart = reader.GetDateTime(6);
                                employee.ContractEnd = reader.GetDateTime(7);

                                employees.Add(employee);
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("error get" + e);
            }
            return employees;
        }
        
        /// Search
        public Employee? SearchEmployee(int id) 
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();
                    string SqlQuery = "select * from Employee where EmpId=@EmpId";
                    using(SqlCommand command = new SqlCommand(SqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@EmpId", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var employee = new Employee();
                                employee.EmpId = reader.GetInt32(0);
                                employee.FirstName = reader.GetString(1);
                                employee.LastName = reader.GetString(2);
                                employee.PhoneNumber = reader.GetInt32(3);
                                employee.Email = reader.GetString(4);
                                employee.Adress = reader.GetString(5);
                                employee.ContractStart = reader.GetDateTime(6);
                                employee.ContractEnd = reader.GetDateTime(7);

                                return employee;

                            } 
                        }
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Error search");
            }
            return null;
        }
        
        ///ADD
        public void AddEmployee(Employee emp)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();
                    string SQLQuery = "INSERT INTO Employee (FirstName, LastName, PhoneNumber, Email, Adress, ContractStart, ContractEnd) VALUES (@FirstName, @LastName, @PhoneNumber, @Email, @Adress, @ContractStart, @ContractEnd)";
                    using(SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        //command.Parameters.AddWithValue("@EmpId", emp.EmpId);
                        command.Parameters.AddWithValue("@FirstName", emp.FirstName);
                        command.Parameters.AddWithValue("@LastName", emp.LastName);
                        command.Parameters.AddWithValue("@PhoneNumber", emp.PhoneNumber);
                        command.Parameters.AddWithValue("@Email", emp.Email);
                        command.Parameters.AddWithValue("@Adress", emp.Adress);
                        command.Parameters.AddWithValue("@ContractStart", emp.ContractStart);
                        command.Parameters.AddWithValue("@ContractEnd", emp.ContractEnd);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Add" + e);
            }
        }

        ///Update
        public void UpdateEmployee(Employee emp)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();
                    string SQLQuery = "update Employee set FirstName=@FirstName, LastName=@LastName, PhoneNumber=@PhoneNumber, Email=@Email, Adress=@Adress, ContractStart=@ContractStart, ContractEnd=@ContractEnd where EmpId=@EmpId";
                    using (SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", emp.FirstName);
                        command.Parameters.AddWithValue("@LastName", emp.LastName);
                        command.Parameters.AddWithValue("@PhoneNumber", emp.PhoneNumber);
                        command.Parameters.AddWithValue("@Email", emp.Email);
                        command.Parameters.AddWithValue("@Adress", emp.Adress);
                        command.Parameters.AddWithValue("@ContractStart", emp.ContractStart);
                        command.Parameters.AddWithValue("@ContractEnd", emp.ContractEnd);
                        command.Parameters.AddWithValue("@EmpId", emp.EmpId);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                ;
            }
        }

        ///Delete
        public void DeleteEmployee(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();
                    string sql = "delete from Employee where EmpId=@EmpId";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@EmpId", id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
            }
        }
        public object EmployeeExist(string email, int phonenumer)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection))
            {
                connection.Open();
                string SQLquery = "Select * from Employee where Email = @Email and PhoneNumber = @PhoneNumber";
                using (SqlCommand command = new SqlCommand(SQLquery, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PhoneNumber", phonenumer);

                    return command.ExecuteScalar();
                }
            }
        }
    }
}
