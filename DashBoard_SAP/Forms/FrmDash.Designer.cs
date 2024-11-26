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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            pnlMenu = new Style_Panel();
            style_GroupBox1 = new Style_GroupBox();
            pictureBox1 = new PictureBox();
            pnlPrimary = new Style_Panel();
            style_Panel3 = new Style_Panel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pnlMenu.SuspendLayout();
            style_GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlPrimary.SuspendLayout();
            style_Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
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
            pnlPrimary.Controls.Add(style_Panel3);
            pnlPrimary.CornerRadius = 30;
            pnlPrimary.Dock = DockStyle.Fill;
            pnlPrimary.Location = new Point(147, 0);
            pnlPrimary.Name = "pnlPrimary";
            pnlPrimary.Size = new Size(1277, 861);
            pnlPrimary.TabIndex = 1;
            // 
            // style_Panel3
            // 
            style_Panel3.BackColor = Color.FromArgb(228, 112, 33);
            style_Panel3.Controls.Add(chart1);
            style_Panel3.CornerRadius = 30;
            style_Panel3.Location = new Point(6, 530);
            style_Panel3.Name = "style_Panel3";
            style_Panel3.Size = new Size(477, 319);
            style_Panel3.TabIndex = 2;
            // 
            // chart1
            // 
            chart1.BackColor = Color.FromArgb(228, 112, 33);
            chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chart1.BorderlineColor = Color.FromArgb(228, 112, 33);
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(0, 59);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(477, 260);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // FrmDash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1424, 861);
            Controls.Add(pnlPrimary);
            Controls.Add(pnlMenu);
            MaximizeBox = false;
            Name = "FrmDash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard Produção";
            Load += FrmDash_Load_1;
            pnlMenu.ResumeLayout(false);
            style_GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlPrimary.ResumeLayout(false);
            style_Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Style_Panel pnlMenu;
        private PictureBox pictureBox1;
        private Style_Panel pnlPrimary;
        private Style_GroupBox style_GroupBox1;
        private Style_Panel style_Panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
