using System;
using System.Windows.Forms;
namespace DashBoard_SAP
{
    public partial class FrmDash : Form
    {
        private void WidthDevice()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.Size = new Size(screenWidth, screenHeight);
        }
        public FrmDash()
        {
            InitializeComponent();
            WidthDevice();
        }

        private void FrmDash_Load(object sender, EventArgs e)
        {

        }
    }
}
