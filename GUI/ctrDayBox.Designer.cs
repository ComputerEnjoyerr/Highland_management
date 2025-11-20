namespace GUI
{
    partial class ctrDayBox
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lbDay = new Label();
            CaContainer = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Gainsboro;
            pnlHeader.Controls.Add(lbDay);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(230, 30);
            pnlHeader.TabIndex = 0;
            pnlHeader.Click += panel1_Click;
            // 
            // lbDay
            // 
            lbDay.AutoSize = true;
            lbDay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbDay.Location = new Point(5, 5);
            lbDay.Name = "lbDay";
            lbDay.Size = new Size(63, 19);
            lbDay.TabIndex = 0;
            lbDay.Text = "Thứ 2...";
            // 
            // CaContainer
            // 
            CaContainer.Dock = DockStyle.Fill;
            CaContainer.FlowDirection = FlowDirection.TopDown;
            CaContainer.Location = new Point(0, 30);
            CaContainer.Name = "CaContainer";
            CaContainer.Padding = new Padding(5);
            CaContainer.Size = new Size(230, 190);
            CaContainer.TabIndex = 1;
            CaContainer.WrapContents = false;
            // 
            // ctrDayBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(CaContainer);
            Controls.Add(pnlHeader);
            Name = "ctrDayBox";
            Size = new Size(230, 220);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lbDay;
    }
}
