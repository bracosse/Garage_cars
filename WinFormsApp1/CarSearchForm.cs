using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Repositories;

namespace WinFormsApp1
{
    public partial class CarSearchForm : MetroFramework.Forms.MetroForm
    {


        public CarSearchForm(DataTable table)
        {

            InitializeComponent();
            DtGCst.DataSource = table;
        }

        private void CarSearchForm_Load(object sender, EventArgs e)
        {

        }



        private void Btnback_Click(object sender, EventArgs e)
        {
            CarForm cfm = new CarForm();
            cfm.ReadCar();
            this.Hide();
            
        }

        public void RemoveCarCS()
        {
            try
            {
                var val = DtGCst.SelectedRows[0].Cells[0].Value.ToString();
                if (val == null) return;

                int carid = int.Parse(val);

                DialogResult DLR = MessageBox.Show("Are you sure", "delete", MessageBoxButtons.YesNo);
                if (DLR == DialogResult.No) return;
                var rep = new CarRep();
                rep.DeleteCaRCST(carid);
                MessageBox.Show("done");
            }
            catch (Exception e)
            {
                MessageBox.Show("Select a car in the table below");
            }
        }
        private void DLTBTNCSTFM_Click(object sender, EventArgs e)
        {
            CarForm cfm = new CarForm();
            RemoveCarCS();
            cfm.ReadCar();
            this.Hide();
        }
    }
}
