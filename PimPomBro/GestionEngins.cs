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
    public partial class frmGestionEngins : Form
    {
        public frmGestionEngins()
        {
            InitializeComponent();
        }

        private BindingSource bsCaserne = new BindingSource();
        private BindingSource bsEngins = new BindingSource();
        private string cheminImage = @"../../Images/ImagesEngins/";

        private void frmGestionEngins_Load(object sender, EventArgs e)
        {
            bsCaserne.DataSource = MesDatas.DsGlobal.Tables["Caserne"];
            cboCaserne.DataSource = bsCaserne;
            cboCaserne.DisplayMember = "nom";
            cboCaserne.ValueMember = "id";

            bsEngins.DataSource = MesDatas.DsGlobal.Tables["Engin"];
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCaserne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idCaserne = Convert.ToInt32(cboCaserne.SelectedValue);
            bsEngins.Filter = "idCaserne = " + idCaserne;
            affichageEngin();
        }

        private void affichageEngin()
        {
            DataRowView currentRow = (DataRowView)bsEngins.Current;
            lblID.Text = "Identifiant : " + currentRow["idCaserne"].ToString() + "-" + currentRow["codeTypeEngin"] + "-" + currentRow["numero"];
            lblDate.Text = "Date d'arrivée' : " + currentRow["dateReception"];
            if (Convert.ToInt32(currentRow["enMission"]) == 1)
            {
                chkMission.Checked = true;
            }
            else
            {
                chkMission.Checked = false;
            }
            if(Convert.ToInt32(currentRow["enPanne"]) == 1)
            {
                chkPanne.Checked = true;
                lblReparations.Visible = true;
                lblReparations.Text = "Réparations à effectuer : " + currentRow["reparations"];
            }
            else
            {
                chkPanne.Checked = false;
                lblReparations.Visible = false;
            }

            switch(currentRow["codeTypeEngin"].ToString())
            {
                case "VSAV":
                    pctEngin.Image = Image.FromFile(cheminImage + "VSAV.png");
                    break;
                case "VSR":
                    pctEngin.Image = Image.FromFile(cheminImage + "VSR.png");
                    break;
                case "EPA":
                    pctEngin.Image = Image.FromFile(cheminImage + "EPA.png");
                    break;
                case "FPT":
                    pctEngin.Image = Image.FromFile(cheminImage + "FPT.png");
                    break;
                case "CCF":
                    pctEngin.Image = Image.FromFile(cheminImage + "CCF.png");
                    break;
                case "VSS":
                    pctEngin.Image = Image.FromFile(cheminImage + "VSS.jpg");
                    break;                
                case "VPC":
                    pctEngin.Image = Image.FromFile(cheminImage + "VPC.png");
                    break;
                case "BRS":
                    pctEngin.Image = Image.FromFile(cheminImage + "BRS.jpg");
                    break;
                case "FCYN":
                    pctEngin.Image = Image.FromFile(cheminImage + "FCYN.png");
                    break;
                case "VID":
                    pctEngin.Image = Image.FromFile(cheminImage + "VID.png");
                    break;
            }

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bsEngins.MoveFirst();
            affichageEngin();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bsEngins.MoveLast();
            affichageEngin();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (bsEngins.Position == bsEngins.Count - 1)
            {
                bsEngins.MoveFirst();
            }
            else 
            { 
                bsEngins.MoveNext();
            }

            affichageEngin();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if(bsEngins.Position == 0)
            {
                bsEngins.MoveLast();
            }
            else
            {
                bsEngins.MovePrevious();
            }
            affichageEngin();
        }
    }
}
