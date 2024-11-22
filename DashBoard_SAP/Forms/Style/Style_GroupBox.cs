using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DashBoard_SAP
{
    public class Style_GroupBox : GroupBox
    {
        private int _cornerRadius = 15; // Raio dos cantos arredondados
        private Color _borderColor = Color.Gray; // Cor da borda
        private int _borderSize = 2; // Tamanho da borda

        public int CornerRadius
        {
            get { return _cornerRadius; }
            set { _cornerRadius = value; this.Invalidate(); } // Redesenha o controle ao alterar
        }

        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; this.Invalidate(); } // Redesenha o controle ao alterar
        }

        public int BorderSize
        {
            get { return _borderSize; }
            set { _borderSize = value; this.Invalidate(); } // Redesenha o controle ao alterar
        }

        public Style_GroupBox()
        {
            this.BorderColor = _borderColor;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            // Limpar a área do GroupBox para evitar sobreposições
            e.Graphics.Clear(this.BackColor);

            // Definir o estilo de suavização
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Medir o título e definir o retângulo de borda
            Size textSize = TextRenderer.MeasureText(this.Text, this.Font);
            Rectangle borderRectangle = new Rectangle(0, textSize.Height / 2, this.Width - 1, this.Height - textSize.Height / 2 - 1);

            // Criar o caminho para a borda arredondada
            GraphicsPath path = new GraphicsPath();
            path.AddArc(borderRectangle.X, borderRectangle.Y, _cornerRadius, _cornerRadius, 180, 90); // Canto superior esquerdo
            path.AddArc(borderRectangle.Right - _cornerRadius, borderRectangle.Y, _cornerRadius, _cornerRadius, 270, 90); // Canto superior direito
            path.AddArc(borderRectangle.Right - _cornerRadius, borderRectangle.Bottom - _cornerRadius, _cornerRadius, _cornerRadius, 0, 90); // Canto inferior direito
            path.AddArc(borderRectangle.X, borderRectangle.Bottom - _cornerRadius, _cornerRadius, _cornerRadius, 90, 90); // Canto inferior esquerdo
            path.CloseFigure();

            // Desenhar a borda arredondada
            using (Pen pen = new Pen(_borderColor, _borderSize))
            {
                e.Graphics.DrawPath(pen, path);
            }

            // Desenhar o texto do título
            Rectangle textRectangle = new Rectangle(10, 0, textSize.Width, textSize.Height);
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), textRectangle);
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, textRectangle.Location, this.ForeColor);
        }
    }
}