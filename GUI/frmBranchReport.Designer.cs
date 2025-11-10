namespace GUI
{
    partial class frmBranchReport
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
            cboProvince = new ComboBox();
            label2 = new Label();
            cboWard = new ComboBox();
            label1 = new Label();
            btnPrint = new Button();
            SuspendLayout();
            // 
            // cboProvince
            // 
            cboProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvince.FormattingEnabled = true;
            cboProvince.Location = new Point(97, 26);
            cboProvince.Name = "cboProvince";
            cboProvince.Size = new Size(177, 31);
            cboProvince.TabIndex = 40;
            cboProvince.SelectedIndexChanged += cboProvince_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 32);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 38;
            label2.Text = "Tỉnh/TP:";
            // 
            // cboWard
            // 
            cboWard.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWard.FormattingEnabled = true;
            cboWard.Location = new Point(400, 24);
            cboWard.Name = "cboWard";
            cboWard.Size = new Size(190, 31);
            cboWard.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 29);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 39;
            label1.Text = "Xã/Phường:";
            // 
            // btnPrint
            // 
            btnPrint.Image = Properties.Resources.printer;
            btnPrint.ImageAlign = ContentAlignment.MiddleRight;
            btnPrint.Location = new Point(602, 21);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(129, 39);
            btnPrint.TabIndex = 42;
            btnPrint.Text = "In ";
            btnPrint.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // frmBranchReport
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 88);
            Controls.Add(btnPrint);
            Controls.Add(cboProvince);
            Controls.Add(label2);
            Controls.Add(cboWard);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBranchReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xuất thông tin chi nhánh";
            Load += frmBranchReport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboProvince;
        private Label label2;
        private ComboBox cboWard;
        private Label label1;
        private Button btnPrint;
    }
}