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
            label16 = new Label();
            dtpProducedDate = new DateTimePicker();
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
            panel1.Location = new Point(968, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 989);
            panel1.TabIndex = 0;
            // 
            // dgvIngredient
            // 
            dgvIngredient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvIngredient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredient.Location = new Point(3, 449);
            dgvIngredient.Name = "dgvIngredient";
            dgvIngredient.RowHeadersWidth = 51;
            dgvIngredient.Size = new Size(718, 537);
            dgvIngredient.TabIndex = 33;
            dgvIngredient.CellClick += dgvIngredient_CellClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(724, 443);
            panel3.TabIndex = 32;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpProducedDate);
            groupBox2.Controls.Add(nmrExpieryDay);
            groupBox2.Controls.Add(btnUpdateIng);
            groupBox2.Controls.Add(btnClearIng);
            groupBox2.Controls.Add(btnAddIng);
            groupBox2.Controls.Add(label16);
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
            groupBox2.Size = new Size(724, 443);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nguyên liệu";
            // 
            // nmrExpieryDay
            // 
            nmrExpieryDay.Location = new Point(183, 260);
            nmrExpieryDay.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nmrExpieryDay.Name = "nmrExpieryDay";
            nmrExpieryDay.Size = new Size(228, 30);
            nmrExpieryDay.TabIndex = 44;
            // 
            // btnUpdateIng
            // 
            btnUpdateIng.BackColor = SystemColors.Control;
            btnUpdateIng.Image = Properties.Resources.pen;
            btnUpdateIng.ImageAlign = ContentAlignment.MiddleRight;
            btnUpdateIng.Location = new Point(343, 316);
            btnUpdateIng.Name = "btnUpdateIng";
            btnUpdateIng.Size = new Size(129, 56);
            btnUpdateIng.TabIndex = 40;
            btnUpdateIng.Text = "Lưu";
            btnUpdateIng.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdateIng.UseVisualStyleBackColor = false;
            btnUpdateIng.Click += btnUpdateIng_Click;
            // 
            // btnClearIng
            // 
            btnClearIng.BackColor = SystemColors.Control;
            btnClearIng.Image = Properties.Resources.arrow;
            btnClearIng.ImageAlign = ContentAlignment.MiddleRight;
            btnClearIng.Location = new Point(497, 316);
            btnClearIng.Name = "btnClearIng";
            btnClearIng.Size = new Size(129, 56);
            btnClearIng.TabIndex = 42;
            btnClearIng.Text = "Hoàn tác";
            btnClearIng.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClearIng.UseVisualStyleBackColor = false;
            btnClearIng.Click += btnClearIng_Click;
            // 
            // btnAddIng
            // 
            btnAddIng.BackColor = SystemColors.Control;
            btnAddIng.Image = Properties.Resources.plus;
            btnAddIng.ImageAlign = ContentAlignment.MiddleRight;
            btnAddIng.Location = new Point(44, 316);
            btnAddIng.Name = "btnAddIng";
            btnAddIng.Size = new Size(129, 56);
            btnAddIng.TabIndex = 41;
            btnAddIng.Text = "Thêm";
            btnAddIng.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddIng.UseVisualStyleBackColor = false;
            btnAddIng.Click += btnAddIng_Click;
            // 
            // btnDeleteIng
            // 
            btnDeleteIng.BackColor = SystemColors.Control;
            btnDeleteIng.Image = Properties.Resources.delete;
            btnDeleteIng.ImageAlign = ContentAlignment.MiddleRight;
            btnDeleteIng.Location = new Point(193, 316);
            btnDeleteIng.Name = "btnDeleteIng";
            btnDeleteIng.Size = new Size(129, 56);
            btnDeleteIng.TabIndex = 43;
            btnDeleteIng.Text = "Xóa";
            btnDeleteIng.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteIng.UseVisualStyleBackColor = false;
            btnDeleteIng.Click += btnDeleteIng_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(44, 263);
            label14.Name = "label14";
            label14.Size = new Size(122, 23);
            label14.TabIndex = 32;
            label14.Text = "Ngày hết hạn:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(44, 190);
            label13.Name = "label13";
            label13.Size = new Size(105, 23);
            label13.TabIndex = 32;
            label13.Text = "Đơn vị tính:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 153);
            label6.Name = "label6";
            label6.Size = new Size(124, 23);
            label6.TabIndex = 32;
            label6.Text = "Nhà cung cấp:";
            // 
            // txtIngredientPrice
            // 
            txtIngredientPrice.Location = new Point(183, 114);
            txtIngredientPrice.Name = "txtIngredientPrice";
            txtIngredientPrice.Size = new Size(228, 30);
            txtIngredientPrice.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 117);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 33;
            label5.Text = "Giá tiền:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 81);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 34;
            label4.Text = "Tên NL:";
            // 
            // cboUnit
            // 
            cboUnit.FormattingEnabled = true;
            cboUnit.Location = new Point(183, 187);
            cboUnit.Name = "cboUnit";
            cboUnit.Size = new Size(228, 31);
            cboUnit.TabIndex = 37;
            // 
            // cboIngredientName
            // 
            cboIngredientName.FormattingEnabled = true;
            cboIngredientName.Location = new Point(183, 78);
            cboIngredientName.Name = "cboIngredientName";
            cboIngredientName.Size = new Size(449, 31);
            cboIngredientName.TabIndex = 37;
            cboIngredientName.SelectedIndexChanged += cboIngredientName_SelectedIndexChanged;
            // 
            // cboSupplier
            // 
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(183, 150);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(449, 31);
            cboSupplier.TabIndex = 37;
            cboSupplier.SelectedIndexChanged += cboSupplier_SelectedIndexChanged;
            // 
            // txtIngredientId
            // 
            txtIngredientId.Location = new Point(183, 42);
            txtIngredientId.Name = "txtIngredientId";
            txtIngredientId.ReadOnly = true;
            txtIngredientId.Size = new Size(449, 30);
            txtIngredientId.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 45);
            label3.Name = "label3";
            label3.Size = new Size(40, 23);
            label3.TabIndex = 35;
            label3.Text = "Mã:";
            // 
            // txtFindIngredient
            // 
            txtFindIngredient.Location = new Point(108, 407);
            txtFindIngredient.Name = "txtFindIngredient";
            txtFindIngredient.Size = new Size(578, 30);
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
            panel2.Size = new Size(968, 373);
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
            groupBox1.Size = new Size(968, 373);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhà cung cấp";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(139, 169);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(309, 30);
            txtEmail.TabIndex = 49;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(28, 172);
            label15.Name = "label15";
            label15.Size = new Size(59, 23);
            label15.TabIndex = 48;
            label15.Text = "Email:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Control;
            btnUpdate.Image = Properties.Resources.pen;
            btnUpdate.ImageAlign = ContentAlignment.MiddleRight;
            btnUpdate.Location = new Point(319, 217);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 56);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "Lưu";
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnHoanTac
            // 
            btnHoanTac.BackColor = SystemColors.Control;
            btnHoanTac.Image = Properties.Resources.arrow;
            btnHoanTac.ImageAlign = ContentAlignment.MiddleRight;
            btnHoanTac.Location = new Point(468, 217);
            btnHoanTac.Name = "btnHoanTac";
            btnHoanTac.Size = new Size(129, 56);
            btnHoanTac.TabIndex = 46;
            btnHoanTac.Text = "Hoàn tác";
            btnHoanTac.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHoanTac.UseVisualStyleBackColor = false;
            btnHoanTac.Click += btnHoanTac_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Image = Properties.Resources.plus;
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(28, 219);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 56);
            btnAdd.TabIndex = 45;
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
            btnDelete.Location = new Point(174, 219);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 56);
            btnDelete.TabIndex = 47;
            btnDelete.Text = "Xóa";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(139, 133);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(309, 30);
            txtPhone.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 137);
            label7.Name = "label7";
            label7.Size = new Size(48, 23);
            label7.TabIndex = 38;
            label7.Text = "SĐT:";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(139, 74);
            txtSupplierName.Multiline = true;
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(309, 53);
            txtSupplierName.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 77);
            label9.Name = "label9";
            label9.Size = new Size(81, 23);
            label9.TabIndex = 39;
            label9.Text = "Tên NCC:";
            // 
            // txtSupplierID
            // 
            txtSupplierID.Location = new Point(139, 38);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.ReadOnly = true;
            txtSupplierID.Size = new Size(309, 30);
            txtSupplierID.TabIndex = 43;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 41);
            label10.Name = "label10";
            label10.Size = new Size(79, 23);
            label10.TabIndex = 40;
            label10.Text = "Mã NCC:";
            // 
            // cbProvince
            // 
            cbProvince.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbProvince.FormattingEnabled = true;
            cbProvince.Location = new Point(598, 111);
            cbProvince.Name = "cbProvince";
            cbProvince.Size = new Size(290, 31);
            cbProvince.TabIndex = 36;
            cbProvince.SelectedIndexChanged += cbProvince_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(487, 117);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 32;
            label2.Text = "Tỉnh/TP:";
            // 
            // cbWard
            // 
            cbWard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbWard.FormattingEnabled = true;
            cbWard.Location = new Point(598, 74);
            cbWard.Name = "cbWard";
            cbWard.Size = new Size(290, 31);
            cbWard.TabIndex = 37;
            cbWard.SelectedIndexChanged += cbWard_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(487, 80);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 33;
            label1.Text = "Xã/Phường:";
            // 
            // txtFindSuppliers
            // 
            txtFindSuppliers.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtFindSuppliers.Location = new Point(119, 337);
            txtFindSuppliers.Name = "txtFindSuppliers";
            txtFindSuppliers.Size = new Size(649, 30);
            txtFindSuppliers.TabIndex = 35;
            txtFindSuppliers.TextChanged += txtFindSuppliers_TextChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(22, 340);
            label11.Name = "label11";
            label11.Size = new Size(91, 23);
            label11.TabIndex = 34;
            label11.Text = "Tìm kiếm:";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Location = new Point(598, 38);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(290, 30);
            txtAddress.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(487, 41);
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
            dgvSupplier.Location = new Point(0, 373);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.RowHeadersWidth = 51;
            dgvSupplier.Size = new Size(959, 613);
            dgvSupplier.TabIndex = 2;
            dgvSupplier.CellClick += dgvSupplier_CellClick;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(44, 227);
            label16.Name = "label16";
            label16.Size = new Size(128, 23);
            label16.TabIndex = 32;
            label16.Text = "Ngày sản xuất:";
            // 
            // dtpProducedDate
            // 
            dtpProducedDate.Format = DateTimePickerFormat.Short;
            dtpProducedDate.Location = new Point(183, 224);
            dtpProducedDate.Name = "dtpProducedDate";
            dtpProducedDate.Size = new Size(228, 30);
            dtpProducedDate.TabIndex = 45;
            // 
            // frmSupplier
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1692, 989);
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
        private DateTimePicker dtpProducedDate;
        private Label label16;
    }
}