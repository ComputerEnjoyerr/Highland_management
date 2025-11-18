namespace GUI
{
    partial class frmIngredientDetail
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
            panel2 = new Panel();
            lbTongTien = new Label();
            lbDonGia = new Label();
            lbTongNhap = new Label();
            lbTen = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 228);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbTongTien);
            panel2.Controls.Add(lbDonGia);
            panel2.Controls.Add(lbTongNhap);
            panel2.Controls.Add(lbTen);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 228);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            lbTongTien.ForeColor = Color.Red;
            lbTongTien.Location = new Point(249, 158);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(0, 31);
            lbTongTien.TabIndex = 8;
            // 
            // lbDonGia
            // 
            lbDonGia.AutoSize = true;
            lbDonGia.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            lbDonGia.Location = new Point(249, 125);
            lbDonGia.Name = "lbDonGia";
            lbDonGia.Size = new Size(0, 31);
            lbDonGia.TabIndex = 7;
            // 
            // lbTongNhap
            // 
            lbTongNhap.AutoSize = true;
            lbTongNhap.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            lbTongNhap.Location = new Point(249, 93);
            lbTongNhap.Name = "lbTongNhap";
            lbTongNhap.Size = new Size(0, 31);
            lbTongNhap.TabIndex = 6;
            // 
            // lbTen
            // 
            lbTen.AutoSize = true;
            lbTen.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            lbTen.Location = new Point(249, 61);
            lbTen.Name = "lbTen";
            lbTen.Size = new Size(0, 31);
            lbTen.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(37, 158);
            label5.Name = "label5";
            label5.Size = new Size(118, 31);
            label5.TabIndex = 4;
            label5.Text = "Tổng tiền:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(37, 125);
            label4.Name = "label4";
            label4.Size = new Size(102, 31);
            label4.TabIndex = 3;
            label4.Text = "Đơn giá:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(37, 93);
            label3.Name = "label3";
            label3.Size = new Size(130, 31);
            label3.TabIndex = 2;
            label3.Text = "Tổng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(37, 62);
            label2.Name = "label2";
            label2.Size = new Size(185, 31);
            label2.TabIndex = 1;
            label2.Text = "Tên nguyên liệu:";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(914, 46);
            label1.TabIndex = 0;
            label1.Text = "CHI TIẾT NHẬP NGUYÊN LIỆU";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 228);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(914, 198);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(810, 516);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Đóng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.Location = new Point(0, 426);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(914, 87);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // frmIngredientDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 60, 60);
            ClientSize = new Size(914, 550);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "frmIngredientDetail";
            Text = "frmIngredientDetail";
            Load += frmIngredientDetail_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbTongTien;
        private Label lbDonGia;
        private Label lbTongNhap;
        private Label lbTen;
        private Button button1;
        private RichTextBox richTextBox1;
    }
}