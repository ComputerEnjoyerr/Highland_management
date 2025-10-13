namespace GUI
{
    partial class ctrSideBarButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrSideBarButton));
            pnDatMon = new Panel();
            btnDatMon = new Button();
            pnDatMon.SuspendLayout();
            SuspendLayout();
            // 
            // pnDatMon
            // 
            pnDatMon.Controls.Add(btnDatMon);
            pnDatMon.Location = new Point(0, 0);
            pnDatMon.Margin = new Padding(0);
            pnDatMon.Name = "pnDatMon";
            pnDatMon.Size = new Size(185, 60);
            pnDatMon.TabIndex = 1;
            // 
            // btnDatMon
            // 
            btnDatMon.BackColor = Color.FromArgb(59, 48, 48);
            btnDatMon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDatMon.ForeColor = Color.FromArgb(249, 245, 238);
            btnDatMon.Image = (Image)resources.GetObject("btnDatMon.Image");
            btnDatMon.Location = new Point(-16, -16);
            btnDatMon.Name = "btnDatMon";
            btnDatMon.Size = new Size(216, 91);
            btnDatMon.TabIndex = 1;
            btnDatMon.Text = "    Đặt món";
            btnDatMon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDatMon.UseVisualStyleBackColor = false;
            // 
            // ctrSideBarButton
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(pnDatMon);
            Name = "ctrSideBarButton";
            Size = new Size(185, 60);
            pnDatMon.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnDatMon;
        private Button btnDatMon;
    }
}
