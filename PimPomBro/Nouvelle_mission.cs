using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls_Nouvelle_Mission;

namespace PimPomBro
{
    public partial class frmMission : Form
    {
        public frmMission()
        {
            InitializeComponent();
        }

        DataRow drMission;
        int idMission;
        List<DataRow> partirAvec = new List<DataRow>();
        List<DataRow> mobiliser = new List<DataRow>();

        private void frmMission_Load(object sender, EventArgs e)
        {
            //Remplissage des comboBox à partir du DataSet
            remplissageCombo(cboNatureSinitre, "NatureSinistre", "libelle", "id");
            remplissageCombo(cboCaserne, "Caserne", "nom", "id");

            //Mettre la bonne date et la bonne heure
            DateTime date = DateTime.Now;
            lblDate.Text = date.ToString("dd/MM/yyyy");
            lblHeure.Text = date.ToString("HH:mm:ss").Substring(0, 5);

            idMission = MesDatas.DsGlobal.Tables["Mission"].Rows.Count + 1;
            tabControl1.Controls[0].Text = "Mission n° " + idMission.ToString();

            btnValider.Enabled = false;
            btnValider.Cursor = Cursors.No;
            txtMotif.Focus();

        }

        private void remplissageCombo(ComboBox combo, string table, string colonne1, string colonne2)
        {
            combo.Items.Clear();
            combo.DataSource = MesDatas.DsGlobal.Tables[table];
            combo.DisplayMember = colonne1;
            combo.ValueMember = colonne2;
        }

        private void SetTextDescription(TextBox txt, string description)
        {
            //On remet le texte de description
            if (txt.Text == "" || txt.Text == " ")
            {
                txt.Text = description;
                txt.ForeColor = Color.Gray;
            }
        }

        private void RemoveTextDescription(TextBox txt, string description)
        {
            //On enlève le texte de description
            if (txt.Text == description)
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;
            }
        }

