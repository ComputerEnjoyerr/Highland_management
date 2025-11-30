
namespace GUI
{
    partial class frmBranch
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
            dgvBranch = new DataGridView();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            cboStatus = new ComboBox();
            label16 = new Label();
            dtpCloseTime = new DateTimePicker();
            dtpOpenTime = new DateTimePicker();
            label18 = new Label();
            label17 = new Label();
            btnSave = new Button();
            btnReset = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            txtPhone = new TextBox();
            label7 = new Label();
            txtBName = new TextBox();
            label9 = new Label();
            txtBId = new TextBox();
            label10 = new Label();
            cboProvince = new ComboBox();
            label2 = new Label();
            cboWard = new ComboBox();
            label1 = new Label();
            txtFindBranch = new TextBox();
            label11 = new Label();
            txtAddress = new TextBox();
            label8 = new Label();
            panel1 = new Panel();
            dgvBanchEmployee = new DataGridView();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            dtpDateOfBirth = new DateTimePicker();
            txtESalaryPerHour = new TextBox();
            label19 = new Label();
            cboEmployeeStatus = new ComboBox();
            cboGender = new ComboBox();
            cboERole = new ComboBox();
            cboEProvince = new ComboBox();
            label3 = new Label();
            cboEWard = new ComboBox();
            label4 = new Label();
            txtEPhone = new TextBox();
            label5 = new Label();
            label22 = new Label();
            label23 = new Label();
            txtEAddress = new TextBox();
            label21 = new Label();
            label6 = new Label();
            label13 = new Label();
            txtCitizenId = new TextBox();
            label20 = new Label();
            txtEName = new TextBox();
            label14 = new Label();
            txtEId = new TextBox();
            label15 = new Label();
            btnESave = new Button();
            btnEReset = new Button();
            btnEAdd = new Button();
            btnEDelete = new Button();
            txtEFind = new TextBox();
            label12 = new Label();
            btnPrintReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBranch).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBanchEmployee).BeginInit();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBranch
            // 
            dgvBranch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBranch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBranch.Location = new Point(3, 483);
            dgvBranch.Name = "dgvBranch";
            dgvBranch.RowHeadersWidth = 51;
            dgvBranch.Size = new Size(878, 503);
            dgvBranch.TabIndex = 5;
            dgvBranch.CellClick += dgvBranch_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(887, 477);
            panel2.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPrintReport);
            groupBox1.Controls.Add(cboStatus);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(dtpCloseTime);
            groupBox1.Controls.Add(dtpOpenTime);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtBName);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtBId);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cboProvince);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboWard);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtFindBranch);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label8);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(887, 477);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi nhánh";
            // 
            // cboStatus
            // 
            cboStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(644, 111);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(185, 31);
            cboStatus.TabIndex = 65;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(515, 119);
            label16.Name = "label16";
            label16.Size = new Size(97, 23);
            label16.TabIndex = 64;
            label16.Text = "Trạng thái:";
            // 
            // dtpCloseTime
            // 
            dtpCloseTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpCloseTime.Format = DateTimePickerFormat.Time;
            dtpCloseTime.Location = new Point(644, 74);
            dtpCloseTime.Name = "dtpCloseTime";
            dtpCloseTime.ShowUpDown = true;
            dtpCloseTime.Size = new Size(145, 30);
            dtpCloseTime.TabIndex = 63;
            // 
            // dtpOpenTime
            // 
            dtpOpenTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpOpenTime.Format = DateTimePickerFormat.Time;
            dtpOpenTime.Location = new Point(644, 38);
            dtpOpenTime.Name = "dtpOpenTime";
            dtpOpenTime.ShowUpDown = true;
            dtpOpenTime.Size = new Size(145, 30);
            dtpOpenTime.TabIndex = 62;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(515, 77);
            label18.Name = "label18";
            label18.Size = new Size(123, 23);
            label18.TabIndex = 60;
            label18.Text = "Giờ đóng cửa:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(515, 41);
            label17.Name = "label17";
            label17.Size = new Size(108, 23);
            label17.TabIndex = 61;
            label17.Text = "Giờ mở cửa:";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.Image = Properties.Resources.pen;
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(322, 302);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(128, 58);
            btnSave.TabIndex = 48;
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
            btnReset.Location = new Point(468, 302);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(128, 58);
            btnReset.TabIndex = 50;
            btnReset.Text = "Hoàn tác";
            btnReset.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Image = Properties.Resources.plus;
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(28, 302);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 58);
            btnAdd.TabIndex = 49;
            btnAdd.Text = "Thêm";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Control;
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.ImageAlign = ContentAlignment.MiddleRight;
            btnDelete.Location = new Point(176, 302);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 58);
            btnDelete.TabIndex = 51;
            btnDelete.Text = "Xóa";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(135, 133);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(313, 30);
            txtPhone.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 137);
            label7.Name = "label7";
            label7.Size = new Size(48, 23);
            label7.TabIndex = 38;
            label7.Text = "SĐT:";
            // 
            // txtBName
            // 
            txtBName.Location = new Point(135, 74);
            txtBName.Multiline = true;
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(313, 53);
            txtBName.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 77);
            label9.Name = "label9";
            label9.Size = new Size(71, 23);
            label9.TabIndex = 39;
            label9.Text = "Tên CN:";
            // 
            // txtBId
            // 
            txtBId.Location = new Point(135, 38);
            txtBId.Name = "txtBId";
            txtBId.ReadOnly = true;
            txtBId.Size = new Size(313, 30);
            txtBId.TabIndex = 43;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 41);
            label10.Name = "label10";
            label10.Size = new Size(69, 23);
            label10.TabIndex = 40;
            label10.Text = "Mã CN:";
            // 
            // cboProvince
            // 
            cboProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvince.FormattingEnabled = true;
            cboProvince.Location = new Point(135, 242);
            cboProvince.Name = "cboProvince";
            cboProvince.Size = new Size(313, 31);
            cboProvince.TabIndex = 36;
            cboProvince.SelectedIndexChanged += cboProvince_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 248);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 32;
            label2.Text = "Tỉnh/TP:";
            // 
            // cboWard
            // 
            cboWard.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWard.FormattingEnabled = true;
            cboWard.Location = new Point(135, 204);
            cboWard.Name = "cboWard";
            cboWard.Size = new Size(313, 31);
            cboWard.TabIndex = 37;
            cboWard.SelectedIndexChanged += cboWard_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 210);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 33;
            label1.Text = "Xã/Phường:";
            // 
            // txtFindBranch
            // 
            txtFindBranch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtFindBranch.Location = new Point(121, 444);
            txtFindBranch.Name = "txtFindBranch";
            txtFindBranch.Size = new Size(597, 30);
            txtFindBranch.TabIndex = 35;
            txtFindBranch.TextChanged += txtFindBranch_TextChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(24, 447);
            label11.Name = "label11";
            label11.Size = new Size(91, 23);
            label11.TabIndex = 34;
            label11.Text = "Tìm kiếm:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(135, 169);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(313, 30);
            txtAddress.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 172);
            label8.Name = "label8";
            label8.Size = new Size(70, 23);
            label8.TabIndex = 34;
            label8.Text = "Địa chỉ:";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvBanchEmployee);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(887, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 989);
            panel1.TabIndex = 3;
            // 
            // dgvBanchEmployee
            // 
            dgvBanchEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBanchEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBanchEmployee.Location = new Point(6, 444);
            dgvBanchEmployee.Name = "dgvBanchEmployee";
            dgvBanchEmployee.RowHeadersWidth = 51;
            dgvBanchEmployee.Size = new Size(796, 542);
            dgvBanchEmployee.TabIndex = 33;
            dgvBanchEmployee.CellClick += dgvBanchEmployee_CellClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(805, 440);
            panel3.TabIndex = 32;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpDateOfBirth);
            groupBox2.Controls.Add(txtESalaryPerHour);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(cboEmployeeStatus);
            groupBox2.Controls.Add(cboGender);
            groupBox2.Controls.Add(cboERole);
            groupBox2.Controls.Add(cboEProvince);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cboEWard);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtEPhone);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(label23);
            groupBox2.Controls.Add(txtEAddress);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(txtCitizenId);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(txtEName);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(txtEId);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(btnESave);
            groupBox2.Controls.Add(btnEReset);
            groupBox2.Controls.Add(btnEAdd);
            groupBox2.Controls.Add(btnEDelete);
            groupBox2.Controls.Add(txtEFind);
            groupBox2.Controls.Add(label12);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(805, 440);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nhân viên chi nhánh";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(566, 184);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(208, 30);
            dtpDateOfBirth.TabIndex = 60;
            // 
            // txtESalaryPerHour
            // 
            txtESalaryPerHour.Location = new Point(551, 108);
            txtESalaryPerHour.Name = "txtESalaryPerHour";
            txtESalaryPerHour.Size = new Size(223, 30);
            txtESalaryPerHour.TabIndex = 59;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(466, 111);
            label19.Name = "label19";
            label19.Size = new Size(67, 23);
            label19.TabIndex = 58;
            label19.Text = "Lương:";
            // 
            // cboEmployeeStatus
            // 
            cboEmployeeStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmployeeStatus.FormattingEnabled = true;
            cboEmployeeStatus.Location = new Point(152, 253);
            cboEmployeeStatus.Name = "cboEmployeeStatus";
            cboEmployeeStatus.Size = new Size(216, 31);
            cboEmployeeStatus.TabIndex = 55;
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(551, 146);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(223, 31);
            cboGender.TabIndex = 55;
            // 
            // cboERole
            // 
            cboERole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboERole.FormattingEnabled = true;
            cboERole.Location = new Point(551, 35);
            cboERole.Name = "cboERole";
            cboERole.Size = new Size(223, 31);
            cboERole.TabIndex = 55;
            // 
            // cboEProvince
            // 
            cboEProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEProvince.FormattingEnabled = true;
            cboEProvince.Location = new Point(152, 216);
            cboEProvince.Name = "cboEProvince";
            cboEProvince.Size = new Size(276, 31);
            cboEProvince.TabIndex = 56;
            cboEProvince.SelectedIndexChanged += cboEProvince_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 222);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 44;
            label3.Text = "Tỉnh/TP:";
            // 
            // cboEWard
            // 
            cboEWard.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEWard.FormattingEnabled = true;
            cboEWard.Location = new Point(152, 179);
            cboEWard.Name = "cboEWard";
            cboEWard.Size = new Size(276, 31);
            cboEWard.TabIndex = 57;
            cboEWard.SelectedIndexChanged += cboEWard_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 185);
            label4.Name = "label4";
            label4.Size = new Size(106, 23);
            label4.TabIndex = 45;
            label4.Text = "Xã/Phường:";
            // 
            // txtEPhone
            // 
            txtEPhone.Location = new Point(551, 72);
            txtEPhone.Name = "txtEPhone";
            txtEPhone.Size = new Size(223, 30);
            txtEPhone.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(466, 78);
            label5.Name = "label5";
            label5.Size = new Size(48, 23);
            label5.TabIndex = 46;
            label5.Text = "SĐT:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(466, 190);
            label22.Name = "label22";
            label22.Size = new Size(94, 23);
            label22.TabIndex = 48;
            label22.Text = "Ngày sinh:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(27, 261);
            label23.Name = "label23";
            label23.Size = new Size(97, 23);
            label23.TabIndex = 48;
            label23.Text = "Trạng thái:";
            // 
            // txtEAddress
            // 
            txtEAddress.Location = new Point(152, 143);
            txtEAddress.Name = "txtEAddress";
            txtEAddress.Size = new Size(276, 30);
            txtEAddress.TabIndex = 52;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(466, 152);
            label21.Name = "label21";
            label21.Size = new Size(85, 23);
            label21.TabIndex = 48;
            label21.Text = "Giới tính:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 149);
            label6.Name = "label6";
            label6.Size = new Size(70, 23);
            label6.TabIndex = 47;
            label6.Text = "Địa chỉ:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(466, 41);
            label13.Name = "label13";
            label13.Size = new Size(79, 23);
            label13.TabIndex = 48;
            label13.Text = "Chức vụ:";
            // 
            // txtCitizenId
            // 
            txtCitizenId.Location = new Point(152, 71);
            txtCitizenId.Name = "txtCitizenId";
            txtCitizenId.Size = new Size(276, 30);
            txtCitizenId.TabIndex = 53;
            txtCitizenId.Leave += txtEName_Leave;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(27, 77);
            label20.Name = "label20";
            label20.Size = new Size(120, 23);
            label20.TabIndex = 49;
            label20.Text = "CCCD/CMND:";
            // 
            // txtEName
            // 
            txtEName.Location = new Point(152, 107);
            txtEName.Name = "txtEName";
            txtEName.Size = new Size(276, 30);
            txtEName.TabIndex = 53;
            txtEName.Leave += txtEName_Leave;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(27, 113);
            label14.Name = "label14";
            label14.Size = new Size(69, 23);
            label14.TabIndex = 49;
            label14.Text = "Họ tên:";
            // 
            // txtEId
            // 
            txtEId.Location = new Point(152, 35);
            txtEId.Name = "txtEId";
            txtEId.ReadOnly = true;
            txtEId.Size = new Size(276, 30);
            txtEId.TabIndex = 54;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(27, 41);
            label15.Name = "label15";
            label15.Size = new Size(69, 23);
            label15.TabIndex = 50;
            label15.Text = "Mã NV:";
            // 
            // btnESave
            // 
            btnESave.BackColor = SystemColors.Control;
            btnESave.Image = Properties.Resources.pen;
            btnESave.ImageAlign = ContentAlignment.MiddleRight;
            btnESave.Location = new Point(318, 306);
            btnESave.Name = "btnESave";
            btnESave.Size = new Size(128, 58);
            btnESave.TabIndex = 40;
            btnESave.Text = "Lưu";
            btnESave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnESave.UseVisualStyleBackColor = false;
            btnESave.Click += btnESave_Click;
            // 
            // btnEReset
            // 
            btnEReset.BackColor = SystemColors.Control;
            btnEReset.Image = Properties.Resources.arrow;
            btnEReset.ImageAlign = ContentAlignment.MiddleRight;
            btnEReset.Location = new Point(463, 306);
            btnEReset.Name = "btnEReset";
            btnEReset.Size = new Size(128, 58);
            btnEReset.TabIndex = 42;
            btnEReset.Text = "Hoàn tác";
            btnEReset.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEReset.UseVisualStyleBackColor = false;
            btnEReset.Click += btnEReset_Click;
            // 
            // btnEAdd
            // 
            btnEAdd.BackColor = SystemColors.Control;
            btnEAdd.Image = Properties.Resources.plus;
            btnEAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnEAdd.Location = new Point(28, 306);
            btnEAdd.Name = "btnEAdd";
            btnEAdd.Size = new Size(128, 58);
            btnEAdd.TabIndex = 41;
            btnEAdd.Text = "Thêm";
            btnEAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEAdd.UseVisualStyleBackColor = false;
            btnEAdd.Click += btnEAdd_Click;
            // 
            // btnEDelete
            // 
            btnEDelete.BackColor = SystemColors.Control;
            btnEDelete.Image = Properties.Resources.delete;
            btnEDelete.ImageAlign = ContentAlignment.MiddleRight;
            btnEDelete.Location = new Point(173, 306);
            btnEDelete.Name = "btnEDelete";
            btnEDelete.Size = new Size(128, 58);
            btnEDelete.TabIndex = 43;
            btnEDelete.Text = "Xóa";
            btnEDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEDelete.UseVisualStyleBackColor = false;
            btnEDelete.Click += btnEDelete_Click;
            // 
            // txtEFind
            // 
            txtEFind.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtEFind.Location = new Point(110, 404);
            txtEFind.Name = "txtEFind";
            txtEFind.Size = new Size(527, 30);
            txtEFind.TabIndex = 35;
            txtEFind.TextChanged += txtEFind_TextChanged;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Location = new Point(18, 407);
            label12.Name = "label12";
            label12.Size = new Size(91, 23);
            label12.TabIndex = 34;
            label12.Text = "Tìm kiếm:";
            // 
            // btnPrintReport
            // 
            btnPrintReport.Image = Properties.Resources.printer;
            btnPrintReport.ImageAlign = ContentAlignment.MiddleRight;
            btnPrintReport.Location = new Point(515, 236);
            btnPrintReport.Name = "btnPrintReport";
            btnPrintReport.Size = new Size(237, 47);
            btnPrintReport.TabIndex = 66;
            btnPrintReport.Text = "In Thông Tin Chi Nhánh";
            btnPrintReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrintReport.UseVisualStyleBackColor = true;
            btnPrintReport.Click += btnPrintReport_Click;
            // 
            // frmBranch
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1692, 989);
            Controls.Add(dgvBranch);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "frmBranch";
            Text = "frmBranch";
            Load += frmBranch_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBranch).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBanchEmployee).EndInit();
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private DataGridView dgvBranch;
        private Panel panel2;
        private GroupBox groupBox1;
        private TextBox txtPhone;
        private Label label7;
        private TextBox txtBName;
        private Label label9;
        private TextBox txtBId;
        private Label label10;
        private ComboBox cboProvince;
        private Label label2;
        private ComboBox cboWard;
        private Label label1;
        private TextBox txtFindBranch;
        private Label label11;
        private TextBox txtAddress;
        private Label label8;
        private Panel panel1;
        private Button btnSave;
        private Button btnReset;
        private Button btnAdd;
        private Button btnDelete;
        private DateTimePicker dtpCloseTime;
        private DateTimePicker dtpOpenTime;
        private Label label18;
        private Label label17;
        private ComboBox cboStatus;
        private Label label16;
        private DataGridView dgvBanchEmployee;
        private Panel panel3;
        private GroupBox groupBox2;
        private TextBox txtESalaryPerHour;
        private Label label19;
        private ComboBox cboERole;
        private ComboBox cboEProvince;
        private Label label3;
        private ComboBox cboEWard;
        private Label label4;
        private TextBox txtEPhone;
        private Label label5;
        private TextBox txtEAddress;
        private Label label6;
        private Label label13;
        private TextBox txtEName;
        private Label label14;
        private TextBox txtEId;
        private Label label15;
        private Button btnESave;
        private Button btnEReset;
        private Button btnEAdd;
        private Button btnEDelete;
        private TextBox txtEFind;
        private Label label12;
        private TextBox txtCitizenId;
        private Label label20;
        private ComboBox cboGender;
        private Label label21;
        private DateTimePicker dtpDateOfBirth;
        private Label label22;
        private ComboBox cboEmployeeStatus;
        private Label label23;
        private Button btnPrintReport;
    }
}