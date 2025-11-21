using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using WinFormsApp1.Models;

namespace WinFormsApp1.Repositories
{
    internal class EmployeeRep
    {
        private readonly string DBConnection = "Data Source=localhost\\sqlexpress;Initial Catalog=GarageDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        ///get
        public List<Employee> GetEmployee()
        {
            var employees = new List<Employee>();
            try
            {
                using(SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();

                    string SQLQuery = "select * from Employee order by id ASC";
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
                MessageBox.Show("error get");
            }
            return employees;
        }
        
        /// Search
        public Employee SearchEmployee(int id) 
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection))
                {
                    connection.Open();
                    string SqlQuery = "select * from Employee where EmpId=@EmpId";
                    using(SqlCommand command = new SqlCommand(SqlQuery, connection))
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
                    string SQLQuery = "INSERT INTO Employee (EmpId, FirstName, LastName, PhoneNumber, Email, Adress, ContractStart, ContractEnd) VALUES (@EmpId, @FirstName, @LastName, @PhoneNumber, @Email, @Adress, @ContractStart, @ContractEnd)";
                    using(SqlCommand command = new SqlCommand(SQLQuery, connection))
                    {
                        command.Parameters.AddWithValue("@EmpId", emp.EmpId);
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
                MessageBox.Show("Error Add");
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
                    string SQLQuery = "update Employee set FirstName=@FirstName, LastName=@LastName, PhoneNumber=@PhoneNumber, Email=@Email, Adress=@Adress, ContractStart=@ContractStart, ContractEnd=@ContractEnd) VALUES (@EmpId, @FirstName, @LastName, @PhoneNumber, @Email, @Adress, @ContractStart, @ContractEnd where EmpId=@EmpId";
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
                MessageBox.Show("Error Add");
            }
        }

        ///Delete
        public void DeleteClient(int id)
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
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }
    }
}