        private void txtMotif_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            RemoveTextDescription(txt, txt.Text);
        }

        private void txtMotif_Leave(object sender, EventArgs e)
        {
            SetTextDescription(txtMotif, "Motif");
        }

        private void txtRue_Leave(object sender, EventArgs e)
        {
            SetTextDescription(txtRue, "Rue");
        }

        private void txtVille_Leave(object sender, EventArgs e)
        {
            SetTextDescription(txtVille, "Ville");
        }

        private void txtCp_Leave(object sender, EventArgs e)
        {
            SetTextDescription(txtCp, "Code Postal");
        }


        private void afficherErreur(TextBox txt, string message)
        {
            //On affiche un message d'erreur
            erpErreurSaisie.SetError(txt, message);
            txt.Focus();
        }

        private void txtCp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Interdire tout caractère sauf les chiffres et les tabulations
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Tab && e.KeyChar != (char) Keys.Back){
                e.Handled = true;
            }

            if(txtCp.Text.Length == 5 && e.KeyChar != (char)Keys.Back)
            {
                //On ne peut pas entrer plus de 5 chiffres
                e.Handled = true;
            }

        }

        private void desafichage()
        {
            foreach (afficherPompiers affichePomp in tbpMission.Controls.OfType<afficherPompiers>().ToList())
            {
                tbpMission.Controls.Remove(affichePomp);
            }

            foreach (affichageVehicules vehi in tbpMission.Controls.OfType<affichageVehicules>().ToList())
            {
                tbpMission.Controls.Remove(vehi);
            }
            
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            erpErreurSaisie.Clear();
            txtMotif.Text = "Motif";
            txtMotif.ForeColor = Color.Gray;
            txtRue.Text = "Rue";
            txtRue.ForeColor = Color.Gray;
            txtCp.Text = "Code Postal";
            txtCp.ForeColor = Color.Gray;
            txtVille.Text = "Ville";
            txtVille.ForeColor = Color.Gray;

            cboNatureSinitre.SelectedIndex = 0;
            cboCaserne.SelectedIndex = 0;
            drMission = MesDatas.DsGlobal.Tables["Mission"].NewRow();

            foreach(DataRow dr in partirAvec)
            {
                //Remettre les engins disponibles
                string filtreEngin = "numero = " + dr["numeroEngin"].ToString() + " and idCaserne = " + dr["idCaserne"].ToString() + " and codeTypeEngin = '" + dr["codeTypeEngin"] + "'";
                DataRow[] engin = MesDatas.DsGlobal.Tables["Engin"].Select(filtreEngin);
                engin[0]["enMission"] = 0;
            }
            partirAvec.Clear();

            foreach(DataRow dr in mobiliser)
            {
                //Remttre les pompiers disponibles
                string filtrePompier = "matricule = " + dr["matriculePompier"].ToString();
                DataRow[] pompier = MesDatas.DsGlobal.Tables["Pompier"].Select(filtrePompier);
                pompier[0]["enMission"] = 0;
            }
            mobiliser.Clear();

            desafichage();

            btnValider.Enabled = false;
            btnConstituerEquipe.Enabled = true;
            btnValider.ForeColor = Color.Black;
            btnValider.Font = new Font(btnValider.Font, FontStyle.Regular);
            btnConstituerEquipe.ForeColor = Color.Navy;
            btnConstituerEquipe.Font = new Font(btnConstituerEquipe.Font, FontStyle.Bold);

            txtMotif.Focus();
        }

        private void btnConstituerEquipe_Click(object sender, EventArgs e)
        {
            //Enleve les anciennes erreurs
            erpErreurSaisie.Clear();

            if (txtMotif.Text != "Motif" && txtRue.Text != "Rue" && txtVille.Text != "Ville" && txtCp.Text != "Code postal" && txtRue.Text.Length != 5)
            {
                drMission = MesDatas.DsGlobal.Tables["Mission"].NewRow();

                int idNatureSinistre = Convert.ToInt32(cboNatureSinitre.SelectedValue);
                int idCaserne = Convert.ToInt32(cboCaserne.SelectedValue);
                drMission["id"] = idMission;

                //On remplit la ligne de la mission
                    //Heure de départ
                string date = lblDate.Text;
                string day = date.Substring(0, 2);
                string month = date.Substring(3, 2);
                string year = date.Substring(6, 4);
                string heure = lblHeure.Text;
                drMission["dateHeureDepart"] = year + "-" + month + "-" + day + " " + heure;

                drMission["motifAppel"] = txtMotif.Text;
                drMission["adresse"] = txtRue.Text;
                drMission["ville"] = txtVille.Text;
                drMission["cp"] = txtCp.Text;
                drMission["terminee"] = 0;
                drMission["idNatureSinistre"] = idNatureSinistre;
                drMission["idCaserne"] = cboCaserne.SelectedValue;

                 //On met à null (on ne sait pas encore)
                drMission["compteRendu"] = null;
                drMission["dateHeureRetour"] = null;

                //On récupère les types d'engins nécessaires et leur nombre
                string filtreSinistre = "idNatureSinistre = " + idNatureSinistre;
                DataRow[] typesNecessaires = MesDatas.DsGlobal.Tables["Necessiter"].Select(filtreSinistre);

                int hautVehicule = pnlDecisions.Top;
                int gaucheVehicule = 250;
                int hautPompier = pnlInfosUsagers.Top - 140;
                int gauchePompier = 250;
                int nbMobilisesTotal = 0;
                int nbEnginTotal = 0; //Nombre total d'engins à mobiliser (utilisé pour l'affichage)

                foreach (DataRow typeEngin in typesNecessaires) 
                { 
                    string codeType = typeEngin["codeTypeEngin"].ToString();
                    int nombreType = Convert.ToInt32(typeEngin["nombre"]);

                    string filtreEngin = "codeTypeEngin = '" + codeType + "' and idCaserne = " + idCaserne;
                    DataRow[] engins = MesDatas.DsGlobal.Tables["Engin"].Select(filtreEngin);


                    if (engins.Length < nombreType)
                    {
                        //Pas assez d'engin de ce type dans la caserne
                        MessageBox.Show("Pas assez d'engin de type " + codeType + " dans la caserne, veuillez choisir une autre caserne.");
                        desafichage();
                        return;
                    }

                    int nbEnginsMobilises = 0; //On veut mobiliser nombreType de ce type d'engin

                    //On va chercher les engins de ce type dans la caserne
                    for (int i=0; i<engins.Length; i++)
                    {
                        DataRow engin = engins[i];

                        //S'il n'est pas en mission ou en panne
                        if (Convert.ToInt64(engin["enMission"]) == 0 && Convert.ToInt64(engin["enPanne"]) == 0)
                        {
                            //Mobiliser l'engin (ajout à la table PartirAvec)
                            DataRow partAvec = MesDatas.DsGlobal.Tables["PartirAvec"].NewRow();
                            partAvec["idCaserne"] = idCaserne;
                            partAvec["codeTypeEngin"] = codeType;
                            partAvec["numeroEngin"] = engin["numero"];
                            partAvec["idMission"] = idMission;
                            partAvec["reparationsEventuelles"] = null;
                            partirAvec.Add(partAvec);

                            //Mobilisation des pompiers de cet engin
                            string filtreEmbarquer = "codeTypeEngin = '" + codeType + "'";
                            DataRow[] habEmbarquees = MesDatas.DsGlobal.Tables["Embarquer"].Select(filtreEmbarquer);

                           
                            //Par habilitation
                            foreach (DataRow hab in habEmbarquees)
                            {
                                int idHabilitation = Convert.ToInt32(hab["idHabilitation"]);
                                int nbPompiersHab = Convert.ToInt32(hab["nombre"]);             //Nombre de pompiers requis avec cette habilitation

                                //On va chercher les pompiers qui ont cette habilitation
                                string filtrePompiers = "idHabilitation = " + idHabilitation;
                                DataRow[] pompiersHab = MesDatas.DsGlobal.Tables["Passer"].Select(filtrePompiers);      //Toutes les lignes de la table Passer avec les pompiers ayant cette habilitation
                                
                                //Recuperation du nom de l'habilitation
                                string filtreNomHabilitation = "id = " + idHabilitation;
                                DataRow[] nomHabilitation = MesDatas.DsGlobal.Tables["Habilitation"].Select(filtreNomHabilitation);
                                string nomHab = nomHabilitation[0]["libelle"].ToString();

                                if (pompiersHab.Length == 0)
                                {
                                    //Il n'y a pas de pompiers avec cette habilitation, la mission n'est pas possible
                                    MessageBox.Show("Pas assez de pompiers avec l'habilitation " + nomHab + " pour l'engin de type " + codeType + ". La mission n'est pas possible.");
                                    desafichage();
                                    return;
                                }

                                if(pompiersHab.Length < nbPompiersHab)
                                {
                                    MessageBox.Show("Il n'y aura pas assez de pompiers avec cette habilitation");
                                }

                                int nbMobilisesHab = 0;

                                //On va aller chercher les pompiers qui ont cette habilitation (on veut en mobiliser nbPompiersHab)
                                for (int j= 0; j< pompiersHab.Length; j++)
                                {
                                    DataRow pompierHab = pompiersHab[j];        //Ligne de la table Passer
                                    string matricule = pompierHab["matriculePompier"].ToString();

                                    //On regarde s'il est actuellement affecté à la caserne
                                    string filtreAffectation = "matriculePompier = " + matricule + " and idCaserne = " + idCaserne + " and dateFin IS NULL";
                                    DataRow[] affectation = MesDatas.DsGlobal.Tables["Affectation"].Select(filtreAffectation);

                                    if(affectation.Length == 0)
                                    {
                                        //Il n'est pas affecté à cette caserne, on ne peut pas le mobiliser
                                        continue;
                                    }

                                    //On va mobiliser le pompier
                                    string filtrePompier = "matricule = " + matricule;
                                    DataRow[] pompier = MesDatas.DsGlobal.Tables["Pompier"].Select(filtrePompier);

                                    if (Convert.ToInt64(pompier[0]["enMission"]) == 1 || Convert.ToInt64(pompier[0]["enConge"]) == 1)
                                    {
                                        //Il est déjà en mission ou en congé, on ne peut pas le mobiliser
                                        continue;
                                    }

                                    //On le mobilise
                                    DataRow mobilise = MesDatas.DsGlobal.Tables["Mobiliser"].NewRow();
                                    mobilise["matriculePompier"] = Convert.ToInt32(matricule);
                                    mobilise["idMission"] = idMission;
                                    mobilise["idHabilitation"] = idHabilitation;
                                    mobiliser.Add(mobilise);

                                    //MessageBox.Show("Mobilisation du pompier " + matricule + " pour l'habilitation " + idHabilitation);

                                    //On modifie le pompier pour qu'il soit en mission
                                    pompier[0]["enMission"] = 1;

                                    //afficher le pompier
                                    afficherPompiers afficherPompiers = new afficherPompiers(matricule, nomHab, pompier[0]["sexe"].ToString(), pompier[0]["nom"].ToString() + " " + pompier[0]["prenom"].ToString());

                                    afficherPompiers.Top = hautPompier;
                                    afficherPompiers.Left = gauchePompier;
                                    //MessageBox.Show("Pompier affiché ! (haut/gauche) : " + hautPompier + "/" + gauchePompier);
                                    tbpMission.Controls.Add(afficherPompiers);
                                    
                                    nbMobilisesHab++;
                                    nbMobilisesTotal++;

                                    if (nbMobilisesTotal %4 == 0)
                                    {
                                        hautPompier += afficherPompiers.Height - 10;
                                        gauchePompier = 250;
                                    }
                                    else
                                    {
                                        gauchePompier += 175;
                                    }

                                    if (nbMobilisesHab == nbPompiersHab)
                                    {
                                        //On a mobilisé le bon nombre de pompiers pour cette habilitation
                                        break;
                                    }
                                }

                                if(nbMobilisesHab == 0)
                                {
                                    //Il n'y a aucun pompier pour cette habilitation dans la caserne
                                    MessageBox.Show("Un des engins n'a pas de pompiers disponibles dans la caserne pour l'habilitation " + nomHab + ". Veuillez choisir une autre caserne ou attendre que les pompiers soient de retour.");
                                    desafichage();
                                    return;
                                }
                            }

                            //Modification dans le DataSet de l'engin pour qu'il ne soit plus disponible
                            engin["enMission"] = 1;
                            nbEnginsMobilises++;

                            //Affichage de l'engin (tous les pompiers de cet engin ont pu être mobilisés)
                            affichageVehicules vehicule = new affichageVehicules(codeType, Convert.ToInt32(engin["numero"]));

                            vehicule.Top = hautVehicule;
                            vehicule.Left = gaucheVehicule;

                            tbpMission.Controls.Add(vehicule);
                            
                            nbEnginTotal++;
                            
                            if (nbEnginTotal % 5 == 0)
                            {
                                hautVehicule += vehicule.Height - 10;
                                gaucheVehicule = 250;
                            }
                            else
                            {
                                gaucheVehicule += vehicule.Width - 50;
                            }

                            if (nbEnginsMobilises == nombreType)
                            {
                                //On a mobilisé le bon nombre d'engins
                                break;
                            }
                        }
                    }
                }

                //On a mobilisé tous les engins et pompiers nécessaires, on peut valider la mission
                btnValider.Enabled = true;
                btnValider.ForeColor = Color.Navy;
                btnValider.Font = new Font(btnValider.Font, FontStyle.Bold);
                btnValider.Cursor = Cursors.Hand;
                btnConstituerEquipe.Enabled = false;
                btnConstituerEquipe.ForeColor = Color.Black;
                btnConstituerEquipe.Font = new Font(btnConstituerEquipe.Font, FontStyle.Regular);
                btnConstituerEquipe.Cursor = Cursors.No;
                MessageBox.Show("L'équipe a été constituée avec succès ! Vous pouvez maintenant valider la mission.");
            }
            else
            {
                //On vérifie quels champs sont vides et on déclence l'erreur
                if (txtMotif.Text == "Motif")
                {
                    afficherErreur(txtMotif, "Le motif est obligatoire.");
                }

                if (txtRue.Text == "Rue")
                {
                    afficherErreur(txtRue, "La rue est obligatoire.");
                }

                if (txtVille.Text == "Ville")
                {
                    afficherErreur(txtVille, "La ville est obligatoire.");
                }

                if (txtCp.Text == "Code postal" || txtRue.Text.Length != 5)
                {
                    afficherErreur(txtCp, "Le code postal est obligatoire et doit être de 5 chiffres.");
                }
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //Ajout dans la base de données
            MesDatas.DsGlobal.Tables["Mission"].Rows.Add(drMission);

            foreach (DataRow dr in partirAvec)
            {
                MesDatas.DsGlobal.Tables["PartirAvec"].Rows.Add(dr);
            }

            foreach (DataRow dr in mobiliser)
            {
                MesDatas.DsGlobal.Tables["Mobiliser"].Rows.Add(dr);
            }

            MessageBox.Show("Mission n° " + idMission.ToString() + " créée avec succès ! Ajout dans la base de donnée effectué");
            MesDatas.DsGlobal.AcceptChanges(); //On valide les modifications dans le DataSet
            reset();
        }

        private void reset()
        {
            desafichage();
            btnValider.Enabled = false;
            btnConstituerEquipe.Enabled = true;
            btnValider.ForeColor = Color.Black;
            btnValider.Font = new Font(btnValider.Font, FontStyle.Regular);
            btnValider.Cursor = Cursors.No;
            btnConstituerEquipe.Cursor = Cursors.Hand;
            btnConstituerEquipe.ForeColor = Color.Navy;
            btnConstituerEquipe.Font = new Font(btnConstituerEquipe.Font, FontStyle.Bold);
            txtMotif.Text = "";
            SetTextDescription(txtMotif, "Motif");
            txtRue.Text = "";
            SetTextDescription(txtRue, "Rue");
            txtCp.Text = "";
            SetTextDescription(txtCp, "Code Postal");
            txtVille.Text = "";
            SetTextDescription(txtVille, "Ville");
            idMission = MesDatas.DsGlobal.Tables["Mission"].Rows.Count + 1;
            tabControl1.Controls[0].Text = "Mission n° " + idMission.ToString();
            DateTime date = DateTime.Now;
            lblDate.Text = date.ToString("dd/MM/yyyy");
            lblHeure.Text = date.ToString("HH:mm:ss").Substring(0, 5);

            partirAvec.Clear();
            mobiliser.Clear();

        }

    }
}