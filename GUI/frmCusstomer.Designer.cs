namespace GUI
{
    partial class frmCusstomer
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
            dgvCustomer = new DataGridView();
            label6 = new Label();
            txtId = new TextBox();
            label5 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            txtFindCustomer = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label2 = new Label();
            cboTier = new ComboBox();
            btnDelete = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            panel1 = new Panel();
            nmrPoint = new NumericUpDown();
            nmrDrips = new NumericUpDown();
            label9 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrPoint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrDrips).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Dock = DockStyle.Fill;
            dgvCustomer.Location = new Point(0, 201);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.Size = new Size(992, 529);
            dgvCustomer.TabIndex = 5;
            dgvCustomer.CellClick += dgvCustomer_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 25);
            label6.Name = "label6";
            label6.Size = new Size(69, 23);
            label6.TabIndex = 26;
            label6.Text = "Mã KH:";
            // 
            // txtId
            // 
            txtId.Location = new Point(104, 19);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(204, 30);
            txtId.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 60);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 25;
            label5.Text = "Họ tên:";
            // 
            // txtName
            // 
            txtName.Location = new Point(104, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(204, 30);
            txtName.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 165);
            label4.Name = "label4";
            label4.Size = new Size(144, 23);
            label4.TabIndex = 25;
            label4.Text = "Tìm Khách hàng:";
            // 
            // txtFindCustomer
            // 
            txtFindCustomer.Location = new Point(167, 162);
            txtFindCustomer.Name = "txtFindCustomer";
            txtFindCustomer.Size = new Size(300, 30);
            txtFindCustomer.TabIndex = 29;
            txtFindCustomer.TextChanged += textBox2_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 124);
            label8.Name = "label8";
            label8.Size = new Size(59, 23);
            label8.TabIndex = 23;
            label8.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(104, 121);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 30);
            txtEmail.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 93);
            label3.Name = "label3";
            label3.Size = new Size(48, 23);
            label3.TabIndex = 23;
            label3.Text = "SĐT:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(104, 87);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(204, 30);
            txtPhone.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 93);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 22;
            label2.Text = "Hạng:";
            // 
            // cboTier
            // 
            cboTier.FormattingEnabled = true;
            cboTier.Location = new Point(396, 87);
            cboTier.Name = "cboTier";
            cboTier.Size = new Size(185, 31);
            cboTier.TabIndex = 31;
            cboTier.SelectedIndexChanged += cboTier_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(169, 65, 65);
            btnDelete.Location = new Point(789, 16);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(145, 53);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(104, 176, 145);
            btnAdd.Location = new Point(638, 16);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 53);
            btnAdd.TabIndex = 32;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Location = new Point(789, 75);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 53);
            btnClear.TabIndex = 33;
            btnClear.Text = "Hoàn tác";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(230, 181, 56);
            btnUpdate.Location = new Point(638, 75);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(145, 53);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Lưu";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(nmrPoint);
            panel1.Controls.Add(nmrDrips);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(cboTier);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtFindCustomer);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 201);
            panel1.TabIndex = 4;
            // 
            // nmrPoint
            // 
            nmrPoint.Location = new Point(396, 19);
            nmrPoint.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmrPoint.Name = "nmrPoint";
            nmrPoint.Size = new Size(185, 30);
            nmrPoint.TabIndex = 34;
            // 
            // nmrDrips
            // 
            nmrDrips.Location = new Point(396, 53);
            nmrDrips.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmrDrips.Name = "nmrDrips";
            nmrDrips.Size = new Size(185, 30);
            nmrDrips.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(322, 50);
            label9.Name = "label9";
            label9.Size = new Size(58, 23);
            label9.TabIndex = 23;
            label9.Text = "Drips:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 22);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 23;
            label1.Text = "Điểm:";
            // 
            // frmCusstomer
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(992, 730);
            Controls.Add(dgvCustomer);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "frmCusstomer";
            Text = "frmCusstomer";
            Load += frmCusstomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrPoint).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrDrips).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCustomer;
        private Label label6;
        private TextBox txtId;
        private Label label5;
        private TextBox txtName;
        private Label label4;
        private TextBox txtFindCustomer;
        private Label label8;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtPhone;
        private Label label2;
        private ComboBox cboTier;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnClear;
        private Button btnUpdate;
        private Panel panel1;
        private Label label9;
        private Label label1;
        private NumericUpDown nmrDrips;
        private NumericUpDown nmrPoint;
    }
}