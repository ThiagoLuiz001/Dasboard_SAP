using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DashBoard_SAP.Models.Enums;
namespace DashBoard_SAP.Forms
{
    public partial class FrmConfiguration : Form
    {
        private void Loadproducts()
        {
            var enums = typeof(EnumProd).GetFields();
            foreach (var en in enums)
            {
                string tipo = en.Name.ToString().Replace('_', ' ');
                if (tipo != "value  ")
                    cbProduct.Items.Add(tipo);
            }
        }



        public FrmConfiguration()
        {
            InitializeComponent();
        }

        private void FrmConfiguration_Load(object sender, EventArgs e)
        {
            Loadproducts();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}
