namespace GUI
{
    partial class ctrDayBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            cbSelect = new CheckBox();
            lbDay = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cbSelect);
            panel1.Controls.Add(lbDay);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 130);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            panel1.Paint += panel1_Paint;
            // 
            // cbSelect
            // 
            cbSelect.AutoSize = true;
            cbSelect.Location = new Point(3, 14);
            cbSelect.Name = "cbSelect";
            cbSelect.Size = new Size(18, 17);
            cbSelect.TabIndex = 1;
            cbSelect.UseVisualStyleBackColor = true;
            // 
            // lbDay
            // 
            lbDay.AutoSize = true;
            lbDay.ForeColor = Color.Black;
            lbDay.Location = new Point(194, 10);
            lbDay.Name = "lbDay";
            lbDay.Size = new Size(28, 23);
            lbDay.TabIndex = 0;
            lbDay.Text = "00";
            // 
            // ctrDayBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Gray;
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(2);
            Name = "ctrDayBox";
            Size = new Size(230, 130);
            Load += ctrDayBox_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbDay;
        private CheckBox cbSelect;
    }
}
