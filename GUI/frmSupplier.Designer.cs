namespace GUI
{
    partial class frmSupplier
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            textBox12 = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            comboBox4 = new ComboBox();
            textBox4 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox10 = new TextBox();
            label12 = new Label();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            txtEmail = new TextBox();
            label15 = new Label();
            btnUpdate = new Button();
            btnHoanTac = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            txtPhone = new TextBox();
            label7 = new Label();
            txtSupplierName = new TextBox();
            label9 = new Label();
            txtSupplierID = new TextBox();
            label10 = new Label();
            cbProvince = new ComboBox();
            label2 = new Label();
            cbWard = new ComboBox();
            label1 = new Label();
            txtFindSuppliers = new TextBox();
            label11 = new Label();
            txtAddress = new TextBox();
            label8 = new Label();
            dgvSupplier = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(561, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 710);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 389);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(425, 318);
            dataGridView1.TabIndex = 33;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(431, 383);
            panel3.TabIndex = 32;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(textBox12);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(comboBox4);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(label12);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(431, 383);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nguyên liệu";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(230, 181, 56);
            button5.Location = new Point(18, 286);
            button5.Name = "button5";
            button5.Size = new Size(145, 53);
            button5.TabIndex = 40;
            button5.Text = "Lưu";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Location = new Point(169, 286);
            button6.Name = "button6";
            button6.Size = new Size(145, 53);
            button6.TabIndex = 42;
            button6.Text = "Hoàn tác";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(104, 176, 145);
            button7.Location = new Point(18, 227);
            button7.Name = "button7";
            button7.Size = new Size(145, 53);
            button7.TabIndex = 41;
            button7.Text = "Thêm";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(169, 65, 65);
            button8.Location = new Point(169, 227);
            button8.Name = "button8";
            button8.Size = new Size(145, 53);
            button8.TabIndex = 43;
            button8.Text = "Xóa";
            button8.UseVisualStyleBackColor = false;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(143, 190);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(254, 30);
            textBox12.TabIndex = 36;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(18, 193);
            label14.Name = "label14";
            label14.Size = new Size(122, 23);
            label14.TabIndex = 32;
            label14.Text = "Ngày hết hạn:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 162);
            label13.Name = "label13";
            label13.Size = new Size(105, 23);
            label13.TabIndex = 32;
            label13.Text = "Đơn vị tính:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 131);
            label6.Name = "label6";
            label6.Size = new Size(124, 23);
            label6.TabIndex = 32;
            label6.Text = "Nhà cung cấp:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(143, 97);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(254, 30);
            textBox5.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 100);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 33;
            label5.Text = "Giá tiền:";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(143, 159);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(254, 31);
            comboBox4.TabIndex = 36;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(143, 66);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(254, 30);
            textBox4.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 69);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 34;
            label4.Text = "Tên NL:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(143, 128);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(254, 31);
            comboBox1.TabIndex = 37;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(143, 35);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(254, 30);
            textBox3.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 38);
            label3.Name = "label3";
            label3.Size = new Size(40, 23);
            label3.TabIndex = 35;
            label3.Text = "Mã:";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(108, 355);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(289, 30);
            textBox10.TabIndex = 35;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 358);
            label12.Name = "label12";
            label12.Size = new Size(91, 23);
            label12.TabIndex = 34;
            label12.Text = "Tìm kiếm:";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(561, 299);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnHoanTac);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtSupplierName);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtSupplierID);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cbProvince);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbWard);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtFindSuppliers);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label8);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(561, 299);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhà cung cấp";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(135, 144);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(226, 30);
            txtEmail.TabIndex = 49;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(24, 147);
            label15.Name = "label15";
            label15.Size = new Size(59, 23);
            label15.TabIndex = 48;
            label15.Text = "Email:";
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(230, 181, 56);
            btnUpdate.Location = new Point(395, 147);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(145, 53);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "Lưu";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnHoanTac
            // 
            btnHoanTac.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHoanTac.BackColor = Color.White;
            btnHoanTac.Location = new Point(395, 206);
            btnHoanTac.Name = "btnHoanTac";
            btnHoanTac.Size = new Size(145, 53);
            btnHoanTac.TabIndex = 46;
            btnHoanTac.Text = "Hoàn tác";
            btnHoanTac.UseVisualStyleBackColor = false;
            btnHoanTac.Click += btnHoanTac_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(104, 176, 145);
            btnAdd.Location = new Point(395, 29);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 53);
            btnAdd.TabIndex = 45;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(169, 65, 65);
            btnDelete.Location = new Point(395, 88);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(145, 53);
            btnDelete.TabIndex = 47;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(135, 112);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(226, 30);
            txtPhone.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 116);
            label7.Name = "label7";
            label7.Size = new Size(48, 23);
            label7.TabIndex = 38;
            label7.Text = "SĐT:";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSupplierName.Location = new Point(135, 56);
            txtSupplierName.Multiline = true;
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(226, 53);
            txtSupplierName.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 59);
            label9.Name = "label9";
            label9.Size = new Size(81, 23);
            label9.TabIndex = 39;
            label9.Text = "Tên NCC:";
            // 
            // txtSupplierID
            // 
            txtSupplierID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSupplierID.Location = new Point(135, 25);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.ReadOnly = true;
            txtSupplierID.Size = new Size(226, 30);
            txtSupplierID.TabIndex = 43;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 28);
            label10.Name = "label10";
            label10.Size = new Size(79, 23);
            label10.TabIndex = 40;
            label10.Text = "Mã NCC:";
            // 
            // cbProvince
            // 
            cbProvince.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbProvince.FormattingEnabled = true;
            cbProvince.Location = new Point(135, 237);
            cbProvince.Name = "cbProvince";
            cbProvince.Size = new Size(226, 31);
            cbProvince.TabIndex = 36;
            cbProvince.SelectedIndexChanged += cbProvince_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 243);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 32;
            label2.Text = "Tỉnh/TP:";
            // 
            // cbWard
            // 
            cbWard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbWard.FormattingEnabled = true;
            cbWard.Location = new Point(135, 206);
            cbWard.Name = "cbWard";
            cbWard.Size = new Size(226, 31);
            cbWard.TabIndex = 37;
            cbWard.SelectedIndexChanged += cbWard_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 212);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 33;
            label1.Text = "Xã/Phường:";
            // 
            // txtFindSuppliers
            // 
            txtFindSuppliers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFindSuppliers.Location = new Point(116, 275);
            txtFindSuppliers.Name = "txtFindSuppliers";
            txtFindSuppliers.Size = new Size(245, 30);
            txtFindSuppliers.TabIndex = 35;
            txtFindSuppliers.TextChanged += txtFindSuppliers_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 278);
            label11.Name = "label11";
            label11.Size = new Size(91, 23);
            label11.TabIndex = 34;
            label11.Text = "Tìm kiếm:";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Location = new Point(135, 174);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(226, 30);
            txtAddress.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 177);
            label8.Name = "label8";
            label8.Size = new Size(70, 23);
            label8.TabIndex = 34;
            label8.Text = "Địa chỉ:";
            // 
            // dgvSupplier
            // 
            dgvSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplier.Location = new Point(3, 305);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.RowHeadersWidth = 51;
            dgvSupplier.Size = new Size(552, 402);
            dgvSupplier.TabIndex = 2;
            dgvSupplier.CellClick += dgvSupplier_CellClick;
            // 
            // frmSupplier
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(992, 710);
            Controls.Add(dgvSupplier);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "frmSupplier";
            Text = "frmSupplier";
            Load += frmSupplier_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel3;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private Panel panel2;
        private GroupBox groupBox1;
        private DataGridView dgvSupplier;
        private ComboBox cbProvince;
        private Label label2;
        private ComboBox cbWard;
        private Label label1;
        private TextBox txtAddress;
        private Label label8;
        private TextBox txtPhone;
        private Label label7;
        private TextBox txtSupplierName;
        private Label label9;
        private TextBox txtSupplierID;
        private Label label10;
        private Button btnUpdate;
        private Button btnHoanTac;
        private Button btnAdd;
        private Button btnDelete;
        private TextBox txtFindSuppliers;
        private Label label11;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox textBox10;
        private Label label12;
        private TextBox textBox12;
        private Label label14;
        private Label label13;
        private ComboBox comboBox4;
        private ComboBox comboBox1;
        private TextBox txtEmail;
        private Label label15;
    }
}