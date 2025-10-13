namespace GUI
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pnTitleBar = new Panel();
            pictureBox1 = new PictureBox();
            ctrTitleBar1 = new ctrTitleBar();
            lbTitle = new Label();
            pbSideBar = new PictureBox();
            flpSideBar = new FlowLayoutPanel();
            pnOrder = new Panel();
            btnOrder = new Button();
            pnHistory = new Panel();
            btnHistory = new Button();
            pnAttendance = new Panel();
            btnAttendance = new Button();
            pnSchedule = new Panel();
            btnSchedule = new Button();
            pnInventory = new Panel();
            btnInventory = new Button();
            pnEmployee = new Panel();
            btnEmployee = new Button();
            panel1 = new Panel();
            btnTable = new Button();
            panel3 = new Panel();
            btnPromotion = new Button();
            pnFinancial = new Panel();
            btnFinancial = new Button();
            pnNotification = new Panel();
            btnNotification = new Button();
            panel2 = new Panel();
            btnLogOut = new Button();
            tmSideBar = new System.Windows.Forms.Timer(components);
            pnTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSideBar).BeginInit();
            flpSideBar.SuspendLayout();
            pnOrder.SuspendLayout();
            pnHistory.SuspendLayout();
            pnAttendance.SuspendLayout();
            pnSchedule.SuspendLayout();
            pnInventory.SuspendLayout();
            pnEmployee.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            pnFinancial.SuspendLayout();
            pnNotification.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnTitleBar
            // 
            pnTitleBar.BackColor = Color.FromArgb(168, 34, 43);
            pnTitleBar.Controls.Add(pictureBox1);
            pnTitleBar.Controls.Add(ctrTitleBar1);
            pnTitleBar.Controls.Add(lbTitle);
            pnTitleBar.Controls.Add(pbSideBar);
            pnTitleBar.Dock = DockStyle.Top;
            pnTitleBar.Location = new Point(0, 0);
            pnTitleBar.Name = "pnTitleBar";
            pnTitleBar.Size = new Size(1248, 40);
            pnTitleBar.TabIndex = 0;
            pnTitleBar.Paint += pnTitleBar_Paint;
            pnTitleBar.MouseDown += pnTitleBar_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(265, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ctrTitleBar1
            // 
            ctrTitleBar1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ctrTitleBar1.Location = new Point(1120, 3);
            ctrTitleBar1.Name = "ctrTitleBar1";
            ctrTitleBar1.Size = new Size(120, 29);
            ctrTitleBar1.TabIndex = 3;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbTitle.ForeColor = Color.FromArgb(249, 245, 238);
            lbTitle.Location = new Point(54, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(253, 23);
            lbTitle.TabIndex = 2;
            lbTitle.Text = "Highland Coffee Management";
            // 
            // pbSideBar
            // 
            pbSideBar.Image = (Image)resources.GetObject("pbSideBar.Image");
            pbSideBar.Location = new Point(3, 2);
            pbSideBar.Name = "pbSideBar";
            pbSideBar.Size = new Size(45, 36);
            pbSideBar.SizeMode = PictureBoxSizeMode.CenterImage;
            pbSideBar.TabIndex = 1;
            pbSideBar.TabStop = false;
            pbSideBar.Click += pbSideBar_Click;
            // 
            // flpSideBar
            // 
            flpSideBar.AllowDrop = true;
            flpSideBar.BackColor = Color.FromArgb(74, 60, 60);
            flpSideBar.Controls.Add(pnOrder);
            flpSideBar.Controls.Add(pnHistory);
            flpSideBar.Controls.Add(pnAttendance);
            flpSideBar.Controls.Add(pnSchedule);
            flpSideBar.Controls.Add(pnInventory);
            flpSideBar.Controls.Add(pnEmployee);
            flpSideBar.Controls.Add(panel1);
            flpSideBar.Controls.Add(panel3);
            flpSideBar.Controls.Add(pnFinancial);
            flpSideBar.Controls.Add(pnNotification);
            flpSideBar.Controls.Add(panel2);
            flpSideBar.Dock = DockStyle.Left;
            flpSideBar.Location = new Point(0, 40);
            flpSideBar.Name = "flpSideBar";
            flpSideBar.Size = new Size(240, 749);
            flpSideBar.TabIndex = 1;
            // 
            // pnOrder
            // 
            pnOrder.Controls.Add(btnOrder);
            pnOrder.Location = new Point(0, 0);
            pnOrder.Margin = new Padding(0);
            pnOrder.Name = "pnOrder";
            pnOrder.Size = new Size(240, 60);
            pnOrder.TabIndex = 2;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(59, 48, 48);
            btnOrder.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOrder.ForeColor = Color.FromArgb(249, 245, 238);
            btnOrder.Image = (Image)resources.GetObject("btnOrder.Image");
            btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrder.Location = new Point(-16, -16);
            btnOrder.Name = "btnOrder";
            btnOrder.Padding = new Padding(30, 0, 0, 0);
            btnOrder.Size = new Size(270, 91);
            btnOrder.TabIndex = 1;
            btnOrder.Text = "    Đặt món";
            btnOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // pnHistory
            // 
            pnHistory.Controls.Add(btnHistory);
            pnHistory.Location = new Point(0, 60);
            pnHistory.Margin = new Padding(0);
            pnHistory.Name = "pnHistory";
            pnHistory.Size = new Size(240, 60);
            pnHistory.TabIndex = 2;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.FromArgb(59, 48, 48);
            btnHistory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHistory.ForeColor = Color.FromArgb(249, 245, 238);
            btnHistory.Image = (Image)resources.GetObject("btnHistory.Image");
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(-16, -16);
            btnHistory.Name = "btnHistory";
            btnHistory.Padding = new Padding(30, 0, 0, 0);
            btnHistory.Size = new Size(270, 91);
            btnHistory.TabIndex = 1;
            btnHistory.Text = "    Lịch sử Thanh toán";
            btnHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // pnAttendance
            // 
            pnAttendance.Controls.Add(btnAttendance);
            pnAttendance.Location = new Point(0, 120);
            pnAttendance.Margin = new Padding(0);
            pnAttendance.Name = "pnAttendance";
            pnAttendance.Size = new Size(240, 60);
            pnAttendance.TabIndex = 2;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.FromArgb(59, 48, 48);
            btnAttendance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAttendance.ForeColor = Color.FromArgb(249, 245, 238);
            btnAttendance.Image = (Image)resources.GetObject("btnAttendance.Image");
            btnAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendance.Location = new Point(-16, -16);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Padding = new Padding(30, 0, 0, 0);
            btnAttendance.Size = new Size(270, 91);
            btnAttendance.TabIndex = 1;
            btnAttendance.Text = "    Điểm danh";
            btnAttendance.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // pnSchedule
            // 
            pnSchedule.Controls.Add(btnSchedule);
            pnSchedule.Location = new Point(0, 180);
            pnSchedule.Margin = new Padding(0);
            pnSchedule.Name = "pnSchedule";
            pnSchedule.Size = new Size(240, 60);
            pnSchedule.TabIndex = 2;
            // 
            // btnSchedule
            // 
            btnSchedule.BackColor = Color.FromArgb(59, 48, 48);
            btnSchedule.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSchedule.ForeColor = Color.FromArgb(249, 245, 238);
            btnSchedule.Image = (Image)resources.GetObject("btnSchedule.Image");
            btnSchedule.ImageAlign = ContentAlignment.MiddleLeft;
            btnSchedule.Location = new Point(-16, -16);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Padding = new Padding(30, 0, 0, 0);
            btnSchedule.Size = new Size(270, 91);
            btnSchedule.TabIndex = 1;
            btnSchedule.Text = "    Lịch làm việc";
            btnSchedule.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSchedule.UseVisualStyleBackColor = false;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // pnInventory
            // 
            pnInventory.Controls.Add(btnInventory);
            pnInventory.Location = new Point(0, 240);
            pnInventory.Margin = new Padding(0);
            pnInventory.Name = "pnInventory";
            pnInventory.Size = new Size(240, 60);
            pnInventory.TabIndex = 2;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.FromArgb(59, 48, 48);
            btnInventory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInventory.ForeColor = Color.FromArgb(249, 245, 238);
            btnInventory.Image = (Image)resources.GetObject("btnInventory.Image");
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.Location = new Point(-16, -16);
            btnInventory.Name = "btnInventory";
            btnInventory.Padding = new Padding(30, 0, 0, 0);
            btnInventory.Size = new Size(270, 91);
            btnInventory.TabIndex = 1;
            btnInventory.Text = "    Kho hàng";
            btnInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // pnEmployee
            // 
            pnEmployee.Controls.Add(btnEmployee);
            pnEmployee.Location = new Point(0, 300);
            pnEmployee.Margin = new Padding(0);
            pnEmployee.Name = "pnEmployee";
            pnEmployee.Size = new Size(240, 60);
            pnEmployee.TabIndex = 2;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(59, 48, 48);
            btnEmployee.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEmployee.ForeColor = Color.FromArgb(249, 245, 238);
            btnEmployee.Image = (Image)resources.GetObject("btnEmployee.Image");
            btnEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployee.Location = new Point(-16, -16);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Padding = new Padding(30, 0, 0, 0);
            btnEmployee.Size = new Size(270, 91);
            btnEmployee.TabIndex = 1;
            btnEmployee.Text = "    Quản lý Nhân viên";
            btnEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTable);
            panel1.Location = new Point(0, 360);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 60);
            panel1.TabIndex = 2;
            // 
            // btnTable
            // 
            btnTable.BackColor = Color.FromArgb(59, 48, 48);
            btnTable.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTable.ForeColor = Color.FromArgb(249, 245, 238);
            btnTable.Image = (Image)resources.GetObject("btnTable.Image");
            btnTable.ImageAlign = ContentAlignment.MiddleLeft;
            btnTable.Location = new Point(-16, -16);
            btnTable.Name = "btnTable";
            btnTable.Padding = new Padding(30, 0, 0, 0);
            btnTable.Size = new Size(270, 91);
            btnTable.TabIndex = 1;
            btnTable.Text = "    Quản lý Bàn ăn";
            btnTable.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTable.UseVisualStyleBackColor = false;
            btnTable.Click += btnTable_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnPromotion);
            panel3.Location = new Point(0, 420);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(240, 60);
            panel3.TabIndex = 2;
            // 
            // btnPromotion
            // 
            btnPromotion.BackColor = Color.FromArgb(59, 48, 48);
            btnPromotion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPromotion.ForeColor = Color.FromArgb(249, 245, 238);
            btnPromotion.Image = (Image)resources.GetObject("btnPromotion.Image");
            btnPromotion.ImageAlign = ContentAlignment.MiddleLeft;
            btnPromotion.Location = new Point(-16, -16);
            btnPromotion.Name = "btnPromotion";
            btnPromotion.Padding = new Padding(30, 0, 0, 0);
            btnPromotion.Size = new Size(270, 91);
            btnPromotion.TabIndex = 1;
            btnPromotion.Text = "    Quản lý Khuyến mãi";
            btnPromotion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPromotion.UseVisualStyleBackColor = false;
            btnPromotion.Click += btnPromotion_Click;
            // 
            // pnFinancial
            // 
            pnFinancial.Controls.Add(btnFinancial);
            pnFinancial.Location = new Point(0, 480);
            pnFinancial.Margin = new Padding(0);
            pnFinancial.Name = "pnFinancial";
            pnFinancial.Size = new Size(240, 60);
            pnFinancial.TabIndex = 2;
            // 
            // btnFinancial
            // 
            btnFinancial.BackColor = Color.FromArgb(59, 48, 48);
            btnFinancial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFinancial.ForeColor = Color.FromArgb(249, 245, 238);
            btnFinancial.Image = (Image)resources.GetObject("btnFinancial.Image");
            btnFinancial.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinancial.Location = new Point(-16, -16);
            btnFinancial.Name = "btnFinancial";
            btnFinancial.Padding = new Padding(30, 0, 0, 0);
            btnFinancial.Size = new Size(270, 91);
            btnFinancial.TabIndex = 1;
            btnFinancial.Text = "    Doanh thu";
            btnFinancial.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFinancial.UseVisualStyleBackColor = false;
            btnFinancial.Click += btnFinancial_Click;
            // 
            // pnNotification
            // 
            pnNotification.Controls.Add(btnNotification);
            pnNotification.Location = new Point(0, 540);
            pnNotification.Margin = new Padding(0);
            pnNotification.Name = "pnNotification";
            pnNotification.Size = new Size(240, 60);
            pnNotification.TabIndex = 2;
            // 
            // btnNotification
            // 
            btnNotification.BackColor = Color.FromArgb(59, 48, 48);
            btnNotification.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNotification.ForeColor = Color.FromArgb(249, 245, 238);
            btnNotification.Image = (Image)resources.GetObject("btnNotification.Image");
            btnNotification.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotification.Location = new Point(-16, -16);
            btnNotification.Name = "btnNotification";
            btnNotification.Padding = new Padding(30, 0, 0, 0);
            btnNotification.Size = new Size(270, 91);
            btnNotification.TabIndex = 1;
            btnNotification.Text = "    Thông báo";
            btnNotification.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNotification.UseVisualStyleBackColor = false;
            btnNotification.Click += btnNotification_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLogOut);
            panel2.Location = new Point(0, 600);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 60);
            panel2.TabIndex = 2;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(59, 48, 48);
            btnLogOut.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogOut.ForeColor = Color.FromArgb(249, 245, 238);
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(-16, -16);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(30, 0, 0, 0);
            btnLogOut.Size = new Size(270, 91);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "    Đăng xuất";
            btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // tmSideBar
            // 
            tmSideBar.Interval = 1;
            tmSideBar.Tick += tmSideBar_Tick;
            // 
            // frmMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1248, 789);
            ControlBox = false;
            Controls.Add(flpSideBar);
            Controls.Add(pnTitleBar);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            pnTitleBar.ResumeLayout(false);
            pnTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSideBar).EndInit();
            flpSideBar.ResumeLayout(false);
            pnOrder.ResumeLayout(false);
            pnHistory.ResumeLayout(false);
            pnAttendance.ResumeLayout(false);
            pnSchedule.ResumeLayout(false);
            pnInventory.ResumeLayout(false);
            pnEmployee.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pnFinancial.ResumeLayout(false);
            pnNotification.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnTitleBar;
        private PictureBox pbSideBar;
        private Label lbTitle;
        private ctrTitleBar ctrTitleBar1;
        private FlowLayoutPanel flpSideBar;
        private Panel pnOrder;
        private Button btnOrder;
        private Panel pnHistory;
        private Button btnHistory;
        private Panel pnNotification;
        private Button btnNotification;
        private Panel pnEmployee;
        private Button btnEmployee;
        private Panel pnInventory;
        private Button btnInventory;
        private Panel pnFinancial;
        private Button btnFinancial;
        private Panel pnSchedule;
        private Button btnSchedule;
        private Panel pnAttendance;
        private Button btnAttendance;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmSideBar;
        private Panel panel1;
        private Button btnTable;
        private Panel panel2;
        private Button btnLogOut;
        private Panel panel3;
        private Button btnPromotion;
    }
}
