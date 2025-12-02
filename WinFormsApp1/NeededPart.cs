using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        private PrintDocument printDocument1 = new PrintDocument();


        public NeededPart()
        {
            InitializeComponent();
            printDocument1.PrintPage += PrintDoc;
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
        public void FillComboboxIssue()
        {
            int id = 0;

            if (comboBox1.SelectedValue is DataRowView drv)
            {
                id = Convert.ToInt32(drv["CarId"]);
            }
            else if (comboBox1.SelectedValue != null)
            {
                id = Convert.ToInt32(comboBox1.SelectedValue);
            }

            var rep = new NeededPartRep();
            DataTable dt = rep.Fillcomboboxissue(id);

            comboBox4.DataSource = dt;
            comboBox4.DisplayMember = "Issue";
            comboBox4.ValueMember = "Issue";
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            //comboBox4.SelectedIndex = -1;
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
                MessageBox.Show("error combobox 3");
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
            label15.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1 || HandBox.Text == null)
            {
                MessageBox.Show("error btn price");
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
            label19.Text = inf.CustId.ToString();
            label13.Text = inf.FirstName;
            label7.Text = inf.LastName;
            label5.Text = inf.EmpId.ToString();

            FillComboboxIssue();
        }

        public void SaveToArchive()
        {
            Archive arc = new Archive();
            var rep = new ArcHiveRep();

            //if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1 || comboBox4.SelectedIndex == -1 || HandBox.Text == "")
            //{
            //    MessageBox.Show("Please Fill all the values before sending to Archive.");
            //    return;
            //}
            //if (label15.Text == "price" || label15.Text == "0 Dhs")
            //{
            //    MessageBox.Show("Generate the final price with the Button");
            //    return;
            //}

            arc.EmployeeID = int.Parse(label5.Text);
            arc.CustomerID = int.Parse(label19.Text);
            arc.FirstName = label13.Text;
            arc.LastName = label7.Text;
            arc.CarID = int.Parse(comboBox1.Text);
            arc.Issue = comboBox4.Text;
            arc.PartName = label8.Text;
            arc.PartProvider = label9.Text;
            arc.Quantity = int.Parse(comboBox3.Text);
            arc.ServicePrice = int.Parse(HandBox.Text);
            arc.FinalPrice = int.Parse(label15.Text);

            rep.AddToArchive(arc);
        }
        public void RemoveCar()
        {
            try
            {
                var val = Convert.ToInt32(comboBox1.SelectedValue);
                //if (val == null) return;

                int carid = val;
                var rep = new CarRep();
                rep.DeleteCaR(carid);


                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedValue = -1;
                comboBox4.SelectedIndex = -1;
                HandBox.Text = "";
                label15.Text = "price";
            }
            catch (Exception e)
            {
                MessageBox.Show("this is " + e);
            }
        }

        public void Quantity_Change()
        {
            try
            {
                var rep = new ArcHiveRep();
                int partId = Convert.ToInt32(comboBox2.SelectedValue);
                int quantityUsed = Convert.ToInt32(comboBox3.SelectedItem);

                int? currentQty = rep.SearchPart(partId);

                int newQty = currentQty.Value - quantityUsed;

                if (newQty < 0)
                {
                    MessageBox.Show("Not enough stock!");
                    return;
                }

                rep.UpdateQuality(partId, newQty);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1 || comboBox4.SelectedIndex == -1 || HandBox.Text == "")
            {
                MessageBox.Show("Please Fill all the values before sending to Archive.");
                return;
            }
            if (label15.Text == "price" || label15.Text == "0")
            {
                MessageBox.Show("Generate the final price with the Button");
                return;
            }
            DialogResult DLR = MessageBox.Show("This will Archive this car and delete it from the database Car, are you sure you want to continue?", "delete", MessageBoxButtons.YesNo);
            if (DLR == DialogResult.No)
            {
                return;
            }
            if (DLR == DialogResult.Yes)
            {
                SaveToArchive();
                Quantity_Change();
                RemoveCar();
                FillComboboxcar();
                MessageBox.Show("done");
            }
        }

        private void PrintDoc(object sender, PrintPageEventArgs e)
        {
            int y = 40;
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 12, FontStyle.Bold);
            Font textFont = new Font("Arial", 11);

            float pageWidth = e.PageBounds.Width;

            string header = "*****-RECEIPT-*****";
            float headerWidth = e.Graphics.MeasureString(header, headerFont).Width;
            e.Graphics.DrawString(header, headerFont, Brushes.Black, (pageWidth - headerWidth) / 2, y);
            y += 40;

            
            e.Graphics.DrawLine(Pens.Black, 40, y, pageWidth - 40, y);
            y += 20;

            
            string section = "Customer Details";
            float sectionWidth = e.Graphics.MeasureString(section, subHeaderFont).Width;
            e.Graphics.DrawString(section, subHeaderFont, Brushes.Black, (pageWidth - sectionWidth) / 2, y);
            y += 25;

            e.Graphics.DrawString($"ID: {label19.Text}", textFont, Brushes.Black, (pageWidth - e.Graphics.MeasureString($"ID: {label19.Text}", textFont).Width) / 2, y); y += 20;
            e.Graphics.DrawString($"First Name: {label13.Text}", textFont, Brushes.Black, (pageWidth - e.Graphics.MeasureString($"First Name: {label13.Text}", textFont).Width) / 2, y); y += 20;
            e.Graphics.DrawString($"Last Name:  {label7.Text}", textFont, Brushes.Black, (pageWidth - e.Graphics.MeasureString($"Last Name:  {label7.Text}", textFont).Width) / 2, y); y += 30;

            
            e.Graphics.DrawLine(Pens.Black, 40, y, pageWidth - 40, y);
            y += 20;

            
            section = "Service Details";
            sectionWidth = e.Graphics.MeasureString(section, subHeaderFont).Width;
            e.Graphics.DrawString(section, subHeaderFont, Brushes.Black, (pageWidth - sectionWidth) / 2, y);
            y += 25;

            e.Graphics.DrawString($"Employee In Charge: {label5.Text}", textFont, Brushes.Black, (pageWidth - e.Graphics.MeasureString($"Employee in Charge: {label5.Text}", textFont).Width) / 2, y); y += 20;
            e.Graphics.DrawString($"Car ID: {comboBox1.Text}", textFont, Brushes.Black, (pageWidth - e.Graphics.MeasureString($"Car ID: {comboBox1.Text}", textFont).Width) / 2, y); y += 20;
            e.Graphics.DrawString($"Problem Solved: {comboBox4.Text}", textFont, Brushes.Black, (pageWidth - e.Graphics.MeasureString($"Problem Solved: {comboBox4.Text}", textFont).Width) / 2, y); y += 30;

            
            e.Graphics.DrawLine(Pens.Black, 40, y, pageWidth - 40, y);
            y += 20;

            
            section = "Exchange Parts Used";
            sectionWidth = e.Graphics.MeasureString(section, subHeaderFont).Width;
            e.Graphics.DrawString(section, subHeaderFont, Brushes.Black, (pageWidth - sectionWidth) / 2, y);
            y += 25;

            e.Graphics.DrawString($"Exchange Part ID: {comboBox2.Text}", textFont, Brushes.Black, (pageWidth - e.Graphics.MeasureString($"Part ID: {comboBox2.Text}", textFont).Width) / 2, y); y += 20;
            e.Graphics.DrawString($"Exchange Part Name: {label9.Text}", textFont, Brushes.Black, (pageWidth - e.Graphics.MeasureString($"Part Name: {label9.Text}", textFont).Width) / 2, y); y += 20;
            e.Graphics.DrawString($"Quantity: {comboBox3.Text}", textFont, Brushes.Black, (pageWidth - e.Graphics.MeasureString($"Quantity: {comboBox3.Text}", textFont).Width) / 2, y); y += 30;

            
            e.Graphics.DrawLine(Pens.Black, 40, y, pageWidth - 40, y);
            y += 20;

            
            section = "To be Paid";
            sectionWidth = e.Graphics.MeasureString(section, subHeaderFont).Width;
            e.Graphics.DrawString(section, subHeaderFont, Brushes.Black, (pageWidth - sectionWidth) / 2, y);
            y += 25;

            e.Graphics.DrawString($"Service Fees: {HandBox.Text}", textFont, Brushes.Black, (pageWidth - e.Graphics.MeasureString($"Service Price: {HandBox.Text}", textFont).Width) / 2, y); y += 20;
            e.Graphics.DrawString($"Total Price: {label15.Text}", textFont, Brushes.Black, (pageWidth - e.Graphics.MeasureString($"Final Price: {label15.Text}", textFont).Width) / 2, y); y += 30;

            
            y += 20;
            string footer = "Thank You For Choosing Our Garage!";
            float footerWidth = e.Graphics.MeasureString(footer, textFont).Width;
            e.Graphics.DrawString(footer, textFont, Brushes.Black, (pageWidth - footerWidth) / 2, y);
        }



        private void button3_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PDF Files|*.pdf|All Files|*.*";
                saveDialog.FileName = "receipt";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                    printDocument1.PrinterSettings.PrintToFile = true;
                    printDocument1.PrinterSettings.PrintFileName = saveDialog.FileName;

                    printDocument1.Print();
                }
            }
        }
    }
}
