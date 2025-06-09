using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using PimPomBro;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Asn1.IsisMtt.X509;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MenuPrincipal
{
    public partial class frmTabBord : Form
    {
        public frmTabBord()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Charger les données depuis la base SQLite une seule fois
            ChargerToutesLesTables();
           
            txtRecherche.Text = "id...";
            txtRecherche.ForeColor = Color.Gray;

            // Préparer le bouton recherche
            btnrecherche.BackgroundImage = System.Drawing.Image.FromFile("../../Images/Tableau_bord/check.png");
            btnrecherche.BackgroundImageLayout = ImageLayout.Stretch;
            btnrecherche.Text = "";

            // Préparer les icônes des autres boutons
            button2.BackgroundImage = System.Drawing.Image.FromFile("../../Images/Tableau_bord/Mission.png");
            button2.BackgroundImageLayout = ImageLayout.Stretch;

            button3.BackgroundImage = System.Drawing.Image.FromFile("../../Images/Tableau_bord/Camion.png");
            button3.BackgroundImageLayout = ImageLayout.Stretch;

            button4.BackgroundImage = System.Drawing.Image.FromFile("../../Images/Tableau_bord/Pompiers.png");
            button4.BackgroundImageLayout = ImageLayout.Stretch;

            button5.BackgroundImage = System.Drawing.Image.FromFile("../../Images/Tableau_bord/Stats.png");
            button5.BackgroundImageLayout = ImageLayout.Stretch;

            // Générer les missions à partir du DataSet (mode déconnecté)
            GenerationMission(); 
        }

        public static void ChargerToutesLesTables()
        {
            string req;
            DataTable schemaTable = Connexion.Connec.GetSchema("Tables");
            for (int i = 0; i < schemaTable.Rows.Count; i++)
            {
                string nomTable = schemaTable.Rows[i][2].ToString();
                req = @"select * from " + nomTable;
                SQLiteCommand cd = new SQLiteCommand(req, Connexion.Connec);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cd);
                da.FillSchema(MesDatas.DsGlobal, SchemaType.Source, nomTable);
                da.Fill(MesDatas.DsGlobal, nomTable);
            }

            Connexion.FermerConnexion();
        }

        public void GenerationMission()
        {
            
            // Nettoyer le panel au cas où on recharge
            panel.Controls.Clear();

            int DistanceHaut = 5;

            // Parcourir chaque ligne de la table Mission
            foreach (DataRow mission in MesDatas.DsGlobal.Tables["Mission"].Rows)
            {
                int id = Convert.ToInt32(mission["id"]);
                int type = Convert.ToInt32(mission["idNatureSinistre"]);
                int cas = Convert.ToInt32(mission["idCaserne"]);
                int terminee = Convert.ToInt32(mission["terminee"]);


                string NatureSinistre = MesDatas.DsGlobal.Tables["NatureSinistre"]
                    .Select("id = " + type)[0]["libelle"].ToString();

                string Caserne = MesDatas.DsGlobal.Tables["Caserne"]
                    .Select("id = " + cas)[0]["nom"].ToString();

                string dateHeure = mission["DateHeureDepart"].ToString();
                string Date = dateHeure.Substring(8, 2) + "/" + dateHeure.Substring(5, 2) + "/" + dateHeure.Substring(0, 4);
                string Heure = dateHeure.Substring(10, 6);

                string Adresse = mission["adresse"].ToString();
                string cp = mission["cp"].ToString();
                string ville = mission["ville"].ToString();
                string Motif = mission["motifAppel"].ToString();
                string Status;
                string ch3;

                if (terminee == 1)
                {
                    Status = "Terminée";
                    ch3 = "../../Images/Tableau_bord/Sign-check-icon.png";
                }
                else
                {
                    Status = "En cours";
                    ch3 = "../../Images/Tableau_bord/archive.png";
                }

                string ch1;
                switch (NatureSinistre)
                {
                    case "Incendie":
                        ch1 = "../../Images/Tableau_bord/Missions/incendie.png";
                        break;
                    case "Accident de la circulation":
                        ch1 = "../../Images/Tableau_bord/Missions/accident_circulation.png";
                        break;
                    case "Secours d'urgence aux personnes":
                        ch1 = "../../Images/Tableau_bord/Missions/secours_urgence.png";
                        break;
                    case "Risque industriel et pollution":
                        ch1 = "../../Images/Tableau_bord/Missions/risque_industriel.png";
                        break;
                    case "Feu de forêt":
                        ch1 = "../../Images/Tableau_bord/Missions/feu_foret.png";
                        break;
                    case "Protection de la faune":
                        ch1 = "../../Images/Tableau_bord/Missions/protection_faune.png";
                        break;
                    case "Plan d'urgence":
                        ch1 = "../../Images/Tableau_bord/Missions/plan_urgence.png";
                        break;
                    case "Secours en mer ou rivière":
                        ch1 = "../../Images/Tableau_bord/Missions/sauvetage_mer.png";
                        break;
                    case "Eboulement":
                        ch1 = "../../Images/Tableau_bord/Missions/eboulement.png";
                        break;
                    case "Assistance non urgente":
                        ch1 = "../../Images/Tableau_bord/Missions/assistance_non_urgente.png";
                        break;
                    default:
                        ch1 = "../../Images/Tableau_bord/Mission.png";
                        break;
                }

                string ch2 = "../../Images/Tableau_bord/pdf.png";

                AfficheMission Mission = new AfficheMission(id, NatureSinistre, Caserne, Date, Heure, Adresse, cp, ville, Status, Motif, ch1, ch2, ch3);
                Mission.ClotureMission = clotureMission;
                Mission.PDF = generationPDF;
                Mission.Tag = id;

                Mission.Size = new Size(1050, 250);
                Mission.Top = DistanceHaut;
                Mission.Left = 8;

                panel.Controls.Add(Mission);
                DistanceHaut += 255;

              
            }

        }

        public void GenerationMission(int idRecherche)
        {
            // Nettoyer le panel
            panel.Controls.Clear();

            int DistanceHaut = 5;

            // Parcourir les missions
            foreach (DataRow mission in MesDatas.DsGlobal.Tables["Mission"].Rows)
            {
                int id = Convert.ToInt32(mission["id"]);

                if (id != idRecherche)
                    continue;

                int type = Convert.ToInt32(mission["idNatureSinistre"]);
                int cas = Convert.ToInt32(mission["idCaserne"]);
                int terminee = Convert.ToInt32(mission["terminee"]);

             
              
                string NatureSinistre = MesDatas.DsGlobal.Tables["NatureSinistre"]
                    .Select("id = " + type)[0]["libelle"].ToString();

                string Caserne = MesDatas.DsGlobal.Tables["Caserne"]
                    .Select("id = " + cas)[0]["nom"].ToString();

                string dateHeure = mission["DateHeureDepart"].ToString();
                string Date = dateHeure.Substring(8, 2) + "/" + dateHeure.Substring(5, 2) + "/" + dateHeure.Substring(0, 4);
                string Heure = dateHeure.Substring(10, 6);

                string Adresse = mission["adresse"].ToString();
                string cp = mission["cp"].ToString();
                string ville = mission["ville"].ToString();
                string Motif = mission["motifAppel"].ToString();
                string Status;
                string ch3;

                if (terminee == 1)
                {
                    Status = "Terminée";
                    ch3 = "../../Images/Tableau_bord/Sign-check-icon.png";
                }
                else
                {
                    Status = "En cours";
                    ch3 = "../../Images/Tableau_bord/archive.png";
                }

                string ch1;
                switch (NatureSinistre)
                {
                    case "Incendie":
                        ch1 = "../../Images/Tableau_bord/Missions/incendie.png";
                        break;
                    case "Accident de la circulation":
                        ch1 = "../../Images/Tableau_bord/Missions/accident_circulation.png";
                        break;
                    case "Secours d'urgence aux personnes":
                        ch1 = "../../Images/Tableau_bord/Missions/secours_urgence.png";
                        break;
                    case "Risque industriel et pollution":
                        ch1 = "../../Images/Tableau_bord/Missions/risque_industriel.png";
                        break;
                    case "Feu de forêt":
                        ch1 = "../../Images/Tableau_bord/Missions/feu_foret.png";
                        break;
                    case "Protection de la faune":
                        ch1 = "../../Images/Tableau_bord/Missions/protection_faune.png";
                        break;
                    case "Plan d'urgence":
                        ch1 = "../../Images/Tableau_bord/Missions/plan_urgence.png";
                        break;
                    case "Secours en mer ou rivière":
                        ch1 = "../../Images/Tableau_bord/Missions/sauvetage_mer.png";
                        break;
                    case "Eboulement":
                        ch1 = "../../Images/Tableau_bord/Missions/eboulement.png";
                        break;
                    case "Assistance non urgente":
                        ch1 = "../../Images/Tableau_bord/Missions/assistance_non_urgente.png";
                        break;
                    default:
                        ch1 = "../../Images/Tableau_bord/Mission.png";
                        break;
                }

                string ch2 = "../../Images/Tableau_bord/pdf.png";
                
                AfficheMission Mission = new AfficheMission(id, NatureSinistre, Caserne, Date, Heure, Adresse, cp, ville, Status, Motif, ch1, ch2, ch3);
                Mission.ClotureMission = clotureMission;
                Mission.PDF = generationPDF;
                Mission.Tag = id;

                Mission.Size = new Size(1050, 250);
                Mission.Top = DistanceHaut;
                Mission.Left = 8;

                panel.Controls.Add(Mission);
                DistanceHaut += 255;

                break; 
            }
        }


        public void GenerationMissionEnCours()
        {
            // Nettoyer le panel au cas où on recharge
            panel.Controls.Clear();

            int DistanceHaut = 5;

            // Parcourir chaque ligne de la table Mission
            foreach (DataRow mission in MesDatas.DsGlobal.Tables["Mission"].Rows)
            {
                int id = Convert.ToInt32(mission["id"]);
                int type = Convert.ToInt32(mission["idNatureSinistre"]);
                int cas = Convert.ToInt32(mission["idCaserne"]);
                int terminee = Convert.ToInt32(mission["terminee"]);

                // ❗️On affiche uniquement les missions "En cours"
                if (terminee == 1)
                {
                    continue; // On saute si elle est terminée
                }

                string NatureSinistre = MesDatas.DsGlobal.Tables["NatureSinistre"]
                    .Select("id = " + type)[0]["libelle"].ToString();

                string Caserne = MesDatas.DsGlobal.Tables["Caserne"]
                    .Select("id = " + cas)[0]["nom"].ToString();

                string dateHeure = mission["DateHeureDepart"].ToString();
                string Date = dateHeure.Substring(8, 2) + "/" + dateHeure.Substring(5, 2) + "/" + dateHeure.Substring(0, 4);
                string Heure = dateHeure.Substring(10, 6);

                string Adresse = mission["adresse"].ToString();
                string cp = mission["cp"].ToString();
                string ville = mission["ville"].ToString();
                string Motif = mission["motifAppel"].ToString();
                string Status;
                string ch3;

                if (terminee == 1)
                {
                    Status = "Terminée";
                    ch3 = "../../Images/Tableau_bord/Sign-check-icon.png";
                }
                else
                {
                    Status = "En cours";
                    ch3 = "../../Images/Tableau_bord/archive.png";
                }

                string ch1;
                switch (NatureSinistre)
                {
                    case "Incendie":
                        ch1 = "../../Images/Tableau_bord/Missions/incendie.png";
                        break;
                    case "Accident de la circulation":
                        ch1 = "../../Images/Tableau_bord/Missions/accident_circulation.png";
                        break;
                    case "Secours d'urgence aux personnes":
                        ch1 = "../../Images/Tableau_bord/Missions/secours_urgence.png";
                        break;
                    case "Risque industriel et pollution":
                        ch1 = "../../Images/Tableau_bord/Missions/risque_industriel.png";
                        break;
                    case "Feu de forêt":
                        ch1 = "../../Images/Tableau_bord/Missions/feu_foret.png";
                        break;
                    case "Protection de la faune":
                        ch1 = "../../Images/Tableau_bord/Missions/protection_faune.png";
                        break;
                    case "Plan d'urgence":
                        ch1 = "../../Images/Tableau_bord/Missions/plan_urgence.png";
                        break;
                    case "Secours en mer ou rivière":
                        ch1 = "../../Images/Tableau_bord/Missions/sauvetage_mer.png";
                        break;
                    case "Eboulement":
                        ch1 = "../../Images/Tableau_bord/Missions/eboulement.png";
                        break;
                    case "Assistance non urgente":
                        ch1 = "../../Images/Tableau_bord/Missions/assistance_non_urgente.png";
                        break;
                    default:
                        ch1 = "../../Images/Tableau_bord/Mission.png";
                        break;
                }

                string ch2 = "../../Images/Tableau_bord/pdf.png";

                AfficheMission Mission = new AfficheMission(id, NatureSinistre, Caserne, Date, Heure, Adresse, cp, ville, Status, Motif, ch1, ch2, ch3);
                Mission.ClotureMission = clotureMission;
                Mission.PDF = generationPDF;
                Mission.Tag = id;

                Mission.Size = new Size(1050, 250);
                Mission.Top = DistanceHaut;
                Mission.Left = 8;

                panel.Controls.Add(Mission);
                DistanceHaut += 255;
            }
        }


        public void GenerationMissionEnCours(int idRecherche)
        {
            // Nettoyer le panel au cas où on recharge
            panel.Controls.Clear();

            int DistanceHaut = 5;

            // Parcourir chaque ligne de la table Mission
            foreach (DataRow mission in MesDatas.DsGlobal.Tables["Mission"].Rows)
            {
                int id = Convert.ToInt32(mission["id"]);
                int type = Convert.ToInt32(mission["idNatureSinistre"]);
                int cas = Convert.ToInt32(mission["idCaserne"]);
                int terminee = Convert.ToInt32(mission["terminee"]);

                // On filtre sur l'id demandé et on affiche uniquement les missions "En cours"
                if (id != idRecherche || terminee == 1)
                {
                    continue; // On saute si l'id ne correspond pas ou la mission est terminée
                }

                string NatureSinistre = MesDatas.DsGlobal.Tables["NatureSinistre"]
                    .Select("id = " + type)[0]["libelle"].ToString();

                string Caserne = MesDatas.DsGlobal.Tables["Caserne"]
                    .Select("id = " + cas)[0]["nom"].ToString();

                string dateHeure = mission["DateHeureDepart"].ToString();
                string Date = dateHeure.Substring(8, 2) + "/" + dateHeure.Substring(5, 2) + "/" + dateHeure.Substring(0, 4);
                string Heure = dateHeure.Substring(10, 6);
                
                string Adresse = mission["adresse"].ToString();
                string cp = mission["cp"].ToString();
                string ville = mission["ville"].ToString();
                string Motif = mission["motifAppel"].ToString();
                string Status;
                string ch3;

                if (terminee == 1)
                {
                    Status = "Terminée";
                    ch3 = "../../Images/Tableau_bord/Sign-check-icon.png";
                }
                else
                {
                    Status = "En cours";
                    ch3 = "../../Images/Tableau_bord/archive.png";
                }

                string ch1;
                switch (NatureSinistre)
                {
                    case "Incendie":
                        ch1 = "../../Images/Tableau_bord/Missions/incendie.png";
                        break;
                    case "Accident de la circulation":
                        ch1 = "../../Images/Tableau_bord/Missions/accident_circulation.png";
                        break;
                    case "Secours d'urgence aux personnes":
                        ch1 = "../../Images/Tableau_bord/Missions/secours_urgence.png";
                        break;
                    case "Risque industriel et pollution":
                        ch1 = "../../Images/Tableau_bord/Missions/risque_industriel.png";
                        break;
                    case "Feu de forêt":
                        ch1 = "../../Images/Tableau_bord/Missions/feu_foret.png";
                        break;
                    case "Protection de la faune":
                        ch1 = "../../Images/Tableau_bord/Missions/protection_faune.png";
                        break;
                    case "Plan d'urgence":
                        ch1 = "../../Images/Tableau_bord/Missions/plan_urgence.png";
                        break;
                    case "Secours en mer ou rivière":
                        ch1 = "../../Images/Tableau_bord/Missions/sauvetage_mer.png";
                        break;
                    case "Eboulement":
                        ch1 = "../../Images/Tableau_bord/Missions/eboulement.png";
                        break;
                    case "Assistance non urgente":
                        ch1 = "../../Images/Tableau_bord/Missions/assistance_non_urgente.png";
                        break;
                    default:
                        ch1 = "../../Images/Tableau_bord/Mission.png";
                        break;
                }
                                
                string ch2 = "../../Images/Tableau_bord/pdf.png";

                AfficheMission Mission = new AfficheMission(id, NatureSinistre, Caserne, Date, Heure, Adresse, cp, ville, Status, Motif, ch1, ch2, ch3);
                Mission.ClotureMission = clotureMission;
                Mission.PDF = generationPDF;
                Mission.Tag = id;

                Mission.Size = new Size(1050, 250);
                Mission.Top = DistanceHaut;
                Mission.Left = 8;

                panel.Controls.Add(Mission);
                DistanceHaut += 255;
            }
        }


        private void chkEnCours_CheckedChanged(object sender, EventArgs e)
        {
            if (txtRecherche.Text == ""||txtRecherche.Text=="id...")
            {
                if (chkEnCours.Checked)
                {
                    GenerationMissionEnCours();
                }
                else
                {
                    GenerationMission();
                }
            }
            else
            {
                if (chkEnCours.Checked)
                {
                    int id = int.Parse(txtRecherche.Text);
                    GenerationMissionEnCours(id);
                }
                else
                {
                    int id = int.Parse(txtRecherche.Text);
                    GenerationMission(id);
                }

            }

        }

        private void txtRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                txtRecherche.ForeColor = Color.Black;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtRecherche.Text == "")
                {
                    GenerationMission();
                    txtRecherche.Text = "id..."; // Réinitialiser le champ de recherche
                    txtRecherche.ForeColor = Color.Gray; // Remettre la couleur grise
                }
                else{
                    int id = int.Parse(txtRecherche.Text);
                    GenerationMission(id);
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
                txtRecherche.Text = ""; // Réinitialiser le champ de recherche
                txtRecherche.ForeColor = Color.Black; // Remettre la couleur noire
            }
        }

        private void btnrecherche_Click(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "" || txtRecherche.Text == "id...")
            {
                GenerationMission();
                txtRecherche.Text = "id..."; // Réinitialiser le champ de recherche
                txtRecherche.ForeColor = Color.Gray; // Remettre la couleur grise
            }
            else
            {
                int id = int.Parse(txtRecherche.Text);
                GenerationMission(id);
            }
        }

        private void btnTableauDeBord_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
             btn.BackColor = Color.LightGray;
        }

        private void btnTableauDeBord_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            btn.BackColor = Color.White;
        }

        private void txtRecherche_Leave(object sender, EventArgs e)
        {
            if (txtRecherche.Text=="")
            {
                txtRecherche.Text = "id...";
                txtRecherche.ForeColor = Color.Gray;
            }
            
        }

        private void btnNouvelleMission_Click(object sender, EventArgs e)
        {
            frmMission nouvelle_Mission = new frmMission();
            nouvelle_Mission.ShowDialog(); // ouverture de l'autre formulaire
            GenerationMission();
        }

        private void btnGestionDesEngins_Click(object sender, EventArgs e)
        {
            frmGestionEngins gestionEngins = new frmGestionEngins();
            gestionEngins.ShowDialog(); // ouverture de l'autre formulaire
        }

        private void btnGestionDuPersonnel_Click(object sender, EventArgs e)
        {
            frmGestionPompiers gestionPompiers = new frmGestionPompiers();
            gestionPompiers.ShowDialog(); // ouverture de l'autre formulaire
        }

        private void btnStatistiques_Click(object sender, EventArgs e)
        {
            Statitiques statitiques = new Statitiques();
            statitiques.ShowDialog(); // ouverture de l'autre formulaire
        }

        
        private void txtRecherche_Enter(object sender, EventArgs e)
        {
            txtRecherche.Text = "";
            txtRecherche.ForeColor = Color.Black;
            chkEnCours.Checked = false;
        }

        private void clotureMission(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            AfficheMission mission = (AfficheMission)btn.Parent;
            int idMission = (int)mission.Tag;

            if (Convert.ToInt32(MesDatas.DsGlobal.Tables["Mission"].Select("id = " + idMission)[0]["terminee"]) == 1)
            {
                MessageBox.Show("Cette mission est déjà clôturé.");
                return;
            }

            MessageBox.Show("Clôturer la mission " + idMission);

            int idCaserne = Convert.ToInt32(MesDatas.DsGlobal.Tables["Mission"].Select("id = " + idMission)[0]["idCaserne"].ToString());

            SQLiteTransaction transaction = Connexion.Connec.BeginTransaction();

            try
            {
                //Clotûre de la mission
                MesDatas.DsGlobal.Tables["Mission"].Select("id = " + idMission)[0]["terminee"] = 1;

                //On met à jour la date de cloture
                string heureFin = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                MesDatas.DsGlobal.Tables["Mission"].Select("id = " + idMission)[0]["dateHeureRetour"] = heureFin;

                //Compte rendu
                frmCompteRendu compteRendu = new frmCompteRendu(idMission);
                compteRendu.ShowDialog();
                string compteRenduText = null;
                if (compteRendu.DialogResult == DialogResult.OK)
                {
                    compteRenduText = compteRendu.CompteRendu;
                    MesDatas.DsGlobal.Tables["Mission"].Select("id = " + idMission)[0]["compteRendu"] = compteRenduText;
                }

                //Vérification si la mission existe déjà dans la base
                string req = @"select count(*) from Mission where id = " + idMission;
                SQLiteCommand cmd = new SQLiteCommand(req, Connexion.Connec);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    req = @"update Mission set " +
                            "dateHeureRetour = '" + heureFin + "', " +
                            "compteRendu = @compteRendu, " +
                            "terminee = 1 where id = " + idMission;
                    cmd = new SQLiteCommand(req, Connexion.Connec);
                    cmd.Parameters.AddWithValue("@compteRendu", compteRenduText);
                    cmd.ExecuteNonQuery();
                }
                else 
                { 
                    //Insertion de la mission dans la base
                    string heureDepart = MesDatas.DsGlobal.Tables["Mission"].Select("id = " + idMission)[0]["dateHeureDepart"].ToString();
                    string motif = MesDatas.DsGlobal.Tables["Mission"].Select("id = " + idMission)[0]["motifAppel"].ToString();
                    string adresse = MesDatas.DsGlobal.Tables["Mission"].Select("id = " + idMission)[0]["adresse"].ToString();
                    string cp = MesDatas.DsGlobal.Tables["Mission"].Select("id = " + idMission)[0]["cp"].ToString();
                    string ville = MesDatas.DsGlobal.Tables["Mission"].Select("id = " + idMission)[0]["ville"].ToString();
                    int idNatureSinistre = Convert.ToInt32(MesDatas.DsGlobal.Tables["Mission"].Select("id = " + idMission)[0]["idNatureSinistre"]);

                    //Utilisation de requêtes paramétrées pour éviter les injections SQL (problèmes avec les ')

                    req = @"insert into Mission " +
                            "values (" + idMission + ", '" + heureDepart + "', " +
                                     "'" + heureFin + "', @motif, @adresse, '" + cp + "', @ville, " +
                                     "1, @compteRendu, " + idNatureSinistre + ", " + idCaserne + ") ";
                    cmd = new SQLiteCommand(req, Connexion.Connec);
                    cmd.Parameters.AddWithValue("@motif", motif);
                    cmd.Parameters.AddWithValue("@adresse", adresse);
                    cmd.Parameters.AddWithValue("@ville", ville);
                    cmd.Parameters.AddWithValue("@compteRendu", compteRenduText);
                    cmd.ExecuteNonQuery();
                }

                //On met à jour les pompiers (enMission = 0)
                string filtreMission = "idMission = " + idMission;
                DataRow[] mobilises = MesDatas.DsGlobal.Tables["Mobiliser"].Select(filtreMission);
                foreach (DataRow mobilise in mobilises)
                {
                    DataRow pompier = MesDatas.DsGlobal.Tables["Pompier"].Select("matricule = " + mobilise["matriculePompier"])[0];
                    pompier["enMission"] = 0;

                    //Update dans la base (table Pompier)
                    req = @"update Pompier set enMission = 0 where matricule = " + pompier["matricule"];
                    cmd = new SQLiteCommand(req, Connexion.Connec);
                    cmd.ExecuteNonQuery();

                    //On insère la ligne mobilise (table Mobiliser) si elle n'existe pas déjà
                    if (count == 0)
                    {
                        string idHab = mobilise["idHabilitation"].ToString();
                        req = @"insert into Mobiliser 
                            values (" + pompier["matricule"] + ", " +
                                        idMission + ", " + idHab + ")";
                        cmd = new SQLiteCommand(req, Connexion.Connec);
                        cmd.ExecuteNonQuery();
                    }
                }

                //On met à jour les engins (en Mission = 0)
                DataRow[] partis = MesDatas.DsGlobal.Tables["PartirAvec"].Select(filtreMission);
                foreach (DataRow part in partis)
                {
                    DataRow engin = MesDatas.DsGlobal.Tables["Engin"].Select("codeTypeEngin = '" + part["codeTypeEngin"] + "' and numero = " + part["numeroEngin"] + " and idCaserne = " + idCaserne)[0];
                    engin["enMission"] = 0;

                    //Update dans la base
                    req = @"update Engin set enMission = 0 where codeTypeEngin = '" + part["codeTypeEngin"] + "' and numero = " + part["numeroEngin"] + " and idCaserne = " + idCaserne;
                    cmd = new SQLiteCommand(req, Connexion.Connec);
                    cmd.ExecuteNonQuery();

                    //On met à jour les réparations éventuelles
                    frmEtatVehicule etatVehicule = new frmEtatVehicule(engin["codeTypeEngin"].ToString(), engin["numero"].ToString());
                    etatVehicule.ShowDialog();
                    string reparations = null;
                    if (etatVehicule.DialogResult == DialogResult.OK)
                    {
                        reparations = etatVehicule.Reparations;
                        if (reparations != null)
                        {
                            engin["enPanne"] = 1;
                            MesDatas.DsGlobal.Tables["PartirAvec"].Select("idMission = " + idMission + " and codeTypeEngin = '" + part["codeTypeEngin"] + "' and numeroEngin = " + part["numeroEngin"])[0]["reparationsEventuelles"] = reparations;
                            
                            //Update dans la base (table Engin)
                            req = @"update Engin set enPanne = 1 where codeTypeEngin = '" + part["codeTypeEngin"] + "' and numero = " + part["numeroEngin"] + " and idCaserne = " + idCaserne;
                            cmd = new SQLiteCommand(req, Connexion.Connec);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    //On insère la ligne partirAvec (table PartirAvec)
                    if (count == 0)
                    {
                        req = @"insert into PartirAvec 
                                values (" + idCaserne + ", " +
                                        "'" + part["codeTypeEngin"] + "', " + part["numeroEngin"] +
                                        ", " + idMission + ", @reparations)";
                        cmd = new SQLiteCommand(req, Connexion.Connec);
                        cmd.Parameters.AddWithValue("@reparations", reparations);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        //On met à jour la ligne partirAvec (table PartirAvec)
                        req = @"update PartirAvec set reparationsEventuelles = @reparations " + 
                               "where idMission = " + idMission + " and codeTypeEngin = '" + 
                               part["codeTypeEngin"] + "' and numeroEngin = " + part["numeroEngin"];
                        cmd = new SQLiteCommand(req, Connexion.Connec);
                        cmd.Parameters.AddWithValue("@reparations", reparations);
                        cmd.ExecuteNonQuery();
                    }
                }

                //On accepte les changements dans le dataset
                MesDatas.DsGlobal.AcceptChanges();

                // On valide la transaction
                transaction.Commit();
                MessageBox.Show("Mission " + idMission + " clôturée avec succès.");

                generationPDF(sender, e); // Générer le PDF après la clôture de la mission
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la clôture de la mission.");
                transaction.Rollback(); // Annuler la transaction en cas d'erreur
                MesDatas.DsGlobal.RejectChanges(); // Rejeter les changements dans le DataSet
            }
            finally
            {
                // On ferme la connexion
                Connexion.FermerConnexion();
                // On recharge les missions
                chkEnCours.Checked = false;
                GenerationMission();
            }
        }


        private void generationPDF(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            AfficheMission mission = (AfficheMission)btn.Parent;
            string idMission = mission.Tag.ToString();
            
            //Récupération des informations nécessaires
            DataRow[] missionData = MesDatas.DsGlobal.Tables["Mission"].Select("id = " + idMission);
            int idNatureSinistre = Convert.ToInt32(missionData[0]["idNatureSinistre"]);
            int idCaserne = Convert.ToInt32(missionData[0]["idCaserne"]);
            
            string date = missionData[0]["DateHeureDepart"].ToString().Substring(0, 10);
            string heure = missionData[0]["DateHeureDepart"].ToString().Substring(11, 5);

            string adresse = missionData[0]["adresse"].ToString();
            string cp = missionData[0]["cp"].ToString();
            string ville = missionData[0]["ville"].ToString();
            string adr;
            if (!string.IsNullOrEmpty(adresse) && !string.IsNullOrEmpty(cp) && !string.IsNullOrEmpty(ville))
            {
                adr = adresse + ", " + cp + " " + ville;
            }
            else if (!string.IsNullOrEmpty(adresse))
            {
                adr = adresse;
                if (!string.IsNullOrEmpty(cp))
                {
                    adr += ", " + cp + " " + ville;
                }
                else if (!string.IsNullOrEmpty(ville))
                {
                    adr += ", " + ville;
                }
            }
            else if (!string.IsNullOrEmpty(cp))
            {
                adr = cp + " " + ville;
            }
            else if(!string.IsNullOrEmpty(ville))
            {
                adr = ville;
            }
            else
            {
                adr = "Adresse non renseignée";
            }
            string status = missionData[0]["terminee"].ToString() == "1" ? "terminée" : "en cours";
            string motif = missionData[0]["motifAppel"].ToString();

            string compteRendu;
            string dateRetour = "";
            string heureRetour = "";
            if (status == "terminée")
            {
                if(missionData[0]["compteRendu"] == DBNull.Value || string.IsNullOrEmpty(missionData[0]["compteRendu"].ToString()))
                {
                    compteRendu = "Aucun compte rendu disponible.";
                }
                else
                {
                    compteRendu = missionData[0]["compteRendu"].ToString();
                }
                dateRetour = missionData[0]["dateHeureRetour"].ToString().Substring(0, 10);
                heureRetour = missionData[0]["dateHeureRetour"].ToString().Substring(11, 5);
            }
            else
            {
                compteRendu = "Aucun compte rendu disponible (mission en cours).";
            }

            // Récupération de la nature du sinistre
            string sinistre = MesDatas.DsGlobal.Tables["NatureSinistre"].Select("id = " + idNatureSinistre)[0]["libelle"].ToString();

            // Récupération de la caserne
            string caserne = MesDatas.DsGlobal.Tables["Caserne"].Select("id = " + idCaserne)[0]["nom"].ToString();




            //Génération du PDF
            Document doc = new Document();
            // police grise, taille 16, en gras
            iTextSharp.text.Font maPolice = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16f, BaseColor.GRAY);
            // police noir, taille 12, normale
            iTextSharp.text.Font police = FontFactory.GetFont(FontFactory.TIMES, 12f, BaseColor.BLACK);

            try
            {
                string chemin = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Mission_{idMission}.pdf");
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(chemin, FileMode.Create));
                doc.Open();


                iTextSharp.text.Font titre = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20f, BaseColor.RED);
                Paragraph pTitre = new Paragraph("Mission " + idMission + " (" + status + ")", titre);
                pTitre.Alignment = Element.ALIGN_CENTER; // centrer le texte
                doc.Add(pTitre);
                doc.Add(new Paragraph(" ")); // espace après le titre

                Paragraph pInfos = new Paragraph("Informations générales : ", maPolice);
                doc.Add(pInfos);

                doc.Add(new Paragraph("Caserne mobilisée : " + caserne, police));
                doc.Add(new Paragraph("Déclenchée le : " + date + " à " + heure, police));
                if (status == "terminée")
                {
                    doc.Add(new Paragraph("Terminée le : " + dateRetour + " à " + heureRetour, police));
                }

                doc.Add(new Paragraph("Adresse du sinistre : " + adr, police));


                doc.Add(new Paragraph(" "));
                Paragraph pNatureSinistre = new Paragraph("Nature du sinistre : " + sinistre, maPolice);
                doc.Add(pNatureSinistre);

                Paragraph pMotif = new Paragraph("Motif : " + motif, police);
                pMotif.Alignment = Element.ALIGN_JUSTIFIED; // Justifier le texte
                doc.Add(pMotif);

                Paragraph pCompteRendu = new Paragraph("Compte rendu : " + compteRendu, police);
                pCompteRendu.Alignment = Element.ALIGN_JUSTIFIED; 
                doc.Add(pCompteRendu);

                doc.Add(new Paragraph(" "));

                Paragraph pEnginsMobilises = new Paragraph("Engins mobilisés :", maPolice);
                doc.Add(pEnginsMobilises);

                // Récupération des engins mobilisés
                DataRow[] partis = MesDatas.DsGlobal.Tables["PartirAvec"].Select("idMission = " + idMission);
                foreach (DataRow engin in partis)
                {
                    string nomEngin = MesDatas.DsGlobal.Tables["TypeEngin"].Select("code = '" + engin["codeTypeEngin"] + "'")[0]["nom"].ToString();
                    string texte = $"* {nomEngin} {idCaserne}-{engin["codeTypeEngin"]}-{engin["numeroEngin"]}";
                    if (engin["reparationsEventuelles"] != DBNull.Value && engin["reparationsEventuelles"].ToString() != "")
                    {
                        texte += " (Réparations : " + engin["reparationsEventuelles"] + ")";
                    }
                    else
                    {
                        texte += " (Aucune réparation nécessaire)";
                    }
                    Paragraph pEngin = new Paragraph(texte, police);
                    pEngin.Alignment = Element.ALIGN_JUSTIFIED;
                    doc.Add(pEngin);
                }

                doc.Add(new Paragraph(" "));
                
                Paragraph pPompierMobilises = new Paragraph("Pompiers mobilisés :", maPolice);
                pPompierMobilises.PaddingTop = 10f; // espace entre les sections
                doc.Add(pPompierMobilises);

                // Récupération des pompiers mobilisés
                DataRow[] mobilises = MesDatas.DsGlobal.Tables["Mobiliser"].Select("idMission = " + idMission);

                foreach (DataRow mobilise in mobilises)
                {
                    DataRow pompierData = MesDatas.DsGlobal.Tables["Pompier"].Select("matricule = " + mobilise["matriculePompier"])[0];

                    string codeGrade = pompierData["codeGrade"].ToString();
                    string grade = MesDatas.DsGlobal.Tables["Grade"].Select("code = '" + codeGrade + "'")[0]["libelle"].ToString();

                    string nomPompier = pompierData["nom"].ToString();
                    string prenomPompier = pompierData["prenom"].ToString();
                    string texte = $"* {grade} {nomPompier} {prenomPompier} (Matricule : {mobilise["matriculePompier"]})";
                    
                    string idHabilitation = mobilise["idHabilitation"].ToString();
                    string habilitation = MesDatas.DsGlobal.Tables["Habilitation"].Select("id = " + idHabilitation)[0]["libelle"].ToString();
                    texte += $" - Habilitation : {habilitation}";

                    Paragraph pPompier = new Paragraph(texte, police);
                    pPompier.Alignment = Element.ALIGN_JUSTIFIED;
                    doc.Add(pPompier);
                }

                MessageBox.Show($"PDF de la mission {idMission} généré sur le bureau !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                doc.Close();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}