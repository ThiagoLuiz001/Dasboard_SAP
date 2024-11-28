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
            groupImage = new Style_GroupBox();
            logo = new PictureBox();
            pnlPrimary = new Style_Panel();
            style_Button1 = new Style_Button();
            pnlMenu.SuspendLayout();
            groupImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(31, 31, 31);
            pnlMenu.Controls.Add(style_Button1);
            pnlMenu.Controls.Add(groupImage);
            pnlMenu.CornerRadius = 30;
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(175, 749);
            pnlMenu.TabIndex = 0;
            // 
            // groupImage
            // 
            groupImage.BorderColor = Color.Snow;
            groupImage.BorderSize = 2;
            groupImage.Controls.Add(logo);
            groupImage.CornerRadius = 15;
            groupImage.Location = new Point(3, 12);
            groupImage.Name = "groupImage";
            groupImage.Size = new Size(166, 96);
            groupImage.TabIndex = 1;
            groupImage.TabStop = false;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(9, 12);
            logo.Name = "logo";
            logo.Size = new Size(151, 78);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // pnlPrimary
            // 
            pnlPrimary.BackColor = Color.FromArgb(1, 1, 1);
            pnlPrimary.CornerRadius = 30;
            pnlPrimary.Dock = DockStyle.Fill;
            pnlPrimary.Location = new Point(175, 0);
            pnlPrimary.Name = "pnlPrimary";
            pnlPrimary.Size = new Size(1195, 749);
            pnlPrimary.TabIndex = 1;
            // 
            // style_Button1
            // 
            style_Button1.Location = new Point(0, 142);
            style_Button1.Name = "style_Button1";
            style_Button1.Size = new Size(175, 56);
            style_Button1.TabIndex = 2;
            style_Button1.Text = "style_Button1";
            style_Button1.UseVisualStyleBackColor = true;
            // 
            // FrmDash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 749);
            Controls.Add(pnlPrimary);
            Controls.Add(pnlMenu);
            MaximizeBox = false;
            Name = "FrmDash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard Produção";
            Load += FrmDash_Load_1;
            pnlMenu.ResumeLayout(false);
            groupImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Style_Panel pnlMenu;
        private PictureBox logo;
        private Style_Panel pnlPrimary;
        private Style_GroupBox groupImage;
        private Style_Button style_Button1;
    }
}
