namespace GUI
{
    partial class frmEmployeeSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeSchedule));
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(249, 245, 238);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 53);
            panel1.TabIndex = 5;
            // 
            // textBox1
            // 
<<<<<<< Updated upstream
            textBox1.Location = new Point(100, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 25);
            textBox1.TabIndex = 1;
=======
            txtFind.Location = new Point(116, 12);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(578, 30);
            txtFind.TabIndex = 1;
            txtFind.TextChanged += txtFind_TextChanged;
>>>>>>> Stashed changes
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 15);
            label1.Name = "label1";
            label1.Size = new Size(75, 19);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm:";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(887, 464);
            dataGridView1.TabIndex = 4;
            // 
            // frmEmployeeSchedule
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(74, 60, 60);
            ClientSize = new Size(914, 550);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEmployeeSchedule";
            Text = "Các ca làm việc của nhân viên";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
    }
}