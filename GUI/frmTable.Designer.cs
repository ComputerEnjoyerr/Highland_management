namespace GUI
{
    partial class frmTable
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
            dgvTable = new DataGridView();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            btnUpdate = new Button();
            btnReset = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            cboCapacity = new ComboBox();
            cboStatus = new ComboBox();
            label2 = new Label();
            label7 = new Label();
            txtFind = new TextBox();
            label4 = new Label();
            txtTableName = new TextBox();
            label5 = new Label();
            txtId = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTable).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTable
            // 
            dgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTable.Dock = DockStyle.Fill;
            dgvTable.Location = new Point(0, 376);
            dgvTable.Name = "dgvTable";
            dgvTable.RowHeadersWidth = 51;
            dgvTable.Size = new Size(1692, 613);
            dgvTable.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1692, 376);
            panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(cboCapacity);
            groupBox1.Controls.Add(cboStatus);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtFind);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTableName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label6);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1692, 376);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bàn ăn";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Control;
            btnUpdate.Image = Properties.Resources.pen;
            btnUpdate.ImageAlign = ContentAlignment.MiddleRight;
            btnUpdate.Location = new Point(317, 149);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 56);
            btnUpdate.TabIndex = 62;
            btnUpdate.Text = "Lưu";
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.Control;
            btnReset.Image = Properties.Resources.arrow;
            btnReset.ImageAlign = ContentAlignment.MiddleRight;
            btnReset.Location = new Point(466, 149);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(129, 56);
            btnReset.TabIndex = 64;
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
            btnAdd.Location = new Point(26, 151);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 56);
            btnAdd.TabIndex = 63;
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
            btnDelete.Location = new Point(172, 151);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 56);
            btnDelete.TabIndex = 65;
            btnDelete.Text = "Xóa";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // cboCapacity
            // 
            cboCapacity.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCapacity.FormattingEnabled = true;
            cboCapacity.Location = new Point(663, 50);
            cboCapacity.Name = "cboCapacity";
            cboCapacity.Size = new Size(409, 31);
            cboCapacity.TabIndex = 60;
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(663, 87);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(409, 31);
            cboStatus.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(551, 91);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 52;
            label2.Text = "Trạng thái:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(551, 57);
            label7.Name = "label7";
            label7.Size = new Size(87, 23);
            label7.TabIndex = 53;
            label7.Text = "Sức chứa:";
            // 
            // txtFind
            // 
            txtFind.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtFind.Location = new Point(126, 340);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(771, 30);
            txtFind.TabIndex = 57;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(16, 343);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 54;
            label4.Text = "Tìm kiếm:";
            // 
            // txtTableName
            // 
            txtTableName.Location = new Point(109, 88);
            txtTableName.Name = "txtTableName";
            txtTableName.Size = new Size(412, 30);
            txtTableName.TabIndex = 58;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 94);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 55;
            label5.Text = "Tên bàn:";
            // 
            // txtId
            // 
            txtId.Location = new Point(109, 51);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(412, 30);
            txtId.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 57);
            label6.Name = "label6";
            label6.Size = new Size(75, 23);
            label6.TabIndex = 56;
            label6.Text = "Mã bàn:";
            // 
            // frmTable
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1692, 989);
            Controls.Add(dgvTable);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "frmTable";
            Text = "frmTable";
            Load += frmTable_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTable).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTable;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button btnUpdate;
        private Button btnReset;
        private Button btnAdd;
        private Button btnDelete;
        private ComboBox cboCapacity;
        private ComboBox cboStatus;
        private Label label2;
        private Label label7;
        private TextBox txtFind;
        private Label label4;
        private TextBox txtTableName;
        private Label label5;
        private TextBox txtId;
        private Label label6;
    }
}