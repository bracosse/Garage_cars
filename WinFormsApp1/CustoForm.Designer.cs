namespace WinFormsApp1
{
    partial class CustoForm
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
            DGridCusto = new DataGridView();
            comboBox1 = new ComboBox();
            ReturnEmpdateTimePicker = new DateTimePicker();
            ArrivalEmpdateTimePicker = new DateTimePicker();
            ADressBox = new TextBox();
            EMailBox = new TextBox();
            PNBox = new TextBox();
            LNameBox = new TextBox();
            FNameBox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button5 = new Button();
            Btnback = new Button();
            Btndeleteemp = new Button();
            BtnUpdateemp = new Button();
            Btnaddemp = new Button();
            comboBox2 = new ComboBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGridCusto).BeginInit();
            SuspendLayout();
            // 
            // DGridCusto
            // 
            DGridCusto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGridCusto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGridCusto.Location = new Point(23, 279);
            DGridCusto.Name = "DGridCusto";
            DGridCusto.RowHeadersWidth = 51;
            DGridCusto.Size = new Size(898, 238);
            DGridCusto.TabIndex = 30;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(241, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(155, 28);
            comboBox1.TabIndex = 46;
            // 
            // ReturnEmpdateTimePicker
            // 
            ReturnEmpdateTimePicker.Anchor = AnchorStyles.None;
            ReturnEmpdateTimePicker.Location = new Point(639, 156);
            ReturnEmpdateTimePicker.Name = "ReturnEmpdateTimePicker";
            ReturnEmpdateTimePicker.Size = new Size(250, 27);
            ReturnEmpdateTimePicker.TabIndex = 45;
            // 
            // ArrivalEmpdateTimePicker
            // 
            ArrivalEmpdateTimePicker.Anchor = AnchorStyles.None;
            ArrivalEmpdateTimePicker.Location = new Point(146, 156);
            ArrivalEmpdateTimePicker.Name = "ArrivalEmpdateTimePicker";
            ArrivalEmpdateTimePicker.Size = new Size(250, 27);
            ArrivalEmpdateTimePicker.TabIndex = 44;
            // 
            // ADressBox
            // 
            ADressBox.Anchor = AnchorStyles.None;
            ADressBox.Location = new Point(605, 120);
            ADressBox.Name = "ADressBox";
            ADressBox.Size = new Size(155, 27);
            ADressBox.TabIndex = 43;
            // 
            // EMailBox
            // 
            EMailBox.Anchor = AnchorStyles.None;
            EMailBox.Location = new Point(605, 87);
            EMailBox.Name = "EMailBox";
            EMailBox.Size = new Size(155, 27);
            EMailBox.TabIndex = 42;
            // 
            // PNBox
            // 
            PNBox.Anchor = AnchorStyles.None;
            PNBox.Location = new Point(605, 56);
            PNBox.Name = "PNBox";
            PNBox.Size = new Size(155, 27);
            PNBox.TabIndex = 41;
            // 
            // LNameBox
            // 
            LNameBox.Anchor = AnchorStyles.None;
            LNameBox.Location = new Point(241, 123);
            LNameBox.Name = "LNameBox";
            LNameBox.Size = new Size(155, 27);
            LNameBox.TabIndex = 40;
            // 
            // FNameBox
            // 
            FNameBox.Anchor = AnchorStyles.None;
            FNameBox.Location = new Point(241, 90);
            FNameBox.Name = "FNameBox";
            FNameBox.Size = new Size(155, 27);
            FNameBox.TabIndex = 39;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(545, 161);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 38;
            label8.Text = "Return Date";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(52, 161);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 37;
            label7.Text = "Arrival Date";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(481, 127);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 36;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(481, 94);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 35;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(481, 63);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 34;
            label4.Text = "Phone Number";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(156, 127);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 33;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(155, 94);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 32;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(159, 63);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 31;
            label1.Text = "ID";
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Location = new Point(23, 54);
            button5.Name = "button5";
            button5.Size = new Size(127, 31);
            button5.TabIndex = 29;
            button5.Text = "Search by";
            button5.UseVisualStyleBackColor = true;
            // 
            // Btnback
            // 
            Btnback.Anchor = AnchorStyles.None;
            Btnback.Location = new Point(794, 54);
            Btnback.Name = "Btnback";
            Btnback.Size = new Size(127, 31);
            Btnback.TabIndex = 28;
            Btnback.Text = "Previous";
            Btnback.UseVisualStyleBackColor = true;
            Btnback.Click += Btnback_Click;
            // 
            // Btndeleteemp
            // 
            Btndeleteemp.Anchor = AnchorStyles.None;
            Btndeleteemp.Location = new Point(586, 235);
            Btndeleteemp.Name = "Btndeleteemp";
            Btndeleteemp.Size = new Size(174, 29);
            Btndeleteemp.TabIndex = 27;
            Btndeleteemp.Text = "Delete";
            Btndeleteemp.UseVisualStyleBackColor = true;
            // 
            // BtnUpdateemp
            // 
            BtnUpdateemp.Anchor = AnchorStyles.None;
            BtnUpdateemp.Location = new Point(378, 235);
            BtnUpdateemp.Name = "BtnUpdateemp";
            BtnUpdateemp.Size = new Size(174, 29);
            BtnUpdateemp.TabIndex = 26;
            BtnUpdateemp.Text = "Update";
            BtnUpdateemp.UseVisualStyleBackColor = true;
            // 
            // Btnaddemp
            // 
            Btnaddemp.Anchor = AnchorStyles.None;
            Btnaddemp.Location = new Point(159, 235);
            Btnaddemp.Name = "Btnaddemp";
            Btnaddemp.Size = new Size(174, 29);
            Btnaddemp.TabIndex = 25;
            Btnaddemp.Text = "Add";
            Btnaddemp.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(463, 192);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(155, 28);
            comboBox2.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(318, 195);
            label9.Name = "label9";
            label9.Size = new Size(139, 20);
            label9.TabIndex = 48;
            label9.Text = "Assigned Employee";
            // 
            // CustoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 540);
            Controls.Add(label9);
            Controls.Add(comboBox2);
            Controls.Add(DGridCusto);
            Controls.Add(comboBox1);
            Controls.Add(ReturnEmpdateTimePicker);
            Controls.Add(ArrivalEmpdateTimePicker);
            Controls.Add(ADressBox);
            Controls.Add(EMailBox);
            Controls.Add(PNBox);
            Controls.Add(LNameBox);
            Controls.Add(FNameBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btnback);
            Controls.Add(Btndeleteemp);
            Controls.Add(BtnUpdateemp);
            Controls.Add(Btnaddemp);
            Controls.Add(button5);
            Name = "CustoForm";
            Text = "CustoForm";
            Load += CustoForm_Load;
            ((System.ComponentModel.ISupportInitialize)DGridCusto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGridCusto;
        private ComboBox comboBox1;
        private DateTimePicker ReturnEmpdateTimePicker;
        private DateTimePicker ArrivalEmpdateTimePicker;
        private TextBox ADressBox;
        private TextBox EMailBox;
        private TextBox PNBox;
        private TextBox LNameBox;
        private TextBox FNameBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button5;
        private Button Btnback;
        private Button Btndeleteemp;
        private Button BtnUpdateemp;
        private Button Btnaddemp;
        private ComboBox comboBox2;
        private Label label9;
    }
}