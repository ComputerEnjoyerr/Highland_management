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
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            numericUpDown1 = new NumericUpDown();
            comboBox2 = new ComboBox();
            textBox10 = new TextBox();
            textBox5 = new TextBox();
            button12 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label14 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            textBox3 = new TextBox();
            label26 = new Label();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            button2 = new Button();
            label6 = new Label();
            tabPage4 = new TabPage();
            dataGridView3 = new DataGridView();
            clA = new DataGridViewTextBoxColumn();
            cl2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox7 = new TextBox();
            label13 = new Label();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox4 = new TextBox();
            label11 = new Label();
            textBox6 = new TextBox();
            label12 = new Label();
            dataGridView4 = new DataGridView();
            button4 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
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
            tabControl1.Size = new Size(992, 710);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(984, 674);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Phiếu nhập kho";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(597, 489);
            dataGridView1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(button4);
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(textBox10);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(button12);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(597, 179);
            panel3.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(93, 78);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(156, 30);
            numericUpDown1.TabIndex = 21;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(379, 78);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(209, 31);
            comboBox2.TabIndex = 17;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(379, 15);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(209, 30);
            textBox10.TabIndex = 14;
            // 
            // textBox5
            // 
<<<<<<< Updated upstream
            textBox5.Location = new Point(379, 47);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(209, 30);
            textBox5.TabIndex = 14;
=======
            txtFind1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtFind1.Location = new Point(127, 357);
            txtFind1.Name = "txtFind1";
            txtFind1.Size = new Size(618, 30);
            txtFind1.TabIndex = 14;
            txtFind1.TextChanged += txtFind1_TextChanged;
>>>>>>> Stashed changes
            // 
            // button12
            // 
            button12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button12.BackColor = Color.FromArgb(104, 176, 145);
            button12.FlatAppearance.BorderSize = 0;
            button12.Location = new Point(9, 117);
            button12.Name = "button12";
            button12.Size = new Size(145, 56);
            button12.TabIndex = 20;
            button12.Text = "Thêm nguyên liệu";
            button12.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(257, 53);
            label5.Name = "label5";
            label5.Size = new Size(107, 23);
            label5.TabIndex = 8;
            label5.Text = "HSD (ngày):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 84);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 9;
            label4.Text = "Đơn vị:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 22);
            label3.Name = "label3";
            label3.Size = new Size(124, 23);
            label3.TabIndex = 10;
            label3.Text = "Nhà cung cấp:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 30);
            textBox2.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 53);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 11;
            label2.Text = "Tên NL:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(9, 84);
            label14.Name = "label14";
            label14.Size = new Size(88, 23);
            label14.TabIndex = 12;
            label14.Text = "Số lượng:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 30);
            textBox1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 22);
            label1.Name = "label1";
            label1.Size = new Size(67, 23);
            label1.TabIndex = 13;
            label1.Text = "Mã NL:";
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(600, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(381, 668);
            panel1.TabIndex = 0;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(0, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(381, 668);
            tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(label26);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(label6);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(373, 632);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Phiếu nhập";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox3.Location = new Point(124, 515);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(243, 34);
            textBox3.TabIndex = 7;
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label26.Location = new Point(6, 518);
            label26.Name = "label26";
            label26.Size = new Size(119, 28);
            label26.TabIndex = 6;
            label26.Text = "Thành tiền:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(104, 176, 145);
            button1.Location = new Point(6, 568);
            button1.Name = "button1";
            button1.Size = new Size(145, 55);
            button1.TabIndex = 5;
            button1.Text = "Xuất phiếu";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 38);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(361, 471);
            dataGridView2.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.FromArgb(169, 65, 65);
            button2.Location = new Point(157, 568);
            button2.Name = "button2";
            button2.Size = new Size(145, 55);
            button2.TabIndex = 5;
            button2.Text = "Xóa nguyên liệu";
            button2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(6, 3);
            label6.Name = "label6";
            label6.Size = new Size(280, 32);
            label6.TabIndex = 2;
            label6.Text = "Danh sách nguyên liệu:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView3);
            tabPage4.Controls.Add(label7);
            tabPage4.Location = new Point(4, 32);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(373, 632);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Lịch sử";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { clA, cl2, Column1, Column2 });
            dataGridView3.Location = new Point(6, 38);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(361, 600);
            dataGridView3.TabIndex = 3;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // clA
            // 
            clA.HeaderText = "Mã PN";
            clA.MinimumWidth = 6;
            clA.Name = "clA";
            // 
            // cl2
            // 
            cl2.HeaderText = "Ngày tạo";
            cl2.MinimumWidth = 6;
            cl2.Name = "cl2";
            // 
            // Column1
            // 
            Column1.HeaderText = "Người tạo";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tổng tiền";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(6, 3);
            label7.Name = "label7";
            label7.Size = new Size(213, 32);
            label7.TabIndex = 4;
            label7.Text = "Lịch sử nhập kho:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
<<<<<<< Updated upstream
            tabPage2.Controls.Add(dataGridView4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(984, 677);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kho hàng";
            tabPage2.UseVisualStyleBackColor = true;
=======
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1684, 953);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kho hàng";
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.Location = new Point(881, 84);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.Size = new Size(800, 866);
            dgvInventory.TabIndex = 3;
            dgvInventory.CellClick += dgvInventory_CellClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtFind2);
            panel4.Controls.Add(label13);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(881, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 81);
            panel4.TabIndex = 2;
            // 
            // txtFind2
            // 
            txtFind2.Location = new Point(162, 36);
            txtFind2.Name = "txtFind2";
            txtFind2.Size = new Size(581, 30);
            txtFind2.TabIndex = 11;
            txtFind2.TextChanged += txtFind2_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 39);
            label13.Name = "label13";
            label13.Size = new Size(144, 23);
            label13.TabIndex = 8;
            label13.Text = "Tìm nguyên liệu:";
