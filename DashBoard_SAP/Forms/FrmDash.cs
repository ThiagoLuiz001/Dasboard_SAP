using System;
using System.Security.Cryptography.Pkcs;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DashBoard_SAP.Models.Entities;
using DashBoard_SAP.Services;
namespace DashBoard_SAP
{
    public partial class FrmDash : Form
    {
        private int lx = 22, ly = 30;

        private void SizeScreen()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height - 30;
            this.Size = new Size(screenWidth, screenHeight);
            this.pnlMenu.Size = new Size((int)Math.Ceiling(screenWidth * 0.12), pnlMenu.Height);
        }/// <summary>
         /// Cria os displays do produto na tela
         /// </summary>
         /// <param name="prod"></param>
        private void CreationItensPainel(Production prod)
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
                Location = new Point(lx == 22 ? 22 : lx, ly)
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
                Font = new Font("Tahoma", Font.GetNewHeight(16), FontStyle.Bold | FontStyle.Italic),
                BackColor = Color.FromArgb(228, 112, 33),
                ForeColor = Color.Snow,
                Size = new Size(Size.GetNewSizeX(150), 30),
                Text = prod.Product,
                Location = new Point(picture.Width + 25 + picture.Location.X, picture.Location.Y),

            };
            var desccription = new Label
            {
                Font = new Font("Tahoma", Font.GetNewHeight(8), FontStyle.Bold),
                BackColor = Color.FromArgb(228, 112, 33),
                ForeColor = Color.Snow,
                Size = new Size(Size.GetNewSizeX(300), 150),
                Location = new Point(picture.Width + 7 + picture.Location.X, title.Location.Y + 40),
                Text = $"Capacidade: {prod.Capacity.ToString("F0")} UN" +
                $"\n\nProduzindo: {prod._Production.ToString("F0")} UN" +
                $"\n\nCap. Atual: {prod.Consumption.ToString("F0")} UN"
            };


            painel.Controls.Add(picture);
            painel.Controls.Add(title);
            painel.Controls.Add(desccription);
            this.pnlPrimary.Controls.Add(painel);
            lx += (int)Math.Ceiling(width * (22.0 / 100)) + 22;


        }
        /// <summary>
        /// Cria os graficos da pagina
        /// </summary>
        private void CreationGraphicPainel()
        {
            
            int initX = 22, initY = (int)Math.Ceiling(pnlPrimary.Height * 0.43), width = pnlPrimary.Width;
            // Primeiro Grafico________________________________________________________________
            var painel1 = new Style_Panel
            {
                Location = new Point(initX, initY),
                BackColor = Color.FromArgb(228, 112, 33),
                Width = (int)Math.Ceiling((width * 0.22) * 2.5 + 22),
                Height = (int)Math.Ceiling(pnlPrimary.Height * 0.53)
            };
            var title1 = new Label
            {
                Font = new Font("Tahoma", Font.GetNewHeight(18), FontStyle.Bold | FontStyle.Italic),
                BackColor = Color.FromArgb(228, 112, 33),
                ForeColor = Color.Snow,
                Size = new Size(Size.GetNewSizeX(500), 30),
                Text = "Grafico de Produção X Capacidade",
                Location = new Point((int)Math.Ceiling(painel1.Width / 4.5), 10),
            };
            var graphics1 = new Chart
            {
                BackColor = Color.FromArgb(228, 112, 33),
                BackGradientStyle = GradientStyle.TopBottom,
                Location = new Point(0, title1.Size.Height + 50),
                Size = new Size(painel1.Size.Width , painel1.Size.Height - title1.Size.Height - 50),
                ForeColor = Color.Black,


            };

            var legend = new Legend("Producao")
            {
                Title = "Legendas", 
                Docking = Docking.Right, 
                Alignment = StringAlignment.Near
            };
            graphics1.Legends.Add(legend);
            graphics1.ChartAreas.Add("Capacidade");
            graphics1.ChartAreas[0].AxisX.Title = "Produtos";
            graphics1.ChartAreas[0].AxisY.Title = "Produção";
            graphics1.ChartAreas[0].AxisX.Interval = 1;

            var seriesA = new Series("Produção")
            {
                ChartType = SeriesChartType.StackedBar,
                LabelForeColor = Color.Black,
                Color = Color.FromArgb(228,111,30),
                Legend = "Producao"
            };
            double m = 0;
            foreach (var prod in Variables.Prod)
            {
                seriesA.Points.AddXY(m, prod.Value._Production);

                m++;
            }
            var seriesB = new Series("Capacidade")
            {
                ChartType = SeriesChartType.StackedBar,
                Color = Color.Gray,
                Legend = "Producao"
            };
            m = 0;
            foreach (var prod in Variables.Prod)
            {
                seriesB.Points.AddXY(m, prod.Value.Capacity - prod.Value._Production);
                m++;
            }
            graphics1.Series.Add(seriesA);
            graphics1.Series.Add(seriesB);
            m = -0.4;
            foreach(var prod in Variables.Prod.Values)
            {
                graphics1.ChartAreas[0].AxisX.CustomLabels.Add(m, m +1, prod.Product);
                m++;
            }



            painel1.Controls.Add(title1);
            painel1.Controls.Add(graphics1);


            //Grafico 2 _________________________________________________________________
            var painel2 = new Style_Panel
            {
                Location = new Point(initX + painel1.Width + 22, initY),
                BackColor = Color.FromArgb(228, 112, 33),
                Width = (int)Math.Ceiling((width * 0.22) * 1.5 + 22),
                Height = (int)Math.Ceiling(pnlPrimary.Height * 0.53)
            };
            var group2 = new Style_GroupBox
            {
                Location = new Point(10, 10),
                BorderColor = Color.Snow,
                BackColor = painel2.BackColor,
                ForeColor = Color.Snow,
                Font = title1.Font,
                Size = new Size(painel2.Width - 22, painel2.Height - 20),
                Text = "Grafico de Produção do Item"
            };
            painel2.Controls.Add(group2);
            this.pnlPrimary.Controls.Add(painel1);
            this.pnlPrimary.Controls.Add(painel2);

        }


        private void AdjustSizes()
        {
            groupImage.Size = new Size(pnlMenu.Width - 10, (int)Math.Ceiling(pnlMenu.Height * .13));
            logo.Size = new Size(groupImage.Width - 20, groupImage.Height - 20);
        }

        public FrmDash()
        {
            InitializeComponent();
            SizeScreen();
            var p1 = new Production("Injetado", 800, 600, DateTime.Now);
            var p2 = new Production("Purse", 1200, 1200, DateTime.Now);
            var p3 = new Production("Diplomata", 8000, 6555, DateTime.Now);
            var p4 = new Production("Especial", 900, 400, DateTime.Now);
            var p5 = new Production("Cartucho", 1000, 904, DateTime.Now);
            Variables.Prod.Add(p1._Key(), p1);
            Variables.Prod.Add(p2._Key(), p2);
            Variables.Prod.Add(p3._Key(), p3);
            Variables.Prod.Add(p4._Key(), p4);
            Variables.Prod.Add(p5._Key(), p5);
            foreach (var prod in Variables.Prod.Values)
            {
                CreationItensPainel(prod);
            }
            CreationGraphicPainel();
            AdjustSizes();

        }

        private void FrmDash_Load_1(object sender, EventArgs e)
        {

        }
    }
}
