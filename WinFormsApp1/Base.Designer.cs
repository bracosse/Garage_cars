namespace WinFormsApp1
{
    partial class Base
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnEmployee = new Button();
            BtnCustomer = new Button();
            BtnCar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // BtnEmployee
            // 
            BtnEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnEmployee.BackColor = Color.Turquoise;
            BtnEmployee.Location = new Point(228, 38);
            BtnEmployee.Name = "BtnEmployee";
            BtnEmployee.Size = new Size(199, 166);
            BtnEmployee.TabIndex = 0;
            BtnEmployee.Text = "Employee form";
            BtnEmployee.UseVisualStyleBackColor = false;
            BtnEmployee.Click += BtnEmployee_Click;
            // 
            // BtnCustomer
            // 
            BtnCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnCustomer.BackColor = Color.Turquoise;
            BtnCustomer.Location = new Point(433, 38);
            BtnCustomer.Name = "BtnCustomer";
            BtnCustomer.Size = new Size(199, 166);
            BtnCustomer.TabIndex = 3;
            BtnCustomer.Text = "Customer form";
            BtnCustomer.UseVisualStyleBackColor = false;
            BtnCustomer.Click += BtnCustomer_Click;
            // 
            // BtnCar
            // 
            BtnCar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnCar.BackColor = Color.Turquoise;
            BtnCar.Location = new Point(228, 238);
            BtnCar.Name = "BtnCar";
            BtnCar.Size = new Size(199, 166);
            BtnCar.TabIndex = 4;
            BtnCar.Text = "Car form";
            BtnCar.UseVisualStyleBackColor = false;
            BtnCar.Click += BtnCar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Turquoise;
            button1.Location = new Point(433, 238);
            button1.Name = "button1";
            button1.Size = new Size(199, 166);
            button1.TabIndex = 5;
            button1.Text = "Parts form";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Base
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(BtnCar);
            Controls.Add(BtnCustomer);
            Controls.Add(BtnEmployee);
            Name = "Base";
            Text = "Base";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnEmployee;
        private Button BtnCustomer;
        private Button BtnCar;
        private Button button1;
    }
}
