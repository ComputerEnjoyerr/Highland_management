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
            textBox2 = new TextBox();
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
            txtDrips = new TextBox();
            label9 = new Label();
            txtPoint = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Dock = DockStyle.Fill;
            dgvCustomer.Location = new Point(0, 201);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.Size = new Size(992, 529);
            dgvCustomer.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 22);
            label6.Name = "label6";
            label6.Size = new Size(58, 19);
            label6.TabIndex = 26;
            label6.Text = "Mã KH:";
            // 
            // txtId
            // 
            txtId.Location = new Point(104, 16);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(204, 25);
            txtId.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 53);
            label5.Name = "label5";
            label5.Size = new Size(58, 19);
            label5.TabIndex = 25;
            label5.Text = "Họ tên:";
            // 
            // txtName
            // 
            txtName.Location = new Point(104, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(204, 25);
            txtName.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 165);
            label4.Name = "label4";
            label4.Size = new Size(119, 19);
            label4.TabIndex = 25;
            label4.Text = "Tìm Khách hàng:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 25);
            textBox2.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 118);
            label8.Name = "label8";
            label8.Size = new Size(49, 19);
            label8.TabIndex = 23;
            label8.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(104, 115);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 25);
            txtEmail.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 84);
            label3.Name = "label3";
            label3.Size = new Size(39, 19);
            label3.TabIndex = 23;
            label3.Text = "SĐT:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(104, 78);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(204, 25);
            txtPhone.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 84);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 22;
            label2.Text = "Hạng:";
            // 
            // cboTier
            // 
            cboTier.FormattingEnabled = true;
            cboTier.Location = new Point(396, 78);
            cboTier.Name = "cboTier";
            cboTier.Size = new Size(185, 25);
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
            // 
            // panel1
            // 
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(cboTier);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtDrips);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtPoint);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox2);
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
            // txtDrips
            // 
            txtDrips.Location = new Point(396, 47);
            txtDrips.Name = "txtDrips";
            txtDrips.Size = new Size(185, 25);
            txtDrips.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(322, 50);
            label9.Name = "label9";
            label9.Size = new Size(48, 19);
            label9.TabIndex = 23;
            label9.Text = "Drips:";
            // 
            // txtPoint
            // 
            txtPoint.Location = new Point(396, 16);
            txtPoint.Name = "txtPoint";
            txtPoint.Size = new Size(185, 25);
            txtPoint.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 19);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
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
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCustomer;
        private Label label6;
        private TextBox txtId;
        private Label label5;
        private TextBox txtName;
        private Label label4;
        private TextBox textBox2;
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
        private TextBox txtDrips;
        private Label label9;
        private TextBox txtPoint;
        private Label label1;
    }
}