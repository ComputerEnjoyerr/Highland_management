namespace GUI
{
    partial class frmBillDetail
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
            lbTongtien = new Label();
            lbNhanVien = new Label();
            lbKhachHang = new Label();
            lbThoiGian = new Label();
            lbMaHoaDon = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            lbGiamGia = new Label();
            lbTongGia = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(lbTongtien);
            panel1.Controls.Add(lbNhanVien);
            panel1.Controls.Add(lbKhachHang);
            panel1.Controls.Add(lbThoiGian);
            panel1.Controls.Add(lbMaHoaDon);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 217);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lbTongtien
            // 
            lbTongtien.AutoSize = true;
            lbTongtien.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            lbTongtien.ForeColor = Color.Red;
            lbTongtien.Location = new Point(180, 182);
            lbTongtien.Name = "lbTongtien";
            lbTongtien.Size = new Size(0, 31);
            lbTongtien.TabIndex = 10;
            // 
            // lbNhanVien
            // 
            lbNhanVien.AutoSize = true;
            lbNhanVien.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            lbNhanVien.Location = new Point(180, 151);
            lbNhanVien.Name = "lbNhanVien";
            lbNhanVien.Size = new Size(0, 31);
            lbNhanVien.TabIndex = 9;
            // 
            // lbKhachHang
            // 
            lbKhachHang.AutoSize = true;
            lbKhachHang.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            lbKhachHang.Location = new Point(180, 116);
            lbKhachHang.Name = "lbKhachHang";
            lbKhachHang.Size = new Size(0, 31);
            lbKhachHang.TabIndex = 8;
            // 
            // lbThoiGian
            // 
            lbThoiGian.AutoSize = true;
            lbThoiGian.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            lbThoiGian.Location = new Point(180, 82);
            lbThoiGian.Name = "lbThoiGian";
            lbThoiGian.Size = new Size(0, 31);
            lbThoiGian.TabIndex = 7;
            // 
            // lbMaHoaDon
            // 
            lbMaHoaDon.AutoSize = true;
            lbMaHoaDon.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            lbMaHoaDon.Location = new Point(180, 51);
            lbMaHoaDon.Name = "lbMaHoaDon";
            lbMaHoaDon.Size = new Size(0, 31);
            lbMaHoaDon.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(32, 182);
            label6.Name = "label6";
            label6.Size = new Size(124, 31);
            label6.TabIndex = 5;
            label6.Text = "Tổng tiền: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(32, 151);
            label5.Name = "label5";
            label5.Size = new Size(133, 31);
            label5.TabIndex = 4;
            label5.Text = "Nhân viên: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(32, 116);
            label4.Name = "label4";
            label4.Size = new Size(147, 31);
            label4.TabIndex = 3;
            label4.Text = "Khách hàng: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(32, 82);
            label3.Name = "label3";
            label3.Size = new Size(118, 31);
            label3.TabIndex = 2;
            label3.Text = "Thời gian:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(32, 51);
            label2.Name = "label2";
            label2.Size = new Size(142, 31);
            label2.TabIndex = 1;
            label2.Text = "Mã hóa đơn:";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(914, 43);
            label1.TabIndex = 0;
            label1.Text = "CHI TIẾT HÓA ĐƠN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 217);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(914, 178);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(808, 509);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Đóng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(617, 455);
            label7.Name = "label7";
            label7.Size = new Size(121, 31);
            label7.TabIndex = 6;
            label7.Text = "Giảm giá: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(617, 420);
            label8.Name = "label8";
            label8.Size = new Size(111, 31);
            label8.TabIndex = 5;
            label8.Text = "Tổng giá:";
            // 
            // lbGiamGia
            // 
            lbGiamGia.AutoSize = true;
            lbGiamGia.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            lbGiamGia.ForeColor = Color.YellowGreen;
            lbGiamGia.Location = new Point(747, 455);
            lbGiamGia.Name = "lbGiamGia";
            lbGiamGia.Size = new Size(0, 31);
            lbGiamGia.TabIndex = 8;
            // 
            // lbTongGia
            // 
            lbTongGia.AutoSize = true;
            lbTongGia.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            lbTongGia.ForeColor = Color.Red;
            lbTongGia.Location = new Point(747, 420);
            lbTongGia.Name = "lbTongGia";
            lbTongGia.Size = new Size(0, 31);
            lbTongGia.TabIndex = 7;
            // 
            // frmBillDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 60, 60);
            ClientSize = new Size(914, 550);
            Controls.Add(lbGiamGia);
            Controls.Add(lbTongGia);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "frmBillDetail";
            Text = "frmBillDetail";
            Load += frmBillDetail_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label lbTongtien;
        private Label lbNhanVien;
        private Label lbKhachHang;
        private Label lbThoiGian;
        private Label lbMaHoaDon;
        private Label label6;
        private Label label5;
        private Button button1;
        private Label label7;
        private Label label8;
        private Label lbGiamGia;
        private Label lbTongGia;
    }
}