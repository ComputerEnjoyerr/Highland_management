namespace GUI
{
    partial class frmSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchedule));
            panel2 = new Panel();
            btnPrintReport = new Button();
            pbNext = new PictureBox();
            pbPrev = new PictureBox();
            lbMonthDisplay = new Label();
            panel1 = new Panel();
            flpSchedule = new FlowLayoutPanel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel4 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPrev).BeginInit();
            panel1.SuspendLayout();
            flpSchedule.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnPrintReport);
            panel2.Controls.Add(pbNext);
            panel2.Controls.Add(pbPrev);
            panel2.Controls.Add(lbMonthDisplay);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1692, 95);
            panel2.TabIndex = 15;
            // 
            // btnPrintReport
            // 
            btnPrintReport.Image = Properties.Resources.printer;
            btnPrintReport.ImageAlign = ContentAlignment.MiddleRight;
            btnPrintReport.Location = new Point(1454, 33);
            btnPrintReport.Name = "btnPrintReport";
            btnPrintReport.Size = new Size(171, 38);
            btnPrintReport.TabIndex = 17;
            btnPrintReport.Text = "In Lịch làm việc";
            btnPrintReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrintReport.UseVisualStyleBackColor = true;
            btnPrintReport.Click += btnPrintReport_Click;
            // 
            // pbNext
            // 
            pbNext.Cursor = Cursors.Hand;
            pbNext.Image = (Image)resources.GetObject("pbNext.Image");
            pbNext.Location = new Point(476, 39);
            pbNext.Name = "pbNext";
            pbNext.Size = new Size(27, 20);
            pbNext.SizeMode = PictureBoxSizeMode.CenterImage;
            pbNext.TabIndex = 15;
            pbNext.TabStop = false;
            pbNext.Click += pbNext_Click;
            // 
            // pbPrev
            // 
            pbPrev.Cursor = Cursors.Hand;
            pbPrev.Image = (Image)resources.GetObject("pbPrev.Image");
            pbPrev.Location = new Point(443, 39);
            pbPrev.Name = "pbPrev";
            pbPrev.Size = new Size(27, 20);
            pbPrev.SizeMode = PictureBoxSizeMode.CenterImage;
            pbPrev.TabIndex = 16;
            pbPrev.TabStop = false;
            pbPrev.Click += pbPrev_Click;
            // 
            // lbMonthDisplay
            // 
            lbMonthDisplay.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbMonthDisplay.Location = new Point(13, 28);
            lbMonthDisplay.Name = "lbMonthDisplay";
            lbMonthDisplay.Size = new Size(408, 49);
            lbMonthDisplay.TabIndex = 14;
            lbMonthDisplay.Text = "Tháng";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(flpSchedule);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(1692, 894);
            panel1.TabIndex = 16;
            // 
            // flpSchedule
            // 
            flpSchedule.BackColor = Color.Transparent;
            flpSchedule.Controls.Add(panel3);
            flpSchedule.Controls.Add(panel5);
            flpSchedule.Controls.Add(panel6);
            flpSchedule.Controls.Add(panel4);
            flpSchedule.Controls.Add(panel7);
            flpSchedule.Controls.Add(panel8);
            flpSchedule.Controls.Add(panel9);
            flpSchedule.Location = new Point(11, 4);
            flpSchedule.Margin = new Padding(1);
            flpSchedule.Name = "flpSchedule";
            flpSchedule.Size = new Size(1671, 880);
            flpSchedule.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 875);
            panel3.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Location = new Point(234, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(225, 875);
            panel5.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Location = new Point(465, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(225, 875);
            panel6.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Location = new Point(696, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(225, 875);
            panel4.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Location = new Point(927, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(225, 875);
            panel7.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Location = new Point(1158, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(225, 875);
            panel8.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Location = new Point(1389, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(225, 875);
            panel9.TabIndex = 0;
            // 
            // frmSchedule
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(249, 245, 238);
            ClientSize = new Size(1692, 989);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "frmSchedule";
            Text = "frmAttendance";
            Load += frmSchedule_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbNext).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPrev).EndInit();
            panel1.ResumeLayout(false);
            flpSchedule.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pbNext;
        private PictureBox pbPrev;
        private Label lbMonthDisplay;
        private Panel panel1;
        private FlowLayoutPanel flpSchedule;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private Panel panel4;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Button btnPrintReport;
    }
}