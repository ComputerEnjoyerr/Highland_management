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
            dgvIngredient = new DataGridView();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            nmrExpieryDay = new NumericUpDown();
            btnUpdateIng = new Button();
            btnClearIng = new Button();
            btnAddIng = new Button();
            btnDeleteIng = new Button();
            label14 = new Label();
            label13 = new Label();
            label6 = new Label();
            txtIngredientPrice = new TextBox();
            label5 = new Label();
            label4 = new Label();
            cboUnit = new ComboBox();
            cboIngredientName = new ComboBox();
            cboSupplier = new ComboBox();
            txtIngredientId = new TextBox();
            label3 = new Label();
            txtFindIngredient = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)dgvIngredient).BeginInit();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrExpieryDay).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvIngredient);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(494, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 710);
            panel1.TabIndex = 0;
            // 
            // dgvIngredient
            // 
            dgvIngredient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvIngredient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredient.Location = new Point(3, 449);
            dgvIngredient.Name = "dgvIngredient";
            dgvIngredient.RowHeadersWidth = 51;
            dgvIngredient.Size = new Size(492, 258);
            dgvIngredient.TabIndex = 33;
            dgvIngredient.CellClick += dgvIngredient_CellClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(498, 443);
            panel3.TabIndex = 32;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nmrExpieryDay);
            groupBox2.Controls.Add(btnUpdateIng);
            groupBox2.Controls.Add(btnClearIng);
            groupBox2.Controls.Add(btnAddIng);
            groupBox2.Controls.Add(btnDeleteIng);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtIngredientPrice);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cboUnit);
            groupBox2.Controls.Add(cboIngredientName);
            groupBox2.Controls.Add(cboSupplier);
            groupBox2.Controls.Add(txtIngredientId);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtFindIngredient);
            groupBox2.Controls.Add(label12);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(498, 443);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nguyên liệu";
            // 
            // nmrExpieryDay
            // 
            nmrExpieryDay.Location = new Point(143, 217);
            nmrExpieryDay.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nmrExpieryDay.Name = "nmrExpieryDay";
            nmrExpieryDay.Size = new Size(254, 30);
            nmrExpieryDay.TabIndex = 44;
            // 
            // btnUpdateIng
            // 
            btnUpdateIng.BackColor = Color.FromArgb(230, 181, 56);
            btnUpdateIng.Location = new Point(18, 337);
            btnUpdateIng.Name = "btnUpdateIng";
            btnUpdateIng.Size = new Size(145, 53);
            btnUpdateIng.TabIndex = 40;
            btnUpdateIng.Text = "Lưu";
            btnUpdateIng.UseVisualStyleBackColor = false;
            btnUpdateIng.Click += btnUpdateIng_Click;
            // 
            // btnClearIng
            // 
            btnClearIng.BackColor = Color.White;
            btnClearIng.Location = new Point(169, 337);
            btnClearIng.Name = "btnClearIng";
            btnClearIng.Size = new Size(145, 53);
            btnClearIng.TabIndex = 42;
            btnClearIng.Text = "Hoàn tác";
            btnClearIng.UseVisualStyleBackColor = false;
            btnClearIng.Click += btnClearIng_Click;
            // 
            // btnAddIng
            // 
            btnAddIng.BackColor = Color.FromArgb(104, 176, 145);
            btnAddIng.Location = new Point(18, 278);
            btnAddIng.Name = "btnAddIng";
            btnAddIng.Size = new Size(145, 53);
            btnAddIng.TabIndex = 41;
            btnAddIng.Text = "Thêm";
            btnAddIng.UseVisualStyleBackColor = false;
            btnAddIng.Click += btnAddIng_Click;
            // 
            // btnDeleteIng
            // 
            btnDeleteIng.BackColor = Color.FromArgb(169, 65, 65);
            btnDeleteIng.Location = new Point(169, 278);
            btnDeleteIng.Name = "btnDeleteIng";
            btnDeleteIng.Size = new Size(145, 53);
            btnDeleteIng.TabIndex = 43;
            btnDeleteIng.Text = "Xóa";
            btnDeleteIng.UseVisualStyleBackColor = false;
            btnDeleteIng.Click += btnDeleteIng_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(18, 220);
            label14.Name = "label14";
            label14.Size = new Size(122, 23);
            label14.TabIndex = 32;
            label14.Text = "Ngày hết hạn:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 183);
            label13.Name = "label13";
            label13.Size = new Size(105, 23);
            label13.TabIndex = 32;
            label13.Text = "Đơn vị tính:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 146);
            label6.Name = "label6";
            label6.Size = new Size(124, 23);
            label6.TabIndex = 32;
            label6.Text = "Nhà cung cấp:";
            // 
            // txtIngredientPrice
            // 
            txtIngredientPrice.Location = new Point(143, 107);
            txtIngredientPrice.Name = "txtIngredientPrice";
            txtIngredientPrice.Size = new Size(254, 30);
            txtIngredientPrice.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 110);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 33;
            label5.Text = "Giá tiền:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 74);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 34;
            label4.Text = "Tên NL:";
            // 
            // cboUnit
            // 
            cboUnit.FormattingEnabled = true;
            cboUnit.Location = new Point(143, 180);
            cboUnit.Name = "cboUnit";
            cboUnit.Size = new Size(254, 31);
            cboUnit.TabIndex = 37;
            // 
            // cboIngredientName
            // 
            cboIngredientName.FormattingEnabled = true;
            cboIngredientName.Location = new Point(143, 71);
            cboIngredientName.Name = "cboIngredientName";
            cboIngredientName.Size = new Size(254, 31);
            cboIngredientName.TabIndex = 37;
            cboIngredientName.SelectedIndexChanged += cboIngredientName_SelectedIndexChanged;
            // 
            // cboSupplier
            // 
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(143, 143);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(254, 31);
            cboSupplier.TabIndex = 37;
            cboSupplier.SelectedIndexChanged += cboSupplier_SelectedIndexChanged;
            // 
            // txtIngredientId
            // 
            txtIngredientId.Location = new Point(143, 35);
            txtIngredientId.Name = "txtIngredientId";
            txtIngredientId.ReadOnly = true;
            txtIngredientId.Size = new Size(254, 30);
            txtIngredientId.TabIndex = 39;
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
            // txtFindIngredient
            // 
            txtFindIngredient.Location = new Point(108, 407);
            txtFindIngredient.Name = "txtFindIngredient";
            txtFindIngredient.Size = new Size(289, 30);
            txtFindIngredient.TabIndex = 35;
            txtFindIngredient.TextChanged += txtFindIngredient_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 410);
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
            panel2.Size = new Size(494, 355);
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
            groupBox1.Size = new Size(494, 355);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhà cung cấp";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(135, 156);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(159, 30);
            txtEmail.TabIndex = 49;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(24, 159);
            label15.Name = "label15";
            label15.Size = new Size(59, 23);
            label15.TabIndex = 48;
            label15.Text = "Email:";
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(230, 181, 56);
            btnUpdate.Location = new Point(328, 147);
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
            btnHoanTac.Location = new Point(328, 206);
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
            btnAdd.Location = new Point(328, 29);
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
            btnDelete.Location = new Point(328, 88);
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
            txtPhone.Location = new Point(135, 120);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(159, 30);
            txtPhone.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 124);
            label7.Name = "label7";
            label7.Size = new Size(48, 23);
            label7.TabIndex = 38;
            label7.Text = "SĐT:";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSupplierName.Location = new Point(135, 61);
            txtSupplierName.Multiline = true;
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(159, 53);
            txtSupplierName.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 64);
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
            txtSupplierID.Size = new Size(159, 30);
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
            cbProvince.Location = new Point(135, 265);
            cbProvince.Name = "cbProvince";
            cbProvince.Size = new Size(159, 31);
            cbProvince.TabIndex = 36;
            cbProvince.SelectedIndexChanged += cbProvince_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 271);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 32;
            label2.Text = "Tỉnh/TP:";
            // 
            // cbWard
            // 
            cbWard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbWard.FormattingEnabled = true;
            cbWard.Location = new Point(135, 228);
            cbWard.Name = "cbWard";
            cbWard.Size = new Size(159, 31);
            cbWard.TabIndex = 37;
            cbWard.SelectedIndexChanged += cbWard_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 234);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 33;
            label1.Text = "Xã/Phường:";
            // 
            // txtFindSuppliers
            // 
            txtFindSuppliers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFindSuppliers.Location = new Point(116, 319);
            txtFindSuppliers.Name = "txtFindSuppliers";
            txtFindSuppliers.Size = new Size(262, 30);
            txtFindSuppliers.TabIndex = 35;
            txtFindSuppliers.TextChanged += txtFindSuppliers_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 322);
            label11.Name = "label11";
            label11.Size = new Size(91, 23);
            label11.TabIndex = 34;
            label11.Text = "Tìm kiếm:";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Location = new Point(135, 192);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(159, 30);
            txtAddress.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 195);
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
            dgvSupplier.Location = new Point(3, 361);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.RowHeadersWidth = 51;
            dgvSupplier.Size = new Size(488, 346);
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
            ((System.ComponentModel.ISupportInitialize)dgvIngredient).EndInit();
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrExpieryDay).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvIngredient;
        private Panel panel3;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox txtIngredientPrice;
        private Label label5;
        private Label label4;
        private TextBox txtIngredientId;
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
        private Button btnUpdateIng;
        private Button btnClearIng;
        private Button btnAddIng;
        private Button btnDeleteIng;
        private TextBox txtFindIngredient;
        private Label label12;
        private TextBox textBox12;
        private Label label14;
        private Label label13;
        private ComboBox comboBox4;
        private ComboBox cboSupplier;
        private TextBox txtEmail;
        private Label label15;
        private NumericUpDown nmrExpieryDay;
        private ComboBox cboUnit;
        private ComboBox cboIngredientName;
    }
}