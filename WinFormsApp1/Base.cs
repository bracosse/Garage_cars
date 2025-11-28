namespace WinFormsApp1
{
    public partial class Base : MetroFramework.Forms.MetroForm
    {
        public Base()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            EmpForm Eform = new EmpForm();
            Eform.FormClosed += (s, args) => this.Close();
            this.Hide();
            Eform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Your code here
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Your code here
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            CustoForm CTF = new CustoForm();
            CTF.FormClosed += (s, args) => this.Close();
            this.Hide();
            CTF.Show();
        }

        private void BtnCar_Click(object sender, EventArgs e)
        {
            CarForm CAR = new CarForm();
            CAR.FormClosed += (s, args) => this.Close();
            this.Hide();
            CAR.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PartsForm PTF = new PartsForm();
            PTF.FormClosed += (s, args) => this.Close();
            this.Hide();
            PTF.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            NeededPart NPT = new NeededPart();
            NPT.FormClosed += (s, args) => this.Close();
            this.Hide();
            NPT.Show();
        }
    }
}
