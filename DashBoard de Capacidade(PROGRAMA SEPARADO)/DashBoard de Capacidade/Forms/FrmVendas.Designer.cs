namespace DashBoard_de_Capacidade.Forms
{
    partial class FrmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendas));
            label1 = new Label();
            cbEstojo = new ComboBox();
            label2 = new Label();
            rtxtUnidades = new RichTextBox();
            btnLancar = new Button();
            gradeVendas = new DataGridView();
            clEstojo = new DataGridViewTextBoxColumn();
            clQtd = new DataGridViewTextBoxColumn();
            clApagar = new DataGridViewButtonColumn();
            btnRegistrar = new Button();
            ((System.ComponentModel.ISupportInitialize)gradeVendas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10F);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 17);
            label1.TabIndex = 0;
            label1.Text = "Estojo Vendido:";
            // 
            // cbEstojo
            // 
            cbEstojo.FlatStyle = FlatStyle.Flat;
            cbEstojo.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbEstojo.FormattingEnabled = true;
            cbEstojo.Items.AddRange(new object[] { "", "Injetado", "Diplomata", "Cartucho", "Purse", "Especial" });
            cbEstojo.Location = new Point(15, 29);
            cbEstojo.Name = "cbEstojo";
            cbEstojo.Size = new Size(140, 24);
            cbEstojo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(102, 17);
            label2.TabIndex = 2;
            label2.Text = "Unid. Vendidas:";
            // 
            // rtxtUnidades
            // 
            rtxtUnidades.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxtUnidades.Location = new Point(12, 90);
            rtxtUnidades.Name = "rtxtUnidades";
            rtxtUnidades.Size = new Size(143, 109);
            rtxtUnidades.TabIndex = 3;
            rtxtUnidades.Text = "";
            // 
            // btnLancar
            // 
            btnLancar.FlatAppearance.BorderSize = 0;
            btnLancar.FlatAppearance.MouseDownBackColor = Color.FromArgb(152, 74, 22);
            btnLancar.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 112, 33);
            btnLancar.FlatStyle = FlatStyle.Flat;
            btnLancar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLancar.ForeColor = Color.Snow;
            btnLancar.Image = (Image)resources.GetObject("btnLancar.Image");
            btnLancar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLancar.Location = new Point(12, 219);
            btnLancar.Name = "btnLancar";
            btnLancar.Size = new Size(143, 39);
            btnLancar.TabIndex = 4;
            btnLancar.Text = "&Salvar";
            btnLancar.UseVisualStyleBackColor = true;
            btnLancar.Click += btnLancar_Click;
            // 
            // gradeVendas
            // 
            gradeVendas.AllowUserToAddRows = false;
            gradeVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gradeVendas.Columns.AddRange(new DataGridViewColumn[] { clEstojo, clQtd, clApagar });
            gradeVendas.Location = new Point(214, 29);
            gradeVendas.Name = "gradeVendas";
            gradeVendas.ShowEditingIcon = false;
            gradeVendas.Size = new Size(265, 229);
            gradeVendas.TabIndex = 5;
            // 
            // clEstojo
            // 
            clEstojo.HeaderText = "Estojo";
            clEstojo.Name = "clEstojo";
            // 
            // clQtd
            // 
            clQtd.HeaderText = "Unidades";
            clQtd.Name = "clQtd";
            clQtd.Width = 60;
            // 
            // clApagar
            // 
            clApagar.HeaderText = "Apagar";
            clApagar.Name = "clApagar";
            clApagar.Width = 60;
            // 
            // btnRegistrar
            // 
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(152, 74, 22);
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 112, 33);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.Snow;
            btnRegistrar.Image = (Image)resources.GetObject("btnRegistrar.Image");
            btnRegistrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrar.Location = new Point(350, 264);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(129, 39);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "&Registrar";
            btnRegistrar.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // FrmVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(491, 331);
            Controls.Add(btnRegistrar);
            Controls.Add(gradeVendas);
            Controls.Add(btnLancar);
            Controls.Add(rtxtUnidades);
            Controls.Add(label2);
            Controls.Add(cbEstojo);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FrmVendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVendas";
            ((System.ComponentModel.ISupportInitialize)gradeVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbEstojo;
        private Label label2;
        private RichTextBox rtxtUnidades;
        private Button btnLancar;
        private DataGridView gradeVendas;
        private DataGridViewTextBoxColumn clEstojo;
        private DataGridViewTextBoxColumn clQtd;
        private DataGridViewButtonColumn clApagar;
        private Button btnRegistrar;
    }
}