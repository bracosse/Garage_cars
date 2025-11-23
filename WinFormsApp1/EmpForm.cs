using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public void FillComboBox()
        {
            var rep = new EmployeeRep();
            DataTable dt = rep.FillComboboxrep();

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "FirstName";
            comboBox1.ValueMember = "EmpId";
            comboBox1.SelectedIndex = -1;
        }
        private void EmpForm_Load(object sender, EventArgs e)
        {
            FillComboBox();
            ReadEmployee();
        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            Base bse = new Base();
            bse.FormClosed += (s, args) => this.Close();
            this.Hide();
            bse.Show();
        }


        ///Create
        public void CreateEmployee()
        {
            Employee employee = new Employee();
            var rep = new EmployeeRep();

            employee.FirstName = this.textBox2.Text;
            employee.LastName = this.textBox3.Text;
            employee.PhoneNumber = int.Parse(textBox4.Text);
            employee.Email = this.textBox5.Text;
            employee.Adress = this.textBox6.Text;
            employee.ContractStart = DateTime.Parse(StartEmpdateTimePicker.Text);
            employee.ContractEnd = EndEmpdateTimePicker.Value;



            object exists = rep.EmployeeExist(employee.Email, employee.PhoneNumber);
            if (exists != null)
            {
                MessageBox.Show("Seems like this employee exists already");
                return;
            }
            else
            {
                rep.AddEmployee(employee);
                FillComboBox();
            }
        }
        private void Btnaddemp_Click(object sender, EventArgs e)
        {
            CreateEmployee();
            ReadEmployee();
        }



        ///Update
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rep = new EmployeeRep();
            if (comboBox1.SelectedIndex == -1) return;
            if (comboBox1.SelectedValue == null) return;

            int selectedId;
            if (!int.TryParse(comboBox1.SelectedValue.ToString(), out selectedId))
                return;

            var emp = rep.SearchEmployee(selectedId);
            if (emp != null)
            {
                textBox2.Text = emp.FirstName;
                textBox3.Text = emp.LastName;
                textBox4.Text = emp.PhoneNumber.ToString();
                textBox5.Text = emp.Email;
                textBox6.Text = emp.Adress;
                StartEmpdateTimePicker.Value = emp.ContractStart;
                EndEmpdateTimePicker.Value = emp.ContractEnd;
            }
        }

        private void updateclick()
        {

            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Select an employee ID first");
                return;
            }

            int empId = (int)comboBox1.SelectedValue;


            var rep = new EmployeeRep();


            var emp = rep.SearchEmployee(empId);

            if (emp == null)
            {
                MessageBox.Show("noe");
                return;
            }


            emp.FirstName = textBox2.Text;
            emp.LastName = textBox3.Text;
            emp.PhoneNumber = Convert.ToInt32(textBox4.Text);
            emp.Email = textBox5.Text;
            emp.Adress = textBox6.Text;
            emp.ContractStart = StartEmpdateTimePicker.Value;
            emp.ContractEnd = EndEmpdateTimePicker.Value;


            rep.UpdateEmployee(emp);

            MessageBox.Show("done");
        }

        private void BtnUpdateemp_Click(object sender, EventArgs e)
        {
            updateclick();
            ReadEmployee();
        }


        ///Delete
        public void removeGrid()
        {
            var val = this.DGridEmp.SelectedRows[0].Cells[0].Value.ToString();

            if (val == null) return;

            int employeeid = Convert.ToInt32(val);

            DialogResult DLR = MessageBox.Show("are you sure", "delete", MessageBoxButtons.YesNo);
            if (DLR == DialogResult.No)
            {
                return;
            }
            var rep = new EmployeeRep();
            rep.DeleteEmployee(employeeid);
            MessageBox.Show("done ");
            ReadEmployee();
            FillComboBox();
        }
        //public void removeBox()
        //{
        //    var vat = this.comboBox1.SelectedValue;

        //    if (vat == null) return;

        //    int employeeid = Convert.ToInt32(vat);

        //    DialogResult DLR = MessageBox.Show("are you sure", "delete", MessageBoxButtons.YesNo);
        //    if (DLR == DialogResult.No)
        //    {
        //        return;
        //    }
        //    var rep = new EmployeeRep();
        //    rep.DeleteEmployee(employeeid);
        //    MessageBox.Show("done ");
        //    ReadEmployee();
        //    FillComboBox();
        //}
        private void Btndeleteemp_Click(object sender, EventArgs e)
        {
            //removeBox();
            removeGrid();

        }


        private void DGridEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0) return;

            //var row = DGridEmp.Rows[e.RowIndex];

            //string GetValue(int index)
            //{
            //    var v = row.Cells[index].Value;
            //    return (v == null || v == DBNull.Value) ? "" : v.ToString();
            //}

            //// Fill ComboBox
            //comboBox1.DataSource = null;
            //comboBox1.Items.Clear();
            //comboBox1.Items.Add(GetValue(0));
            //comboBox1.SelectedIndex = 0;

            //// Fill TextBoxes
            //textBox2.Text = GetValue(1);
            //textBox3.Text = GetValue(2);
            //textBox4.Text = GetValue(3);
        }


        ///Search

        public void Searching()
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Please enter an Employee ID.");
                return;
            }

           
            int empId;
            if (!int.TryParse(comboBox1.Text, out empId))
            {
                MessageBox.Show("Invalid Employee ID.");
                return;
            }

            // Search employee
            var rep = new EmployeeRep();
            var emp = rep.SearchEmployee(empId);

            if (emp == null)
            {
                MessageBox.Show("Employee not found.");
                return;
            }

            textBox2.Text = emp.FirstName;
            textBox3.Text = emp.LastName;
            textBox4.Text = emp.PhoneNumber.ToString();
            textBox5.Text = emp.Email;
            textBox6.Text = emp.Adress;
            StartEmpdateTimePicker.Value = emp.ContractStart;
            EndEmpdateTimePicker.Value = emp.ContractEnd;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Searching();
        }
    }
}
