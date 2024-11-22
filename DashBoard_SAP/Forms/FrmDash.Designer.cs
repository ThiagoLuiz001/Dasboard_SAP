namespace DashBoard_SAP
{
    partial class FrmDash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDash));
            pnlMenu = new Style_Panel();
            style_GroupBox1 = new Style_GroupBox();
            pictureBox1 = new PictureBox();
            pnlPrimary = new Style_Panel();
            pnlMenu.SuspendLayout();
            style_GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(31, 31, 31);
            pnlMenu.Controls.Add(style_GroupBox1);
            pnlMenu.CornerRadius = 30;
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(147, 861);
            pnlMenu.TabIndex = 0;
            // 
            // style_GroupBox1
            // 
            style_GroupBox1.BorderColor = Color.Snow;
            style_GroupBox1.BorderSize = 2;
            style_GroupBox1.Controls.Add(pictureBox1);
            style_GroupBox1.CornerRadius = 15;
            style_GroupBox1.Location = new Point(12, 12);
            style_GroupBox1.Name = "style_GroupBox1";
            style_GroupBox1.Size = new Size(118, 89);
            style_GroupBox1.TabIndex = 1;
            style_GroupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlPrimary
            // 
            pnlPrimary.BackColor = Color.FromArgb(1, 1, 1);
            pnlPrimary.CornerRadius = 30;
            pnlPrimary.Dock = DockStyle.Fill;
            pnlPrimary.Location = new Point(147, 0);
            pnlPrimary.Name = "pnlPrimary";
            pnlPrimary.Size = new Size(837, 861);
            pnlPrimary.TabIndex = 1;
            // 
            // FrmDash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 861);
            Controls.Add(pnlPrimary);
            Controls.Add(pnlMenu);
            MaximizeBox = false;
            Name = "FrmDash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard Produção";
            pnlMenu.ResumeLayout(false);
            style_GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Style_Panel pnlMenu;
        private PictureBox pictureBox1;
        private Style_Panel pnlPrimary;
        private Style_GroupBox style_GroupBox1;
    }
}
