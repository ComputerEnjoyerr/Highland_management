namespace GUI
{
    partial class ctrTitleBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrTitleBar));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pbMin = new PictureBox();
            pbMax = new PictureBox();
            pbClose = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pbMin);
            flowLayoutPanel1.Controls.Add(pbMax);
            flowLayoutPanel1.Controls.Add(pbClose);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(120, 30);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pbMin
            // 
            pbMin.Image = (Image)resources.GetObject("pbMin.Image");
            pbMin.Location = new Point(0, 0);
            pbMin.Margin = new Padding(0);
            pbMin.Name = "pbMin";
            pbMin.Size = new Size(40, 30);
            pbMin.SizeMode = PictureBoxSizeMode.CenterImage;
            pbMin.TabIndex = 0;
            pbMin.TabStop = false;
            pbMin.Click += pbMin_Click;
            // 
            // pbMax
            // 
            pbMax.Image = (Image)resources.GetObject("pbMax.Image");
            pbMax.Location = new Point(40, 0);
            pbMax.Margin = new Padding(0);
            pbMax.Name = "pbMax";
            pbMax.Size = new Size(40, 30);
            pbMax.SizeMode = PictureBoxSizeMode.CenterImage;
            pbMax.TabIndex = 0;
            pbMax.TabStop = false;
            pbMax.Click += pbMax_Click;
            // 
            // pbClose
            // 
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(80, 0);
            pbClose.Margin = new Padding(0);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(40, 30);
            pbClose.SizeMode = PictureBoxSizeMode.CenterImage;
            pbClose.TabIndex = 0;
            pbClose.TabStop = false;
            pbClose.Click += pbClose_Click;
            // 
            // ctrTitleBar
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(flowLayoutPanel1);
            Name = "ctrTitleBar";
            Size = new Size(120, 30);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pbMin;
        private PictureBox pbMax;
        private PictureBox pbClose;
    }
}
