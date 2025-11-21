namespace WinFormsApp1
{
    partial class EmpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Btnaddemp = new Button();
            BtnUpdateemp = new Button();
            Btndeleteemp = new Button();
            Btnback = new Button();
            button5 = new Button();
            DGridEmp = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            StartEmpdateTimePicker = new DateTimePicker();
            EndEmpdateTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DGridEmp).BeginInit();
            SuspendLayout();
            // 
            // Btnaddemp
            // 
            Btnaddemp.Anchor = AnchorStyles.None;
            Btnaddemp.Location = new Point(156, 236);
            Btnaddemp.Name = "Btnaddemp";
            Btnaddemp.Size = new Size(174, 29);
            Btnaddemp.TabIndex = 0;
            Btnaddemp.Text = "Add";
            Btnaddemp.UseVisualStyleBackColor = true;
            // 
            // BtnUpdateemp
            // 
            BtnUpdateemp.Anchor = AnchorStyles.None;
            BtnUpdateemp.Location = new Point(375, 236);
            BtnUpdateemp.Name = "BtnUpdateemp";
            BtnUpdateemp.Size = new Size(174, 29);
            BtnUpdateemp.TabIndex = 1;
            BtnUpdateemp.Text = "Update";
            BtnUpdateemp.UseVisualStyleBackColor = true;
            // 
            // Btndeleteemp
            // 
            Btndeleteemp.Anchor = AnchorStyles.None;
            Btndeleteemp.Location = new Point(583, 236);
            Btndeleteemp.Name = "Btndeleteemp";
            Btndeleteemp.Size = new Size(174, 29);
            Btndeleteemp.TabIndex = 2;
            Btndeleteemp.Text = "Delete";
            Btndeleteemp.UseVisualStyleBackColor = true;
            // 
            // Btnback
            // 
            Btnback.Anchor = AnchorStyles.None;
            Btnback.Location = new Point(784, 58);
            Btnback.Name = "Btnback";
            Btnback.Size = new Size(102, 35);
            Btnback.TabIndex = 3;
            Btnback.Text = "Previous";
            Btnback.UseVisualStyleBackColor = true;
            Btnback.Click += Btnback_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Location = new Point(784, 224);
            button5.Name = "button5";
            button5.Size = new Size(102, 53);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // DGridEmp
            // 
            DGridEmp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGridEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGridEmp.Location = new Point(23, 287);
            DGridEmp.Name = "DGridEmp";
            DGridEmp.RowHeadersWidth = 51;
            DGridEmp.Size = new Size(887, 251);
            DGridEmp.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(156, 73);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 6;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(156, 104);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 7;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(156, 137);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 8;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(478, 73);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 9;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(478, 104);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 10;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(478, 137);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 11;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(47, 179);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 12;
            label7.Text = "Start Date";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(536, 179);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 13;
            label8.Text = "Contract End";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(238, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 27);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(238, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 27);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(238, 130);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 27);
            textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(602, 66);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(155, 27);
            textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Location = new Point(602, 97);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(155, 27);
            textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.Location = new Point(602, 130);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(155, 27);
            textBox6.TabIndex = 19;
            // 
            // StartEmpdateTimePicker
            // 
            StartEmpdateTimePicker.Anchor = AnchorStyles.None;
            StartEmpdateTimePicker.Location = new Point(129, 174);
            StartEmpdateTimePicker.Name = "StartEmpdateTimePicker";
            StartEmpdateTimePicker.Size = new Size(250, 27);
            StartEmpdateTimePicker.TabIndex = 22;
            // 
            // EndEmpdateTimePicker
            // 
            EndEmpdateTimePicker.Anchor = AnchorStyles.None;
            EndEmpdateTimePicker.Location = new Point(636, 174);
            EndEmpdateTimePicker.Name = "EndEmpdateTimePicker";
            EndEmpdateTimePicker.Size = new Size(250, 27);
            EndEmpdateTimePicker.TabIndex = 23;
            // 
            // EmpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 561);
            Controls.Add(EndEmpdateTimePicker);
            Controls.Add(StartEmpdateTimePicker);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DGridEmp);
            Controls.Add(button5);
            Controls.Add(Btnback);
            Controls.Add(Btndeleteemp);
            Controls.Add(BtnUpdateemp);
            Controls.Add(Btnaddemp);
            Name = "EmpForm";
            Text = "EmpForm";
            Load += EmpForm_Load;
            ((System.ComponentModel.ISupportInitialize)DGridEmp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btnaddemp;
        private Button BtnUpdateemp;
        private Button Btndeleteemp;
        private Button Btnback;
        private Button button5;
        private DataGridView DGridEmp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private DateTimePicker StartEmpdateTimePicker;
        private DateTimePicker EndEmpdateTimePicker;
    }
}