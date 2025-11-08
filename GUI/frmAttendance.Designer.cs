namespace GUI
{
    partial class frmAttendance
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
            dgvAttendance = new DataGridView();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            button1 = new Button();
            button13 = new Button();
            button12 = new Button();
            cbStatus = new ComboBox();
            dateTimePicker3 = new DateTimePicker();
            label12 = new Label();
            dtCheckOut = new DateTimePicker();
            label11 = new Label();
            dtCheckIn = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            label2 = new Label();
            txtNote = new TextBox();
            txtShift = new TextBox();
            label1 = new Label();
            txtId = new TextBox();
            label8 = new Label();
            panel2 = new Panel();
            dgvEmployee = new DataGridView();
            groupBox1 = new GroupBox();
            txtPhone = new TextBox();
            label7 = new Label();
            txtSalaryPerHour = new TextBox();
            dateTimePicker4 = new DateTimePicker();
            label6 = new Label();
            txtRole = new TextBox();
            label5 = new Label();
            txtEnployeeName = new TextBox();
            label13 = new Label();
            label4 = new Label();
            txtEmployeeId = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAttendance
            // 
            dgvAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Location = new Point(3, 325);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.Size = new Size(883, 385);
            dgvAttendance.TabIndex = 15;
            dgvAttendance.CellClick += dgvAttendance_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 319);
            panel1.TabIndex = 14;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button13);
            groupBox2.Controls.Add(button12);
            groupBox2.Controls.Add(cbStatus);
            groupBox2.Controls.Add(dateTimePicker3);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(dtCheckOut);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(dtCheckIn);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtNote);
            groupBox2.Controls.Add(txtShift);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtId);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(3, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(883, 316);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Điểm danh";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = SystemColors.Control;
            button1.FlatAppearance.BorderSize = 0;
            button1.Image = Properties.Resources._checked;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(552, 136);
            button1.Name = "button1";
            button1.Size = new Size(145, 56);
            button1.TabIndex = 23;
            button1.Text = "Check Out";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button13
            // 
            button13.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button13.BackColor = SystemColors.Control;
            button13.Image = Properties.Resources.x_button;
            button13.ImageAlign = ContentAlignment.MiddleRight;
            button13.Location = new Point(385, 198);
            button13.Name = "button13";
            button13.Size = new Size(145, 56);
            button13.TabIndex = 21;
            button13.Text = "Đánh vắng";
            button13.TextImageRelation = TextImageRelation.ImageBeforeText;
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button12.BackColor = SystemColors.Control;
            button12.FlatAppearance.BorderSize = 0;
            button12.Image = Properties.Resources._checked;
            button12.ImageAlign = ContentAlignment.MiddleRight;
            button12.Location = new Point(385, 136);
            button12.Name = "button12";
            button12.Size = new Size(145, 56);
            button12.TabIndex = 22;
            button12.Text = "Check In";
            button12.TextImageRelation = TextImageRelation.ImageBeforeText;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(121, 133);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(224, 31);
            cbStatus.TabIndex = 17;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(121, 280);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(224, 30);
            dateTimePicker3.TabIndex = 16;
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 136);
            label12.Name = "label12";
            label12.Size = new Size(97, 23);
            label12.TabIndex = 9;
            label12.Text = "Trạng thái:";
            // 
            // dtCheckOut
            // 
            dtCheckOut.Format = DateTimePickerFormat.Time;
            dtCheckOut.Location = new Point(121, 203);
            dtCheckOut.Name = "dtCheckOut";
            dtCheckOut.Size = new Size(224, 30);
            dtCheckOut.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 100);
            label11.Name = "label11";
            label11.Size = new Size(103, 23);
            label11.TabIndex = 9;
            label11.Text = "Lý do vắng:";
            // 
            // dtCheckIn
            // 
            dtCheckIn.Format = DateTimePickerFormat.Time;
            dtCheckIn.Location = new Point(121, 170);
            dtCheckIn.Name = "dtCheckIn";
            dtCheckIn.Size = new Size(224, 30);
            dtCheckIn.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 286);
            label10.Name = "label10";
            label10.Size = new Size(92, 23);
            label10.TabIndex = 9;
            label10.Text = "Ngày làm:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 209);
            label9.Name = "label9";
            label9.Size = new Size(63, 23);
            label9.TabIndex = 9;
            label9.Text = "Lúc ra:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 176);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 9;
            label2.Text = "Lúc vào:";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(121, 98);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(409, 30);
            txtNote.TabIndex = 12;
            // 
            // txtShift
            // 
            txtShift.Location = new Point(121, 62);
            txtShift.Name = "txtShift";
            txtShift.ReadOnly = true;
            txtShift.Size = new Size(409, 30);
            txtShift.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 65);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 10;
            label1.Text = "Ca làm việc:";
            // 
            // txtId
            // 
            txtId.Location = new Point(121, 29);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(409, 30);
            txtId.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 31);
            label8.Name = "label8";
            label8.Size = new Size(40, 23);
            label8.TabIndex = 11;
            label8.Text = "Mã:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvEmployee);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(892, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 710);
            panel2.TabIndex = 13;
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Dock = DockStyle.Fill;
            dgvEmployee.Location = new Point(0, 233);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.Size = new Size(392, 477);
            dgvEmployee.TabIndex = 2;
            dgvEmployee.CellClick += dgvEmployee_CellClick;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtSalaryPerHour);
            groupBox1.Controls.Add(dateTimePicker4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtRole);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEnployeeName);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmployeeId);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 233);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(140, 155);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(225, 30);
            txtPhone.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 158);
            label7.Name = "label7";
            label7.Size = new Size(48, 23);
            label7.TabIndex = 8;
            label7.Text = "SĐT:";
            // 
            // txtSalaryPerHour
            // 
            txtSalaryPerHour.Location = new Point(140, 122);
            txtSalaryPerHour.Name = "txtSalaryPerHour";
            txtSalaryPerHour.ReadOnly = true;
            txtSalaryPerHour.Size = new Size(225, 30);
            txtSalaryPerHour.TabIndex = 12;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Format = DateTimePickerFormat.Short;
            dateTimePicker4.Location = new Point(140, 191);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(166, 30);
            dateTimePicker4.TabIndex = 16;
            dateTimePicker4.ValueChanged += dateTimePicker4_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 125);
            label6.Name = "label6";
            label6.Size = new Size(103, 23);
            label6.TabIndex = 8;
            label6.Text = "Lương/Giờ:";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(140, 91);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(225, 30);
            txtRole.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 94);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 9;
            label5.Text = "Chức vụ:";
            // 
            // txtEnployeeName
            // 
            txtEnployeeName.Location = new Point(140, 60);
            txtEnployeeName.Name = "txtEnployeeName";
            txtEnployeeName.ReadOnly = true;
            txtEnployeeName.Size = new Size(225, 30);
            txtEnployeeName.TabIndex = 14;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(29, 197);
            label13.Name = "label13";
            label13.Size = new Size(92, 23);
            label13.TabIndex = 9;
            label13.Text = "Ngày làm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 63);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 10;
            label4.Text = "Họ tên:";
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(140, 29);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.ReadOnly = true;
            txtEmployeeId.Size = new Size(225, 30);
            txtEmployeeId.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 32);
            label3.Name = "label3";
            label3.Size = new Size(40, 23);
            label3.TabIndex = 11;
            label3.Text = "Mã:";
            // 
            // frmAttendance
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1284, 710);
            Controls.Add(dgvAttendance);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "frmAttendance";
            Text = "frmAttendance";
            Load += frmAttendance_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAttendance;
        private Panel panel1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox txtShift;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox1;
        private TextBox txtSalaryPerHour;
        private Label label6;
        private TextBox txtRole;
        private Label label5;
        private TextBox txtEnployeeName;
        private Label label4;
        private TextBox txtEmployeeId;
        private Label label3;
        private DataGridView dgvEmployee;
        private TextBox txtPhone;
        private Label label7;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dtCheckOut;
        private DateTimePicker dtCheckIn;
        private Label label10;
        private Label label9;
        private TextBox txtId;
        private Label label8;
        private Label label11;
        private ComboBox cbStatus;
        private Label label12;
        private Button button13;
        private Button button12;
        private TextBox txtNote;
        private DateTimePicker dateTimePicker4;
        private Label label13;
        private Button button1;
    }
}