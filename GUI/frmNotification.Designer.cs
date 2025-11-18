namespace GUI
{
    partial class frmNotification
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
            dgvNotification = new DataGridView();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            btnRemove = new Button();
            btnIsRead = new Button();
            cboType = new ComboBox();
            dtpTime = new DateTimePicker();
            label7 = new Label();
            txtContent = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtTitle = new TextBox();
            label4 = new Label();
            txtId = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            cboFindByType = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNotification).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNotification
            // 
            dgvNotification.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNotification.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotification.Location = new Point(3, 80);
            dgvNotification.Name = "dgvNotification";
            dgvNotification.RowHeadersWidth = 51;
            dgvNotification.Size = new Size(1010, 906);
            dgvNotification.TabIndex = 12;
            dgvNotification.CellClick += dgvNotification_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1019, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(673, 989);
            panel2.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Controls.Add(btnIsRead);
            groupBox1.Controls.Add(cboType);
            groupBox1.Controls.Add(dtpTime);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtContent);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(673, 989);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiết thông báo";
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemove.BackColor = SystemColors.Control;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.Image = Properties.Resources.delete;
            btnRemove.ImageAlign = ContentAlignment.MiddleRight;
            btnRemove.Location = new Point(472, 785);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(175, 60);
            btnRemove.TabIndex = 18;
            btnRemove.Text = "Xóa thông báo";
            btnRemove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnIsRead
            // 
            btnIsRead.BackColor = SystemColors.Control;
            btnIsRead.FlatAppearance.BorderSize = 0;
            btnIsRead.Image = Properties.Resources.eye;
            btnIsRead.ImageAlign = ContentAlignment.MiddleRight;
            btnIsRead.Location = new Point(32, 785);
            btnIsRead.Name = "btnIsRead";
            btnIsRead.Size = new Size(136, 60);
            btnIsRead.TabIndex = 18;
            btnIsRead.Text = "Đã xem";
            btnIsRead.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIsRead.UseVisualStyleBackColor = false;
            btnIsRead.Click += btnIsRead_Click;
            // 
            // cboType
            // 
            cboType.FormattingEnabled = true;
            cboType.Location = new Point(170, 108);
            cboType.Name = "cboType";
            cboType.Size = new Size(191, 31);
            cboType.TabIndex = 16;
            // 
            // dtpTime
            // 
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.Location = new Point(170, 145);
            dtpTime.Name = "dtpTime";
            dtpTime.Size = new Size(191, 30);
            dtpTime.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 154);
            label7.Name = "label7";
            label7.Size = new Size(91, 23);
            label7.TabIndex = 7;
            label7.Text = "Thời gian:";
            // 
            // txtContent
            // 
            txtContent.Location = new Point(32, 250);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(615, 513);
            txtContent.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 224);
            label6.Name = "label6";
            label6.Size = new Size(90, 23);
            label6.TabIndex = 8;
            label6.Text = "Nội dung:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 114);
            label5.Name = "label5";
            label5.Size = new Size(136, 23);
            label5.TabIndex = 9;
            label5.Text = "Loại thông báo:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(170, 72);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(471, 30);
            txtTitle.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 78);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 10;
            label4.Text = "Tiêu đề:";
            // 
            // txtId
            // 
            txtId.Location = new Point(170, 36);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(471, 30);
            txtId.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 42);
            label3.Name = "label3";
            label3.Size = new Size(40, 23);
            label3.TabIndex = 11;
            label3.Text = "Mã:";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1019, 74);
            panel1.TabIndex = 13;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboFindByType);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1019, 74);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // cboFindByType
            // 
            cboFindByType.FormattingEnabled = true;
            cboFindByType.Location = new Point(161, 32);
            cboFindByType.Name = "cboFindByType";
            cboFindByType.Size = new Size(271, 31);
            cboFindByType.TabIndex = 16;
            cboFindByType.SelectedIndexChanged += cboFindByType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 10;
            label1.Text = "Loại thông báo:";
            // 
            // frmNotification
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1692, 989);
            Controls.Add(panel1);
            Controls.Add(dgvNotification);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "frmNotification";
            Text = "frmNotification";
            Load += frmNotification_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNotification).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvNotification;
        private Panel panel2;
        private GroupBox groupBox1;
        private DateTimePicker dtpTime;
        private Label label7;
        private TextBox txtContent;
        private Label label6;
        private Label label5;
        private TextBox txtTitle;
        private Label label4;
        private TextBox txtId;
        private Label label3;
        private Panel panel1;
        private GroupBox groupBox2;
        private ComboBox cboFindByType;
        private Label label1;
        private Button btnRemove;
        private Button btnIsRead;
        private ComboBox cboType;
    }
}