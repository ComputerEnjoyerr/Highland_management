namespace GUI
{
    partial class frmScheduleInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleInfo));
            tabPage3 = new TabPage();
            cboShiftEvening = new ComboBox();
            label3 = new Label();
            txtAddressEvening = new TextBox();
            label20 = new Label();
            txtRoleEvening = new TextBox();
            label21 = new Label();
            txtNameEvening = new TextBox();
            label22 = new Label();
            txtIdEvening = new TextBox();
            label23 = new Label();
            btnCancelEvening = new Button();
            txtFindEvening = new TextBox();
            label24 = new Label();
            dgvShiftEvening = new DataGridView();
            tabPage2 = new TabPage();
            cboShiftAfternoon = new ComboBox();
            label2 = new Label();
            txtAddressAfternoon = new TextBox();
            label15 = new Label();
            txtRoleAfternoon = new TextBox();
            label16 = new Label();
            txtNameAfternoon = new TextBox();
            label17 = new Label();
            txtIdAfternoon = new TextBox();
            label18 = new Label();
            btnCancelAfternoon = new Button();
            txtFindAfternoon = new TextBox();
            label19 = new Label();
            dgvShiftAfternoon = new DataGridView();
            tabPage1 = new TabPage();
            cboShiftMorning = new ComboBox();
            label1 = new Label();
            txtAddressMorning = new TextBox();
            label10 = new Label();
            txtRoleMorning = new TextBox();
            label11 = new Label();
            txtNameMorning = new TextBox();
            label12 = new Label();
            txtIdMorning = new TextBox();
            label13 = new Label();
            btnCancelMorning = new Button();
            txtFindMorning = new TextBox();
            label14 = new Label();
            dgvShiftMorning = new DataGridView();
            tabControl1 = new TabControl();
            tabPage4 = new TabPage();
            label25 = new Label();
            txtNote = new TextBox();
            btnRegister = new Button();
            cboEmployeeShift = new ComboBox();
            label9 = new Label();
            txtEmployeeAddress = new TextBox();
            label8 = new Label();
            txtEmployeeRole = new TextBox();
            label7 = new Label();
            txtEmployeeName = new TextBox();
            label5 = new Label();
            txtEmployeeId = new TextBox();
            label6 = new Label();
            txtEmployeeFind = new TextBox();
            label4 = new Label();
            dgvSchedule = new DataGridView();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShiftEvening).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShiftAfternoon).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShiftMorning).BeginInit();
            tabControl1.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(249, 245, 238);
            tabPage3.Controls.Add(cboShiftEvening);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(txtAddressEvening);
            tabPage3.Controls.Add(label20);
            tabPage3.Controls.Add(txtRoleEvening);
            tabPage3.Controls.Add(label21);
            tabPage3.Controls.Add(txtNameEvening);
            tabPage3.Controls.Add(label22);
            tabPage3.Controls.Add(txtIdEvening);
            tabPage3.Controls.Add(label23);
            tabPage3.Controls.Add(btnCancelEvening);
            tabPage3.Controls.Add(txtFindEvening);
            tabPage3.Controls.Add(label24);
            tabPage3.Controls.Add(dgvShiftEvening);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(906, 514);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Ca tối";
            // 
            // cboShiftEvening
            // 
            cboShiftEvening.DropDownStyle = ComboBoxStyle.DropDownList;
            cboShiftEvening.FormattingEnabled = true;
            cboShiftEvening.Location = new Point(414, 37);
            cboShiftEvening.Name = "cboShiftEvening";
            cboShiftEvening.Size = new Size(121, 31);
            cboShiftEvening.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(306, 43);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 38;
            label3.Text = "Ca làm việc:";
            // 
            // txtAddressEvening
            // 
            txtAddressEvening.Location = new Point(414, 6);
            txtAddressEvening.Name = "txtAddressEvening";
            txtAddressEvening.ReadOnly = true;
            txtAddressEvening.Size = new Size(371, 30);
            txtAddressEvening.TabIndex = 43;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(306, 12);
            label20.Name = "label20";
            label20.Size = new Size(70, 23);
            label20.TabIndex = 39;
            label20.Text = "Địa chỉ:";
            // 
            // txtRoleEvening
            // 
            txtRoleEvening.Location = new Point(89, 68);
            txtRoleEvening.Name = "txtRoleEvening";
            txtRoleEvening.ReadOnly = true;
            txtRoleEvening.Size = new Size(204, 30);
            txtRoleEvening.TabIndex = 44;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(9, 74);
            label21.Name = "label21";
            label21.Size = new Size(79, 23);
            label21.TabIndex = 40;
            label21.Text = "Chức vụ:";
            // 
            // txtNameEvening
            // 
            txtNameEvening.Location = new Point(89, 37);
            txtNameEvening.Name = "txtNameEvening";
            txtNameEvening.ReadOnly = true;
            txtNameEvening.Size = new Size(204, 30);
            txtNameEvening.TabIndex = 45;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(9, 43);
            label22.Name = "label22";
            label22.Size = new Size(69, 23);
            label22.TabIndex = 41;
            label22.Text = "Họ tên:";
            // 
            // txtIdEvening
            // 
            txtIdEvening.Location = new Point(89, 6);
            txtIdEvening.Name = "txtIdEvening";
            txtIdEvening.ReadOnly = true;
            txtIdEvening.Size = new Size(204, 30);
            txtIdEvening.TabIndex = 46;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(9, 12);
            label23.Name = "label23";
            label23.Size = new Size(69, 23);
            label23.TabIndex = 42;
            label23.Text = "Mã NV:";
            // 
            // btnCancelEvening
            // 
            btnCancelEvening.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelEvening.BackColor = SystemColors.Control;
            btnCancelEvening.Image = Properties.Resources.delete;
            btnCancelEvening.ImageAlign = ContentAlignment.MiddleRight;
            btnCancelEvening.Location = new Point(640, 47);
            btnCancelEvening.Name = "btnCancelEvening";
            btnCancelEvening.Size = new Size(145, 45);
            btnCancelEvening.TabIndex = 37;
            btnCancelEvening.Text = "Hủy ca";
            btnCancelEvening.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelEvening.UseVisualStyleBackColor = false;
            btnCancelEvening.Click += btnCancelEvening_Click;
            // 
            // txtFindEvening
            // 
            txtFindEvening.Location = new Point(141, 112);
            txtFindEvening.Name = "txtFindEvening";
            txtFindEvening.Size = new Size(357, 30);
            txtFindEvening.TabIndex = 25;
            txtFindEvening.TextChanged += txtFindEvening_TextChanged;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(7, 119);
            label24.Name = "label24";
            label24.Size = new Size(128, 23);
            label24.TabIndex = 24;
            label24.Text = "Tìm nhân viên:";
            // 
            // dgvShiftEvening
            // 
            dgvShiftEvening.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShiftEvening.Location = new Point(7, 146);
            dgvShiftEvening.Name = "dgvShiftEvening";
            dgvShiftEvening.RowHeadersWidth = 51;
            dgvShiftEvening.Size = new Size(892, 365);
            dgvShiftEvening.TabIndex = 23;
            dgvShiftEvening.CellClick += dgvShiftEvening_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(249, 245, 238);
            tabPage2.Controls.Add(cboShiftAfternoon);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txtAddressAfternoon);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(txtRoleAfternoon);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(txtNameAfternoon);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(txtIdAfternoon);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(btnCancelAfternoon);
            tabPage2.Controls.Add(txtFindAfternoon);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(dgvShiftAfternoon);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(906, 517);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ca chiều";
            // 
            // cboShiftAfternoon
            // 
            cboShiftAfternoon.DropDownStyle = ComboBoxStyle.DropDownList;
            cboShiftAfternoon.FormattingEnabled = true;
            cboShiftAfternoon.Location = new Point(412, 37);
            cboShiftAfternoon.Name = "cboShiftAfternoon";
            cboShiftAfternoon.Size = new Size(121, 31);
            cboShiftAfternoon.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 43);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 38;
            label2.Text = "Ca làm việc:";
            // 
            // txtAddressAfternoon
            // 
            txtAddressAfternoon.Location = new Point(412, 6);
            txtAddressAfternoon.Name = "txtAddressAfternoon";
            txtAddressAfternoon.ReadOnly = true;
            txtAddressAfternoon.Size = new Size(371, 30);
            txtAddressAfternoon.TabIndex = 43;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(304, 12);
            label15.Name = "label15";
            label15.Size = new Size(70, 23);
            label15.TabIndex = 39;
            label15.Text = "Địa chỉ:";
            // 
            // txtRoleAfternoon
            // 
            txtRoleAfternoon.Location = new Point(87, 68);
            txtRoleAfternoon.Name = "txtRoleAfternoon";
            txtRoleAfternoon.ReadOnly = true;
            txtRoleAfternoon.Size = new Size(204, 30);
            txtRoleAfternoon.TabIndex = 44;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(7, 74);
            label16.Name = "label16";
            label16.Size = new Size(79, 23);
            label16.TabIndex = 40;
            label16.Text = "Chức vụ:";
            // 
            // txtNameAfternoon
            // 
            txtNameAfternoon.Location = new Point(87, 37);
            txtNameAfternoon.Name = "txtNameAfternoon";
            txtNameAfternoon.ReadOnly = true;
            txtNameAfternoon.Size = new Size(204, 30);
            txtNameAfternoon.TabIndex = 45;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(7, 43);
            label17.Name = "label17";
            label17.Size = new Size(69, 23);
            label17.TabIndex = 41;
            label17.Text = "Họ tên:";
            // 
            // txtIdAfternoon
            // 
            txtIdAfternoon.Location = new Point(87, 6);
            txtIdAfternoon.Name = "txtIdAfternoon";
            txtIdAfternoon.ReadOnly = true;
            txtIdAfternoon.Size = new Size(204, 30);
            txtIdAfternoon.TabIndex = 46;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(7, 12);
            label18.Name = "label18";
            label18.Size = new Size(69, 23);
            label18.TabIndex = 42;
            label18.Text = "Mã NV:";
            // 
            // btnCancelAfternoon
            // 
            btnCancelAfternoon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelAfternoon.BackColor = SystemColors.Control;
            btnCancelAfternoon.Image = Properties.Resources.delete;
            btnCancelAfternoon.ImageAlign = ContentAlignment.MiddleRight;
            btnCancelAfternoon.Location = new Point(638, 53);
            btnCancelAfternoon.Name = "btnCancelAfternoon";
            btnCancelAfternoon.Size = new Size(145, 45);
            btnCancelAfternoon.TabIndex = 37;
            btnCancelAfternoon.Text = "Hủy ca";
            btnCancelAfternoon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelAfternoon.UseVisualStyleBackColor = false;
            btnCancelAfternoon.Click += btnCancelAfternoon_Click;
            // 
            // txtFindAfternoon
            // 
            txtFindAfternoon.Location = new Point(141, 112);
            txtFindAfternoon.Name = "txtFindAfternoon";
            txtFindAfternoon.Size = new Size(357, 30);
            txtFindAfternoon.TabIndex = 25;
            txtFindAfternoon.TextChanged += txtFindAfternoon_TextChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(7, 119);
            label19.Name = "label19";
            label19.Size = new Size(128, 23);
            label19.TabIndex = 24;
            label19.Text = "Tìm nhân viên:";
            // 
            // dgvShiftAfternoon
            // 
            dgvShiftAfternoon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShiftAfternoon.Location = new Point(7, 146);
            dgvShiftAfternoon.Name = "dgvShiftAfternoon";
            dgvShiftAfternoon.RowHeadersWidth = 51;
            dgvShiftAfternoon.Size = new Size(892, 365);
            dgvShiftAfternoon.TabIndex = 23;
            dgvShiftAfternoon.CellClick += dgvShiftAfternoon_CellClick;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(249, 245, 238);
            tabPage1.Controls.Add(cboShiftMorning);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtAddressMorning);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(txtRoleMorning);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(txtNameMorning);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(txtIdMorning);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(btnCancelMorning);
            tabPage1.Controls.Add(txtFindMorning);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(dgvShiftMorning);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(906, 517);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ca sáng";
            // 
            // cboShiftMorning
            // 
            cboShiftMorning.DropDownStyle = ComboBoxStyle.DropDownList;
            cboShiftMorning.FormattingEnabled = true;
            cboShiftMorning.Location = new Point(417, 37);
            cboShiftMorning.Name = "cboShiftMorning";
            cboShiftMorning.Size = new Size(121, 31);
            cboShiftMorning.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 43);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 37;
            label1.Text = "Ca làm việc:";
            // 
            // txtAddressMorning
            // 
            txtAddressMorning.Location = new Point(417, 6);
            txtAddressMorning.Name = "txtAddressMorning";
            txtAddressMorning.ReadOnly = true;
            txtAddressMorning.Size = new Size(371, 30);
            txtAddressMorning.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(309, 12);
            label10.Name = "label10";
            label10.Size = new Size(70, 23);
            label10.TabIndex = 38;
            label10.Text = "Địa chỉ:";
            // 
            // txtRoleMorning
            // 
            txtRoleMorning.Location = new Point(92, 68);
            txtRoleMorning.Name = "txtRoleMorning";
            txtRoleMorning.ReadOnly = true;
            txtRoleMorning.Size = new Size(204, 30);
            txtRoleMorning.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 74);
            label11.Name = "label11";
            label11.Size = new Size(79, 23);
            label11.TabIndex = 39;
            label11.Text = "Chức vụ:";
            // 
            // txtNameMorning
            // 
            txtNameMorning.Location = new Point(92, 37);
            txtNameMorning.Name = "txtNameMorning";
            txtNameMorning.ReadOnly = true;
            txtNameMorning.Size = new Size(204, 30);
            txtNameMorning.TabIndex = 44;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 43);
            label12.Name = "label12";
            label12.Size = new Size(69, 23);
            label12.TabIndex = 40;
            label12.Text = "Họ tên:";
            // 
            // txtIdMorning
            // 
            txtIdMorning.Location = new Point(92, 6);
            txtIdMorning.Name = "txtIdMorning";
            txtIdMorning.ReadOnly = true;
            txtIdMorning.Size = new Size(204, 30);
            txtIdMorning.TabIndex = 45;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 12);
            label13.Name = "label13";
            label13.Size = new Size(69, 23);
            label13.TabIndex = 41;
            label13.Text = "Mã NV:";
            // 
            // btnCancelMorning
            // 
            btnCancelMorning.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelMorning.BackColor = SystemColors.Control;
            btnCancelMorning.Image = Properties.Resources.delete;
            btnCancelMorning.ImageAlign = ContentAlignment.MiddleRight;
            btnCancelMorning.Location = new Point(643, 53);
            btnCancelMorning.Name = "btnCancelMorning";
            btnCancelMorning.Size = new Size(145, 45);
            btnCancelMorning.TabIndex = 36;
            btnCancelMorning.Text = "Hủy ca";
            btnCancelMorning.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelMorning.UseVisualStyleBackColor = false;
            btnCancelMorning.Click += btnCancelMorning_Click;
            // 
            // txtFindMorning
            // 
            txtFindMorning.Location = new Point(141, 114);
            txtFindMorning.Name = "txtFindMorning";
            txtFindMorning.Size = new Size(357, 30);
            txtFindMorning.TabIndex = 25;
            txtFindMorning.TextChanged += txtFindMorning_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(7, 117);
            label14.Name = "label14";
            label14.Size = new Size(128, 23);
            label14.TabIndex = 24;
            label14.Text = "Tìm nhân viên:";
            // 
            // dgvShiftMorning
            // 
            dgvShiftMorning.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShiftMorning.Location = new Point(7, 146);
            dgvShiftMorning.Name = "dgvShiftMorning";
            dgvShiftMorning.RowHeadersWidth = 51;
            dgvShiftMorning.Size = new Size(892, 365);
            dgvShiftMorning.TabIndex = 23;
            dgvShiftMorning.CellClick += dgvShiftMorning_CellClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(914, 550);
            tabControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(249, 245, 238);
            tabPage4.Controls.Add(label25);
            tabPage4.Controls.Add(txtNote);
            tabPage4.Controls.Add(btnRegister);
            tabPage4.Controls.Add(cboEmployeeShift);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(txtEmployeeAddress);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(txtEmployeeRole);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(txtEmployeeName);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(txtEmployeeId);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(txtEmployeeFind);
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(dgvSchedule);
            tabPage4.Location = new Point(4, 32);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(906, 514);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Quản lý ca";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(305, 87);
            label25.Name = "label25";
            label25.Size = new Size(75, 23);
            label25.TabIndex = 24;
            label25.Text = "Ghi chú:";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(413, 83);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(371, 30);
            txtNote.TabIndex = 23;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRegister.BackColor = SystemColors.Control;
            btnRegister.Image = Properties.Resources.pen;
            btnRegister.ImageAlign = ContentAlignment.MiddleRight;
            btnRegister.Location = new Point(639, 113);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(145, 45);
            btnRegister.TabIndex = 22;
            btnRegister.Text = "Đăng kí";
            btnRegister.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // cboEmployeeShift
            // 
            cboEmployeeShift.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmployeeShift.FormattingEnabled = true;
            cboEmployeeShift.Location = new Point(413, 46);
            cboEmployeeShift.Name = "cboEmployeeShift";
            cboEmployeeShift.Size = new Size(121, 31);
            cboEmployeeShift.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(305, 52);
            label9.Name = "label9";
            label9.Size = new Size(106, 23);
            label9.TabIndex = 17;
            label9.Text = "Ca làm việc:";
            // 
            // txtEmployeeAddress
            // 
            txtEmployeeAddress.Location = new Point(413, 10);
            txtEmployeeAddress.Name = "txtEmployeeAddress";
            txtEmployeeAddress.ReadOnly = true;
            txtEmployeeAddress.Size = new Size(371, 30);
            txtEmployeeAddress.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(305, 16);
            label8.Name = "label8";
            label8.Size = new Size(70, 23);
            label8.TabIndex = 17;
            label8.Text = "Địa chỉ:";
            // 
            // txtEmployeeRole
            // 
            txtEmployeeRole.Location = new Point(88, 80);
            txtEmployeeRole.Name = "txtEmployeeRole";
            txtEmployeeRole.ReadOnly = true;
            txtEmployeeRole.Size = new Size(204, 30);
            txtEmployeeRole.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 86);
            label7.Name = "label7";
            label7.Size = new Size(79, 23);
            label7.TabIndex = 17;
            label7.Text = "Chức vụ:";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(88, 46);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.ReadOnly = true;
            txtEmployeeName.Size = new Size(204, 30);
            txtEmployeeName.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 52);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 17;
            label5.Text = "Họ tên:";
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(88, 10);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.ReadOnly = true;
            txtEmployeeId.Size = new Size(204, 30);
            txtEmployeeId.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 16);
            label6.Name = "label6";
            label6.Size = new Size(69, 23);
            label6.TabIndex = 18;
            label6.Text = "Mã NV:";
            // 
            // txtEmployeeFind
            // 
            txtEmployeeFind.Location = new Point(149, 187);
            txtEmployeeFind.Name = "txtEmployeeFind";
            txtEmployeeFind.Size = new Size(357, 30);
            txtEmployeeFind.TabIndex = 9;
            txtEmployeeFind.TextChanged += txtEmployeeFind_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 194);
            label4.Name = "label4";
            label4.Size = new Size(128, 23);
            label4.TabIndex = 8;
            label4.Text = "Tìm nhân viên:";
            // 
            // dgvSchedule
            // 
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(14, 223);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.Size = new Size(892, 288);
            dgvSchedule.TabIndex = 0;
            dgvSchedule.CellClick += dgvSchedule_CellClick;
            dgvSchedule.CellContentDoubleClick += dvgSchedule_CellContentDoubleClick;
            // 
            // frmScheduleInfo
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(74, 60, 60);
            ClientSize = new Size(914, 550);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmScheduleInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách nhân viên làm việc";
            Load += frmScheduleInfo_Load;
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShiftEvening).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShiftAfternoon).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShiftMorning).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPage3;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabControl tabControl1;
        private TabPage tabPage4;
        private TextBox txtEmployeeFind;
        private Label label4;
        private DataGridView dgvSchedule;
        private TextBox txtEmployeeAddress;
        private Label label8;
        private TextBox txtEmployeeRole;
        private Label label7;
        private TextBox txtEmployeeName;
        private Label label5;
        private TextBox txtEmployeeId;
        private Label label6;
        private ComboBox cboEmployeeShift;
        private Label label9;
        private Button btnRegister;
        private TextBox txtFindEvening;
        private Label label24;
        private DataGridView dgvShiftEvening;
        private TextBox txtFindAfternoon;
        private Label label19;
        private DataGridView dgvShiftAfternoon;
        private Button btnCancelMorning;
        private TextBox txtFindMorning;
        private Label label14;
        private DataGridView dgvShiftMorning;
        private Button btnCancelEvening;
        private Button btnCancelAfternoon;
        private ComboBox cboShiftEvening;
        private Label label3;
        private TextBox txtAddressEvening;
        private Label label20;
        private TextBox txtRoleEvening;
        private Label label21;
        private TextBox txtNameEvening;
        private Label label22;
        private TextBox txtIdEvening;
        private Label label23;
        private ComboBox cboShiftAfternoon;
        private Label label2;
        private TextBox txtAddressAfternoon;
        private Label label15;
        private TextBox txtRoleAfternoon;
        private Label label16;
        private TextBox txtNameAfternoon;
        private Label label17;
        private TextBox txtIdAfternoon;
        private Label label18;
        private ComboBox cboShiftMorning;
        private Label label1;
        private TextBox txtAddressMorning;
        private Label label10;
        private TextBox txtRoleMorning;
        private Label label11;
        private TextBox txtNameMorning;
        private Label label12;
        private TextBox txtIdMorning;
        private Label label13;
        private Label label25;
        private TextBox txtNote;
    }
}