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
    public partial class frmCompteRendu : Form
    {
        public frmCompteRendu()
        {
            InitializeComponent();
        }

        public frmCompteRendu(int idMission)
        {
            InitializeComponent();
            lblCloture.Text += idMission.ToString();
        }

        public string CompteRendu { get; private set; }

        private void btnValider_Click(object sender, EventArgs e)
        {
            CompteRendu = txtCompteRendu.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtCompteRendu_TextChanged(object sender, EventArgs e)
        {
            if (txtCompteRendu.Text.Length == 0)
            {
                btnAnnuler.Font = new Font(btnAnnuler.Font, FontStyle.Bold);
                btnValider.Font = new Font(btnValider.Font, FontStyle.Regular);
                btnAnnuler.Enabled = true;
                btnValider.Enabled = false;
            }
            else
            {
                btnValider.Font = new Font(btnValider.Font, FontStyle.Bold);
                btnAnnuler.Font = new Font(btnAnnuler.Font, FontStyle.Regular);
                btnAnnuler.Enabled = false;
                btnValider.Enabled = true;
            }
        }
    }
}
