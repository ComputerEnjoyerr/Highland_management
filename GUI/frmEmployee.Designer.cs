namespace GUI
{
    partial class frmEmployee
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
            tctEmployeeAccount = new TabControl();
            tabPage1 = new TabPage();
            dgvEmployee = new DataGridView();
            panel1 = new Panel();
            btnPrintReport = new Button();
            cboStatus = new ComboBox();
            label23 = new Label();
            btnSave = new Button();
            btnReset = new Button();
            dtpDateOfBirth = new DateTimePicker();
            btnAdd = new Button();
            cboGender = new ComboBox();
            btnDelete = new Button();
            label22 = new Label();
            label21 = new Label();
            txtCitizenId = new TextBox();
            label20 = new Label();
            cboRole = new ComboBox();
            cboProvince = new ComboBox();
            label2 = new Label();
            cboWard = new ComboBox();
            label1 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtSalary = new TextBox();
            label13 = new Label();
            txtAddress = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtFind = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label5 = new Label();
            txtId = new TextBox();
            label6 = new Label();
            tabPage2 = new TabPage();
            dgvAccount = new DataGridView();
            panel2 = new Panel();
            btnSaveA = new Button();
            btnResetA = new Button();
            btnAddA = new Button();
            btnDeleteA = new Button();
            label10 = new Label();
            txtRePassword = new TextBox();
            txtPassword = new TextBox();
            label12 = new Label();
            txtFindA = new TextBox();
            label14 = new Label();
            txtAccount = new TextBox();
            label15 = new Label();
            txtAccountId = new TextBox();
            label11 = new Label();
            txtAId = new TextBox();
            label9 = new Label();
            txtAName = new TextBox();
            label16 = new Label();
            tctEmployeeAccount.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tctEmployeeAccount
            // 
            tctEmployeeAccount.Controls.Add(tabPage1);
            tctEmployeeAccount.Controls.Add(tabPage2);
            tctEmployeeAccount.Dock = DockStyle.Fill;
            tctEmployeeAccount.Location = new Point(0, 0);
            tctEmployeeAccount.Name = "tctEmployeeAccount";
            tctEmployeeAccount.SelectedIndex = 0;
            tctEmployeeAccount.Size = new Size(1138, 710);
            tctEmployeeAccount.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvEmployee);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1130, 674);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Nhân viên";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvEmployee
            // 
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Dock = DockStyle.Fill;
            dgvEmployee.Location = new Point(3, 407);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.Size = new Size(1124, 264);
            dgvEmployee.TabIndex = 3;
            dgvEmployee.CellClick += dgvEmployee_CellClick;
            dgvEmployee.CellContentDoubleClick += dgvEmployee_CellContentDoubleClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnPrintReport);
            panel1.Controls.Add(cboStatus);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(dtpDateOfBirth);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(cboGender);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(label22);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(txtCitizenId);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(cboRole);
            panel1.Controls.Add(cboProvince);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cboWard);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSalary);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtFind);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1124, 404);
            panel1.TabIndex = 2;
            // 
            // btnPrintReport
            // 
            btnPrintReport.Image = Properties.Resources.printer;
            btnPrintReport.ImageAlign = ContentAlignment.MiddleRight;
            btnPrintReport.Location = new Point(628, 288);
            btnPrintReport.Name = "btnPrintReport";
            btnPrintReport.Size = new Size(237, 58);
            btnPrintReport.TabIndex = 67;
            btnPrintReport.Text = "In Thông Tin Nhân Viên";
            btnPrintReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrintReport.UseVisualStyleBackColor = true;
            btnPrintReport.Click += btnPrintReport_Click;
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(685, 202);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(240, 31);
            cboStatus.TabIndex = 66;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(571, 206);
            label23.Name = "label23";
            label23.Size = new Size(97, 23);
            label23.TabIndex = 65;
            label23.Text = "Trạng thái:";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.Image = Properties.Resources.pen;
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(317, 288);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(128, 58);
            btnSave.TabIndex = 52;
            btnSave.Text = "Lưu";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.Control;
            btnReset.Image = Properties.Resources.arrow;
            btnReset.ImageAlign = ContentAlignment.MiddleRight;
            btnReset.Location = new Point(463, 288);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(128, 58);
            btnReset.TabIndex = 54;
            btnReset.Text = "Hoàn tác";
            btnReset.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(147, 200);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(167, 30);
            dtpDateOfBirth.TabIndex = 64;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Image = Properties.Resources.plus;
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(23, 288);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 58);
            btnAdd.TabIndex = 53;
            btnAdd.Text = "Thêm";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(147, 163);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(167, 31);
            cboGender.TabIndex = 63;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Control;
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.ImageAlign = ContentAlignment.MiddleRight;
            btnDelete.Location = new Point(171, 288);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 58);
            btnDelete.TabIndex = 55;
            btnDelete.Text = "Xóa";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(29, 202);
            label22.Name = "label22";
            label22.Size = new Size(94, 23);
            label22.TabIndex = 61;
            label22.Text = "Ngày sinh:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(29, 167);
            label21.Name = "label21";
            label21.Size = new Size(85, 23);
            label21.TabIndex = 62;
            label21.Text = "Giới tính:";
            // 
            // txtCitizenId
            // 
            txtCitizenId.Location = new Point(147, 54);
            txtCitizenId.Name = "txtCitizenId";
            txtCitizenId.Size = new Size(333, 30);
            txtCitizenId.TabIndex = 55;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(23, 58);
            label20.Name = "label20";
            label20.Size = new Size(120, 23);
            label20.TabIndex = 25;
            label20.Text = "CCCD/CMND:";
            // 
            // cboRole
            // 
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(147, 126);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(333, 31);
            cboRole.TabIndex = 31;
            // 
            // cboProvince
            // 
            cboProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvince.FormattingEnabled = true;
            cboProvince.Location = new Point(685, 91);
            cboProvince.Name = "cboProvince";
            cboProvince.Size = new Size(394, 31);
            cboProvince.TabIndex = 31;
            cboProvince.SelectedIndexChanged += cboProvince_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(574, 97);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 22;
            label2.Text = "Tỉnh/TP:";
            // 
            // cboWard
            // 
            cboWard.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWard.FormattingEnabled = true;
            cboWard.Location = new Point(685, 54);
            cboWard.Name = "cboWard";
            cboWard.Size = new Size(394, 31);
            cboWard.TabIndex = 31;
            cboWard.SelectedIndexChanged += cboWard_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(574, 60);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 22;
            label1.Text = "Xã/Phường:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(685, 164);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(240, 30);
            txtPhone.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(574, 167);
            label3.Name = "label3";
            label3.Size = new Size(48, 23);
            label3.TabIndex = 23;
            label3.Text = "SĐT:";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(685, 128);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(240, 30);
            txtSalary.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(574, 131);
            label13.Name = "label13";
            label13.Size = new Size(103, 23);
            label13.TabIndex = 23;
            label13.Text = "Lương/Giờ:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(685, 18);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(394, 30);
            txtAddress.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(574, 26);
            label8.Name = "label8";
            label8.Size = new Size(70, 23);
            label8.TabIndex = 23;
            label8.Text = "Địa chỉ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 131);
            label7.Name = "label7";
            label7.Size = new Size(79, 23);
            label7.TabIndex = 24;
            label7.Text = "Chức vụ:";
            // 
            // txtFind
            // 
            txtFind.Location = new Point(89, 368);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(571, 30);
            txtFind.TabIndex = 29;
            txtFind.TextChanged += txtFind_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 374);
            label4.Name = "label4";
            label4.Size = new Size(46, 23);
            label4.TabIndex = 25;
            label4.Text = "Tìm:";
            // 
            // txtName
            // 
            txtName.Location = new Point(147, 90);
            txtName.Name = "txtName";
            txtName.Size = new Size(333, 30);
            txtName.TabIndex = 29;
            txtName.Leave += txtName_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 93);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 25;
            label5.Text = "Họ tên:";
            // 
            // txtId
            // 
            txtId.Location = new Point(147, 18);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(333, 30);
            txtId.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 25);
            label6.Name = "label6";
            label6.Size = new Size(69, 23);
            label6.TabIndex = 26;
            label6.Text = "Mã NV:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvAccount);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1130, 674);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tài khoản nhân viên";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvAccount
            // 
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Dock = DockStyle.Fill;
            dgvAccount.Location = new Point(3, 290);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.Size = new Size(1124, 381);
            dgvAccount.TabIndex = 5;
            dgvAccount.CellClick += dgvAccount_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSaveA);
            panel2.Controls.Add(btnResetA);
            panel2.Controls.Add(btnAddA);
            panel2.Controls.Add(btnDeleteA);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtRePassword);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtFindA);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(txtAccount);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(txtAccountId);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtAId);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtAName);
            panel2.Controls.Add(label16);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1124, 287);
            panel2.TabIndex = 4;
            // 
            // btnSaveA
            // 
            btnSaveA.BackColor = SystemColors.Control;
            btnSaveA.Image = Properties.Resources.pen;
            btnSaveA.ImageAlign = ContentAlignment.MiddleRight;
            btnSaveA.Location = new Point(315, 132);
            btnSaveA.Name = "btnSaveA";
            btnSaveA.Size = new Size(128, 58);
            btnSaveA.TabIndex = 56;
            btnSaveA.Text = "Lưu";
            btnSaveA.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaveA.UseVisualStyleBackColor = false;
            btnSaveA.Click += btnSaveA_Click;
            // 
            // btnResetA
            // 
            btnResetA.BackColor = SystemColors.Control;
            btnResetA.Image = Properties.Resources.arrow;
            btnResetA.ImageAlign = ContentAlignment.MiddleRight;
            btnResetA.Location = new Point(461, 132);
            btnResetA.Name = "btnResetA";
            btnResetA.Size = new Size(128, 58);
            btnResetA.TabIndex = 58;
            btnResetA.Text = "Hoàn tác";
            btnResetA.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnResetA.UseVisualStyleBackColor = false;
            btnResetA.Click += btnResetA_Click;
            // 
            // btnAddA
            // 
            btnAddA.BackColor = SystemColors.Control;
            btnAddA.Image = Properties.Resources.plus;
            btnAddA.ImageAlign = ContentAlignment.MiddleRight;
            btnAddA.Location = new Point(21, 132);
            btnAddA.Name = "btnAddA";
            btnAddA.Size = new Size(128, 58);
            btnAddA.TabIndex = 57;
            btnAddA.Text = "Thêm";
            btnAddA.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddA.UseVisualStyleBackColor = false;
            btnAddA.Click += btnAddA_Click;
            // 
            // btnDeleteA
            // 
            btnDeleteA.BackColor = SystemColors.Control;
            btnDeleteA.Image = Properties.Resources.delete;
            btnDeleteA.ImageAlign = ContentAlignment.MiddleRight;
            btnDeleteA.Location = new Point(169, 132);
            btnDeleteA.Name = "btnDeleteA";
            btnDeleteA.Size = new Size(128, 58);
            btnDeleteA.TabIndex = 59;
            btnDeleteA.Text = "Xóa";
            btnDeleteA.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteA.UseVisualStyleBackColor = false;
            btnDeleteA.Click += btnDeleteA_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(475, 86);
            label10.Name = "label10";
            label10.Size = new Size(114, 23);
            label10.TabIndex = 22;
            label10.Text = "Nhập lại MK:";
            // 
            // txtRePassword
            // 
            txtRePassword.Location = new Point(592, 77);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.Size = new Size(320, 30);
            txtRePassword.TabIndex = 27;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(592, 46);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(320, 30);
            txtPassword.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(475, 49);
            label12.Name = "label12";
            label12.Size = new Size(91, 23);
            label12.TabIndex = 23;
            label12.Text = "Mật khẩu:";
            // 
            // txtFindA
            // 
            txtFindA.Location = new Point(91, 251);
            txtFindA.Name = "txtFindA";
            txtFindA.Size = new Size(451, 30);
            txtFindA.TabIndex = 29;
            txtFindA.TextChanged += txtFindA_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(41, 257);
            label14.Name = "label14";
            label14.Size = new Size(46, 23);
            label14.TabIndex = 25;
            label14.Text = "Tìm:";
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(100, 78);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(308, 30);
            txtAccount.TabIndex = 29;
            txtAccount.Leave += txtAccount_Leave;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(21, 84);
            label15.Name = "label15";
            label15.Size = new Size(68, 23);
            label15.TabIndex = 25;
            label15.Text = "Tên TK:";
            // 
            // txtAccountId
            // 
            txtAccountId.Location = new Point(592, 15);
            txtAccountId.Name = "txtAccountId";
            txtAccountId.ReadOnly = true;
            txtAccountId.Size = new Size(320, 30);
            txtAccountId.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(476, 21);
            label11.Name = "label11";
            label11.Size = new Size(66, 23);
            label11.TabIndex = 26;
            label11.Text = "Mã TK:";
            // 
            // txtAId
            // 
            txtAId.Location = new Point(100, 16);
            txtAId.Name = "txtAId";
            txtAId.ReadOnly = true;
            txtAId.Size = new Size(308, 30);
            txtAId.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 22);
            label9.Name = "label9";
            label9.Size = new Size(69, 23);
            label9.TabIndex = 26;
            label9.Text = "Mã NV:";
            // 
            // txtAName
            // 
            txtAName.Location = new Point(100, 47);
            txtAName.Name = "txtAName";
            txtAName.ReadOnly = true;
            txtAName.Size = new Size(308, 30);
            txtAName.TabIndex = 30;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(21, 53);
            label16.Name = "label16";
            label16.Size = new Size(69, 23);
            label16.TabIndex = 26;
            label16.Text = "Họ tên:";
            // 
            // frmEmployee
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1138, 710);
            Controls.Add(tctEmployeeAccount);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "frmEmployee";
            Text = "frmEmployee";
            Load += frmEmployee_Load;
            tctEmployeeAccount.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tctEmployeeAccount;
        private TabPage tabPage1;
        private DataGridView dgvEmployee;
        private Panel panel1;
        private ComboBox cboProvince;
        private Label label2;
        private ComboBox cboWard;
        private Label label1;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtAddress;
        private Label label8;
        private Label label7;
        private TextBox txtFind;
        private Label label4;
        private TextBox txtName;
        private Label label5;
        private TextBox txtId;
        private Label label6;
        private TabPage tabPage2;
        private DataGridView dgvAccount;
        private Panel panel2;
        private Label label10;
        private TextBox txtPassword;
        private Label label12;
        private TextBox txtFindA;
        private Label label14;
        private TextBox txtAccount;
        private Label label15;
        private TextBox txtAName;
        private Label label16;
        private TextBox txtAccountId;
        private Label label11;
        private TextBox txtAId;
        private Label label9;
        private TextBox txtRePassword;
        private ComboBox cboRole;
        private TextBox txtSalary;
        private Label label13;
        private TextBox txtCitizenId;
        private Label label20;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cboGender;
        private Label label22;
        private Label label21;
        private Button btnSave;
        private Button btnReset;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSaveA;
        private Button btnResetA;
        private Button btnAddA;
        private Button btnDeleteA;
        private ComboBox cboStatus;
        private Label label23;
        private Button btnPrintReport;
    }
}