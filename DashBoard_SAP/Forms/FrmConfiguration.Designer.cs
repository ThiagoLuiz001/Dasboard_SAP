namespace DashBoard_SAP.Forms
{
    partial class FrmConfiguration
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
            style_Panel1 = new Style_Panel();
            style_GroupBox1 = new Style_GroupBox();
            style_Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // style_Panel1
            // 
            style_Panel1.BackColor = Color.FromArgb(31, 31, 31);
            style_Panel1.Controls.Add(style_GroupBox1);
            style_Panel1.CornerRadius = 30;
            style_Panel1.Dock = DockStyle.Fill;
            style_Panel1.Location = new Point(0, 0);
            style_Panel1.Name = "style_Panel1";
            style_Panel1.Size = new Size(627, 362);
            style_Panel1.TabIndex = 0;
            // 
            // style_GroupBox1
            // 
            style_GroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            style_GroupBox1.BorderColor = Color.Snow;
            style_GroupBox1.BorderSize = 2;
            style_GroupBox1.CornerRadius = 15;
            style_GroupBox1.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            style_GroupBox1.ForeColor = Color.Snow;
            style_GroupBox1.Location = new Point(12, 3);
            style_GroupBox1.Name = "style_GroupBox1";
            style_GroupBox1.Size = new Size(607, 347);
            style_GroupBox1.TabIndex = 0;
            style_GroupBox1.TabStop = false;
            style_GroupBox1.Text = "Configuração da capacidade";
            // 
            // FrmConfiguration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 362);
            Controls.Add(style_Panel1);
            Name = "FrmConfiguration";
            Text = "FrmConfiguration";
            style_Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Style_Panel style_Panel1;
        private Style_GroupBox style_GroupBox1;
    }
}