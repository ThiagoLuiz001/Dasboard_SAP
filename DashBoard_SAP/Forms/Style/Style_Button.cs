using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_SAP
{
    public class Style_Button : Button
    {
        private int _cornerRadius = 15;
        public int CornerRadius 
        { 
            get { return _cornerRadius; }
            set { _cornerRadius = value; }
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Definir a borda arredondada
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, _cornerRadius, _cornerRadius, 180, 90); // Canto superior esquerdo
            path.AddArc(this.Width - _cornerRadius - 1, 0, _cornerRadius, _cornerRadius, 270, 90); // Canto superior direito
            path.AddArc(this.Width - _cornerRadius - 1, this.Height - _cornerRadius - 1, _cornerRadius, _cornerRadius, 0, 90); // Canto inferior direito
            path.AddArc(0, this.Height - _cornerRadius - 1, _cornerRadius, _cornerRadius, 90, 90); // Canto inferior esquerdo
            path.CloseFigure();

            // Aplicar a borda arredondada ao botão
            this.Region = new Region(path);

            
            
        }
    }
}
