using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CustoForm : MetroFramework.Forms.MetroForm
    {
        public CustoForm()
        {
            InitializeComponent();
        }

        private void CustoForm_Load(object sender, EventArgs e)
        {

        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            Base bse = new Base();
            bse.FormClosed += (s, args) => this.Close();
            this.Hide();
            bse.Show();
        }
    }
}
