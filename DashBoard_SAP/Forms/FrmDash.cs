using System;
using System.Security.Cryptography.Pkcs;
using System.Windows.Forms;
using DashBoard_SAP.Models.Entities;
using DashBoard_SAP.Services;
namespace DashBoard_SAP
{
    public partial class FrmDash : Form
    {
        private int lx = 22, ly =30;

        private void SizeScreen()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height -30;
            this.Size = new Size(screenWidth, screenHeight);
            this.pnlMenu.Size = new Size((int)Math.Ceiling(screenWidth * 0.12), pnlMenu.Height);
        }/// <summary>
        /// Cria os displays do produto na tela
        /// </summary>
        /// <param name="prod"></param>
        private void CreationStylePainel(Production prod)
        {
            int width = pnlPrimary.Width, height = pnlPrimary.Height;
            if (lx + (int)Math.Ceiling(width * (22.0 / 100)) > pnlPrimary.Width)
            {
                ly += ((int)Math.Ceiling(height * (17.0 / 100)) + 22);
                lx = 22;
            }
            
            var painel = new Style_Panel
            {
                Width = (int)Math.Ceiling(width * 0.22),
                Height = (int)Math.Ceiling(height * 0.17),
                BackColor = Color.FromArgb(228, 112, 33),
                Location = new Point(lx ==22? 22: lx, ly) 
            };
            var picture = new PictureBox
            {
                Height = painel.Height,
                Width = (int)Math.Ceiling((painel.Width * 0.4)),
                Image = Properties.Resources.porta_bugigangas,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            var title = new Label
            {
                Font = new Font("Tahoma",Font.GetNewHeight(16),FontStyle.Bold | FontStyle.Italic),
                BackColor = Color.FromArgb(228,112,33),
                ForeColor = Color.Snow,
                Size = new Size(Size.GetNewSizeX(150),30) 
                Text = prod.Product,
                Location =  new Point(picture.Width + 25 + picture.Location.X, picture.Location.Y ),
                
            };
            var desccription = new Label
            {
                Font = new Font("Tahoma",Font.GetNewHeight(8), FontStyle.Bold),
                BackColor = Color.FromArgb(228, 112, 33),
                ForeColor = Color.Snow,
                Size = new Size(Size.GetNewSizeX(300), 150),
                Location = new Point(picture.Width + 7 + picture.Location.X, title.Location.Y + 40 ),
                Text =$"Capacidade: {prod.Capacity.ToString("F2")} UN" +
                $"\n\nProduzindo: {prod._Production.ToString("F2")} UN" +
                $"\n\nCap. Atual: {prod.Consumption.ToString("F2")} UN"
            };


            painel.Controls.Add(picture);
            painel.Controls.Add(title);
            painel.Controls.Add(desccription);
            this.pnlPrimary.Controls.Add(painel);
            lx += (int)Math.Ceiling(width * (22.0 / 100)) +22;


        }

        public FrmDash()
        {
            InitializeComponent();
            SizeScreen();
            var p1 = new Production("Injetado", 800, 600, DateTime.Now);
            var p2 = new Production("Purse", 1200, 1200, DateTime.Now);
            var p3 = new Production("Diplomata", 8000, 6555, DateTime.Now);
            var p4 = new Production("Matheus", 10, 4, DateTime.Now);
            Variables.Prod.Add(p1._Key(),p1);
            Variables.Prod.Add(p2._Key(), p2);
            Variables.Prod.Add(p3._Key(), p3);
            Variables.Prod.Add(p4._Key(), p4);
            foreach (var prod in Variables.Prod.Values){
                CreationStylePainel(prod);
            }
            
        
        }

        private void FrmDash_Load_1(object sender, EventArgs e)
        {

        }
    }
}
