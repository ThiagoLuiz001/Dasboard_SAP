namespace DashBoard_de_Capacidade
{
    partial class FrmDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashBoard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelMenu = new Panel();
            btnAtualizar = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            lblInjStatus = new Label();
            lblInjVendidos = new Label();
            lblInjCapacidade = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel11 = new Panel();
            chartCapacidade = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel12 = new Panel();
            pictureBox7 = new PictureBox();
            label42 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            lblDiploStatus = new Label();
            lblDiploVendidos = new Label();
            lblDiploCapacidade = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            panel3 = new Panel();
            label15 = new Label();
            pictureBox4 = new PictureBox();
            lblCartStatus = new Label();
            lblCartVendidos = new Label();
            lblCartCapacidade = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            panel4 = new Panel();
            label22 = new Label();
            pictureBox5 = new PictureBox();
            lblPurseStatus = new Label();
            lblPurseVendidos = new Label();
            lblPurseCapacidade = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            panel5 = new Panel();
            label29 = new Label();
            pictureBox6 = new PictureBox();
            lblEspecStatus = new Label();
            lblEspecVendidos = new Label();
            lblEspecCapacidade = new Label();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            panel6 = new Panel();
            label37 = new Label();
            lblTotal = new Label();
            label36 = new Label();
            pictureBox8 = new PictureBox();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartCapacidade).BeginInit();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 31, 31);
            panelMenu.Controls.Add(btnAtualizar);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 746);
            panelMenu.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(152, 74, 22);
            btnAtualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 112, 33);
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtualizar.ForeColor = Color.Snow;
            btnAtualizar.Image = (Image)resources.GetObject("btnAtualizar.Image");
            btnAtualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAtualizar.Location = new Point(3, 168);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(207, 41);
            btnAtualizar.TabIndex = 3;
            btnAtualizar.Text = "&Atualizar Cálculo";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 109);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 112, 33);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lblInjStatus);
            panel1.Controls.Add(lblInjVendidos);
            panel1.Controls.Add(lblInjCapacidade);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(235, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 136);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(153, 3);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 8;
            label1.Text = "Injetado";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(127, 130);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // lblInjStatus
            // 
            lblInjStatus.AutoSize = true;
            lblInjStatus.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblInjStatus.ForeColor = Color.Snow;
            lblInjStatus.Location = new Point(196, 96);
            lblInjStatus.Name = "lblInjStatus";
            lblInjStatus.Size = new Size(19, 16);
            lblInjStatus.TabIndex = 6;
            lblInjStatus.Text = "--";
            // 
            // lblInjVendidos
            // 
            lblInjVendidos.AutoSize = true;
            lblInjVendidos.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblInjVendidos.ForeColor = Color.Snow;
            lblInjVendidos.Location = new Point(211, 70);
            lblInjVendidos.Name = "lblInjVendidos";
            lblInjVendidos.Size = new Size(19, 16);
            lblInjVendidos.TabIndex = 5;
            lblInjVendidos.Text = "--";
            // 
            // lblInjCapacidade
            // 
            lblInjCapacidade.AutoSize = true;
            lblInjCapacidade.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblInjCapacidade.ForeColor = Color.Snow;
            lblInjCapacidade.Location = new Point(213, 42);
            lblInjCapacidade.Name = "lblInjCapacidade";
            lblInjCapacidade.Size = new Size(19, 16);
            lblInjCapacidade.TabIndex = 4;
            lblInjCapacidade.Text = "--";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(138, 98);
            label4.Name = "label4";
            label4.Size = new Size(52, 14);
            label4.TabIndex = 3;
            label4.Text = "Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(138, 71);
            label3.Name = "label3";
            label3.Size = new Size(67, 14);
            label3.TabIndex = 2;
            label3.Text = "Vendidos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(136, 42);
            label2.Name = "label2";
            label2.Size = new Size(80, 14);
            label2.TabIndex = 1;
            label2.Text = "Capacidade:";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(31, 31, 31);
            panel11.Controls.Add(chartCapacidade);
            panel11.Controls.Add(panel12);
            panel11.Location = new Point(235, 342);
            panel11.Name = "panel11";
            panel11.Size = new Size(644, 355);
            panel11.TabIndex = 10;
            // 
            // chartCapacidade
            // 
            chartCapacidade.BackColor = Color.FromArgb(228, 112, 33);
            chartCapacidade.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartCapacidade.BorderlineColor = Color.FromArgb(228, 112, 33);
            chartArea1.Name = "ChartArea1";
            chartCapacidade.ChartAreas.Add(chartArea1);
            chartCapacidade.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartCapacidade.Legends.Add(legend1);
            chartCapacidade.Location = new Point(0, 76);
            chartCapacidade.Name = "chartCapacidade";
            chartCapacidade.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            chartCapacidade.PaletteCustomColors = new Color[]
    {
    Color.FromArgb(228, 112, 33),
    Color.SpringGreen
    };
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            chartCapacidade.Series.Add(series1);
            chartCapacidade.Series.Add(series2);
            chartCapacidade.Size = new Size(644, 279);
            chartCapacidade.TabIndex = 1;
            chartCapacidade.Text = "chart1";
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(228, 112, 33);
            panel12.Controls.Add(pictureBox7);
            panel12.Controls.Add(label42);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(644, 76);
            panel12.TabIndex = 0;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(11, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(78, 66);
            pictureBox7.TabIndex = 4;
            pictureBox7.TabStop = false;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Tahoma", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label42.ForeColor = Color.Snow;
            label42.Location = new Point(104, 19);
            label42.Name = "label42";
            label42.Size = new Size(479, 39);
            label42.TabIndex = 3;
            label42.Text = "Grafico Capacidade x Vendas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(228, 112, 33);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(lblDiploStatus);
            panel2.Controls.Add(lblDiploVendidos);
            panel2.Controls.Add(lblDiploCapacidade);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label14);
            panel2.Location = new Point(586, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 136);
            panel2.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Snow;
            label8.Location = new Point(154, 3);
            label8.Name = "label8";
            label8.Size = new Size(121, 25);
            label8.TabIndex = 8;
            label8.Text = "Diplomata";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(127, 130);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // lblDiploStatus
            // 
            lblDiploStatus.AutoSize = true;
            lblDiploStatus.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDiploStatus.ForeColor = Color.Snow;
            lblDiploStatus.Location = new Point(196, 96);
            lblDiploStatus.Name = "lblDiploStatus";
            lblDiploStatus.Size = new Size(19, 16);
            lblDiploStatus.TabIndex = 6;
            lblDiploStatus.Text = "--";
            // 
            // lblDiploVendidos
            // 
            lblDiploVendidos.AutoSize = true;
            lblDiploVendidos.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDiploVendidos.ForeColor = Color.Snow;
            lblDiploVendidos.Location = new Point(211, 70);
            lblDiploVendidos.Name = "lblDiploVendidos";
            lblDiploVendidos.Size = new Size(19, 16);
            lblDiploVendidos.TabIndex = 5;
            lblDiploVendidos.Text = "--";
            // 
            // lblDiploCapacidade
            // 
            lblDiploCapacidade.AutoSize = true;
            lblDiploCapacidade.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDiploCapacidade.ForeColor = Color.Snow;
            lblDiploCapacidade.Location = new Point(213, 42);
            lblDiploCapacidade.Name = "lblDiploCapacidade";
            lblDiploCapacidade.Size = new Size(19, 16);
            lblDiploCapacidade.TabIndex = 4;
            lblDiploCapacidade.Text = "--";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Snow;
            label12.Location = new Point(138, 98);
            label12.Name = "label12";
            label12.Size = new Size(52, 14);
            label12.TabIndex = 3;
            label12.Text = "Status:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Snow;
            label13.Location = new Point(138, 71);
            label13.Name = "label13";
            label13.Size = new Size(67, 14);
            label13.TabIndex = 2;
            label13.Text = "Vendidos:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Snow;
            label14.Location = new Point(136, 42);
            label14.Name = "label14";
            label14.Size = new Size(80, 14);
            label14.TabIndex = 1;
            label14.Text = "Capacidade:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(228, 112, 33);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(lblCartStatus);
            panel3.Controls.Add(lblCartVendidos);
            panel3.Controls.Add(lblCartCapacidade);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label21);
            panel3.Location = new Point(940, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(293, 136);
            panel3.TabIndex = 12;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Snow;
            label15.Location = new Point(159, 3);
            label15.Name = "label15";
            label15.Size = new Size(96, 23);
            label15.TabIndex = 8;
            label15.Text = "Cartucho";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(127, 130);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // lblCartStatus
            // 
            lblCartStatus.AutoSize = true;
            lblCartStatus.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCartStatus.ForeColor = Color.Snow;
            lblCartStatus.Location = new Point(196, 96);
            lblCartStatus.Name = "lblCartStatus";
            lblCartStatus.Size = new Size(19, 16);
            lblCartStatus.TabIndex = 6;
            lblCartStatus.Text = "--";
            // 
            // lblCartVendidos
            // 
            lblCartVendidos.AutoSize = true;
            lblCartVendidos.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCartVendidos.ForeColor = Color.Snow;
            lblCartVendidos.Location = new Point(211, 70);
            lblCartVendidos.Name = "lblCartVendidos";
            lblCartVendidos.Size = new Size(19, 16);
            lblCartVendidos.TabIndex = 5;
            lblCartVendidos.Text = "--";
            // 
            // lblCartCapacidade
            // 
            lblCartCapacidade.AutoSize = true;
            lblCartCapacidade.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCartCapacidade.ForeColor = Color.Snow;
            lblCartCapacidade.Location = new Point(213, 42);
            lblCartCapacidade.Name = "lblCartCapacidade";
            lblCartCapacidade.Size = new Size(19, 16);
            lblCartCapacidade.TabIndex = 4;
            lblCartCapacidade.Text = "--";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Snow;
            label19.Location = new Point(138, 98);
            label19.Name = "label19";
            label19.Size = new Size(52, 14);
            label19.TabIndex = 3;
            label19.Text = "Status:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Snow;
            label20.Location = new Point(138, 71);
            label20.Name = "label20";
            label20.Size = new Size(67, 14);
            label20.TabIndex = 2;
            label20.Text = "Vendidos:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.Snow;
            label21.Location = new Point(136, 42);
            label21.Name = "label21";
            label21.Size = new Size(80, 14);
            label21.TabIndex = 1;
            label21.Text = "Capacidade:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(228, 112, 33);
            panel4.Controls.Add(label22);
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(lblPurseStatus);
            panel4.Controls.Add(lblPurseVendidos);
            panel4.Controls.Add(lblPurseCapacidade);
            panel4.Controls.Add(label26);
            panel4.Controls.Add(label27);
            panel4.Controls.Add(label28);
            panel4.Location = new Point(235, 181);
            panel4.Name = "panel4";
            panel4.Size = new Size(293, 136);
            panel4.TabIndex = 13;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Tahoma", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Snow;
            label22.Location = new Point(153, 3);
            label22.Name = "label22";
            label22.Size = new Size(71, 25);
            label22.TabIndex = 8;
            label22.Text = "Purse";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(127, 130);
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // lblPurseStatus
            // 
            lblPurseStatus.AutoSize = true;
            lblPurseStatus.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPurseStatus.ForeColor = Color.Snow;
            lblPurseStatus.Location = new Point(196, 96);
            lblPurseStatus.Name = "lblPurseStatus";
            lblPurseStatus.Size = new Size(19, 16);
            lblPurseStatus.TabIndex = 6;
            lblPurseStatus.Text = "--";
            // 
            // lblPurseVendidos
            // 
            lblPurseVendidos.AutoSize = true;
            lblPurseVendidos.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPurseVendidos.ForeColor = Color.Snow;
            lblPurseVendidos.Location = new Point(211, 70);
            lblPurseVendidos.Name = "lblPurseVendidos";
            lblPurseVendidos.Size = new Size(19, 16);
            lblPurseVendidos.TabIndex = 5;
            lblPurseVendidos.Text = "--";
            // 
            // lblPurseCapacidade
            // 
            lblPurseCapacidade.AutoSize = true;
            lblPurseCapacidade.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPurseCapacidade.ForeColor = Color.Snow;
            lblPurseCapacidade.Location = new Point(213, 42);
            lblPurseCapacidade.Name = "lblPurseCapacidade";
            lblPurseCapacidade.Size = new Size(19, 16);
            lblPurseCapacidade.TabIndex = 4;
            lblPurseCapacidade.Text = "--";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.Snow;
            label26.Location = new Point(138, 98);
            label26.Name = "label26";
            label26.Size = new Size(52, 14);
            label26.TabIndex = 3;
            label26.Text = "Status:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.Snow;
            label27.Location = new Point(138, 71);
            label27.Name = "label27";
            label27.Size = new Size(67, 14);
            label27.TabIndex = 2;
            label27.Text = "Vendidos:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.ForeColor = Color.Snow;
            label28.Location = new Point(136, 42);
            label28.Name = "label28";
            label28.Size = new Size(80, 14);
            label28.TabIndex = 1;
            label28.Text = "Capacidade:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(228, 112, 33);
            panel5.Controls.Add(label29);
            panel5.Controls.Add(pictureBox6);
            panel5.Controls.Add(lblEspecStatus);
            panel5.Controls.Add(lblEspecVendidos);
            panel5.Controls.Add(lblEspecCapacidade);
            panel5.Controls.Add(label33);
            panel5.Controls.Add(label34);
            panel5.Controls.Add(label35);
            panel5.Location = new Point(586, 181);
            panel5.Name = "panel5";
            panel5.Size = new Size(293, 136);
            panel5.TabIndex = 14;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Tahoma", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label29.ForeColor = Color.Snow;
            label29.Location = new Point(154, 3);
            label29.Name = "label29";
            label29.Size = new Size(97, 25);
            label29.TabIndex = 8;
            label29.Text = "Especial";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(127, 130);
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            // 
            // lblEspecStatus
            // 
            lblEspecStatus.AutoSize = true;
            lblEspecStatus.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEspecStatus.ForeColor = Color.Snow;
            lblEspecStatus.Location = new Point(196, 96);
            lblEspecStatus.Name = "lblEspecStatus";
            lblEspecStatus.Size = new Size(19, 16);
            lblEspecStatus.TabIndex = 6;
            lblEspecStatus.Text = "--";
            // 
            // lblEspecVendidos
            // 
            lblEspecVendidos.AutoSize = true;
            lblEspecVendidos.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEspecVendidos.ForeColor = Color.Snow;
            lblEspecVendidos.Location = new Point(211, 70);
            lblEspecVendidos.Name = "lblEspecVendidos";
            lblEspecVendidos.Size = new Size(19, 16);
            lblEspecVendidos.TabIndex = 5;
            lblEspecVendidos.Text = "--";
            // 
            // lblEspecCapacidade
            // 
            lblEspecCapacidade.AutoSize = true;
            lblEspecCapacidade.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEspecCapacidade.ForeColor = Color.Snow;
            lblEspecCapacidade.Location = new Point(213, 42);
            lblEspecCapacidade.Name = "lblEspecCapacidade";
            lblEspecCapacidade.Size = new Size(19, 16);
            lblEspecCapacidade.TabIndex = 4;
            lblEspecCapacidade.Text = "--";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label33.ForeColor = Color.Snow;
            label33.Location = new Point(138, 98);
            label33.Name = "label33";
            label33.Size = new Size(52, 14);
            label33.TabIndex = 3;
            label33.Text = "Status:";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label34.ForeColor = Color.Snow;
            label34.Location = new Point(138, 71);
            label34.Name = "label34";
            label34.Size = new Size(67, 14);
            label34.TabIndex = 2;
            label34.Text = "Vendidos:";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label35.ForeColor = Color.Snow;
            label35.Location = new Point(136, 42);
            label35.Name = "label35";
            label35.Size = new Size(80, 14);
            label35.TabIndex = 1;
            label35.Text = "Capacidade:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(228, 112, 33);
            panel6.Controls.Add(label37);
            panel6.Controls.Add(lblTotal);
            panel6.Controls.Add(label36);
            panel6.Controls.Add(pictureBox8);
            panel6.Location = new Point(940, 181);
            panel6.Name = "panel6";
            panel6.Size = new Size(361, 269);
            panel6.TabIndex = 15;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Tahoma", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label37.ForeColor = Color.Snow;
            label37.Location = new Point(76, 15);
            label37.Name = "label37";
            label37.Size = new Size(266, 39);
            label37.TabIndex = 19;
            label37.Text = "Lista de Vendas";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Snow;
            lblTotal.Location = new Point(249, 237);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(75, 18);
            lblTotal.TabIndex = 18;
            lblTotal.Text = "8000 UN";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.ForeColor = Color.Snow;
            label36.Location = new Point(72, 237);
            label36.Name = "label36";
            label36.Size = new Size(171, 18);
            label36.TabIndex = 17;
            label36.Text = "TOTAL DE UNIDADES:";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(3, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(67, 68);
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            // 
            // FrmDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 1, 1);
            ClientSize = new Size(1313, 746);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel11);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Name = "FrmDashBoard";
            Text = "Form1";
            TransparencyKey = Color.FromArgb(192, 0, 0);
            WindowState = FormWindowState.Maximized;
            Load += FrmDashBoard_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartCapacidade).EndInit();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private PictureBox pictureBox1;
        private Button btnAtualizar;
        private Panel panel1;
        private Label lblInjStatus;
        private Label lblInjVendidos;
        private Label lblInjCapacidade;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCapacidade;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label8;
        private PictureBox pictureBox3;
        private Label lblDiploStatus;
        private Label lblDiploVendidos;
        private Label lblDiploCapacidade;
        private Label label12;
        private Label label13;
        private Label label14;
        private Panel panel3;
        private Label label15;
        private PictureBox pictureBox4;
        private Label lblCartStatus;
        private Label lblCartVendidos;
        private Label lblCartCapacidade;
        private Label label19;
        private Label label20;
        private Label label21;
        private Panel panel4;
        private Label label22;
        private PictureBox pictureBox5;
        private Label lblPurseStatus;
        private Label lblPurseVendidos;
        private Label lblPurseCapacidade;
        private Label label26;
        private Label label27;
        private Label label28;
        private Panel panel5;
        private Label label29;
        private PictureBox pictureBox6;
        private Label lblEspecStatus;
        private Label lblEspecVendidos;
        private Label lblEspecCapacidade;
        private Label label33;
        private Label label34;
        private Label label35;
        private Panel panel12;
        private PictureBox pictureBox7;
        private Label label42;
        private Panel panel6;
        private PictureBox pictureBox8;
        private Label lblTotal;
        private Label label36;
        private Label label37;
    }
}
