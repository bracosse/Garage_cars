namespace WinFormsApp1
{
    partial class CarForm
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
            label9 = new Label();
            comboBox2 = new ComboBox();
            DtGCar = new DataGridView();
            Probox = new TextBox();
            HorsepowerBox = new TextBox();
            ColorBox = new TextBox();
            Brandbox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Btnback = new Button();
            Btndeleteemp = new Button();
            BtnUpdateemp = new Button();
            Btnaddemp = new Button();
            button5 = new Button();
            comboBox1 = new ComboBox();
            comboBox3 = new ComboBox();
            label7 = new Label();
            Namebox = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)DtGCar).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(409, 178);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 72;
            label9.Text = "Fixed?";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.None;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(466, 175);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(155, 28);
            comboBox2.TabIndex = 71;
            // 
            // DtGCar
            // 
            DtGCar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DtGCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtGCar.Location = new Point(23, 306);
            DtGCar.Name = "DtGCar";
            DtGCar.RowHeadersWidth = 51;
            DtGCar.Size = new Size(984, 260);
            DtGCar.TabIndex = 54;
            // 
            // Probox
            // 
            Probox.Anchor = AnchorStyles.None;
            Probox.Location = new Point(648, 129);
            Probox.Name = "Probox";
            Probox.Size = new Size(155, 27);
            Probox.TabIndex = 67;
            // 
            // HorsepowerBox
            // 
            HorsepowerBox.Anchor = AnchorStyles.None;
            HorsepowerBox.Location = new Point(648, 96);
            HorsepowerBox.Name = "HorsepowerBox";
            HorsepowerBox.Size = new Size(155, 27);
            HorsepowerBox.TabIndex = 66;
            // 
            // ColorBox
            // 
            ColorBox.Anchor = AnchorStyles.None;
            ColorBox.Location = new Point(648, 65);
            ColorBox.Name = "ColorBox";
            ColorBox.Size = new Size(155, 27);
            ColorBox.TabIndex = 65;
            // 
            // Brandbox
            // 
            Brandbox.Anchor = AnchorStyles.None;
            Brandbox.Location = new Point(296, 132);
            Brandbox.Name = "Brandbox";
            Brandbox.Size = new Size(155, 27);
            Brandbox.TabIndex = 64;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(550, 132);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 60;
            label6.Text = "Problem";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(550, 99);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 59;
            label5.Text = "Horse Power";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(550, 68);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 58;
            label4.Text = "Car Color";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(199, 136);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 57;
            label3.Text = "Car Brand";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(198, 103);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 56;
            label2.Text = "Car Name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(198, 72);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 55;
            label1.Text = "Customer ID";
            // 
            // Btnback
            // 
            Btnback.Anchor = AnchorStyles.None;
            Btnback.Location = new Point(837, 63);
            Btnback.Name = "Btnback";
            Btnback.Size = new Size(127, 31);
            Btnback.TabIndex = 52;
            Btnback.Text = "Previous";
            Btnback.UseVisualStyleBackColor = true;
            Btnback.Click += Btnback_Click;
            // 
            // Btndeleteemp
            // 
            Btndeleteemp.Anchor = AnchorStyles.None;
            Btndeleteemp.Location = new Point(660, 218);
            Btndeleteemp.Name = "Btndeleteemp";
            Btndeleteemp.Size = new Size(174, 29);
            Btndeleteemp.TabIndex = 51;
            Btndeleteemp.Text = "Delete";
            Btndeleteemp.UseVisualStyleBackColor = true;
            Btndeleteemp.Click += Btndeleteemp_Click;
            // 
            // BtnUpdateemp
            // 
            BtnUpdateemp.Anchor = AnchorStyles.None;
            BtnUpdateemp.Location = new Point(449, 218);
            BtnUpdateemp.Name = "BtnUpdateemp";
            BtnUpdateemp.Size = new Size(174, 29);
            BtnUpdateemp.TabIndex = 50;
            BtnUpdateemp.Text = "Update";
            BtnUpdateemp.UseVisualStyleBackColor = true;
            BtnUpdateemp.Click += BtnUpdateemp_Click;
            // 
            // Btnaddemp
            // 
            Btnaddemp.Anchor = AnchorStyles.None;
            Btnaddemp.Location = new Point(238, 218);
            Btnaddemp.Name = "Btnaddemp";
            Btnaddemp.Size = new Size(174, 29);
            Btnaddemp.TabIndex = 49;
            Btnaddemp.Text = "Add";
            Btnaddemp.UseVisualStyleBackColor = true;
            Btnaddemp.Click += Btnaddemp_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Location = new Point(65, 63);
            button5.Name = "button5";
            button5.Size = new Size(127, 31);
            button5.TabIndex = 53;
            button5.Text = "Search BY";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(296, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(155, 28);
            comboBox1.TabIndex = 73;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.None;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(498, 20);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(155, 28);
            comboBox3.TabIndex = 74;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(442, 24);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 75;
            label7.Text = "Car ID";
            // 
            // Namebox
            // 
            Namebox.Anchor = AnchorStyles.None;
            Namebox.Location = new Point(296, 99);
            Namebox.Name = "Namebox";
            Namebox.Size = new Size(155, 27);
            Namebox.TabIndex = 63;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(880, 258);
            button1.Name = "button1";
            button1.Size = new Size(127, 31);
            button1.TabIndex = 76;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 589);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(comboBox3);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(comboBox2);
            Controls.Add(DtGCar);
            Controls.Add(Probox);
            Controls.Add(HorsepowerBox);
            Controls.Add(ColorBox);
            Controls.Add(Brandbox);
            Controls.Add(Namebox);
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
            Name = "CarForm";
            Text = "Car Details Window";
            Load += CarForm_Load;
            ((System.ComponentModel.ISupportInitialize)DtGCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private ComboBox comboBox2;
        private DataGridView DtGCar;
        private TextBox Probox;
        private TextBox HorsepowerBox;
        private TextBox ColorBox;
        private TextBox Brandbox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Btnback;
        private Button Btndeleteemp;
        private Button BtnUpdateemp;
        private Button Btnaddemp;
        private Button button5;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private Label label7;
        private TextBox Namebox;
        private Button button1;
    }
}