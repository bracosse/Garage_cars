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
    public partial class PartsForm : MetroFramework.Forms.MetroForm
    {
        public PartsForm()
        {
            InitializeComponent();
        }


        public void FillComboboxPart()
        {
            var rep = new SparePartRep();
            DataTable dt = rep.Fillcomboboxpartrep();

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "PartID";
            comboBox1.ValueMember = "PartID";
            comboBox1.SelectedIndex = -1;
        }

        public void ReadParT()
        {
            DataTable datable = new DataTable();

            datable.Columns.Add("PartID");
            datable.Columns.Add("PartName");
            datable.Columns.Add("PartProvider");
            datable.Columns.Add("Quantity");
            datable.Columns.Add("Price");
            datable.Columns.Add("Total Parts Amount");

            var rep = new SparePartRep();
            var parts = rep.GetPart();

            foreach (var part in parts)
            {
                var row = datable.NewRow();
                float total = part.Quantity * part.Price;
                row["PartID"] = part.PartID;
                row["PartName"] = part.PartName;
                row["PartProvider"] = part.PartProvider;
                row["Quantity"] = part.Quantity;
                row["Price"] = part.Price;
                row["Total Parts Amount"] = total;

                datable.Rows.Add(row);
            }
            this.DtGPart.DataSource = datable;
        }
        private void PartsForm_Load(object sender, EventArgs e)
        {
            ReadParT();
            FillComboboxPart();
        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            Base bse = new Base();
            bse.FormClosed += (s, args) => this.Close();
            this.Hide();
            bse.Show();
        }


        public void CreatePart()
        {
            try
            {
                SparePart part = new SparePart();
                var rep = new SparePartRep();

                part.PartName = this.Namebox.Text;
                part.PartProvider = this.ProviderBox.Text;
                part.Quantity = int.Parse(QtyBoX.Text);
                part.Price = int.Parse(PriCeBox.Text);

                rep.AddPart(part);

                MessageBox.Show("Added");
            }
            catch(Exception e)
            {
                MessageBox.Show("Enter the correct data first");
            }
        }

        private void Btnaddemp_Click(object sender, EventArgs e)
        {
            CreatePart();
            FillComboboxPart();
            ReadParT();
        }



        private void updatePart()
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Select a Part ID first");
                return;
            }

            int partId = (int)comboBox1.SelectedValue;


            var rep = new SparePartRep();


            var part = rep.SearchPart(partId);

            if (part == null)
            {
                MessageBox.Show("noe");
                return;
            }


           // part.PartID = int.Parse(comboBox1.Text);
            part.PartName = this.Namebox.Text;
            part.PartProvider = this.ProviderBox.Text;
            part.Quantity = int.Parse(QtyBoX.Text);
            part.Price = int.Parse(PriCeBox.Text);


            rep.UpdatePart(part);

            MessageBox.Show("done");
        }
        private void BtnUpdateemp_Click(object sender, EventArgs e)
        {
            updatePart();
            ReadParT();
            FillComboboxPart();
        }



        public void RemovePart()
        {
            try
            {
                var val = DtGPart.SelectedRows[0].Cells[0].Value.ToString();
                if (val == null) return;

                int partid = int.Parse(val);

                DialogResult DLR = MessageBox.Show("Are you sure", "delete", MessageBoxButtons.YesNo);
                if (DLR == DialogResult.No) return;
                var rep = new SparePartRep();
                rep.DeleteParT(partid);
                MessageBox.Show("done");
            }
            catch (Exception e)
            {
                MessageBox.Show("Select a part in the table below");
            }
        }

        private void Btndeleteemp_Click(object sender, EventArgs e)
        {
            RemovePart();
            ReadParT();
            FillComboboxPart();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rep = new SparePartRep();
            if (comboBox1.SelectedIndex == -1) return;
            if (comboBox1.SelectedValue == null) return;

            int selectedId;
            if (!int.TryParse(comboBox1.SelectedValue.ToString(), out selectedId))
                return;

            var part = rep.SearchPart(selectedId);
            if (part != null)
            {
                comboBox1.Text = part.PartID.ToString();
                Namebox.Text = part.PartName;
                ProviderBox.Text = part.PartProvider;
                QtyBoX.Text = part.Quantity.ToString();
                PriCeBox.Text = part.Price.ToString();
            }
        }



        public void Searching()
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Enter a Part Id first");
                return;
            }
            int partId;
            if (!int.TryParse(comboBox1.Text, out partId))
            {
                MessageBox.Show("Invalid Data Entrance");
                return;
            }

            var rep = new SparePartRep();
            var part = rep.SearchPart(partId);
            if (part == null)
            {
                MessageBox.Show("Customer Not Found");
                return;
            }
            comboBox1.Text = part.PartID.ToString();
            Namebox.Text = part.PartName;
            ProviderBox.Text = part.PartProvider;
            QtyBoX.Text = part.Quantity.ToString();
            PriCeBox.Text = part.Price.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Searching();
        }
    }
}
