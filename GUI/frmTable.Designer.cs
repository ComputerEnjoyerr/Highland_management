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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            comboBox3 = new ComboBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 235);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(992, 475);
            dataGridView1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 235);
            panel1.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(230, 181, 56);
            button4.Location = new Point(323, 91);
            button4.Name = "button4";
            button4.Size = new Size(145, 53);
            button4.TabIndex = 32;
            button4.Text = "Lưu";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(686, 16);
            button3.Name = "button3";
            button3.Size = new Size(145, 53);
            button3.TabIndex = 33;
            button3.Text = "Hoàn tác";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(104, 176, 145);
            button1.Location = new Point(21, 91);
            button1.Name = "button1";
            button1.Size = new Size(145, 53);
            button1.TabIndex = 32;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(169, 65, 65);
            button2.Location = new Point(172, 91);
            button2.Name = "button2";
            button2.Size = new Size(145, 53);
            button2.TabIndex = 33;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(460, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 25);
            comboBox1.TabIndex = 31;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(460, 47);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(204, 25);
            comboBox3.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 50);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 22;
            label2.Text = "Trạng thái:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 204);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(460, 25);
            textBox2.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 207);
            label4.Name = "label4";
            label4.Size = new Size(75, 19);
            label4.TabIndex = 25;
            label4.Text = "Tìm kiếm:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(104, 47);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(204, 25);
            textBox5.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 53);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 25;
            label5.Text = "Tên bàn:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(104, 16);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(204, 25);
            textBox6.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 22);
            label6.Name = "label6";
            label6.Size = new Size(63, 19);
            label6.TabIndex = 26;
            label6.Text = "Mã bàn:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(377, 22);
            label7.Name = "label7";
            label7.Size = new Size(73, 19);
            label7.TabIndex = 24;
            label7.Text = "Sức chứa:";
            // 
            // frmTable
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(992, 710);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "frmTable";
            Text = "frmTable";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private Label label2;
        private Label label7;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
    }
}