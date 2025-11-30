namespace GUI
{
    partial class frmScheduleReport
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
            dtpScheduleReport = new DateTimePicker();
            label1 = new Label();
            btnPrint = new Button();
            SuspendLayout();
            // 
            // dtpScheduleReport
            // 
            dtpScheduleReport.Format = DateTimePickerFormat.Short;
            dtpScheduleReport.Location = new Point(119, 12);
            dtpScheduleReport.Name = "dtpScheduleReport";
            dtpScheduleReport.Size = new Size(194, 30);
            dtpScheduleReport.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 19);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 1;
            label1.Text = "Chọn ngày:";
            // 
            // btnPrint
            // 
            btnPrint.Image = Properties.Resources.printer;
            btnPrint.ImageAlign = ContentAlignment.MiddleRight;
            btnPrint.Location = new Point(365, 9);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(129, 39);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "In Lịch";
            btnPrint.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // frmScheduleReport
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 61);
            Controls.Add(btnPrint);
            Controls.Add(label1);
            Controls.Add(dtpScheduleReport);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmScheduleReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xuất lịch Ngày trong Tuần";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpScheduleReport;
        private Label label1;
        private Button btnPrint;
    }
}