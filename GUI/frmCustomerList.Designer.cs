namespace GUI
{
    partial class frmCustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerList));
            dgvCustomer = new DataGridView();
            panel1 = new Panel();
            txtFindCustomer = new TextBox();
            label1 = new Label();
            btnChooseCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCustomer
            // 
            dgvCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(14, 101);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.Size = new Size(887, 437);
            dgvCustomer.TabIndex = 0;
            dgvCustomer.CellContentDoubleClick += dgvCustomer_CellContentDoubleClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(249, 245, 238);
            panel1.Controls.Add(btnChooseCustomer);
            panel1.Controls.Add(txtFindCustomer);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 81);
            panel1.TabIndex = 1;
            // 
            // txtFindCustomer
            // 
            txtFindCustomer.Location = new Point(127, 26);
            txtFindCustomer.Name = "txtFindCustomer";
            txtFindCustomer.Size = new Size(386, 30);
            txtFindCustomer.TabIndex = 1;
            txtFindCustomer.TextChanged += txtFindCustomer_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm:";
            // 
            // btnChooseCustomer
            // 
            btnChooseCustomer.BackColor = SystemColors.Control;
            btnChooseCustomer.Image = Properties.Resources.pen;
            btnChooseCustomer.ImageAlign = ContentAlignment.MiddleRight;
            btnChooseCustomer.Location = new Point(531, 19);
            btnChooseCustomer.Name = "btnChooseCustomer";
            btnChooseCustomer.Size = new Size(195, 42);
            btnChooseCustomer.TabIndex = 5;
            btnChooseCustomer.Text = "Chưa có tài khoản";
            btnChooseCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChooseCustomer.UseVisualStyleBackColor = false;
            btnChooseCustomer.Click += btnChooseCustomer_Click;
            // 
            // frmCustomerList
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(74, 60, 60);
            ClientSize = new Size(914, 550);
            Controls.Add(panel1);
            Controls.Add(dgvCustomer);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCustomerList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách khách hàng";
            Load += frmCustomerList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCustomer;
        private Panel panel1;
        private TextBox txtFindCustomer;
        private Label label1;
        private Button btnChooseCustomer;
    }
}