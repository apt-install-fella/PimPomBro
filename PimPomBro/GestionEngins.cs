using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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

        BindingSource bsEngins = new BindingSource();
        private string cheminImage = @"../../Images/ImagesEngins/";
        DataTable dtEngins = new DataTable();

        private void frmGestionEngins_Load(object sender, EventArgs e)
        {

            string req = @"select *, idCaserne || '-' || codeTypeEngin || '-' || numero as ID " +
                          "from Engin";
            SQLiteDataAdapter daEngins = new SQLiteDataAdapter(req, Connexion.Connec);

            daEngins.Fill(dtEngins);
            bsEngins.DataSource = dtEngins;
            bsEngins.Filter = "idCaserne = 1";
            bsEngins.MoveFirst();
            lblNom.DataBindings.Add("Text", bsEngins, "ID");
            lblAcquisition.DataBindings.Add("Text", bsEngins, "dateReception");
            lblCodeType.DataBindings.Add("Text", bsEngins, "codeTypeEngin");
            lblEnPanne.DataBindings.Add("Text", bsEngins, "enPanne");
            lblEnMission.DataBindings.Add("Text", bsEngins, "enMission");

            disponibiliteVehicule();
            chargerImage();


            cboCaserne.DataSource = MesDatas.DsGlobal.Tables["Caserne"];
            cboCaserne.DisplayMember = "nom";
            cboCaserne.ValueMember = "id";

            Connexion.FermerConnexion();

        }

        private void disponibiliteVehicule()
        {
            //MessageBox.Show($"Vérification de la disponibilité du véhicule : {lblEnPanne.Text}, {lblEnMission.Text}");
            if (lblEnPanne.Text == "1")
            {
                lblDisponibilite.Text = "En panne";
            }
            else if (lblEnMission.Text == "1")
            {
                lblDisponibilite.Text = "En mission";
            }
            else
            {
                lblDisponibilite.Text = "Disponible";
            }
        }

        private void chargerImage()
        {
            switch (lblCodeType.Text)
            {
                case "FPT":
                    pctEngin.Image = Image.FromFile(cheminImage + "FPT.png");
                    break;
                case "CCF":
                    pctEngin.Image = Image.FromFile(cheminImage + "CCF.png");
                    break;
                case "BRS":
                    pctEngin.Image = Image.FromFile(cheminImage + "BRS.jpg");
                    break;
                case "EPA":
                    pctEngin.Image = Image.FromFile(cheminImage + "EPA.png");
                    break;
                case "FCYN":
                    pctEngin.Image = Image.FromFile(cheminImage + "FCYN.png");
                    break;
                case "VID":
                    pctEngin.Image = Image.FromFile(cheminImage + "VID.png");
                    break;
                case "VPC":
                    pctEngin.Image = Image.FromFile(cheminImage + "VPC.png");
                    break;
                case "VSAV":
                    pctEngin.Image = Image.FromFile(cheminImage + "VSAV.png");
                    break;
                case "VSR":
                    pctEngin.Image = Image.FromFile(cheminImage + "VSR.png");
                    break;
                case "VSS":
                    pctEngin.Image = Image.FromFile(cheminImage + "VSS.jpg");
                    break;
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bsEngins.MoveFirst();
            chargerImage();
            disponibiliteVehicule();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bsEngins.MoveLast();
            chargerImage();
            disponibiliteVehicule();
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
            chargerImage();
            disponibiliteVehicule();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (bsEngins.Position == 0)
            {
                bsEngins.MoveLast();
            }
            else
            {
                bsEngins.MovePrevious();
            }
            chargerImage();
            disponibiliteVehicule();
        }


        private void cboCaserne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bsEngins.Filter = $"idCaserne = {cboCaserne.SelectedValue}";
            bsEngins.MoveFirst();
            chargerImage();
            disponibiliteVehicule();
        }
    }
}
