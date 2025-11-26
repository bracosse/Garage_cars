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

namespace WinFormsApp1
{
    public partial class CarForm : MetroFramework.Forms.MetroForm
    {
        public CarForm()
        {
            InitializeComponent();
        }

        public void ReadCar()
        {
            DataTable datable = new DataTable();

            datable.Columns.Add("CarId");
            datable.Columns.Add("CustID");
            datable.Columns.Add("CarName");
            datable.Columns.Add("Brand");
            datable.Columns.Add("Color");
            datable.Columns.Add("HorsePower");
            datable.Columns.Add("Issue");
            datable.Columns.Add("Fixed");

            var rep = new CarRep();
            var cars = rep.GetCar();

            foreach (var car in cars)
            {
                var row = datable.NewRow();
                row["CarId"] = car.CarId;
                row["CustID"] = car.CustID;
                row["CarName"] = car.CarName;
                row["Brand"] = car.Brand;
                row["Color"] = car.Color;
                row["HorsePower"] = car.HorsePower;
                row["Issue"] = car.Issue;
                row["Fixed"] = car.Fixed;

                datable.Rows.Add(row);
            }
            this.DtGCar.DataSource = datable;
        }

        public void FillComboboxCusto()
        {
            var rep = new CarRep();
            DataTable dt = rep.Fillcomboboxcustorep();

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "FirstName";
            comboBox1.ValueMember = "CustId";
            comboBox1.SelectedIndex = -1;
        }
        public void FillComboboxcar()
        {
            var rep = new CarRep();
            DataTable dt = rep.Fillcomboboxcarrep();

            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "FirstName";
            comboBox3.ValueMember = "CarId";
            comboBox3.SelectedIndex = -1;
        }
        public void FillComboboxFix()
        {
            var dtsource = new List<YesNo>();

            dtsource.Add(new YesNo() { Name = "Yes" });
            dtsource.Add(new YesNo() { Name = "No" });

            this.comboBox2.DataSource = dtsource;
            comboBox2.DisplayMember = "Name";
            comboBox2.SelectedIndex = -1;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            ReadCar();
            FillComboboxCusto();
            FillComboboxcar();
            FillComboboxFix();
        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            Base bse = new Base();
            bse.FormClosed += (s, args) => this.Close();
            this.Hide();
            bse.Show();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rep = new CarRep();
            if (comboBox3.SelectedIndex == -1) return;
            if (comboBox3.SelectedValue == null) return;

            int selectedId;
            if (!int.TryParse(comboBox3.SelectedValue.ToString(), out selectedId))
                return;

            var car = rep.SearchCar(selectedId);
            if (car != null)
            {
                comboBox1.Text = car.CustID.ToString();
                Namebox.Text = car.CarName;
                Brandbox.Text = car.Brand;
                ColorBox.Text = car.Color;
                HorsepowerBox.Text = car.HorsePower.ToString();
                Probox.Text = car.Issue;
                comboBox2.Text = car.Fixed;
            }
        }

        public void CreateCar()
        {
            Car car = new Car();
            var rep = new CarRep();
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid Customer.");
                return;
            }
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Is the car fixed?");
                return;
            }

            car.CustID = int.Parse(comboBox1.Text);
            car.CarName = this.Namebox.Text;
            car.Brand = this.Brandbox.Text;
            car.Color = this.ColorBox.Text;
            car.HorsePower = int.Parse(HorsepowerBox.Text);
            car.Issue = Probox.Text;
            car.Fixed = comboBox2.Text;

            rep.AddCar(car);
        }

        private void Btnaddemp_Click(object sender, EventArgs e)
        {
            CreateCar();
            ReadCar();
        }
        private void updateclick()
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Select a Car ID first");
                return;
            }

            int carId = (int)comboBox3.SelectedValue;


            var rep = new CarRep();


            var car = rep.SearchCar(carId);

            if (car == null)
            {
                MessageBox.Show("noe");
                return;
            }


            car.CustID = int.Parse(comboBox1.Text);
            car.CarName = this.Namebox.Text;
            car.Brand = this.Brandbox.Text;
            car.Color = this.ColorBox.Text;
            car.HorsePower = int.Parse(HorsepowerBox.Text);
            car.Issue = Probox.Text;
            car.Fixed = comboBox2.Text;


            rep.UpdateCar(car);

            MessageBox.Show("done");
        }
        private void BtnUpdateemp_Click(object sender, EventArgs e)
        {
            updateclick();
            ReadCar();
            FillComboboxCusto();
            FillComboboxcar();
        }



        public void RemoveCar()
        {
            try
            {
                var val = DtGCar.SelectedRows[0].Cells[0].Value.ToString();
                if (val == null) return;

                int carid = int.Parse(val);

                DialogResult DLR = MessageBox.Show("Are you sure", "delete", MessageBoxButtons.YesNo);
                if (DLR == DialogResult.No) return;
                var rep = new CarRep();
                rep.DeleteCaR(carid);
                MessageBox.Show("done");
            }
            catch (Exception e)
            {
                MessageBox.Show("Select a customer in the table below");
            }
        }
        private void Btndeleteemp_Click(object sender, EventArgs e)
        {
            RemoveCar();    
            ReadCar();
            FillComboboxcar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Searchingcst();
        }


        private void Searchingcst()
        {
            if (comboBox1.SelectedIndex == -1 || comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Select a customer");
                return;
            }

            if (!int.TryParse(comboBox1.SelectedValue.ToString(), out int selectedId))
            {
                MessageBox.Show("Wrong value entrance");
                return;
            }

            var rep = new CarRep();
            var cars = rep.SearchCarcst(selectedId); // NOW returns List<Car>

            if (cars == null || !cars.Any())
            {
                MessageBox.Show("No cars found for this customer.");
                return;
            }

            DataTable datable = new DataTable();
            datable.Columns.Add("CarId");
            datable.Columns.Add("CustID");
            datable.Columns.Add("CarName");
            datable.Columns.Add("Brand");
            datable.Columns.Add("Color");
            datable.Columns.Add("HorsePower");
            datable.Columns.Add("Issue");
            datable.Columns.Add("Fixed");

            foreach (var car in cars)
            {
                var row = datable.NewRow();
                row["CarId"] = car.CarId;
                row["CustID"] = car.CustID;
                row["CarName"] = car.CarName;
                row["Brand"] = car.Brand;
                row["Color"] = car.Color;
                row["HorsePower"] = car.HorsePower;
                row["Issue"] = car.Issue;
                row["Fixed"] = car.Fixed;

                datable.Rows.Add(row);
            }

            CarSearchForm csf = new CarSearchForm(datable);
            csf.Show();
        }

    }
}
