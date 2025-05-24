using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimPomBro
{
    public partial class frmEtatVehicule : Form
    {
        public frmEtatVehicule()
        {
            InitializeComponent();
        }

        public frmEtatVehicule(string typeEngin, string numero)
        {
            InitializeComponent();
            lblEngin.Text += typeEngin + " n°" + numero;
            string typeFichier;

            switch(typeEngin)
            {
                case "BRS": case "VSS":
                    typeFichier = "jpg";
                    break;
                default:
                    typeFichier = "png";
                    break;
            }
            pctEngin.Image = Image.FromFile(@"../../Images/ImagesEngins/" + typeEngin + "." + typeFichier);
        }

        private void chkPanne_CheckedChanged(object sender, EventArgs e)
        {
            if(chkPanne.Checked)
            {
                lblReparations.Visible = true;
                txtReparations.Visible = true;
                txtReparations.Focus();
            }
            else
            {
                lblReparations.Visible = false;
                txtReparations.Visible = false;
                txtReparations.Text = "";
            }
        }

        public string Reparations{ get; private set; }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if(chkPanne.Checked)
            {
                Reparations = txtReparations.Text;
            }
            this.Close();
        }
    }
}
