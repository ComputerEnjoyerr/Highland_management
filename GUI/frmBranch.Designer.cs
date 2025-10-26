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
            txtESalaryPerHour = new TextBox();
            label19 = new Label();
            cboERole = new ComboBox();
            cboEProvince = new ComboBox();
            label3 = new Label();
            cboEWard = new ComboBox();
            label4 = new Label();
            txtEPhone = new TextBox();
            label5 = new Label();
            txtEAddress = new TextBox();
            label6 = new Label();
            label13 = new Label();
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
            dgvBranch.Location = new Point(3, 565);
            dgvBranch.Name = "dgvBranch";
            dgvBranch.RowHeadersWidth = 51;
            dgvBranch.Size = new Size(406, 142);
            dgvBranch.TabIndex = 5;
            dgvBranch.CellClick += dgvBranch_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(415, 559);
            panel2.TabIndex = 4;
            // 
            // groupBox1
            // 
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
            groupBox1.Size = new Size(415, 559);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi nhánh";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(135, 342);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(253, 31);
            cboStatus.TabIndex = 65;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(24, 348);
            label16.Name = "label16";
            label16.Size = new Size(65, 23);
            label16.TabIndex = 64;
            label16.Text = "Status:";
            // 
            // dtpCloseTime
            // 
            dtpCloseTime.Format = DateTimePickerFormat.Time;
            dtpCloseTime.Location = new Point(135, 306);
            dtpCloseTime.Name = "dtpCloseTime";
            dtpCloseTime.ShowUpDown = true;
            dtpCloseTime.Size = new Size(253, 30);
            dtpCloseTime.TabIndex = 63;
            // 
            // dtpOpenTime
            // 
            dtpOpenTime.Format = DateTimePickerFormat.Time;
            dtpOpenTime.Location = new Point(135, 270);
            dtpOpenTime.Name = "dtpOpenTime";
            dtpOpenTime.ShowUpDown = true;
            dtpOpenTime.Size = new Size(253, 30);
            dtpOpenTime.TabIndex = 62;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(11, 309);
            label18.Name = "label18";
            label18.Size = new Size(123, 23);
            label18.TabIndex = 60;
            label18.Text = "Giờ đóng cửa:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(24, 274);
            label17.Name = "label17";
            label17.Size = new Size(108, 23);
            label17.TabIndex = 61;
            label17.Text = "Giờ mở cửa:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(230, 181, 56);
            btnSave.Location = new Point(24, 457);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(145, 53);
            btnSave.TabIndex = 48;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.White;
            btnReset.Location = new Point(175, 457);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(145, 53);
            btnReset.TabIndex = 50;
            btnReset.Text = "Hoàn tác";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(104, 176, 145);
            btnAdd.Location = new Point(24, 398);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 53);
            btnAdd.TabIndex = 49;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(169, 65, 65);
            btnDelete.Location = new Point(175, 398);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(145, 53);
            btnDelete.TabIndex = 51;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(135, 128);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(253, 30);
            txtPhone.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 132);
            label7.Name = "label7";
            label7.Size = new Size(48, 23);
            label7.TabIndex = 38;
            label7.Text = "SĐT:";
            // 
            // txtBName
            // 
            txtBName.Location = new Point(135, 69);
            txtBName.Multiline = true;
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(253, 53);
            txtBName.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 72);
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
            txtBId.Size = new Size(253, 30);
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
            cboProvince.Location = new Point(135, 233);
            cboProvince.Name = "cboProvince";
            cboProvince.Size = new Size(253, 31);
            cboProvince.TabIndex = 36;
            cboProvince.SelectedIndexChanged += cboProvince_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 239);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 32;
            label2.Text = "Tỉnh/TP:";
            // 
            // cboWard
            // 
            cboWard.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWard.FormattingEnabled = true;
            cboWard.Location = new Point(135, 195);
            cboWard.Name = "cboWard";
            cboWard.Size = new Size(253, 31);
            cboWard.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 201);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 33;
            label1.Text = "Xã/Phường:";
            // 
            // txtFindBranch
            // 
            txtFindBranch.Location = new Point(116, 526);
            txtFindBranch.Name = "txtFindBranch";
            txtFindBranch.Size = new Size(272, 30);
            txtFindBranch.TabIndex = 35;
            txtFindBranch.TextChanged += txtFindBranch_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 529);
            label11.Name = "label11";
            label11.Size = new Size(91, 23);
            label11.TabIndex = 34;
            label11.Text = "Tìm kiếm:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(135, 160);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(253, 30);
            txtAddress.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 163);
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
            panel1.Location = new Point(415, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 710);
            panel1.TabIndex = 3;
            // 
            // dgvBanchEmployee
            // 
            dgvBanchEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBanchEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBanchEmployee.Location = new Point(6, 364);
            dgvBanchEmployee.Name = "dgvBanchEmployee";
            dgvBanchEmployee.RowHeadersWidth = 51;
            dgvBanchEmployee.Size = new Size(568, 343);
            dgvBanchEmployee.TabIndex = 33;
            dgvBanchEmployee.CellClick += dgvBanchEmployee_CellClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(577, 358);
            panel3.TabIndex = 32;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtESalaryPerHour);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(cboERole);
            groupBox2.Controls.Add(cboEProvince);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cboEWard);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtEPhone);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtEAddress);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label13);
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
            groupBox2.Size = new Size(577, 358);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nhân viên chi nhánh";
            // 
            // txtESalaryPerHour
            // 
            txtESalaryPerHour.Location = new Point(409, 112);
            txtESalaryPerHour.Name = "txtESalaryPerHour";
            txtESalaryPerHour.Size = new Size(140, 30);
            txtESalaryPerHour.TabIndex = 59;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(324, 115);
            label19.Name = "label19";
            label19.Size = new Size(67, 23);
            label19.TabIndex = 58;
            label19.Text = "Lương:";
            // 
            // cboERole
            // 
            cboERole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboERole.FormattingEnabled = true;
            cboERole.Location = new Point(409, 35);
            cboERole.Name = "cboERole";
            cboERole.Size = new Size(140, 31);
            cboERole.TabIndex = 55;
            // 
            // cboEProvince
            // 
            cboEProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEProvince.FormattingEnabled = true;
            cboEProvince.Location = new Point(139, 159);
            cboEProvince.Name = "cboEProvince";
            cboEProvince.Size = new Size(175, 31);
            cboEProvince.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 165);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 44;
            label3.Text = "Tỉnh/TP:";
            // 
            // cboEWard
            // 
            cboEWard.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEWard.FormattingEnabled = true;
            cboEWard.Location = new Point(139, 128);
            cboEWard.Name = "cboEWard";
            cboEWard.Size = new Size(175, 31);
            cboEWard.TabIndex = 57;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 134);
            label4.Name = "label4";
            label4.Size = new Size(106, 23);
            label4.TabIndex = 45;
            label4.Text = "Xã/Phường:";
            // 
            // txtEPhone
            // 
            txtEPhone.Location = new Point(409, 72);
            txtEPhone.Name = "txtEPhone";
            txtEPhone.Size = new Size(140, 30);
            txtEPhone.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(324, 78);
            label5.Name = "label5";
            label5.Size = new Size(48, 23);
            label5.TabIndex = 46;
            label5.Text = "SĐT:";
            // 
            // txtEAddress
            // 
            txtEAddress.Location = new Point(110, 97);
            txtEAddress.Name = "txtEAddress";
            txtEAddress.Size = new Size(204, 30);
            txtEAddress.TabIndex = 52;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 103);
            label6.Name = "label6";
            label6.Size = new Size(70, 23);
            label6.TabIndex = 47;
            label6.Text = "Địa chỉ:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(324, 41);
            label13.Name = "label13";
            label13.Size = new Size(79, 23);
            label13.TabIndex = 48;
            label13.Text = "Chức vụ:";
            // 
            // txtEName
            // 
            txtEName.Location = new Point(110, 66);
            txtEName.Name = "txtEName";
            txtEName.Size = new Size(204, 30);
            txtEName.TabIndex = 53;
            txtEName.Leave += txtEName_Leave;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(27, 72);
            label14.Name = "label14";
            label14.Size = new Size(69, 23);
            label14.TabIndex = 49;
            label14.Text = "Họ tên:";
            // 
            // txtEId
            // 
            txtEId.Location = new Point(110, 35);
            txtEId.Name = "txtEId";
            txtEId.ReadOnly = true;
            txtEId.Size = new Size(204, 30);
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
            btnESave.BackColor = Color.FromArgb(230, 181, 56);
            btnESave.Location = new Point(27, 257);
            btnESave.Name = "btnESave";
            btnESave.Size = new Size(128, 53);
            btnESave.TabIndex = 40;
            btnESave.Text = "Lưu";
            btnESave.UseVisualStyleBackColor = false;
            // 
            // btnEReset
            // 
            btnEReset.BackColor = Color.White;
            btnEReset.Location = new Point(161, 257);
            btnEReset.Name = "btnEReset";
            btnEReset.Size = new Size(128, 53);
            btnEReset.TabIndex = 42;
            btnEReset.Text = "Hoàn tác";
            btnEReset.UseVisualStyleBackColor = false;
            btnEReset.Click += btnEReset_Click;
            // 
            // btnEAdd
            // 
            btnEAdd.BackColor = Color.FromArgb(104, 176, 145);
            btnEAdd.Location = new Point(27, 199);
            btnEAdd.Name = "btnEAdd";
            btnEAdd.Size = new Size(128, 53);
            btnEAdd.TabIndex = 41;
            btnEAdd.Text = "Thêm";
            btnEAdd.UseVisualStyleBackColor = false;
            // 
            // btnEDelete
            // 
            btnEDelete.BackColor = Color.FromArgb(169, 65, 65);
            btnEDelete.Location = new Point(161, 199);
            btnEDelete.Name = "btnEDelete";
            btnEDelete.Size = new Size(128, 53);
            btnEDelete.TabIndex = 43;
            btnEDelete.Text = "Xóa";
            btnEDelete.UseVisualStyleBackColor = false;
            // 
            // txtEFind
            // 
            txtEFind.Location = new Point(108, 323);
            txtEFind.Name = "txtEFind";
            txtEFind.Size = new Size(272, 30);
            txtEFind.TabIndex = 35;
            txtEFind.TextChanged += txtEFind_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 326);
            label12.Name = "label12";
            label12.Size = new Size(91, 23);
            label12.TabIndex = 34;
            label12.Text = "Tìm kiếm:";
            // 
            // frmBranch
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(992, 710);
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
        private DataGridView dgvBanchEmployee;
        private Panel panel3;
        private GroupBox groupBox2;
        private Button btnESave;
        private Button btnEReset;
        private Button btnEAdd;
        private Button btnEDelete;
        private TextBox txtEFind;
        private Label label12;
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
        private TextBox txtESalaryPerHour;
        private Label label19;
    }
}