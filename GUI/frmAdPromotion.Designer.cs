namespace GUI
{
    partial class frmAdPromotion
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvDataVoucher = new DataGridView();
            panel1 = new Panel();
            numVoucherExpiryday = new NumericUpDown();
            btnUpdateVoucher = new Button();
            btnClearVoucher = new Button();
            btnAddVoucher = new Button();
            btnDeleteVoucher = new Button();
            cbVoucherDiscountType = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtVoucherDescription = new TextBox();
            label3 = new Label();
            txtVoucherMaxDiscount = new TextBox();
            txtVoucherValue = new TextBox();
            label8 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            txtVoucherName = new TextBox();
            label5 = new Label();
            txtVoucherID = new TextBox();
            label6 = new Label();
            tabPage2 = new TabPage();
            dgvPromotionProgram = new DataGridView();
            panel2 = new Panel();
            txtPPMaxDiscount = new TextBox();
            nmrPPRequiringPoint = new NumericUpDown();
            label18 = new Label();
            dtpPPStartDate = new DateTimePicker();
            nmrPPExpiryDay = new NumericUpDown();
            btnSave = new Button();
            btnReset = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            label17 = new Label();
            cboPPDiscountType = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            txtPPDescription = new TextBox();
            label11 = new Label();
            txtPPValue = new TextBox();
            label12 = new Label();
            label13 = new Label();
            txtPPSearch = new TextBox();
            label14 = new Label();
            txtPPName = new TextBox();
            label15 = new Label();
            txtPPId = new TextBox();
            label16 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataVoucher).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numVoucherExpiryday).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPromotionProgram).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrPPRequiringPoint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrPPExpiryDay).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1692, 989);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvDataVoucher);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1684, 953);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản lý Voucher";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvDataVoucher
            // 
            dgvDataVoucher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataVoucher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataVoucher.Dock = DockStyle.Fill;
            dgvDataVoucher.Location = new Point(3, 419);
            dgvDataVoucher.Name = "dgvDataVoucher";
            dgvDataVoucher.RowHeadersWidth = 51;
            dgvDataVoucher.Size = new Size(1678, 531);
            dgvDataVoucher.TabIndex = 5;
            dgvDataVoucher.CellClick += dgvDataVoucher_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(numVoucherExpiryday);
            panel1.Controls.Add(btnUpdateVoucher);
            panel1.Controls.Add(btnClearVoucher);
            panel1.Controls.Add(btnAddVoucher);
            panel1.Controls.Add(btnDeleteVoucher);
            panel1.Controls.Add(cbVoucherDiscountType);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtVoucherDescription);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtVoucherMaxDiscount);
            panel1.Controls.Add(txtVoucherValue);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtVoucherName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtVoucherID);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1678, 416);
            panel1.TabIndex = 4;
            // 
            // numVoucherExpiryday
            // 
            numVoucherExpiryday.Location = new Point(952, 144);
            numVoucherExpiryday.Name = "numVoucherExpiryday";
            numVoucherExpiryday.Size = new Size(185, 30);
            numVoucherExpiryday.TabIndex = 34;
            // 
            // btnUpdateVoucher
            // 
            btnUpdateVoucher.BackColor = SystemColors.Control;
            btnUpdateVoucher.Image = Properties.Resources.pen;
            btnUpdateVoucher.ImageAlign = ContentAlignment.MiddleRight;
            btnUpdateVoucher.Location = new Point(343, 255);
            btnUpdateVoucher.Name = "btnUpdateVoucher";
            btnUpdateVoucher.Size = new Size(132, 57);
            btnUpdateVoucher.TabIndex = 32;
            btnUpdateVoucher.Text = "Lưu";
            btnUpdateVoucher.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdateVoucher.UseVisualStyleBackColor = false;
            btnUpdateVoucher.Click += btnUpdateVoucher_Click;
            // 
            // btnClearVoucher
            // 
            btnClearVoucher.BackColor = SystemColors.Control;
            btnClearVoucher.Image = Properties.Resources.arrow;
            btnClearVoucher.ImageAlign = ContentAlignment.MiddleRight;
            btnClearVoucher.Location = new Point(494, 255);
            btnClearVoucher.Name = "btnClearVoucher";
            btnClearVoucher.Size = new Size(132, 57);
            btnClearVoucher.TabIndex = 33;
            btnClearVoucher.Text = "Hoàn tác";
            btnClearVoucher.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClearVoucher.UseVisualStyleBackColor = false;
            btnClearVoucher.Click += btnClearVoucher_Click;
            // 
            // btnAddVoucher
            // 
            btnAddVoucher.BackColor = SystemColors.Control;
            btnAddVoucher.Image = Properties.Resources.plus;
            btnAddVoucher.ImageAlign = ContentAlignment.MiddleRight;
            btnAddVoucher.Location = new Point(41, 255);
            btnAddVoucher.Name = "btnAddVoucher";
            btnAddVoucher.Size = new Size(132, 57);
            btnAddVoucher.TabIndex = 32;
            btnAddVoucher.Text = "Thêm";
            btnAddVoucher.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddVoucher.UseVisualStyleBackColor = false;
            btnAddVoucher.Click += btnAddVoucher_Click;
            // 
            // btnDeleteVoucher
            // 
            btnDeleteVoucher.BackColor = SystemColors.Control;
            btnDeleteVoucher.Image = Properties.Resources.delete;
            btnDeleteVoucher.ImageAlign = ContentAlignment.MiddleRight;
            btnDeleteVoucher.Location = new Point(192, 255);
            btnDeleteVoucher.Name = "btnDeleteVoucher";
            btnDeleteVoucher.Size = new Size(132, 57);
            btnDeleteVoucher.TabIndex = 33;
            btnDeleteVoucher.Text = "Xóa";
            btnDeleteVoucher.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteVoucher.UseVisualStyleBackColor = false;
            btnDeleteVoucher.Click += btnDeleteVoucher_Click;
            // 
            // cbVoucherDiscountType
            // 
            cbVoucherDiscountType.FormattingEnabled = true;
            cbVoucherDiscountType.Location = new Point(952, 37);
            cbVoucherDiscountType.Name = "cbVoucherDiscountType";
            cbVoucherDiscountType.Size = new Size(503, 31);
            cbVoucherDiscountType.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(857, 149);
            label2.Name = "label2";
            label2.Size = new Size(51, 23);
            label2.TabIndex = 22;
            label2.Text = "HSD:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(856, 115);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 22;
            label1.Text = "Giới hạn:";
            // 
            // txtVoucherDescription
            // 
            txtVoucherDescription.Location = new Point(122, 111);
            txtVoucherDescription.Multiline = true;
            txtVoucherDescription.Name = "txtVoucherDescription";
            txtVoucherDescription.Size = new Size(609, 119);
            txtVoucherDescription.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 117);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 23;
            label3.Text = "Mô tả:";
            // 
            // txtVoucherMaxDiscount
            // 
            txtVoucherMaxDiscount.Location = new Point(951, 108);
            txtVoucherMaxDiscount.Name = "txtVoucherMaxDiscount";
            txtVoucherMaxDiscount.Size = new Size(503, 30);
            txtVoucherMaxDiscount.TabIndex = 27;
            // 
            // txtVoucherValue
            // 
            txtVoucherValue.Location = new Point(952, 73);
            txtVoucherValue.Name = "txtVoucherValue";
            txtVoucherValue.Size = new Size(503, 30);
            txtVoucherValue.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(857, 76);
            label8.Name = "label8";
            label8.Size = new Size(85, 23);
            label8.TabIndex = 23;
            label8.Text = "Khấu trừ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(857, 43);
            label7.Name = "label7";
            label7.Size = new Size(80, 23);
            label7.TabIndex = 24;
            label7.Text = "Loại KM:";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox2.Location = new Point(144, 380);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(765, 30);
            textBox2.TabIndex = 29;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(39, 386);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 25;
            label4.Text = "Tìm kiếm:";
            // 
            // txtVoucherName
            // 
            txtVoucherName.Location = new Point(122, 75);
            txtVoucherName.Name = "txtVoucherName";
            txtVoucherName.Size = new Size(609, 30);
            txtVoucherName.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 81);
            label5.Name = "label5";
            label5.Size = new Size(42, 23);
            label5.TabIndex = 25;
            label5.Text = "Tên:";
            // 
            // txtVoucherID
            // 
            txtVoucherID.Location = new Point(122, 39);
            txtVoucherID.Name = "txtVoucherID";
            txtVoucherID.ReadOnly = true;
            txtVoucherID.Size = new Size(609, 30);
            txtVoucherID.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 45);
            label6.Name = "label6";
            label6.Size = new Size(72, 23);
            label6.TabIndex = 26;
            label6.Text = "Mã KM:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvPromotionProgram);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1684, 953);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Quản lý Chương trình KM";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPromotionProgram
            // 
            dgvPromotionProgram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPromotionProgram.Dock = DockStyle.Fill;
            dgvPromotionProgram.Location = new Point(3, 454);
            dgvPromotionProgram.Name = "dgvPromotionProgram";
            dgvPromotionProgram.RowHeadersWidth = 51;
            dgvPromotionProgram.Size = new Size(1678, 496);
            dgvPromotionProgram.TabIndex = 7;
            dgvPromotionProgram.CellClick += dgvPromotionProgram_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtPPMaxDiscount);
            panel2.Controls.Add(nmrPPRequiringPoint);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(dtpPPStartDate);
            panel2.Controls.Add(nmrPPExpiryDay);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(cboPPDiscountType);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtPPDescription);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtPPValue);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(txtPPSearch);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(txtPPName);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(txtPPId);
            panel2.Controls.Add(label16);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1678, 451);
            panel2.TabIndex = 6;
            // 
            // txtPPMaxDiscount
            // 
            txtPPMaxDiscount.Location = new Point(968, 116);
            txtPPMaxDiscount.Name = "txtPPMaxDiscount";
            txtPPMaxDiscount.Size = new Size(470, 30);
            txtPPMaxDiscount.TabIndex = 38;
            // 
            // nmrPPRequiringPoint
            // 
            nmrPPRequiringPoint.Location = new Point(968, 224);
            nmrPPRequiringPoint.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nmrPPRequiringPoint.Name = "nmrPPRequiringPoint";
            nmrPPRequiringPoint.Size = new Size(209, 30);
            nmrPPRequiringPoint.TabIndex = 37;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(836, 229);
            label18.Name = "label18";
            label18.Size = new Size(123, 23);
            label18.TabIndex = 36;
            label18.Text = "Điểm yêu cầu:";
            // 
            // dtpPPStartDate
            // 
            dtpPPStartDate.Format = DateTimePickerFormat.Short;
            dtpPPStartDate.Location = new Point(968, 152);
            dtpPPStartDate.Name = "dtpPPStartDate";
            dtpPPStartDate.Size = new Size(209, 30);
            dtpPPStartDate.TabIndex = 35;
            // 
            // nmrPPExpiryDay
            // 
            nmrPPExpiryDay.Location = new Point(968, 188);
            nmrPPExpiryDay.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nmrPPExpiryDay.Name = "nmrPPExpiryDay";
            nmrPPExpiryDay.Size = new Size(209, 30);
            nmrPPExpiryDay.TabIndex = 34;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.Image = Properties.Resources.pen;
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(337, 300);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(136, 61);
            btnSave.TabIndex = 32;
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
            btnReset.Location = new Point(488, 300);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(136, 61);
            btnReset.TabIndex = 33;
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
            btnAdd.Location = new Point(35, 300);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 61);
            btnAdd.TabIndex = 32;
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
            btnDelete.Location = new Point(186, 300);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 61);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Xóa";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(836, 193);
            label17.Name = "label17";
            label17.Size = new Size(51, 23);
            label17.TabIndex = 22;
            label17.Text = "HSD:";
            // 
            // cboPPDiscountType
            // 
            cboPPDiscountType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPPDiscountType.FormattingEnabled = true;
            cboPPDiscountType.Location = new Point(968, 43);
            cboPPDiscountType.Name = "cboPPDiscountType";
            cboPPDiscountType.Size = new Size(470, 31);
            cboPPDiscountType.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(836, 158);
            label9.Name = "label9";
            label9.Size = new Size(124, 23);
            label9.TabIndex = 22;
            label9.Text = "Ngày bắt đầu:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(836, 117);
            label10.Name = "label10";
            label10.Size = new Size(82, 23);
            label10.TabIndex = 22;
            label10.Text = "Giới hạn:";
            // 
            // txtPPDescription
            // 
            txtPPDescription.Location = new Point(114, 118);
            txtPPDescription.Multiline = true;
            txtPPDescription.Name = "txtPPDescription";
            txtPPDescription.Size = new Size(565, 136);
            txtPPDescription.TabIndex = 27;
            txtPPDescription.TextChanged += txtPPDescription_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(30, 124);
            label11.Name = "label11";
            label11.Size = new Size(62, 23);
            label11.TabIndex = 23;
            label11.Text = "Mô tả:";
            // 
            // txtPPValue
            // 
            txtPPValue.Location = new Point(968, 80);
            txtPPValue.Name = "txtPPValue";
            txtPPValue.Size = new Size(470, 30);
            txtPPValue.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(836, 77);
            label12.Name = "label12";
            label12.Size = new Size(85, 23);
            label12.TabIndex = 23;
            label12.Text = "Khấu trừ:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(836, 43);
            label13.Name = "label13";
            label13.Size = new Size(80, 23);
            label13.TabIndex = 24;
            label13.Text = "Loại KM:";
            // 
            // txtPPSearch
            // 
            txtPPSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtPPSearch.Location = new Point(114, 414);
            txtPPSearch.Name = "txtPPSearch";
            txtPPSearch.Size = new Size(616, 30);
            txtPPSearch.TabIndex = 29;
            txtPPSearch.TextChanged += txtPPSearch_TextChanged;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Location = new Point(17, 417);
            label14.Name = "label14";
            label14.Size = new Size(91, 23);
            label14.TabIndex = 25;
            label14.Text = "Tìm kiếm:";
            // 
            // txtPPName
            // 
            txtPPName.Location = new Point(113, 81);
            txtPPName.Name = "txtPPName";
            txtPPName.Size = new Size(565, 30);
            txtPPName.TabIndex = 29;
            txtPPName.Leave += txtPPName_Leave;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(30, 87);
            label15.Name = "label15";
            label15.Size = new Size(42, 23);
            label15.TabIndex = 25;
            label15.Text = "Tên:";
            // 
            // txtPPId
            // 
            txtPPId.Location = new Point(113, 45);
            txtPPId.Name = "txtPPId";
            txtPPId.ReadOnly = true;
            txtPPId.Size = new Size(565, 30);
            txtPPId.TabIndex = 30;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(30, 51);
            label16.Name = "label16";
            label16.Size = new Size(72, 23);
            label16.TabIndex = 26;
            label16.Text = "Mã KM:";
            // 
            // frmAdPromotion
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1692, 989);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "frmAdPromotion";
            Text = "frmPromotion";
            Load += frmAdPromotion_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDataVoucher).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numVoucherExpiryday).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPromotionProgram).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrPPRequiringPoint).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrPPExpiryDay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvDataVoucher;
        private Panel panel1;
        private Button btnUpdateVoucher;
        private Button btnClearVoucher;
        private Button btnAddVoucher;
        private Button btnDeleteVoucher;
        private ComboBox cbVoucherDiscountType;
        private Label label2;
        private Label label1;
        private TextBox txtVoucherDescription;
        private Label label3;
        private TextBox txtVoucherValue;
        private Label label8;
        private Label label7;
        private TextBox textBox2;
        private Label label4;
        private TextBox txtVoucherName;
        private Label label5;
        private TextBox txtVoucherID;
        private Label label6;
        private NumericUpDown numVoucherExpiryday;
        private DataGridView dgvPromotionProgram;
        private Panel panel2;
        private DateTimePicker dtpPPStartDate;
        private NumericUpDown nmrPPExpiryDay;
        private Button btnSave;
        private Button btnReset;
        private Button btnAdd;
        private Button btnDelete;
        private Label label17;
        private ComboBox cboPPDiscountType;
        private Label label9;
        private Label label10;
        private TextBox txtPPDescription;
        private Label label11;
        private TextBox txtPPValue;
        private Label label12;
        private Label label13;
        private TextBox txtPPSearch;
        private Label label14;
        private TextBox txtPPName;
        private Label label15;
        private TextBox txtPPId;
        private Label label16;
        private NumericUpDown nmrPPRequiringPoint;
        private Label label18;
        private TextBox txtPPMaxDiscount;
        private TextBox txtVoucherMaxDiscount;
    }
}