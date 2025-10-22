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
            tcMain = new TabControl();
            tpProduct = new TabPage();
            dgvProduct = new DataGridView();
            groupBox3 = new GroupBox();
            txtFindProduct = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            dgvRecipe1 = new DataGridView();
            groupBox1 = new GroupBox();
            btnUpdate = new Button();
            btnClear = new Button();
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
            tpRecipe = new TabPage();
            panel4 = new Panel();
            panel5 = new Panel();
            dgvRecipe2 = new DataGridView();
            groupBox4 = new GroupBox();
            cboProductName = new ComboBox();
            btnUpdateRecipe = new Button();
            btnClearRecipe = new Button();
            btnAddRecipe = new Button();
            btnDeleteRecipe = new Button();
            txtIngredientId = new TextBox();
            label7 = new Label();
            label9 = new Label();
            txtRecipeId = new TextBox();
            label14 = new Label();
            txtProductId2 = new TextBox();
            label10 = new Label();
            cboIngredientUnit = new ComboBox();
            label12 = new Label();
            label6 = new Label();
            txtIngredientQty = new TextBox();
            txtIngredientName = new TextBox();
            label8 = new Label();
            panel3 = new Panel();
            dgvIngredient = new DataGridView();
            groupBox5 = new GroupBox();
            txtFindIngredient = new TextBox();
            label11 = new Label();
            tcMain.SuspendLayout();
            tpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecipe1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            tpRecipe.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecipe2).BeginInit();
            groupBox4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngredient).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // tcMain
            // 
            tcMain.Controls.Add(tpProduct);
            tcMain.Controls.Add(tpRecipe);
            tcMain.Dock = DockStyle.Fill;
            tcMain.Location = new Point(0, 0);
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new Size(992, 710);
            tcMain.TabIndex = 0;
            // 
            // tpProduct
            // 
            tpProduct.Controls.Add(dgvProduct);
            tpProduct.Controls.Add(groupBox3);
            tpProduct.Controls.Add(panel1);
            tpProduct.Location = new Point(4, 26);
            tpProduct.Name = "tpProduct";
            tpProduct.Padding = new Padding(3);
            tpProduct.Size = new Size(984, 680);
            tpProduct.TabIndex = 0;
            tpProduct.Text = "Sản phẩm";
            tpProduct.UseVisualStyleBackColor = true;
            // 
            // dgvProduct
            // 
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.Location = new Point(502, 64);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(479, 613);
            dgvProduct.TabIndex = 4;
            dgvProduct.CellClick += dgvProduct_CellClick;
            dgvProduct.CellDoubleClick += dgvProduct_CellDoubleClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtFindProduct);
            groupBox3.Controls.Add(label5);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(502, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(479, 61);
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
            txtFindProduct.TextChanged += txtFindProduct_TextChanged;
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
            panel1.Size = new Size(499, 674);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvRecipe1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 350);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(499, 324);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết Công thức";
            // 
            // dgvRecipe1
            // 
            dgvRecipe1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecipe1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipe1.Dock = DockStyle.Fill;
            dgvRecipe1.Location = new Point(3, 21);
            dgvRecipe1.Name = "dgvRecipe1";
            dgvRecipe1.RowHeadersWidth = 51;
            dgvRecipe1.Size = new Size(493, 300);
            dgvRecipe1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnClear);
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
            groupBox1.Size = new Size(499, 350);
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
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Location = new Point(359, 296);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(115, 48);
            btnClear.TabIndex = 36;
            btnClear.Text = "Hoàn tác";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnRefresh_Click;
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
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Location = new Point(253, 164);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(102, 42);
            btnChooseImage.TabIndex = 9;
            btnChooseImage.Text = "Chọn ảnh";
            btnChooseImage.UseVisualStyleBackColor = true;
            // 
            // pbImage
            // 
            pbImage.BackColor = Color.Gray;
            pbImage.Location = new Point(101, 164);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(146, 126);
            pbImage.TabIndex = 8;
            pbImage.TabStop = false;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(101, 94);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(342, 25);
            cboCategory.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 4;
            label4.Text = "Hình ảnh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
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
            txtProductName1.Location = new Point(101, 61);
            txtProductName1.Name = "txtProductName1";
            txtProductName1.Size = new Size(342, 25);
            txtProductName1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 4;
            label2.Text = "Tên SP:";
            // 
            // txtProductId1
            // 
            txtProductId1.Location = new Point(101, 28);
            txtProductId1.Name = "txtProductId1";
            txtProductId1.ReadOnly = true;
            txtProductId1.Size = new Size(342, 25);
            txtProductId1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(55, 19);
            label1.TabIndex = 4;
            label1.Text = "Mã SP:";
            // 
            // tpRecipe
            // 
            tpRecipe.Controls.Add(panel4);
            tpRecipe.Location = new Point(4, 26);
            tpRecipe.Name = "tpRecipe";
            tpRecipe.Padding = new Padding(3);
            tpRecipe.Size = new Size(984, 680);
            tpRecipe.TabIndex = 1;
            tpRecipe.Text = "Quản lý công thức";
            tpRecipe.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(978, 674);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(dgvRecipe2);
            panel5.Controls.Add(groupBox4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(348, 674);
            panel5.TabIndex = 1;
            // 
            // dgvRecipe2
            // 
            dgvRecipe2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRecipe2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecipe2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipe2.Location = new Point(5, 421);
            dgvRecipe2.Name = "dgvRecipe2";
            dgvRecipe2.RowHeadersWidth = 51;
            dgvRecipe2.Size = new Size(337, 248);
            dgvRecipe2.TabIndex = 1;
            dgvRecipe2.CellClick += dgvRecipe2_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cboProductName);
            groupBox4.Controls.Add(btnUpdateRecipe);
            groupBox4.Controls.Add(btnClearRecipe);
            groupBox4.Controls.Add(btnAddRecipe);
            groupBox4.Controls.Add(btnDeleteRecipe);
            groupBox4.Controls.Add(txtIngredientId);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(txtRecipeId);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(txtProductId2);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(cboIngredientUnit);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(txtIngredientQty);
            groupBox4.Controls.Add(txtIngredientName);
            groupBox4.Controls.Add(label8);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(348, 415);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Công thức";
            // 
            // cboProductName
            // 
            cboProductName.FormattingEnabled = true;
            cboProductName.Location = new Point(154, 103);
            cboProductName.Name = "cboProductName";
            cboProductName.Size = new Size(279, 25);
            cboProductName.TabIndex = 76;
            cboProductName.SelectedIndexChanged += cboProductName_SelectedIndexChanged;
            // 
            // btnUpdateRecipe
            // 
            btnUpdateRecipe.BackColor = Color.FromArgb(230, 181, 56);
            btnUpdateRecipe.Location = new Point(6, 350);
            btnUpdateRecipe.Name = "btnUpdateRecipe";
            btnUpdateRecipe.Size = new Size(165, 53);
            btnUpdateRecipe.TabIndex = 72;
            btnUpdateRecipe.Text = "Lưu";
            btnUpdateRecipe.UseVisualStyleBackColor = false;
            btnUpdateRecipe.Click += btnUpdateRecipe_Click;
            // 
            // btnClearRecipe
            // 
            btnClearRecipe.BackColor = Color.White;
            btnClearRecipe.Location = new Point(177, 350);
            btnClearRecipe.Name = "btnClearRecipe";
            btnClearRecipe.Size = new Size(165, 53);
            btnClearRecipe.TabIndex = 74;
            btnClearRecipe.Text = "Hoàn tác";
            btnClearRecipe.UseVisualStyleBackColor = false;
            btnClearRecipe.Click += btnClearRecipe_Click;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.BackColor = Color.FromArgb(104, 176, 145);
            btnAddRecipe.Location = new Point(6, 291);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(165, 53);
            btnAddRecipe.TabIndex = 73;
            btnAddRecipe.Text = "Thêm";
            btnAddRecipe.UseVisualStyleBackColor = false;
            btnAddRecipe.Click += btnAddRecipe_Click;
            // 
            // btnDeleteRecipe
            // 
            btnDeleteRecipe.BackColor = Color.FromArgb(169, 65, 65);
            btnDeleteRecipe.Location = new Point(177, 291);
            btnDeleteRecipe.Name = "btnDeleteRecipe";
            btnDeleteRecipe.Size = new Size(165, 53);
            btnDeleteRecipe.TabIndex = 75;
            btnDeleteRecipe.Text = "Xóa";
            btnDeleteRecipe.UseVisualStyleBackColor = false;
            btnDeleteRecipe.Click += btnDeleteRecipe_Click;
            // 
            // txtIngredientId
            // 
            txtIngredientId.Location = new Point(154, 138);
            txtIngredientId.Name = "txtIngredientId";
            txtIngredientId.ReadOnly = true;
            txtIngredientId.Size = new Size(279, 25);
            txtIngredientId.TabIndex = 69;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 142);
            label7.Name = "label7";
            label7.Size = new Size(115, 19);
            label7.TabIndex = 66;
            label7.Text = "Mã nguyên liệu:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 108);
            label9.Name = "label9";
            label9.Size = new Size(104, 19);
            label9.TabIndex = 67;
            label9.Text = "Tên sản phẩm:";
            // 
            // txtRecipeId
            // 
            txtRecipeId.Location = new Point(154, 34);
            txtRecipeId.Name = "txtRecipeId";
            txtRecipeId.ReadOnly = true;
            txtRecipeId.Size = new Size(279, 25);
            txtRecipeId.TabIndex = 71;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(14, 37);
            label14.Name = "label14";
            label14.Size = new Size(104, 19);
            label14.TabIndex = 68;
            label14.Text = "Mã công thức:";
            // 
            // txtProductId2
            // 
            txtProductId2.Location = new Point(154, 69);
            txtProductId2.Name = "txtProductId2";
            txtProductId2.ReadOnly = true;
            txtProductId2.Size = new Size(279, 25);
            txtProductId2.TabIndex = 71;
            txtProductId2.TextChanged += txtProductId2_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 72);
            label10.Name = "label10";
            label10.Size = new Size(102, 19);
            label10.TabIndex = 68;
            label10.Text = "Mã sản phẩm:";
            // 
            // cboIngredientUnit
            // 
            cboIngredientUnit.FormattingEnabled = true;
            cboIngredientUnit.Location = new Point(154, 242);
            cboIngredientUnit.Name = "cboIngredientUnit";
            cboIngredientUnit.Size = new Size(279, 25);
            cboIngredientUnit.TabIndex = 65;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 248);
            label12.Name = "label12";
            label12.Size = new Size(85, 19);
            label12.TabIndex = 60;
            label12.Text = "Đơn vị tính:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 211);
            label6.Name = "label6";
            label6.Size = new Size(73, 19);
            label6.TabIndex = 61;
            label6.Text = "Số lượng:";
            // 
            // txtIngredientQty
            // 
            txtIngredientQty.Location = new Point(154, 208);
            txtIngredientQty.Name = "txtIngredientQty";
            txtIngredientQty.Size = new Size(279, 25);
            txtIngredientQty.TabIndex = 63;
            // 
            // txtIngredientName
            // 
            txtIngredientName.Location = new Point(154, 173);
            txtIngredientName.Name = "txtIngredientName";
            txtIngredientName.ReadOnly = true;
            txtIngredientName.Size = new Size(279, 25);
            txtIngredientName.TabIndex = 64;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 176);
            label8.Name = "label8";
            label8.Size = new Size(117, 19);
            label8.TabIndex = 62;
            label8.Text = "Tên nguyên liệu:";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvIngredient);
            panel3.Controls.Add(groupBox5);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(348, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(630, 674);
            panel3.TabIndex = 0;
            // 
            // dgvIngredient
            // 
            dgvIngredient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIngredient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredient.Dock = DockStyle.Fill;
            dgvIngredient.Location = new Point(0, 68);
            dgvIngredient.Name = "dgvIngredient";
            dgvIngredient.RowHeadersWidth = 51;
            dgvIngredient.Size = new Size(630, 606);
            dgvIngredient.TabIndex = 1;
            dgvIngredient.CellClick += dgvIngredient_CellClick;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtFindIngredient);
            groupBox5.Controls.Add(label11);
            groupBox5.Dock = DockStyle.Top;
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(630, 68);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Nguyên liệu";
            // 
            // txtFindIngredient
            // 
            txtFindIngredient.Location = new Point(110, 27);
            txtFindIngredient.Name = "txtFindIngredient";
            txtFindIngredient.Size = new Size(408, 25);
            txtFindIngredient.TabIndex = 69;
            txtFindIngredient.TextChanged += txtFindIngredient_TextChanged;
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
            Controls.Add(tcMain);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "frmProduct";
            Text = "frmRecipe";
            Load += frmProduct_Load;
            tcMain.ResumeLayout(false);
            tpProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecipe1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            tpRecipe.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecipe2).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIngredient).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcMain;
        private TabPage tpProduct;
        private TabPage tpRecipe;
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
        private Button btnClear;
        private Button btnAdd;
        private Button btnDelete;
        private TextBox txtFindProduct;
        private Label label5;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private DataGridView dgvRecipe1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel3;
        private DataGridView dgvRecipe2;
        private GroupBox groupBox4;
        private Button btnUpdateRecipe;
        private Button btnClearRecipe;
        private Button btnAddRecipe;
        private Button btnDeleteRecipe;
        private TextBox txtIngredientId;
        private Label label7;
        private Label label9;
        private TextBox txtProductId2;
        private Label label10;
        private ComboBox cboIngredientUnit;
        private Label label12;
        private Label label6;
        private TextBox txtIngredientQty;
        private TextBox txtIngredientName;
        private Label label8;
        private DataGridView dgvIngredient;
        private GroupBox groupBox5;
        private TextBox txtFindIngredient;
        private Label label11;
        private DataGridView dgvProduct;
        private TextBox txtPrice;
        private Label label13;
        private ComboBox cboProductName;
        private TextBox txtRecipeId;
        private Label label14;
    }
}