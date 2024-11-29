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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguration));
            style_Panel1 = new Style_Panel();
            style_GroupBox1 = new Style_GroupBox();
            style_GroupBox3 = new Style_GroupBox();
            pictureBox1 = new PictureBox();
            gbItens = new Style_GroupBox();
            cbProduct = new ComboBox();
            btnDelete = new Style_Button();
            btnSave = new Style_Button();
            label1 = new Label();
            label4 = new Label();
            dtpDate = new DateTimePicker();
            txtCapacity = new TextBox();
            label2 = new Label();
            style_GroupBox2 = new Style_GroupBox();
            btnSearch = new Style_Button();
            rbSearch = new RadioButton();
            rbNew = new RadioButton();
            cbFiles = new ComboBox();
            label3 = new Label();
            btnAdd = new Style_Button();
            btnEdit = new Style_Button();
            btnErase = new Style_Button();
            style_Panel1.SuspendLayout();
            style_GroupBox1.SuspendLayout();
            style_GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbItens.SuspendLayout();
            style_GroupBox2.SuspendLayout();
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
            style_GroupBox1.Controls.Add(style_GroupBox3);
            style_GroupBox1.Controls.Add(gbItens);
            style_GroupBox1.Controls.Add(style_GroupBox2);
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
            // style_GroupBox3
            // 
            style_GroupBox3.BorderColor = Color.Snow;
            style_GroupBox3.BorderSize = 2;
            style_GroupBox3.Controls.Add(pictureBox1);
            style_GroupBox3.CornerRadius = 15;
            style_GroupBox3.Location = new Point(466, 14);
            style_GroupBox3.Name = "style_GroupBox3";
            style_GroupBox3.Size = new Size(137, 80);
            style_GroupBox3.TabIndex = 13;
            style_GroupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // gbItens
            // 
            gbItens.BorderColor = Color.Snow;
            gbItens.BorderSize = 2;
            gbItens.Controls.Add(cbProduct);
            gbItens.Controls.Add(btnDelete);
            gbItens.Controls.Add(btnSave);
            gbItens.Controls.Add(label1);
            gbItens.Controls.Add(label4);
            gbItens.Controls.Add(dtpDate);
            gbItens.Controls.Add(txtCapacity);
            gbItens.Controls.Add(label2);
            gbItens.CornerRadius = 15;
            gbItens.Font = new Font("Tahoma", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            gbItens.Location = new Point(6, 133);
            gbItens.Name = "gbItens";
            gbItens.Size = new Size(597, 208);
            gbItens.TabIndex = 12;
            gbItens.TabStop = false;
            gbItens.Text = "Adicionar itens";
            // 
            // cbProduct
            // 
            cbProduct.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbProduct.FormattingEnabled = true;
            cbProduct.Location = new Point(6, 40);
            cbProduct.Name = "cbProduct";
            cbProduct.Size = new Size(157, 24);
            cbProduct.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(247, 0, 29);
            btnDelete.CornerRadius = 15;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Tahoma", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleRight;
            btnDelete.Location = new Point(6, 160);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 42);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "APAGAR";
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(65, 182, 5);
            btnSave.CornerRadius = 15;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(475, 160);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 42);
            btnSave.TabIndex = 0;
            btnSave.Text = "SALVAR";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 21);
            label1.Name = "label1";
            label1.Size = new Size(102, 16);
            label1.TabIndex = 3;
            label1.Text = "Tipo de Estojo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 72);
            label4.Name = "label4";
            label4.Size = new Size(132, 16);
            label4.TabIndex = 10;
            label4.Text = "Definir Capacidade:";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDate.Location = new Point(172, 41);
            dtpDate.MaxDate = new DateTime(2070, 12, 31, 0, 0, 0, 0);
            dtpDate.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(272, 23);
            dtpDate.TabIndex = 7;
            // 
            // txtCapacity
            // 
            txtCapacity.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCapacity.Location = new Point(6, 91);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(157, 23);
            txtCapacity.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(172, 21);
            label2.Name = "label2";
            label2.Size = new Size(43, 16);
            label2.TabIndex = 4;
            label2.Text = "Data:";
            // 
            // style_GroupBox2
            // 
            style_GroupBox2.BorderColor = Color.Gray;
            style_GroupBox2.BorderSize = 2;
            style_GroupBox2.Controls.Add(btnSearch);
            style_GroupBox2.Controls.Add(rbSearch);
            style_GroupBox2.Controls.Add(rbNew);
            style_GroupBox2.Controls.Add(cbFiles);
            style_GroupBox2.Controls.Add(label3);
            style_GroupBox2.Controls.Add(btnAdd);
            style_GroupBox2.Controls.Add(btnEdit);
            style_GroupBox2.Controls.Add(btnErase);
            style_GroupBox2.CornerRadius = 15;
            style_GroupBox2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            style_GroupBox2.Location = new Point(6, 26);
            style_GroupBox2.Name = "style_GroupBox2";
            style_GroupBox2.Size = new Size(350, 88);
            style_GroupBox2.TabIndex = 8;
            style_GroupBox2.TabStop = false;
            style_GroupBox2.Text = "Configurador";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(194, 197, 201);
            btnSearch.CornerRadius = 30;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(310, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(31, 30);
            btnSearch.TabIndex = 13;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // rbSearch
            // 
            rbSearch.AutoSize = true;
            rbSearch.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbSearch.Location = new Point(246, 0);
            rbSearch.Name = "rbSearch";
            rbSearch.Size = new Size(88, 20);
            rbSearch.TabIndex = 9;
            rbSearch.TabStop = true;
            rbSearch.Text = "Pesquisar";
            rbSearch.UseVisualStyleBackColor = true;
            // 
            // rbNew
            // 
            rbNew.AutoSize = true;
            rbNew.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbNew.Location = new Point(173, 0);
            rbNew.Name = "rbNew";
            rbNew.Size = new Size(57, 20);
            rbNew.TabIndex = 10;
            rbNew.TabStop = true;
            rbNew.Text = "Novo";
            rbNew.UseVisualStyleBackColor = true;
            // 
            // cbFiles
            // 
            cbFiles.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbFiles.FormattingEnabled = true;
            cbFiles.Location = new Point(6, 43);
            cbFiles.Name = "cbFiles";
            cbFiles.Size = new Size(177, 24);
            cbFiles.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 24);
            label3.Name = "label3";
            label3.Size = new Size(70, 16);
            label3.TabIndex = 11;
            label3.Text = "Arquivos:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(139, 206, 145);
            btnAdd.CornerRadius = 30;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(199, 38);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(31, 30);
            btnAdd.TabIndex = 10;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(230, 201, 82);
            btnEdit.CornerRadius = 30;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new Point(236, 38);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(31, 30);
            btnEdit.TabIndex = 9;
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnErase
            // 
            btnErase.BackColor = Color.FromArgb(221, 78, 75);
            btnErase.CornerRadius = 30;
            btnErase.Cursor = Cursors.Hand;
            btnErase.FlatAppearance.BorderSize = 0;
            btnErase.FlatStyle = FlatStyle.Flat;
            btnErase.Image = (Image)resources.GetObject("btnErase.Image");
            btnErase.Location = new Point(273, 38);
            btnErase.Name = "btnErase";
            btnErase.Size = new Size(31, 30);
            btnErase.TabIndex = 0;
            btnErase.UseVisualStyleBackColor = false;
            // 
            // FrmConfiguration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 362);
            Controls.Add(style_Panel1);
            Name = "FrmConfiguration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConfiguration";
            Load += FrmConfiguration_Load;
            style_Panel1.ResumeLayout(false);
            style_GroupBox1.ResumeLayout(false);
            style_GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbItens.ResumeLayout(false);
            gbItens.PerformLayout();
            style_GroupBox2.ResumeLayout(false);
            style_GroupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Style_Panel style_Panel1;
        private Style_GroupBox style_GroupBox1;
        private Style_Button btnSave;
        private Label label2;
        private Label label1;
        private ComboBox cbProduct;
        private DateTimePicker dtpDate;
        private Style_GroupBox style_GroupBox2;
        private Style_Button btnErase;
        private Style_Button btnAdd;
        private Style_Button btnEdit;
        private ComboBox cbFiles;
        private Label label3;
        private Label label4;
        private TextBox txtCapacity;
        private RadioButton rbSearch;
        private RadioButton rbNew;
        private Style_Button btnSearch;
        private Style_Button btnDelete;
        private Style_GroupBox style_GroupBox3;
        private Style_GroupBox gbItens;
        private PictureBox pictureBox1;
    }
}