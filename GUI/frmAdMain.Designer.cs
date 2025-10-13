namespace GUI
{
    partial class frmAdMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdMain));
            flpSideBar = new FlowLayoutPanel();
            pnOrder = new Panel();
            btnOrder = new Button();
            pnHistory = new Panel();
            btnHistory = new Button();
            pnAttendance = new Panel();
            btnAttendance = new Button();
            pnSchedule = new Panel();
            btnSchedule = new Button();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            btnLogOut = new Button();
            pnTitleBar = new Panel();
            ctrTitleBar2 = new ctrTitleBar();
            pictureBox1 = new PictureBox();
            ctrTitleBar1 = new ctrTitleBar();
            lbTitle = new Label();
            flpSideBar.SuspendLayout();
            pnOrder.SuspendLayout();
            pnHistory.SuspendLayout();
            pnAttendance.SuspendLayout();
            pnSchedule.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flpSideBar
            // 
            flpSideBar.AllowDrop = true;
            flpSideBar.BackColor = Color.FromArgb(74, 60, 60);
            flpSideBar.Controls.Add(pnOrder);
            flpSideBar.Controls.Add(pnHistory);
            flpSideBar.Controls.Add(pnAttendance);
            flpSideBar.Controls.Add(pnSchedule);
            flpSideBar.Controls.Add(panel1);
            flpSideBar.Controls.Add(panel2);
            flpSideBar.Dock = DockStyle.Left;
            flpSideBar.Location = new Point(0, 40);
            flpSideBar.Name = "flpSideBar";
            flpSideBar.Size = new Size(206, 749);
            flpSideBar.TabIndex = 3;
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
            btnOrder.Text = "    QL Công thức";
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
            btnHistory.Text = "    QL Nhà cung cấp";
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
            btnAttendance.Text = "    QL Khuyến mãi";
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
            btnSchedule.Text = "    QL Chi nhánh";
            btnSchedule.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSchedule.UseVisualStyleBackColor = false;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 240);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 60);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(59, 48, 48);
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(249, 245, 238);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-16, -16);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 0);
            button1.Size = new Size(270, 91);
            button1.TabIndex = 1;
            button1.Text = "    QL Khách hàng";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLogOut);
            panel2.Location = new Point(0, 300);
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
            btnLogOut.Click += btnLogOut_Click_1;
            btnLogOut.MouseCaptureChanged += btnLogOut_MouseCaptureChanged;
            // 
            // pnTitleBar
            // 
            pnTitleBar.BackColor = Color.FromArgb(168, 34, 43);
            pnTitleBar.Controls.Add(ctrTitleBar2);
            pnTitleBar.Controls.Add(pictureBox1);
            pnTitleBar.Controls.Add(ctrTitleBar1);
            pnTitleBar.Controls.Add(lbTitle);
            pnTitleBar.Dock = DockStyle.Top;
            pnTitleBar.Location = new Point(0, 0);
            pnTitleBar.Name = "pnTitleBar";
            pnTitleBar.Size = new Size(1248, 40);
            pnTitleBar.TabIndex = 2;
            pnTitleBar.MouseDown += pnTitleBar_MouseDown;
            // 
            // ctrTitleBar2
            // 
            ctrTitleBar2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrTitleBar2.Location = new Point(1116, 4);
            ctrTitleBar2.Name = "ctrTitleBar2";
            ctrTitleBar2.Size = new Size(120, 30);
            ctrTitleBar2.TabIndex = 4;
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
            ctrTitleBar1.Location = new Point(2168, 3);
            ctrTitleBar1.Name = "ctrTitleBar1";
            ctrTitleBar1.Size = new Size(120, 0);
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
            // frmAdMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1248, 789);
            Controls.Add(flpSideBar);
            Controls.Add(pnTitleBar);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "frmAdMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdMain";
            WindowState = FormWindowState.Maximized;
            flpSideBar.ResumeLayout(false);
            pnOrder.ResumeLayout(false);
            pnHistory.ResumeLayout(false);
            pnAttendance.ResumeLayout(false);
            pnSchedule.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnTitleBar.ResumeLayout(false);
            pnTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpSideBar;
        private Panel pnOrder;
        private Button btnOrder;
        private Panel pnHistory;
        private Button btnHistory;
        private Panel pnAttendance;
        private Button btnAttendance;
        private Panel pnSchedule;
        private Button btnSchedule;
        private Panel pnTitleBar;
        private PictureBox pictureBox1;
        private ctrTitleBar ctrTitleBar1;
        private Label lbTitle;
        private ctrTitleBar ctrTitleBar2;
        private Panel panel2;
        private Button btnLogOut;
        private Panel panel1;
        private Button button1;
    }
}