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
            pbNext = new PictureBox();
            pbPrev = new PictureBox();
            lbMonthDisplay = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label7 = new Label();
            flpSchedule = new FlowLayoutPanel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            label6 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPrev).BeginInit();
            panel1.SuspendLayout();
            flpSchedule.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(pbNext);
            panel2.Controls.Add(pbPrev);
            panel2.Controls.Add(lbMonthDisplay);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1692, 95);
            panel2.TabIndex = 15;
            // 
            // pbNext
            // 
            pbNext.Cursor = Cursors.Hand;
            pbNext.Image = (Image)resources.GetObject("pbNext.Image");
            pbNext.Location = new Point(475, 42);
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
            pbPrev.Location = new Point(442, 42);
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
            lbMonthDisplay.Size = new Size(411, 52);
            lbMonthDisplay.TabIndex = 14;
            lbMonthDisplay.Text = "Tháng";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(flpSchedule);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(1692, 894);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(19, 15);
            label1.Name = "label1";
            label1.Size = new Size(67, 28);
            label1.TabIndex = 13;
            label1.Text = "Thứ 2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(1435, 16);
            label7.Name = "label7";
            label7.Size = new Size(97, 28);
            label7.TabIndex = 14;
            label7.Text = "Chủ nhật";
            // 
            // flpSchedule
            // 
            flpSchedule.BackColor = Color.Transparent;
            flpSchedule.Controls.Add(panel3);
            flpSchedule.Controls.Add(panel5);
            flpSchedule.Controls.Add(panel4);
            flpSchedule.Controls.Add(panel6);
            flpSchedule.Controls.Add(panel7);
            flpSchedule.Controls.Add(panel9);
            flpSchedule.Controls.Add(panel8);
            flpSchedule.Location = new Point(16, 44);
            flpSchedule.Margin = new Padding(1);
            flpSchedule.Name = "flpSchedule";
            flpSchedule.Size = new Size(1666, 819);
            flpSchedule.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.Location = new Point(1, 1);
            panel3.Margin = new Padding(1);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 130);
            panel3.TabIndex = 20;
            // 
            // panel5
            // 
            panel5.Location = new Point(233, 1);
            panel5.Margin = new Padding(1);
            panel5.Name = "panel5";
            panel5.Size = new Size(230, 130);
            panel5.TabIndex = 20;
            // 
            // panel4
            // 
            panel4.Location = new Point(465, 1);
            panel4.Margin = new Padding(1);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 130);
            panel4.TabIndex = 20;
            // 
            // panel6
            // 
            panel6.Location = new Point(697, 1);
            panel6.Margin = new Padding(1);
            panel6.Name = "panel6";
            panel6.Size = new Size(230, 130);
            panel6.TabIndex = 20;
            // 
            // panel7
            // 
            panel7.Location = new Point(929, 1);
            panel7.Margin = new Padding(1);
            panel7.Name = "panel7";
            panel7.Size = new Size(230, 130);
            panel7.TabIndex = 20;
            // 
            // panel9
            // 
            panel9.Location = new Point(1161, 1);
            panel9.Margin = new Padding(1);
            panel9.Name = "panel9";
            panel9.Size = new Size(230, 130);
            panel9.TabIndex = 20;
            // 
            // panel8
            // 
            panel8.Location = new Point(1393, 1);
            panel8.Margin = new Padding(1);
            panel8.Name = "panel8";
            panel8.Size = new Size(230, 130);
            panel8.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(1199, 18);
            label6.Name = "label6";
            label6.Size = new Size(67, 28);
            label6.TabIndex = 15;
            label6.Text = "Thứ 7";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(255, 16);
            label2.Name = "label2";
            label2.Size = new Size(67, 28);
            label2.TabIndex = 16;
            label2.Text = "Thứ 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(963, 18);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 17;
            label5.Text = "Thứ 6";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(491, 16);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 18;
            label3.Text = "Thứ 4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(730, 18);
            label4.Name = "label4";
            label4.Size = new Size(67, 28);
            label4.TabIndex = 19;
            label4.Text = "Thứ 5";
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
            panel1.PerformLayout();
            flpSchedule.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pbNext;
        private PictureBox pbPrev;
        private Label lbMonthDisplay;
        private Panel panel1;
        private Label label1;
        private Label label7;
        private FlowLayoutPanel flpSchedule;
        private Label label6;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label label4;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private Panel panel7;
        private Panel panel9;
        private Panel panel8;
    }
}