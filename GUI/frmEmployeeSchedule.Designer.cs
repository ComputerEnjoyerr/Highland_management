namespace GUI
{
    partial class frmEmployeeSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeSchedule));
            panel1 = new Panel();
            txtFind = new TextBox();
            label1 = new Label();
            dgvEmployeeSchedule = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeSchedule).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(249, 245, 238);
            panel1.Controls.Add(txtFind);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 53);
            panel1.TabIndex = 5;
            // 
            // txtFind
            // 
            txtFind.Location = new Point(100, 12);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(316, 30);
            txtFind.TabIndex = 1;
            txtFind.TextChanged += txtFind_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 15);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm:";
            // 
            // dgvEmployeeSchedule
            // 
            dgvEmployeeSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployeeSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeeSchedule.Location = new Point(14, 73);
            dgvEmployeeSchedule.Name = "dgvEmployeeSchedule";
            dgvEmployeeSchedule.RowHeadersWidth = 51;
            dgvEmployeeSchedule.Size = new Size(887, 464);
            dgvEmployeeSchedule.TabIndex = 4;
            // 
            // frmEmployeeSchedule
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(74, 60, 60);
            ClientSize = new Size(914, 550);
            Controls.Add(panel1);
            Controls.Add(dgvEmployeeSchedule);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmEmployeeSchedule";
            Text = "Các ca làm việc của nhân viên";
            Load += frmEmployeeSchedule_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeSchedule).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtFind;
        private Label label1;
        private DataGridView dgvEmployeeSchedule;
    }
}