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
    }
}
