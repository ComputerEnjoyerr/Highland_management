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
            dtpDOB = new DateTimePicker();
            nmrPoint = new NumericUpDown();
            nmrDrips = new NumericUpDown();
            cboGender = new ComboBox();
            label7 = new Label();
            label9 = new Label();
            label1 = new Label();
            label10 = new Label();
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
            dgvCustomer.Location = new Point(0, 431);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.Size = new Size(992, 299);
            dgvCustomer.TabIndex = 5;
            dgvCustomer.CellClick += dgvCustomer_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 51);
            label6.Name = "label6";
            label6.Size = new Size(58, 19);
            label6.TabIndex = 26;
            label6.Text = "Mã KH:";
            // 
            // txtId
            // 
            txtId.Location = new Point(144, 45);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(480, 25);
            txtId.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 88);
            label5.Name = "label5";
            label5.Size = new Size(58, 19);
            label5.TabIndex = 25;
            label5.Text = "Họ tên:";
            // 
            // txtName
            // 
            txtName.Location = new Point(144, 82);
            txtName.Name = "txtName";
            txtName.Size = new Size(480, 25);
            txtName.TabIndex = 29;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(35, 403);
            label4.Name = "label4";
            label4.Size = new Size(119, 19);
            label4.TabIndex = 25;
            label4.Text = "Tìm Khách hàng:";
            // 
            // txtFindCustomer
            // 
            txtFindCustomer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtFindCustomer.Location = new Point(185, 400);
            txtFindCustomer.Name = "txtFindCustomer";
            txtFindCustomer.Size = new Size(743, 25);
            txtFindCustomer.TabIndex = 29;
            txtFindCustomer.TextChanged += textBox2_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 157);
            label8.Name = "label8";
            label8.Size = new Size(49, 19);
            label8.TabIndex = 23;
            label8.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(143, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(480, 25);
            txtEmail.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 124);
            label3.Name = "label3";
            label3.Size = new Size(39, 19);
            label3.TabIndex = 23;
            label3.Text = "SĐT:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(143, 118);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(480, 25);
            txtPhone.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(745, 123);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 22;
            label2.Text = "Hạng:";
            // 
            // cboTier
            // 
            cboTier.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboTier.FormattingEnabled = true;
            cboTier.Location = new Point(837, 117);
            cboTier.Name = "cboTier";
            cboTier.Size = new Size(21, 25);
            cboTier.TabIndex = 31;
            cboTier.SelectedIndexChanged += cboTier_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Control;
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.ImageAlign = ContentAlignment.MiddleRight;
            btnDelete.Location = new Point(206, 253);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 57);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Xóa";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Image = Properties.Resources.plus;
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(35, 253);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(144, 57);
            btnAdd.TabIndex = 32;
            btnAdd.Text = "Thêm";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Control;
            btnClear.Image = Properties.Resources.arrow;
            btnClear.ImageAlign = ContentAlignment.MiddleRight;
            btnClear.Location = new Point(542, 253);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(144, 57);
            btnClear.TabIndex = 33;
            btnClear.Text = "Hoàn tác";
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Control;
            btnUpdate.Image = Properties.Resources.pen;
            btnUpdate.ImageAlign = ContentAlignment.MiddleRight;
            btnUpdate.Location = new Point(375, 253);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(144, 57);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Lưu";
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 245, 238);
            panel1.Controls.Add(dtpDOB);
            panel1.Controls.Add(nmrPoint);
            panel1.Controls.Add(nmrDrips);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(cboGender);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cboTier);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label10);
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
            panel1.Size = new Size(992, 431);
            panel1.TabIndex = 4;
            // 
            // dtpDOB
            // 
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(143, 190);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(156, 25);
            dtpDOB.TabIndex = 35;
            // 
            // nmrPoint
            // 
            nmrPoint.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nmrPoint.Location = new Point(838, 44);
            nmrPoint.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmrPoint.Name = "nmrPoint";
            nmrPoint.Size = new Size(21, 25);
            nmrPoint.TabIndex = 34;
            nmrPoint.ValueChanged += nmrPoint_ValueChanged;
            // 
            // nmrDrips
            // 
            nmrDrips.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nmrDrips.Location = new Point(838, 80);
            nmrDrips.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmrDrips.Name = "nmrDrips";
            nmrDrips.Size = new Size(21, 25);
            nmrDrips.TabIndex = 34;
            // 
            // cboGender
            // 
            cboGender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(837, 153);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(21, 25);
            cboGender.TabIndex = 31;
            cboGender.SelectedIndexChanged += cboTier_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(745, 159);
            label7.Name = "label7";
            label7.Size = new Size(69, 19);
            label7.TabIndex = 22;
            label7.Text = "Giới tính:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(746, 87);
            label9.Name = "label9";
            label9.Size = new Size(48, 19);
            label9.TabIndex = 23;
            label9.Text = "Drips:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(746, 47);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 23;
            label1.Text = "Điểm:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(34, 196);
            label10.Name = "label10";
            label10.Size = new Size(79, 19);
            label10.TabIndex = 23;
            label10.Text = "Ngày sinh:";
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
        private ComboBox cboGender;
        private Label label7;
        private DateTimePicker dtpDOB;
        private Label label10;
    }
}