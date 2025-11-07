namespace GUI
{
    partial class frmHistory
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
            dgvHistoryBill = new DataGridView();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            btnChooseCustomer = new Button();
            btnClean = new Button();
            btnChooseEmployee = new Button();
            txtFindCustomer = new TextBox();
            label2 = new Label();
            txtFindEmployee = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dgvBill = new DataGridView();
            groupBox1 = new GroupBox();
            dtCreateDate = new DateTimePicker();
            label8 = new Label();
            dtCreateTime = new DateTimePicker();
            label7 = new Label();
            txtTable = new TextBox();
            label6 = new Label();
            txtCustomerName = new TextBox();
            label5 = new Label();
            txtEmployeeName = new TextBox();
            label4 = new Label();
            txtBillId = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistoryBill).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHistoryBill
            // 
            dgvHistoryBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoryBill.Dock = DockStyle.Fill;
            dgvHistoryBill.Location = new Point(0, 238);
            dgvHistoryBill.Name = "dgvHistoryBill";
            dgvHistoryBill.RowHeadersWidth = 51;
            dgvHistoryBill.Size = new Size(947, 751);
            dgvHistoryBill.TabIndex = 12;
            dgvHistoryBill.CellContentClick += dgvHistoryBill_CellContentClick;
            dgvHistoryBill.DoubleClick += dgvHistoryBill_DoubleClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(947, 238);
            panel1.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnChooseCustomer);
            groupBox2.Controls.Add(btnClean);
            groupBox2.Controls.Add(btnChooseEmployee);
            groupBox2.Controls.Add(txtFindCustomer);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtFindEmployee);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(947, 238);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // btnChooseCustomer
            // 
            btnChooseCustomer.Image = Properties.Resources.pen;
            btnChooseCustomer.ImageAlign = ContentAlignment.MiddleRight;
            btnChooseCustomer.Location = new Point(181, 117);
            btnChooseCustomer.Name = "btnChooseCustomer";
            btnChooseCustomer.Size = new Size(117, 46);
            btnChooseCustomer.TabIndex = 13;
            btnChooseCustomer.Text = "Chọn KH";
            btnChooseCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChooseCustomer.UseVisualStyleBackColor = true;
            btnChooseCustomer.Click += button2_Click;
            // 
            // btnClean
            // 
            btnClean.Image = Properties.Resources.arrow;
            btnClean.ImageAlign = ContentAlignment.MiddleRight;
            btnClean.Location = new Point(333, 117);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(117, 46);
            btnClean.TabIndex = 14;
            btnClean.Text = "Hoàn tác";
            btnClean.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // btnChooseEmployee
            // 
            btnChooseEmployee.Image = Properties.Resources.pen;
            btnChooseEmployee.ImageAlign = ContentAlignment.MiddleRight;
            btnChooseEmployee.Location = new Point(31, 117);
            btnChooseEmployee.Name = "btnChooseEmployee";
            btnChooseEmployee.Size = new Size(117, 46);
            btnChooseEmployee.TabIndex = 15;
            btnChooseEmployee.Text = "Chọn NV";
            btnChooseEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChooseEmployee.UseVisualStyleBackColor = true;
            btnChooseEmployee.Click += button1_Click;
            // 
            // txtFindCustomer
            // 
            txtFindCustomer.Location = new Point(151, 68);
            txtFindCustomer.Name = "txtFindCustomer";
            txtFindCustomer.Size = new Size(546, 30);
            txtFindCustomer.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 71);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 9;
            label2.Text = "Khách hàng:";
            // 
            // txtFindEmployee
            // 
            txtFindEmployee.Location = new Point(151, 32);
            txtFindEmployee.Name = "txtFindEmployee";
            txtFindEmployee.Size = new Size(546, 30);
            txtFindEmployee.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 35);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 10;
            label1.Text = "Nhân viên:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvBill);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(947, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(745, 989);
            panel2.TabIndex = 10;
            // 
            // dgvBill
            // 
            dgvBill.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBill.Location = new Point(6, 261);
            dgvBill.Name = "dgvBill";
            dgvBill.RowHeadersWidth = 51;
            dgvBill.Size = new Size(733, 725);
            dgvBill.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtCreateDate);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dtCreateTime);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTable);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEmployeeName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtBillId);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(745, 255);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiết hóa đơn";
            // 
            // dtCreateDate
            // 
            dtCreateDate.Format = DateTimePickerFormat.Time;
            dtCreateDate.Location = new Point(147, 209);
            dtCreateDate.Name = "dtCreateDate";
            dtCreateDate.Size = new Size(171, 30);
            dtCreateDate.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 215);
            label8.Name = "label8";
            label8.Size = new Size(88, 23);
            label8.TabIndex = 6;
            label8.Text = "Ngày tạo:";
            // 
            // dtCreateTime
            // 
            dtCreateTime.Format = DateTimePickerFormat.Time;
            dtCreateTime.Location = new Point(147, 173);
            dtCreateTime.Name = "dtCreateTime";
            dtCreateTime.Size = new Size(171, 30);
            dtCreateTime.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 179);
            label7.Name = "label7";
            label7.Size = new Size(91, 23);
            label7.TabIndex = 7;
            label7.Text = "Thời gian:";
            // 
            // txtTable
            // 
            txtTable.Location = new Point(147, 137);
            txtTable.Name = "txtTable";
            txtTable.Size = new Size(417, 30);
            txtTable.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 140);
            label6.Name = "label6";
            label6.Size = new Size(69, 23);
            label6.TabIndex = 8;
            label6.Text = "Bàn ăn:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(147, 101);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(417, 30);
            txtCustomerName.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 104);
            label5.Name = "label5";
            label5.Size = new Size(108, 23);
            label5.TabIndex = 9;
            label5.Text = "Khách hàng:";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(147, 65);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(417, 30);
            txtEmployeeName.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 68);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 10;
            label4.Text = "Nhân viên:";
            // 
            // txtBillId
            // 
            txtBillId.Location = new Point(147, 29);
            txtBillId.Name = "txtBillId";
            txtBillId.Size = new Size(417, 30);
            txtBillId.TabIndex = 15;
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
            // frmHistory
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1692, 989);
            Controls.Add(dgvHistoryBill);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "frmHistory";
            Text = "frmHistory";
            Load += frmHistory_Load;
            DoubleClick += frmHistory_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)dgvHistoryBill).EndInit();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHistoryBill;
        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private DateTimePicker dtCreateDate;
        private Label label8;
        private DateTimePicker dtCreateTime;
        private Label label7;
        private TextBox txtTable;
        private Label label6;
        private TextBox txtCustomerName;
        private Label label5;
        private TextBox txtEmployeeName;
        private Label label4;
        private TextBox txtBillId;
        private Label label3;
        private DataGridView dgvBill;
        private GroupBox groupBox2;
        private Button btnChooseCustomer;
        private Button btnClean;
        private Button btnChooseEmployee;
        private TextBox txtFindCustomer;
        private Label label2;
        private TextBox txtFindEmployee;
        private Label label1;
    }
}