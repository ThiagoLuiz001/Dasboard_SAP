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
using DashBoard_SAP.DAO.Local;
namespace DashBoard_SAP.Forms
{
    public partial class FrmConfiguration : Form
    {
        private void LoadFolders()
        {
            var folder = Capacity.LoadFiles();
            foreach (var f in folder)
            {
                cbFiles.Items.Add(f);
            }
        }
        private void CheckForm()
        {

            if (rbNew.Checked)
            {
                cbFiles.Enabled = false;
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnErase.Enabled = false;
                btnSearch.Enabled = false;
                gbItens.Enabled = true;
                btnDelete.Visible = false;
            }
            else
            {
                cbFiles.Enabled = true;
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnErase.Enabled = true;
                btnSearch.Enabled = true;
                gbItens.Enabled = false;
                btnDelete.Visible = true;
            }
        }
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

        private void rbNew_CheckedChanged(object sender, EventArgs e)
        {
            CheckForm();
        }

        private void rbSearch_CheckedChanged(object sender, EventArgs e)
        {
            CheckForm();
            LoadFolders();
        }
    }
}
