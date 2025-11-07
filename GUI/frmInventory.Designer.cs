namespace GUI
{
    partial class frmInventory
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
            dgvSupplierIngredient = new DataGridView();
            panel3 = new Panel();
            btnUpdateIngreToStock = new Button();
            nmrQty = new NumericUpDown();
            cboUnit1 = new ComboBox();
            txtFind1 = new TextBox();
            btnDeleteIngredient = new Button();
            txtSupplierName1 = new TextBox();
            txtProducedDate = new TextBox();
            txtExpiryDate = new TextBox();
            txtPrice = new TextBox();
            label19 = new Label();
            txtExpiryDay = new TextBox();
            label17 = new Label();
            label18 = new Label();
            btnAddIngreToStock = new Button();
            label5 = new Label();
            label16 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtIngreName1 = new TextBox();
            label2 = new Label();
            label14 = new Label();
            txtStockId = new TextBox();
            label20 = new Label();
            txtIngreId1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            label21 = new Label();
            txtFinalPrice = new TextBox();
            label26 = new Label();
            btnCheckoutReceipt = new Button();
            dgvStockReceipt = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            tabPage2 = new TabPage();
            dgvInventory = new DataGridView();
            panel4 = new Panel();
            txtFind2 = new TextBox();
            label13 = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            dtpFindStockByDate = new DateTimePicker();
            label15 = new Label();
            dgvStockHistory = new DataGridView();
            groupBox1 = new GroupBox();
            cboUnit2 = new ComboBox();
            dtpExpiryDate = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtSupplierName2 = new TextBox();
            txtInvQty = new TextBox();
            label22 = new Label();
            txtIngreName2 = new TextBox();
            label11 = new Label();
            txtIngreId2 = new TextBox();
            label12 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupplierIngredient).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrQty).BeginInit();
            panel1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockReceipt).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockHistory).BeginInit();
            groupBox1.SuspendLayout();
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
            tabPage1.BackColor = Color.FromArgb(249, 245, 238);
            tabPage1.Controls.Add(dgvSupplierIngredient);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1684, 953);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Phiếu nhập kho";
            // 
            // dgvSupplierIngredient
            // 
            dgvSupplierIngredient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplierIngredient.Dock = DockStyle.Fill;
            dgvSupplierIngredient.Location = new Point(3, 396);
            dgvSupplierIngredient.Name = "dgvSupplierIngredient";
            dgvSupplierIngredient.RowHeadersWidth = 51;
            dgvSupplierIngredient.Size = new Size(888, 554);
            dgvSupplierIngredient.TabIndex = 2;
            dgvSupplierIngredient.CellClick += dgvSupplierIngredient_CellClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnUpdateIngreToStock);
            panel3.Controls.Add(nmrQty);
            panel3.Controls.Add(cboUnit1);
            panel3.Controls.Add(txtFind1);
            panel3.Controls.Add(btnDeleteIngredient);
            panel3.Controls.Add(txtSupplierName1);
            panel3.Controls.Add(txtProducedDate);
            panel3.Controls.Add(txtExpiryDate);
            panel3.Controls.Add(txtPrice);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(txtExpiryDay);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(btnAddIngreToStock);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtIngreName1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txtStockId);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(txtIngreId1);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(888, 393);
            panel3.TabIndex = 1;
            // 
            // btnUpdateIngreToStock
            // 
            btnUpdateIngreToStock.BackColor = SystemColors.Control;
            btnUpdateIngreToStock.Image = Properties.Resources.pen;
            btnUpdateIngreToStock.ImageAlign = ContentAlignment.MiddleRight;
            btnUpdateIngreToStock.Location = new Point(250, 240);
            btnUpdateIngreToStock.Name = "btnUpdateIngreToStock";
            btnUpdateIngreToStock.Size = new Size(145, 53);
            btnUpdateIngreToStock.TabIndex = 33;
            btnUpdateIngreToStock.Text = "Lưu";
            btnUpdateIngreToStock.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdateIngreToStock.UseVisualStyleBackColor = false;
            btnUpdateIngreToStock.Click += btnUpdateIngreToStock_Click;
            // 
            // nmrQty
            // 
            nmrQty.Location = new Point(117, 149);
            nmrQty.Name = "nmrQty";
            nmrQty.Size = new Size(175, 30);
            nmrQty.TabIndex = 21;
            nmrQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nmrQty.ValueChanged += nmrQty_ValueChanged;
            // 
            // cboUnit1
            // 
            cboUnit1.FormattingEnabled = true;
            cboUnit1.Location = new Point(550, 186);
            cboUnit1.Name = "cboUnit1";
            cboUnit1.Size = new Size(168, 31);
            cboUnit1.TabIndex = 17;
            // 
            // txtFind1
            // 
            txtFind1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtFind1.Location = new Point(127, 357);
            txtFind1.Name = "txtFind1";
            txtFind1.Size = new Size(618, 30);
            txtFind1.TabIndex = 14;
            // 
            // btnDeleteIngredient
            // 
            btnDeleteIngredient.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteIngredient.BackColor = SystemColors.Control;
            btnDeleteIngredient.Image = Properties.Resources.delete;
            btnDeleteIngredient.ImageAlign = ContentAlignment.MiddleRight;
            btnDeleteIngredient.Location = new Point(429, 238);
            btnDeleteIngredient.Name = "btnDeleteIngredient";
            btnDeleteIngredient.Size = new Size(167, 55);
            btnDeleteIngredient.TabIndex = 5;
            btnDeleteIngredient.Text = "Xóa nguyên liệu";
            btnDeleteIngredient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteIngredient.UseVisualStyleBackColor = false;
            btnDeleteIngredient.Click += btnDeleteIngredient_Click;
            // 
            // txtSupplierName1
            // 
            txtSupplierName1.Location = new Point(550, 42);
            txtSupplierName1.Name = "txtSupplierName1";
            txtSupplierName1.ReadOnly = true;
            txtSupplierName1.Size = new Size(312, 30);
            txtSupplierName1.TabIndex = 14;
            // 
            // txtProducedDate
            // 
            txtProducedDate.Location = new Point(550, 114);
            txtProducedDate.Name = "txtProducedDate";
            txtProducedDate.ReadOnly = true;
            txtProducedDate.Size = new Size(168, 30);
            txtProducedDate.TabIndex = 14;
            // 
            // txtExpiryDate
            // 
            txtExpiryDate.Location = new Point(550, 150);
            txtExpiryDate.Name = "txtExpiryDate";
            txtExpiryDate.ReadOnly = true;
            txtExpiryDate.Size = new Size(168, 30);
            txtExpiryDate.TabIndex = 14;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(117, 185);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(175, 30);
            txtPrice.TabIndex = 14;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(420, 120);
            label19.Name = "label19";
            label19.Size = new Size(128, 23);
            label19.TabIndex = 8;
            label19.Text = "Ngày sản xuất:";
            // 
            // txtExpiryDay
            // 
            txtExpiryDay.Location = new Point(550, 78);
            txtExpiryDay.Name = "txtExpiryDay";
            txtExpiryDay.ReadOnly = true;
            txtExpiryDay.Size = new Size(168, 30);
            txtExpiryDay.TabIndex = 14;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(420, 156);
            label17.Name = "label17";
            label17.Size = new Size(122, 23);
            label17.TabIndex = 8;
            label17.Text = "Ngày hết hạn:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(23, 192);
            label18.Name = "label18";
            label18.Size = new Size(77, 23);
            label18.TabIndex = 8;
            label18.Text = "Giá tiền:";
            // 
            // btnAddIngreToStock
            // 
            btnAddIngreToStock.BackColor = SystemColors.Control;
            btnAddIngreToStock.FlatAppearance.BorderSize = 0;
            btnAddIngreToStock.Image = Properties.Resources.plus;
            btnAddIngreToStock.ImageAlign = ContentAlignment.MiddleRight;
            btnAddIngreToStock.Location = new Point(21, 240);
            btnAddIngreToStock.Name = "btnAddIngreToStock";
            btnAddIngreToStock.Size = new Size(194, 56);
            btnAddIngreToStock.TabIndex = 20;
            btnAddIngreToStock.Text = "Thêm nguyên liệu";
            btnAddIngreToStock.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddIngreToStock.UseVisualStyleBackColor = false;
            btnAddIngreToStock.Click += btnAddIngreToStock_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(420, 84);
            label5.Name = "label5";
            label5.Size = new Size(107, 23);
            label5.TabIndex = 8;
            label5.Text = "HSD (ngày):";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label16.AutoSize = true;
            label16.Location = new Point(30, 364);
            label16.Name = "label16";
            label16.Size = new Size(91, 23);
            label16.TabIndex = 10;
            label16.Text = "Tìm kiếm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(420, 189);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 9;
            label4.Text = "Đơn vị:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(420, 49);
            label3.Name = "label3";
            label3.Size = new Size(124, 23);
            label3.TabIndex = 10;
            label3.Text = "Nhà cung cấp:";
            // 
            // txtIngreName1
            // 
            txtIngreName1.Location = new Point(117, 113);
            txtIngreName1.Name = "txtIngreName1";
            txtIngreName1.ReadOnly = true;
            txtIngreName1.Size = new Size(278, 30);
            txtIngreName1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 120);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 11;
            label2.Text = "Tên NL:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(21, 156);
            label14.Name = "label14";
            label14.Size = new Size(88, 23);
            label14.TabIndex = 12;
            label14.Text = "Số lượng:";
            // 
            // txtStockId
            // 
            txtStockId.Location = new Point(117, 42);
            txtStockId.Name = "txtStockId";
            txtStockId.ReadOnly = true;
            txtStockId.Size = new Size(278, 30);
            txtStockId.TabIndex = 16;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(21, 49);
            label20.Name = "label20";
            label20.Size = new Size(68, 23);
            label20.TabIndex = 13;
            label20.Text = "Mã PN:";
            // 
            // txtIngreId1
            // 
            txtIngreId1.Location = new Point(117, 78);
            txtIngreId1.Name = "txtIngreId1";
            txtIngreId1.ReadOnly = true;
            txtIngreId1.Size = new Size(278, 30);
            txtIngreId1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 85);
            label1.Name = "label1";
            label1.Size = new Size(67, 23);
            label1.TabIndex = 13;
            label1.Text = "Mã NL:";
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(891, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 947);
            panel1.TabIndex = 0;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(0, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(790, 947);
            tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(249, 245, 238);
            tabPage3.Controls.Add(label21);
            tabPage3.Controls.Add(txtFinalPrice);
            tabPage3.Controls.Add(label26);
            tabPage3.Controls.Add(btnCheckoutReceipt);
            tabPage3.Controls.Add(dgvStockReceipt);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label7);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(782, 911);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Phiếu nhập";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label21.Location = new Point(10, 770);
            label21.Name = "label21";
            label21.Size = new Size(119, 28);
            label21.TabIndex = 11;
            label21.Text = "Thành tiền:";
            // 
            // txtFinalPrice
            // 
            txtFinalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtFinalPrice.Location = new Point(135, 764);
            txtFinalPrice.Name = "txtFinalPrice";
            txtFinalPrice.ReadOnly = true;
            txtFinalPrice.Size = new Size(373, 34);
            txtFinalPrice.TabIndex = 7;
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label26.Location = new Point(6, 764);
            label26.Name = "label26";
            label26.Size = new Size(0, 28);
            label26.TabIndex = 6;
            // 
            // btnCheckoutReceipt
            // 
            btnCheckoutReceipt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCheckoutReceipt.BackColor = SystemColors.Control;
            btnCheckoutReceipt.Image = Properties.Resources.plus;
            btnCheckoutReceipt.ImageAlign = ContentAlignment.MiddleRight;
            btnCheckoutReceipt.Location = new Point(6, 816);
            btnCheckoutReceipt.Name = "btnCheckoutReceipt";
            btnCheckoutReceipt.Size = new Size(145, 55);
            btnCheckoutReceipt.TabIndex = 5;
            btnCheckoutReceipt.Text = "Xuất phiếu";
            btnCheckoutReceipt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCheckoutReceipt.UseVisualStyleBackColor = false;
            btnCheckoutReceipt.Click += btnCheckoutReceipt_Click;
            // 
            // dgvStockReceipt
            // 
            dgvStockReceipt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvStockReceipt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockReceipt.Location = new Point(6, 53);
            dgvStockReceipt.Name = "dgvStockReceipt";
            dgvStockReceipt.RowHeadersWidth = 51;
            dgvStockReceipt.Size = new Size(770, 699);
            dgvStockReceipt.TabIndex = 0;
            dgvStockReceipt.CellClick += dgvStockReceipt_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(6, 3);
            label6.Name = "label6";
            label6.Size = new Size(0, 32);
            label6.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(6, 12);
            label7.Name = "label7";
            label7.Size = new Size(227, 28);
            label7.TabIndex = 10;
            label7.Text = "Danh sách nguyên liệu";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(249, 245, 238);
            tabPage2.Controls.Add(dgvInventory);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1684, 956);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kho hàng";
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.Location = new Point(810, 84);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.Size = new Size(871, 869);
            dgvInventory.TabIndex = 3;
            dgvInventory.CellClick += dgvInventory_CellClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtFind2);
            panel4.Controls.Add(label13);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(810, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(871, 81);
            panel4.TabIndex = 2;
            // 
            // txtFind2
            // 
            txtFind2.Location = new Point(162, 36);
            txtFind2.Name = "txtFind2";
            txtFind2.Size = new Size(581, 30);
            txtFind2.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 39);
            label13.Name = "label13";
            label13.Size = new Size(144, 23);
            label13.TabIndex = 8;
            label13.Text = "Tìm nguyên liệu:";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(807, 950);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpFindStockByDate);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(dgvStockHistory);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 321);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(807, 629);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lịch sử nhập kho";
            // 
            // dtpFindStockByDate
            // 
            dtpFindStockByDate.Format = DateTimePickerFormat.Short;
            dtpFindStockByDate.Location = new Point(160, 42);
            dtpFindStockByDate.Name = "dtpFindStockByDate";
            dtpFindStockByDate.Size = new Size(179, 30);
            dtpFindStockByDate.TabIndex = 32;
            dtpFindStockByDate.ValueChanged += dtpFindStockByDate_ValueChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label15.Location = new Point(17, 49);
            label15.Name = "label15";
            label15.Size = new Size(137, 23);
            label15.TabIndex = 31;
            label15.Text = "Ngày lập phiếu:";
            // 
            // dgvStockHistory
            // 
            dgvStockHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStockHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStockHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockHistory.Location = new Point(0, 78);
            dgvStockHistory.Name = "dgvStockHistory";
            dgvStockHistory.RowHeadersWidth = 51;
            dgvStockHistory.Size = new Size(801, 545);
            dgvStockHistory.TabIndex = 30;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboUnit2);
            groupBox1.Controls.Add(dtpExpiryDate);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtSupplierName2);
            groupBox1.Controls.Add(txtInvQty);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(txtIngreName2);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtIngreId2);
            groupBox1.Controls.Add(label12);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(807, 321);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nguyên liệu";
            // 
            // cboUnit2
            // 
            cboUnit2.FormattingEnabled = true;
            cboUnit2.Location = new Point(160, 122);
            cboUnit2.Name = "cboUnit2";
            cboUnit2.Size = new Size(179, 31);
            cboUnit2.TabIndex = 26;
            // 
            // dtpExpiryDate
            // 
            dtpExpiryDate.Enabled = false;
            dtpExpiryDate.Format = DateTimePickerFormat.Short;
            dtpExpiryDate.Location = new Point(160, 271);
            dtpExpiryDate.Name = "dtpExpiryDate";
            dtpExpiryDate.Size = new Size(179, 30);
            dtpExpiryDate.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 277);
            label8.Name = "label8";
            label8.Size = new Size(122, 23);
            label8.TabIndex = 16;
            label8.Text = "Ngày hết hạn:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 129);
            label9.Name = "label9";
            label9.Size = new Size(68, 23);
            label9.TabIndex = 17;
            label9.Text = "Đơn vị:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(33, 201);
            label10.Name = "label10";
            label10.Size = new Size(124, 23);
            label10.TabIndex = 18;
            label10.Text = "Nhà cung cấp:";
            // 
            // txtSupplierName2
            // 
            txtSupplierName2.Location = new Point(160, 195);
            txtSupplierName2.Multiline = true;
            txtSupplierName2.Name = "txtSupplierName2";
            txtSupplierName2.ReadOnly = true;
            txtSupplierName2.Size = new Size(493, 70);
            txtSupplierName2.TabIndex = 21;
            // 
            // txtInvQty
            // 
            txtInvQty.Location = new Point(160, 159);
            txtInvQty.Name = "txtInvQty";
            txtInvQty.ReadOnly = true;
            txtInvQty.Size = new Size(179, 30);
            txtInvQty.TabIndex = 22;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(35, 166);
            label22.Name = "label22";
            label22.Size = new Size(120, 23);
            label22.TabIndex = 19;
            label22.Text = "Số lượng tồn:";
            // 
            // txtIngreName2
            // 
            txtIngreName2.Location = new Point(160, 86);
            txtIngreName2.Name = "txtIngreName2";
            txtIngreName2.ReadOnly = true;
            txtIngreName2.Size = new Size(493, 30);
            txtIngreName2.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 93);
            label11.Name = "label11";
            label11.Size = new Size(69, 23);
            label11.TabIndex = 19;
            label11.Text = "Tên NL:";
            // 
            // txtIngreId2
            // 
            txtIngreId2.Location = new Point(160, 50);
            txtIngreId2.Name = "txtIngreId2";
            txtIngreId2.ReadOnly = true;
            txtIngreId2.Size = new Size(493, 30);
            txtIngreId2.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(35, 57);
            label12.Name = "label12";
            label12.Size = new Size(67, 23);
            label12.TabIndex = 20;
            label12.Text = "Mã NL:";
            // 
            // frmInventory
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1692, 989);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "frmInventory";
            Text = "frmInventory";
            Load += frmInventory_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSupplierIngredient).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrQty).EndInit();
            panel1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockReceipt).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockHistory).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private Button btnDeleteIngredient;
        private Panel panel2;
        private TextBox txtFind2;
        private Label label13;
        private DataGridView dgvSupplierIngredient;
        private Panel panel3;
        private NumericUpDown nmrQty;
        private ComboBox cboUnit1;
        private TextBox txtExpiryDay;
        private Button btnAddIngreToStock;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtIngreName1;
        private Label label2;
        private Label label14;
        private TextBox txtIngreId1;
        private Label label1;
        private TextBox txtSupplierName1;
        private Button btnUpdateIngreToStock;
        private TextBox txtFind1;
        private Label label16;
        private Label label17;
        private TextBox txtExpiryDate;
        private TextBox txtPrice;
        private Label label18;
        private TextBox txtProducedDate;
        private Label label19;
        private TextBox txtStockId;
        private Label label20;
        private DataGridView dgvInventory;
        private Panel panel4;
        private GroupBox groupBox1;
        private ComboBox cboUnit2;
        private DateTimePicker dtpExpiryDate;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtSupplierName2;
        private TextBox txtIngreName2;
        private Label label11;
        private TextBox txtIngreId2;
        private Label label12;
        private GroupBox groupBox2;
        private DateTimePicker dtpFindStockByDate;
        private Label label15;
        private DataGridView dgvStockHistory;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private Label label26;
        private DataGridView dgvStockReceipt;
        private Label label6;
        private Label label7;
        private Label label21;
        private TextBox txtFinalPrice;
        private Button btnCheckoutReceipt;
        private TextBox txtInvQty;
        private Label label22;
    }
}