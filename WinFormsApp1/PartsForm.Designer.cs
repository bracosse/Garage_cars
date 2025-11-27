namespace WinFormsApp1
{
    partial class PartsForm
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
            comboBox1 = new ComboBox();
            DtGPart = new DataGridView();
            PriCeBox = new TextBox();
            QtyBoX = new TextBox();
            ProviderBox = new TextBox();
            Namebox = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)DtGPart).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(296, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(155, 28);
            comboBox1.TabIndex = 95;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // DtGPart
            // 
            DtGPart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DtGPart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtGPart.Location = new Point(23, 292);
            DtGPart.Name = "DtGPart";
            DtGPart.RowHeadersWidth = 51;
            DtGPart.Size = new Size(988, 236);
            DtGPart.TabIndex = 81;
            // 
            // PriCeBox
            // 
            PriCeBox.Anchor = AnchorStyles.None;
            PriCeBox.Location = new Point(648, 100);
            PriCeBox.Name = "PriCeBox";
            PriCeBox.Size = new Size(155, 27);
            PriCeBox.TabIndex = 91;
            // 
            // QtyBoX
            // 
            QtyBoX.Anchor = AnchorStyles.None;
            QtyBoX.Location = new Point(648, 69);
            QtyBoX.Name = "QtyBoX";
            QtyBoX.Size = new Size(155, 27);
            QtyBoX.TabIndex = 90;
            // 
            // ProviderBox
            // 
            ProviderBox.Anchor = AnchorStyles.None;
            ProviderBox.Location = new Point(296, 136);
            ProviderBox.Name = "ProviderBox";
            ProviderBox.Size = new Size(155, 27);
            ProviderBox.TabIndex = 89;
            // 
            // Namebox
            // 
            Namebox.Anchor = AnchorStyles.None;
            Namebox.Location = new Point(296, 103);
            Namebox.Name = "Namebox";
            Namebox.Size = new Size(155, 27);
            Namebox.TabIndex = 88;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(550, 103);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 86;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(550, 72);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 85;
            label4.Text = "Quantity";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(221, 143);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 84;
            label3.Text = "Provider";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(238, 106);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 83;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(198, 76);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 82;
            label1.Text = "Spare Part ID";
            // 
            // Btnback
            // 
            Btnback.Anchor = AnchorStyles.None;
            Btnback.Location = new Point(825, 65);
            Btnback.Name = "Btnback";
            Btnback.Size = new Size(127, 31);
            Btnback.TabIndex = 79;
            Btnback.Text = "Previous";
            Btnback.UseVisualStyleBackColor = true;
            Btnback.Click += Btnback_Click;
            // 
            // Btndeleteemp
            // 
            Btndeleteemp.Anchor = AnchorStyles.None;
            Btndeleteemp.Location = new Point(660, 222);
            Btndeleteemp.Name = "Btndeleteemp";
            Btndeleteemp.Size = new Size(174, 29);
            Btndeleteemp.TabIndex = 78;
            Btndeleteemp.Text = "Delete";
            Btndeleteemp.UseVisualStyleBackColor = true;
            Btndeleteemp.Click += Btndeleteemp_Click;
            // 
            // BtnUpdateemp
            // 
            BtnUpdateemp.Anchor = AnchorStyles.None;
            BtnUpdateemp.Location = new Point(449, 222);
            BtnUpdateemp.Name = "BtnUpdateemp";
            BtnUpdateemp.Size = new Size(174, 29);
            BtnUpdateemp.TabIndex = 77;
            BtnUpdateemp.Text = "Update";
            BtnUpdateemp.UseVisualStyleBackColor = true;
            BtnUpdateemp.Click += BtnUpdateemp_Click;
            // 
            // Btnaddemp
            // 
            Btnaddemp.Anchor = AnchorStyles.None;
            Btnaddemp.Location = new Point(238, 222);
            Btnaddemp.Name = "Btnaddemp";
            Btnaddemp.Size = new Size(174, 29);
            Btnaddemp.TabIndex = 76;
            Btnaddemp.Text = "Add";
            Btnaddemp.UseVisualStyleBackColor = true;
            Btnaddemp.Click += Btnaddemp_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Location = new Point(65, 67);
            button5.Name = "button5";
            button5.Size = new Size(127, 31);
            button5.TabIndex = 80;
            button5.Text = "Search BY";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // PartsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 551);
            Controls.Add(comboBox1);
            Controls.Add(DtGPart);
            Controls.Add(PriCeBox);
            Controls.Add(QtyBoX);
            Controls.Add(ProviderBox);
            Controls.Add(Namebox);
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
            Name = "PartsForm";
            Text = "PartsForm";
            Load += PartsForm_Load;
            ((System.ComponentModel.ISupportInitialize)DtGPart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private DataGridView DtGPart;
        private TextBox PriCeBox;
        private TextBox QtyBoX;
        private TextBox ProviderBox;
        private TextBox Namebox;
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
    }
}