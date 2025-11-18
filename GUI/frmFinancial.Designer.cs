namespace GUI
{
    partial class frmFinancial
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
            panel2 = new Panel();
            panel10 = new Panel();
            button2 = new Button();
            btnFill = new Button();
            button1 = new Button();
            btnClear = new Button();
            cbYear = new ComboBox();
            label10 = new Label();
            cbMonth = new ComboBox();
            label9 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            btnSuaChiPhi = new Button();
            btnLuuChiPhi = new Button();
            picChart = new PictureBox();
            panel11 = new Panel();
            txtLoiNhuan = new RichTextBox();
            label7 = new Label();
            panel9 = new Panel();
            txtChiPhiKhac = new RichTextBox();
            label6 = new Label();
            panel8 = new Panel();
            txtDienNuoc = new RichTextBox();
            label5 = new Label();
            panel7 = new Panel();
            txtMatBang = new RichTextBox();
            label4 = new Label();
            panel6 = new Panel();
            txtTienNguyenLieu = new RichTextBox();
            label3 = new Label();
            panel5 = new Panel();
            txtLuongNV = new RichTextBox();
            label2 = new Label();
            panel4 = new Panel();
            txtDoanhThu = new RichTextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            tabPage3 = new TabPage();
            dataGridView3 = new DataGridView();
            panel2.SuspendLayout();
            panel10.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChart).BeginInit();
            panel11.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(74, 60, 60);
            panel2.Controls.Add(panel10);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1214, 63);
            panel2.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(249, 245, 238);
            panel10.Controls.Add(button2);
            panel10.Controls.Add(btnFill);
            panel10.Controls.Add(button1);
            panel10.Controls.Add(btnClear);
            panel10.Controls.Add(cbYear);
            panel10.Controls.Add(label10);
            panel10.Controls.Add(cbMonth);
            panel10.Controls.Add(label9);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(1214, 63);
            panel10.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(977, 5);
            button2.Name = "button2";
            button2.Size = new Size(115, 40);
            button2.TabIndex = 5;
            button2.Text = "In báo cáo";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnFill
            // 
            btnFill.Location = new Point(650, 4);
            btnFill.Name = "btnFill";
            btnFill.Size = new Size(84, 40);
            btnFill.TabIndex = 2;
            btnFill.Text = "Lọc";
            btnFill.UseVisualStyleBackColor = true;
            btnFill.Click += btnFill_Click;
            // 
            // button1
            // 
            button1.Location = new Point(840, 5);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 4;
            button1.Text = "Xuất Excel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(740, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 40);
            btnClear.TabIndex = 2;
            btnClear.Text = "Hoàn tác";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cbYear
            // 
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(408, 10);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(219, 31);
            cbYear.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(329, 13);
            label10.Name = "label10";
            label10.Size = new Size(53, 23);
            label10.TabIndex = 0;
            label10.Text = "Năm:";
            // 
            // cbMonth
            // 
            cbMonth.FormattingEnabled = true;
            cbMonth.Location = new Point(93, 10);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(219, 31);
            cbMonth.TabIndex = 1;
            cbMonth.SelectedIndexChanged += cbMonth_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 13);
            label9.Name = "label9";
            label9.Size = new Size(65, 23);
            label9.TabIndex = 0;
            label9.Text = "Tháng:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 60, 60);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1214, 996);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(249, 245, 238);
            panel3.Controls.Add(btnSuaChiPhi);
            panel3.Controls.Add(btnLuuChiPhi);
            panel3.Controls.Add(picChart);
            panel3.Controls.Add(panel11);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(1214, 497);
            panel3.TabIndex = 4;
            // 
            // btnSuaChiPhi
            // 
            btnSuaChiPhi.Location = new Point(299, 440);
            btnSuaChiPhi.Name = "btnSuaChiPhi";
            btnSuaChiPhi.Size = new Size(131, 40);
            btnSuaChiPhi.TabIndex = 7;
            btnSuaChiPhi.Text = "Sửa";
            btnSuaChiPhi.UseVisualStyleBackColor = true;
            btnSuaChiPhi.Click += btnSuaChiPhi_Click;
            // 
            // btnLuuChiPhi
            // 
            btnLuuChiPhi.Location = new Point(145, 440);
            btnLuuChiPhi.Name = "btnLuuChiPhi";
            btnLuuChiPhi.Size = new Size(131, 40);
            btnLuuChiPhi.TabIndex = 6;
            btnLuuChiPhi.Text = "Lưu";
            btnLuuChiPhi.UseVisualStyleBackColor = true;
            btnLuuChiPhi.Click += btnLuuChiPhi_Click;
            // 
            // picChart
            // 
            picChart.BorderStyle = BorderStyle.FixedSingle;
            picChart.Location = new Point(777, 23);
            picChart.Name = "picChart";
            picChart.Size = new Size(500, 500);
            picChart.TabIndex = 5;
            picChart.TabStop = false;
            picChart.Click += picChart_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(76, 175, 80);
            panel11.Controls.Add(txtLoiNhuan);
            panel11.Controls.Add(label7);
            panel11.Location = new Point(50, 289);
            panel11.Name = "panel11";
            panel11.Size = new Size(684, 145);
            panel11.TabIndex = 4;
            // 
            // txtLoiNhuan
            // 
            txtLoiNhuan.BackColor = Color.FromArgb(76, 175, 80);
            txtLoiNhuan.Dock = DockStyle.Fill;
            txtLoiNhuan.Enabled = false;
            txtLoiNhuan.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txtLoiNhuan.Location = new Point(0, 41);
            txtLoiNhuan.Name = "txtLoiNhuan";
            txtLoiNhuan.Size = new Size(684, 104);
            txtLoiNhuan.TabIndex = 2;
            txtLoiNhuan.Text = "";
            // 
            // label7
            // 
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(684, 41);
            label7.TabIndex = 1;
            label7.Text = "Lợi nhuận";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(158, 158, 158);
            panel9.Controls.Add(txtChiPhiKhac);
            panel9.Controls.Add(label6);
            panel9.Location = new Point(514, 156);
            panel9.Name = "panel9";
            panel9.Size = new Size(226, 127);
            panel9.TabIndex = 3;
            // 
            // txtChiPhiKhac
            // 
            txtChiPhiKhac.BackColor = Color.FromArgb(158, 158, 158);
            txtChiPhiKhac.Dock = DockStyle.Fill;
            txtChiPhiKhac.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txtChiPhiKhac.Location = new Point(0, 41);
            txtChiPhiKhac.Name = "txtChiPhiKhac";
            txtChiPhiKhac.Size = new Size(226, 86);
            txtChiPhiKhac.TabIndex = 2;
            txtChiPhiKhac.Text = "";
            // 
            // label6
            // 
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(226, 41);
            label6.TabIndex = 1;
            label6.Text = "Chi phí khác";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(33, 150, 243);
            panel8.Controls.Add(txtDienNuoc);
            panel8.Controls.Add(label5);
            panel8.Location = new Point(282, 156);
            panel8.Name = "panel8";
            panel8.Size = new Size(226, 127);
            panel8.TabIndex = 1;
            // 
            // txtDienNuoc
            // 
            txtDienNuoc.BackColor = Color.FromArgb(33, 150, 243);
            txtDienNuoc.Dock = DockStyle.Fill;
            txtDienNuoc.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txtDienNuoc.Location = new Point(0, 41);
            txtDienNuoc.Name = "txtDienNuoc";
            txtDienNuoc.Size = new Size(226, 86);
            txtDienNuoc.TabIndex = 2;
            txtDienNuoc.Text = "";
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(226, 41);
            label5.TabIndex = 1;
            label5.Text = "Điện nước";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(233, 30, 99);
            panel7.Controls.Add(txtMatBang);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(50, 156);
            panel7.Name = "panel7";
            panel7.Size = new Size(226, 127);
            panel7.TabIndex = 2;
            // 
            // txtMatBang
            // 
            txtMatBang.BackColor = Color.FromArgb(255, 128, 128);
            txtMatBang.Dock = DockStyle.Fill;
            txtMatBang.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txtMatBang.Location = new Point(0, 41);
            txtMatBang.Name = "txtMatBang";
            txtMatBang.Size = new Size(226, 86);
            txtMatBang.TabIndex = 2;
            txtMatBang.Text = "";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(255, 128, 128);
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(226, 41);
            label4.TabIndex = 1;
            label4.Text = "Mặt bằng";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 152, 0);
            panel6.Controls.Add(txtTienNguyenLieu);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(514, 23);
            panel6.Name = "panel6";
            panel6.Size = new Size(226, 127);
            panel6.TabIndex = 1;
            // 
            // txtTienNguyenLieu
            // 
            txtTienNguyenLieu.BackColor = Color.FromArgb(255, 152, 0);
            txtTienNguyenLieu.Dock = DockStyle.Fill;
            txtTienNguyenLieu.Enabled = false;
            txtTienNguyenLieu.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txtTienNguyenLieu.Location = new Point(0, 41);
            txtTienNguyenLieu.Name = "txtTienNguyenLieu";
            txtTienNguyenLieu.Size = new Size(226, 86);
            txtTienNguyenLieu.TabIndex = 2;
            txtTienNguyenLieu.Text = "";
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(226, 41);
            label3.TabIndex = 1;
            label3.Text = "Tiền nguyên liệu";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(244, 67, 54);
            panel5.Controls.Add(txtLuongNV);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(282, 23);
            panel5.Name = "panel5";
            panel5.Size = new Size(226, 127);
            panel5.TabIndex = 1;
            // 
            // txtLuongNV
            // 
            txtLuongNV.BackColor = Color.FromArgb(244, 67, 54);
            txtLuongNV.Dock = DockStyle.Fill;
            txtLuongNV.Enabled = false;
            txtLuongNV.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txtLuongNV.Location = new Point(0, 41);
            txtLuongNV.Name = "txtLuongNV";
            txtLuongNV.Size = new Size(226, 86);
            txtLuongNV.TabIndex = 2;
            txtLuongNV.Text = "";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(226, 41);
            label2.TabIndex = 1;
            label2.Text = "Lương nhân viên";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 193, 7);
            panel4.Controls.Add(txtDoanhThu);
            panel4.Controls.Add(richTextBox1);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(50, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(226, 127);
            panel4.TabIndex = 0;
            // 
            // txtDoanhThu
            // 
            txtDoanhThu.BackColor = Color.FromArgb(255, 193, 7);
            txtDoanhThu.Dock = DockStyle.Fill;
            txtDoanhThu.Enabled = false;
            txtDoanhThu.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txtDoanhThu.Location = new Point(0, 41);
            txtDoanhThu.Name = "txtDoanhThu";
            txtDoanhThu.Size = new Size(226, 86);
            txtDoanhThu.TabIndex = 2;
            txtDoanhThu.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 41);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(226, 86);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(226, 41);
            label1.TabIndex = 0;
            label1.Text = "Doanh thu";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 560);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1214, 436);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1206, 400);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hóa đơn";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1200, 394);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1206, 403);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Nguyên liệu";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1200, 397);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1206, 403);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Nhân viên";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(3, 3);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(1200, 397);
            dataGridView3.TabIndex = 0;
            // 
            // frmFinancial
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(249, 245, 238);
            ClientSize = new Size(1214, 996);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "frmFinancial";
            Text = "frmDoanhThu";
            Load += frmFinancial_Load;
            panel2.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picChart).EndInit();
            panel11.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private Panel panel10;
        private Button btnFill;
        private Button btnClear;
        private ComboBox cbYear;
        private Label label10;
        private ComboBox cbMonth;
        private Label label9;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button2;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Panel panel3;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel11;
        private Label label1;
        private RichTextBox txtLoiNhuan;
        private Label label7;
        private RichTextBox txtChiPhiKhac;
        private Label label6;
        private RichTextBox txtDienNuoc;
        private Label label5;
        private RichTextBox txtMatBang;
        private Label label4;
        private RichTextBox txtTienNguyenLieu;
        private Label label3;
        private RichTextBox txtLuongNV;
        private Label label2;
        private RichTextBox txtDoanhThu;
        private RichTextBox richTextBox1;
        private PictureBox picChart;
        private Button btnSuaChiPhi;
        private Button btnLuuChiPhi;
    }
}