>>>>>>> Stashed changes
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label12);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
<<<<<<< Updated upstream
            panel2.Size = new Size(978, 178);
=======
            panel2.Size = new Size(878, 947);
>>>>>>> Stashed changes
            panel2.TabIndex = 1;
            // 
            // button3
            // 
<<<<<<< Updated upstream
            button3.Location = new Point(743, 16);
            button3.Name = "button3";
            button3.Size = new Size(87, 39);
            button3.TabIndex = 14;
            button3.Text = "In báo cáo";
            button3.UseVisualStyleBackColor = true;
=======
            groupBox2.Controls.Add(dtpFindStockByDate);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(dgvStockHistory);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 321);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(878, 626);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lịch sử nhập kho";
>>>>>>> Stashed changes
            // 
            // dateTimePicker1
            // 
<<<<<<< Updated upstream
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(468, 47);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 30);
            dateTimePicker1.TabIndex = 13;
=======
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
            dgvStockHistory.Size = new Size(872, 542);
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
            groupBox1.Size = new Size(878, 321);
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
>>>>>>> Stashed changes
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(341, 53);
            label8.Name = "label8";
            label8.Size = new Size(122, 23);
            label8.TabIndex = 5;
            label8.Text = "Ngày hết hạn:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 84);
            label9.Name = "label9";
            label9.Size = new Size(68, 23);
            label9.TabIndex = 6;
            label9.Text = "Đơn vị:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(341, 22);
            label10.Name = "label10";
            label10.Size = new Size(124, 23);
            label10.TabIndex = 7;
            label10.Text = "Nhà cung cấp:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(152, 135);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(319, 30);
            textBox7.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(13, 141);
            label13.Name = "label13";
            label13.Size = new Size(144, 23);
            label13.TabIndex = 8;
            label13.Text = "Tìm nguyên liệu:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(92, 78);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(226, 30);
            textBox8.TabIndex = 11;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(468, 16);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(250, 30);
            textBox9.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(92, 47);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(226, 30);
            textBox4.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 53);
            label11.Name = "label11";
            label11.Size = new Size(69, 23);
            label11.TabIndex = 8;
            label11.Text = "Tên NL:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(92, 16);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(226, 30);
            textBox6.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(13, 22);
            label12.Name = "label12";
            label12.Size = new Size(67, 23);
            label12.TabIndex = 9;
            label12.Text = "Mã NL:";
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Dock = DockStyle.Fill;
            dataGridView4.Location = new Point(3, 3);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(978, 671);
            dataGridView4.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(230, 181, 56);
            button4.Location = new Point(160, 117);
            button4.Name = "button4";
            button4.Size = new Size(145, 53);
            button4.TabIndex = 33;
            button4.Text = "Sửa";
            button4.UseVisualStyleBackColor = false;
            // 
            // frmInventory
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(992, 710);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "frmInventory";
            Text = "frmInventory";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private DataGridView dataGridView2;
        private TabPage tabPage4;
        private Label label6;
        private DataGridView dataGridView3;
        private Label label7;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView4;
        private Panel panel2;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox7;
        private Label label13;
        private TextBox textBox4;
        private Label label11;
        private TextBox textBox6;
        private Label label12;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox8;
        private TextBox textBox9;
        private DataGridView dataGridView1;
        private Panel panel3;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox2;
        private TextBox textBox5;
        private Button button12;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Label label14;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox3;
        private Label label26;
        private DataGridViewTextBoxColumn clA;
        private DataGridViewTextBoxColumn cl2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button button3;
        private TextBox textBox10;
        private Button button4;
    }
}