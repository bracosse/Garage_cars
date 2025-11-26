namespace WinFormsApp1
{
    partial class CarSearchForm
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
            DtGCst = new DataGridView();
            Btnback = new Button();
            DLTBTNCSTFM = new Button();
            ((System.ComponentModel.ISupportInitialize)DtGCst).BeginInit();
            SuspendLayout();
            // 
            // DtGCst
            // 
            DtGCst.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DtGCst.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtGCst.Location = new Point(23, 139);
            DtGCst.Name = "DtGCst";
            DtGCst.RowHeadersWidth = 51;
            DtGCst.Size = new Size(1099, 260);
            DtGCst.TabIndex = 55;
            // 
            // Btnback
            // 
            Btnback.Anchor = AnchorStyles.None;
            Btnback.Location = new Point(995, 102);
            Btnback.Name = "Btnback";
            Btnback.Size = new Size(127, 31);
            Btnback.TabIndex = 56;
            Btnback.Text = "Previous";
            Btnback.UseVisualStyleBackColor = true;
            Btnback.Click += Btnback_Click;
            // 
            // DLTBTNCSTFM
            // 
            DLTBTNCSTFM.Anchor = AnchorStyles.None;
            DLTBTNCSTFM.Location = new Point(570, 63);
            DLTBTNCSTFM.Name = "DLTBTNCSTFM";
            DLTBTNCSTFM.Size = new Size(127, 31);
            DLTBTNCSTFM.TabIndex = 57;
            DLTBTNCSTFM.Text = "Remove";
            DLTBTNCSTFM.UseVisualStyleBackColor = true;
            DLTBTNCSTFM.Click += DLTBTNCSTFM_Click;
            // 
            // CarSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 422);
            Controls.Add(DLTBTNCSTFM);
            Controls.Add(Btnback);
            Controls.Add(DtGCst);
            Name = "CarSearchForm";
            Text = "CarSearchForm";
            Load += CarSearchForm_Load;
            ((System.ComponentModel.ISupportInitialize)DtGCst).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DtGCst;
        private Button Btnback;
        private Button DLTBTNCSTFM;
    }
}