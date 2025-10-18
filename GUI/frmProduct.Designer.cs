namespace GUI
{
    partial class frmProduct
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
            dgvProduct = new DataGridView();
            groupBox3 = new GroupBox();
            txtFindProduct = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            btnUpdate = new Button();
            button3 = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnChooseImage = new Button();
            pbImage = new PictureBox();
            cboCategory = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtPrice = new TextBox();
            label13 = new Label();
            txtProductName1 = new TextBox();
            label2 = new Label();
            txtProductId1 = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel4 = new Panel();
            panel5 = new Panel();
            dataGridView3 = new DataGridView();
            groupBox4 = new GroupBox();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            textBox7 = new TextBox();
            label10 = new Label();
            comboBox3 = new ComboBox();
            label12 = new Label();
            label6 = new Label();
            textBox6 = new TextBox();
            textBox8 = new TextBox();
            label8 = new Label();
            panel3 = new Panel();
            dataGridView4 = new DataGridView();
            groupBox5 = new GroupBox();
            textBox9 = new TextBox();
            label11 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBox4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            groupBox5.SuspendLayout();
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
            tabPage1.Controls.Add(dgvProduct);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(984, 680);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sản phẩm";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvProduct
            // 
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.Location = new Point(483, 64);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(498, 613);
            dgvProduct.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtFindProduct);
            groupBox3.Controls.Add(label5);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(483, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(498, 61);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sản phẩm";
            // 
            // txtFindProduct
            // 
            txtFindProduct.Location = new Point(113, 24);
            txtFindProduct.Name = "txtFindProduct";
            txtFindProduct.Size = new Size(379, 25);
            txtFindProduct.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 27);
            label5.Name = "label5";
            label5.Size = new Size(75, 19);
            label5.TabIndex = 4;
            label5.Text = "Tìm kiếm:";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 674);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 350);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(480, 324);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nguyên liệu";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(474, 300);
            dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnChooseImage);
            groupBox1.Controls.Add(pbImage);
            groupBox1.Controls.Add(cboCategory);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtProductName1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtProductId1);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 350);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản phẩm";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(230, 181, 56);
            btnUpdate.Location = new Point(242, 296);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 48);
            btnUpdate.TabIndex = 34;
            btnUpdate.Text = "Lưu";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(359, 296);
            button3.Name = "button3";
            button3.Size = new Size(115, 48);
            button3.TabIndex = 36;
            button3.Text = "Hoàn tác";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(104, 176, 145);
            btnAdd.Location = new Point(8, 296);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 48);
            btnAdd.TabIndex = 35;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(169, 65, 65);
            btnDelete.Location = new Point(125, 296);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 48);
            btnDelete.TabIndex = 37;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Location = new Point(262, 160);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(102, 42);
            btnChooseImage.TabIndex = 9;
            btnChooseImage.Text = "Chọn ảnh";
            btnChooseImage.UseVisualStyleBackColor = true;
            // 
            // pbImage
            // 
            pbImage.BackColor = Color.Gray;
            pbImage.Location = new Point(101, 160);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(146, 126);
            pbImage.TabIndex = 8;
            pbImage.TabStop = false;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(101, 98);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(342, 25);
            cboCategory.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 160);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 4;
            label4.Text = "Hình ảnh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(41, 19);
            label3.TabIndex = 4;
            label3.Text = "Loại:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(101, 129);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(342, 25);
            txtPrice.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 132);
            label13.Name = "label13";
            label13.Size = new Size(64, 19);
            label13.TabIndex = 4;
            label13.Text = "Giá bán:";
            // 
            // txtProductName1
            // 
            txtProductName1.Location = new Point(101, 67);
            txtProductName1.Name = "txtProductName1";
            txtProductName1.Size = new Size(342, 25);
            txtProductName1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 4;
            label2.Text = "Tên SP:";
            // 
            // txtProductId1
            // 
            txtProductId1.Location = new Point(101, 36);
            txtProductId1.Name = "txtProductId1";
            txtProductId1.Size = new Size(342, 25);
            txtProductId1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(55, 19);
            label1.TabIndex = 4;
            label1.Text = "Mã SP:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(984, 682);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Quản lý công thức";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(978, 676);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridView3);
            panel5.Controls.Add(groupBox4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(454, 676);
            panel5.TabIndex = 1;
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(5, 357);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(443, 314);
            dataGridView3.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button6);
            groupBox4.Controls.Add(button7);
            groupBox4.Controls.Add(button8);
            groupBox4.Controls.Add(button9);
            groupBox4.Controls.Add(textBox4);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(textBox5);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(textBox7);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(comboBox3);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(textBox6);
            groupBox4.Controls.Add(textBox8);
            groupBox4.Controls.Add(label8);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(454, 351);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Công thức";
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(230, 181, 56);
            button6.Location = new Point(14, 278);
            button6.Name = "button6";
            button6.Size = new Size(165, 53);
            button6.TabIndex = 72;
            button6.Text = "Lưu";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Location = new Point(185, 278);
            button7.Name = "button7";
            button7.Size = new Size(165, 53);
            button7.TabIndex = 74;
            button7.Text = "Hoàn tác";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(104, 176, 145);
            button8.Location = new Point(14, 219);
            button8.Name = "button8";
            button8.Size = new Size(165, 53);
            button8.TabIndex = 73;
            button8.Text = "Thêm";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(169, 65, 65);
            button9.Location = new Point(185, 219);
            button9.Name = "button9";
            button9.Size = new Size(165, 53);
            button9.TabIndex = 75;
            button9.Text = "Xóa";
            button9.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(154, 85);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(279, 25);
            textBox4.TabIndex = 69;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 89);
            label7.Name = "label7";
            label7.Size = new Size(115, 19);
            label7.TabIndex = 66;
            label7.Text = "Mã nguyên liệu:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(154, 55);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(279, 25);
            textBox5.TabIndex = 70;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 58);
            label9.Name = "label9";
            label9.Size = new Size(104, 19);
            label9.TabIndex = 67;
            label9.Text = "Tên sản phẩm:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(154, 24);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(279, 25);
            textBox7.TabIndex = 71;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 27);
            label10.Name = "label10";
            label10.Size = new Size(102, 19);
            label10.TabIndex = 68;
            label10.Text = "Mã sản phẩm:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(154, 179);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(279, 25);
            comboBox3.TabIndex = 65;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 185);
            label12.Name = "label12";
            label12.Size = new Size(85, 19);
            label12.TabIndex = 60;
            label12.Text = "Đơn vị tính:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 151);
            label6.Name = "label6";
            label6.Size = new Size(73, 19);
            label6.TabIndex = 61;
            label6.Text = "Số lượng:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(154, 148);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(279, 25);
            textBox6.TabIndex = 63;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(154, 116);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(279, 25);
            textBox8.TabIndex = 64;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 119);
            label8.Name = "label8";
            label8.Size = new Size(117, 19);
            label8.TabIndex = 62;
            label8.Text = "Tên nguyên liệu:";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView4);
            panel3.Controls.Add(groupBox5);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(454, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(524, 676);
            panel3.TabIndex = 0;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Dock = DockStyle.Fill;
            dataGridView4.Location = new Point(0, 68);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(524, 608);
            dataGridView4.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox9);
            groupBox5.Controls.Add(label11);
            groupBox5.Dock = DockStyle.Top;
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(524, 68);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Nguyên liệu";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(110, 27);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(408, 25);
            textBox9.TabIndex = 69;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 31);
            label11.Name = "label11";
            label11.Size = new Size(75, 19);
            label11.TabIndex = 66;
            label11.Text = "Tìm kiếm:";
            // 
            // frmProduct
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(992, 710);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "frmProduct";
            Text = "frmRecipe";
            Load += frmProduct_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            tabPage2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button btnChooseImage;
        private PictureBox pbImage;
        private ComboBox cboCategory;
        private Label label4;
        private Label label3;
        private TextBox txtProductName1;
        private Label label2;
        private TextBox txtProductId1;
        private Label label1;
        private Button btnUpdate;
        private Button button3;
        private Button btnAdd;
        private Button btnDelete;
        private TextBox txtFindProduct;
        private Label label5;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel3;
        private DataGridView dataGridView3;
        private GroupBox groupBox4;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox7;
        private Label label10;
        private ComboBox comboBox3;
        private Label label12;
        private Label label6;
        private TextBox textBox6;
        private TextBox textBox8;
        private Label label8;
        private DataGridView dataGridView4;
        private GroupBox groupBox5;
        private TextBox textBox9;
        private Label label11;
        private DataGridView dgvProduct;
        private TextBox txtPrice;
        private Label label13;
    }
}