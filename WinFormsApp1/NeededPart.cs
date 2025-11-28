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
    public partial class NeededPart : MetroFramework.Forms.MetroForm
    {
        public NeededPart()
        {
            InitializeComponent();
        }

        public void FillComboboxcar()
        {
            var rep = new NeededPartRep();
            DataTable dt = rep.Fillcomboboxcarrep();

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "CarName";
            comboBox1.ValueMember = "CarId";
            comboBox1.SelectedIndex = -1;
        }
        public void FillComboboxpart()
        {
            var rep = new NeededPartRep();
            DataTable dt = rep.Fillcomboboxapartrep();

            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "PartName";
            comboBox2.ValueMember = "PartID";
            comboBox2.SelectedIndex = -1;
        }
        //public void FillComboboxqty()
        //{
        //    var rep = new NeededPartRep();
        //    DataTable dt = rep.Fillcomboboxcarrep();

        //    comboBox1.DataSource = dt;
        //    comboBox1.DisplayMember = "Quantity";
        //    comboBox1.ValueMember = "Quantity";
        //    comboBox1.SelectedIndex = -1;
        //}
        private void NeededPart_Load(object sender, EventArgs e)
        {
            FillComboboxcar();
            FillComboboxpart();
            //FillComboboxqty();
        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            Base bse = new Base();
            bse.FormClosed += (s, args) => this.Close();
            this.Hide();
            bse.Show();
        }




        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox2.SelectedIndex == -1)
                return;
            if (comboBox2.SelectedValue == null || comboBox2.SelectedValue is DataRowView)
                return;

            int partId = Convert.ToInt32(comboBox2.SelectedValue);

            NeededPartRep rep = new NeededPartRep();
            int maxQty = rep.GetPartQuantity(partId);

            comboBox3.Items.Clear();

            for (int i = 1; i <= maxQty; i++)
            {
                comboBox3.Items.Add(i);
            }

            var name = rep.GetPartInfo(partId);
            label8.Text = name.PartName;
            label9.Text = name.PartProvider;
            label11.Text = name.Price.ToString();


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int total = int.Parse(label11.Text) * int.Parse(comboBox3.Text);
                label12.Text = total.ToString() + " Dhs";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill the values");
            }
        }
        public void finalprice()
        {
            string labelText = new string(label12.Text.Where(char.IsDigit).ToArray());

            int labelValue = 0;
            int handValue = 0;

            int.TryParse(labelText, out labelValue);
            int.TryParse(HandBox.Text, out handValue);

            int total = labelValue + handValue;
            label15.Text = total.ToString() + " Dhs";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1 || HandBox.Text == null)
            {
                MessageBox.Show("Fill the values");
            }
            finalprice();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            int carId = 0;

            if (comboBox1.SelectedValue is DataRowView drv)
            {
                carId = Convert.ToInt32(drv["CarId"]);
            }
            else if (comboBox1.SelectedValue != null)
            {
                carId = Convert.ToInt32(comboBox1.SelectedValue);
            }

            var rep = new NeededPartRep();
            var inf = rep.GetCustInfo(carId);
            label13.Text = inf.FirstName;
            label7.Text = inf.LastName;
            label5.Text = inf.EmpId.ToString();
        }
    }
}
