using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories;

namespace WinFormsApp1
{
    public partial class EmpForm : MetroFramework.Forms.MetroForm
    {
        public EmpForm()
        {
            InitializeComponent();
        }
        public void ReadEmployee()
        {
            DataTable datable = new DataTable();

            datable.Columns.Add("EmpId");
            datable.Columns.Add("FirstName");
            datable.Columns.Add("LastName");
            datable.Columns.Add("PhoneNumber");
            datable.Columns.Add("Email");
            datable.Columns.Add("Adress");
            datable.Columns.Add("ContractStart");
            datable.Columns.Add("ContractEnd");

            var rep = new EmployeeRep();
            var employees = rep.GetEmployee();

            foreach (var employee in employees)
            {
                var row = datable.NewRow();
                row["EmpId"] = employee.EmpId;
                row["FirstName"] = employee.FirstName;
                row["LastName"] = employee.LastName;
                row["PhoneNumber"] = employee.PhoneNumber;
                row["Email"] = employee.Email;
                row["Adress"] = employee.Adress;
                row["ContractStart"] = employee.ContractStart;
                row["ContractEnd"] = employee.ContractEnd;

                datable.Rows.Add(row);
            }
            this.DGridEmp.DataSource = datable;
        }
        private void EmpForm_Load(object sender, EventArgs e)
        {
            ReadEmployee();
        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            Base bse = new Base();
            bse.FormClosed += (s, args) => this.Close();
            this.Hide();
            bse.Show();
        }
        private int EmploID = 7;
        public void CreateEmployee()
        {
            Employee employee = new Employee();

            //employee.EmpId = this.EmploID;
            employee.FirstName = this.textBox2.Text;
            employee.LastName = this.textBox3.Text;
            employee.PhoneNumber = int.Parse(textBox4.Text);
            employee.Email = this.textBox5.Text;
            employee.Adress = this.textBox6.Text;
            employee.ContractStart = DateTime.Parse(StartEmpdateTimePicker.Text);
            employee.ContractEnd = EndEmpdateTimePicker.Value;

            var rep = new EmployeeRep();
            rep.AddEmployee(employee);
        }
        private void Btnaddemp_Click(object sender, EventArgs e)
        {
            CreateEmployee();
            ReadEmployee();
        }
    }
}
