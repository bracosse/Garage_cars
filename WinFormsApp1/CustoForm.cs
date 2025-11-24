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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class CustoForm : MetroFramework.Forms.MetroForm
    {
        public CustoForm()
        {
            InitializeComponent();
        }

        public void ReadCustomer()
        {
            DataTable datable = new DataTable();

            datable.Columns.Add("CustId");
            datable.Columns.Add("FirstName");
            datable.Columns.Add("LastName");
            datable.Columns.Add("PhoneNumber");
            datable.Columns.Add("Email");
            datable.Columns.Add("Adress");
            datable.Columns.Add("ArrivalDate");
            datable.Columns.Add("ReturnDate");
            datable.Columns.Add("Assigned To Employee");

            var rep = new CustomerRep();
            var customers = rep.GetCustomer();

            foreach (var customer in customers)
            {
                var row = datable.NewRow();
                row["CustId"] = customer.CustId;
                row["FirstName"] = customer.FirstName;
                row["LastName"] = customer.LastName;
                row["PhoneNumber"] = customer.PhoneNumber;
                row["Email"] = customer.Email;
                row["Adress"] = customer.Adress;
                row["ArrivalDate"] = customer.ArrivalDate.ToString("yyyy-MM-dd");
                row["ReturnDate"] = customer.ReturnDate.ToString("yyyy-MM-dd");
                row["Assigned To Employee"] = customer.EmpID;

                datable.Rows.Add(row);
            }
            this.DGridCusto.DataSource = datable;
        }

        public void FillComboboxCusto()
        {
            var rep = new CustomerRep();
            DataTable dt = rep.Fillcomboboxcustorep();

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "FirstName";
            comboBox1.ValueMember = "CustId";
            comboBox1.SelectedIndex = -1;
        }
        public void FillComboboxEmp()
        {
            var rep = new CustomerRep();
            DataTable dt = rep.Fillcomboboxemprep();

            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "FirstName";
            comboBox2.ValueMember = "EmpId";
            comboBox2.SelectedIndex = -1;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rep = new CustomerRep();
            if (comboBox1.SelectedIndex == -1) return;
            if (comboBox1.SelectedValue == null) return;

            int selectedId;
            if (!int.TryParse(comboBox1.SelectedValue.ToString(), out selectedId))
                return;

            var custo = rep.SearchCustomer(selectedId);
            if (custo != null)
            {
                FNameBox.Text = custo.FirstName;
                LNameBox.Text = custo.LastName;
                PNBox.Text = custo.PhoneNumber.ToString();
                EMailBox.Text = custo.Email;
                ADressBox.Text = custo.Adress;
                ArrivalEmpdateTimePicker.Value = custo.ArrivalDate;
                ReturnEmpdateTimePicker.Value = custo.ReturnDate;
                comboBox2.Text = custo.EmpID.ToString();
            }
        }

        private void CustoForm_Load(object sender, EventArgs e)
        {
            ReadCustomer();
            FillComboboxCusto();
            FillComboboxEmp();
        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            Base bse = new Base();
            bse.FormClosed += (s, args) => this.Close();
            this.Hide();
            bse.Show();
        }

        public void CreateCustomer()
        {
            Customer customer = new Customer();
            var rep = new CustomerRep();
            if (!int.TryParse(PNBox.Text, out int phone))
            {
                MessageBox.Show("Invalid phone number.");
                return;
            }
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid employee.");
                return;
            }

            customer.FirstName = this.FNameBox.Text;
            customer.LastName = this.LNameBox.Text;
            customer.PhoneNumber = int.Parse(PNBox.Text);
            customer.Email = this.EMailBox.Text;
            customer.Adress = this.ADressBox.Text;
            customer.ArrivalDate = DateTime.Parse(ArrivalEmpdateTimePicker.Text);
            customer.ReturnDate = ReturnEmpdateTimePicker.Value;
            customer.EmpID = int.Parse(comboBox2.Text);

            object exist = rep.CustomerExist(customer.FirstName, customer.PhoneNumber, customer.ArrivalDate);
            if (exist != null)
            {
                MessageBox.Show("Customer already exists");
                return;
            }
            else
            {
                rep.AddCustomer(customer);
            }
        }
        private void Btnaddemp_Click(object sender, EventArgs e)
        {
            CreateCustomer();
            FillComboboxCusto();
            ReadCustomer();
        }
        private void updateclick()
        {

            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Select a customer ID first");
                return;
            }

            int custoId = (int)comboBox1.SelectedValue;


            var rep = new CustomerRep();


            var custo = rep.SearchCustomer(custoId);

            if (custo == null)
            {
                MessageBox.Show("noe");
                return;
            }


            custo.FirstName = FNameBox.Text;
            custo.LastName = LNameBox.Text;
            custo.PhoneNumber = Convert.ToInt32(PNBox.Text);
            custo.Email = EMailBox.Text;
            custo.Adress = ADressBox.Text;
            custo.ArrivalDate = ArrivalEmpdateTimePicker.Value;
            custo.ReturnDate = ReturnEmpdateTimePicker.Value;
            custo.EmpID = int.Parse(comboBox2.Text);


            rep.UpdateCustomer(custo);

            MessageBox.Show("done");
        }
        private void BtnUpdateemp_Click(object sender, EventArgs e)
        {
            updateclick();
            ReadCustomer();
        }

        public void RemoveCustomer()
        {
            try
            {
                var val = DGridCusto.SelectedRows[0].Cells[0].Value.ToString();
                if (val == null) return;

                int customerid = int.Parse(val);

                DialogResult DLR = MessageBox.Show("Are you sure", "delete", MessageBoxButtons.YesNo);
                if (DLR == DialogResult.No) return;
                var rep = new CustomerRep();
                rep.DeleteEmployee(customerid);
                MessageBox.Show("done");
                ReadCustomer();
                FillComboboxCusto();
            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e);
            }
        }
        private void Btndeleteemp_Click(object sender, EventArgs e)
        {
            RemoveCustomer();
            ReadCustomer();
        }

        public void Searching()
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Enter a Customer Id first");
                return;
            }
            int custoId;
            if(!int.TryParse(comboBox1.Text ,out custoId))
            {
                MessageBox.Show("Invalid Data Entrance");
                return;
            }

            var rep = new CustomerRep();
            var cst = rep.SearchCustomer(custoId);
            if(cst == null)
            {
                MessageBox.Show("Customer Not Found");
                return;
            }
            FNameBox.Text = cst.FirstName;
            LNameBox.Text = cst.LastName;
            PNBox.Text = cst.PhoneNumber.ToString();
            EMailBox.Text = cst.Email;
            ADressBox.Text = cst.Adress;
            ArrivalEmpdateTimePicker.Value = cst.ArrivalDate;
            ReturnEmpdateTimePicker.Value = cst.ReturnDate;
            comboBox2.Text = cst.EmpID.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Searching();
        }
    }
}
