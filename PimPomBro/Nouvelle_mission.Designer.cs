namespace PimPomBro
{
    partial class frmMission
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMission));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpMission = new System.Windows.Forms.TabPage();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConstituerEquipe = new System.Windows.Forms.Button();
            this.pnlDecisions = new System.Windows.Forms.Panel();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.cboNatureSinitre = new System.Windows.Forms.ComboBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblNatureSinistre = new System.Windows.Forms.Label();
            this.lblDecisions = new System.Windows.Forms.Label();
            this.pnlInfosUsagers = new System.Windows.Forms.Panel();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.lblAdr = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.lblTitrePanel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.lblDeclenche = new System.Windows.Forms.Label();
            this.erpErreurSaisie = new System.Windows.Forms.ErrorProvider(this.components);
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tbpMission.SuspendLayout();
            this.pnlDecisions.SuspendLayout();
            this.pnlInfosUsagers.SuspendLayout();
            this.pnlDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpErreurSaisie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpMission);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 37);
            this.tabControl1.Location = new System.Drawing.Point(21, 80);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1427, 811);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpMission
            // 
            this.tbpMission.BackColor = System.Drawing.Color.Transparent;
            this.tbpMission.BackgroundImage = global::PimPomBro.Properties.Resources.fond_onglet_volet2;
            this.tbpMission.Controls.Add(this.btnValider);
            this.tbpMission.Controls.Add(this.btnFermer);
            this.tbpMission.Controls.Add(this.btnAnnuler);
            this.tbpMission.Controls.Add(this.btnConstituerEquipe);
            this.tbpMission.Controls.Add(this.pnlDecisions);
            this.tbpMission.Controls.Add(this.pnlInfosUsagers);
            this.tbpMission.ImageIndex = 0;
            this.tbpMission.Location = new System.Drawing.Point(4, 41);
            this.tbpMission.Margin = new System.Windows.Forms.Padding(2);
            this.tbpMission.Name = "tbpMission";
            this.tbpMission.Padding = new System.Windows.Forms.Padding(2);
            this.tbpMission.Size = new System.Drawing.Size(1419, 766);
            this.tbpMission.TabIndex = 0;
            this.tbpMission.Text = "Mission n° ";
            // 
            // btnValider
            // 
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.Location = new System.Drawing.Point(1215, 718);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(188, 36);
            this.btnValider.TabIndex = 10;
            this.btnValider.Text = "Valider la création";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFermer.Location = new System.Drawing.Point(1023, 718);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(188, 36);
            this.btnFermer.TabIndex = 9;
            this.btnFermer.Text = "Retour au menu";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.Location = new System.Drawing.Point(16, 718);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(159, 36);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler les saisies";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConstituerEquipe
            // 
            this.btnConstituerEquipe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConstituerEquipe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConstituerEquipe.ForeColor = System.Drawing.Color.Navy;
            this.btnConstituerEquipe.Location = new System.Drawing.Point(178, 718);
            this.btnConstituerEquipe.Name = "btnConstituerEquipe";
            this.btnConstituerEquipe.Size = new System.Drawing.Size(188, 36);
            this.btnConstituerEquipe.TabIndex = 7;
            this.btnConstituerEquipe.Text = "Former la mission";
            this.btnConstituerEquipe.UseVisualStyleBackColor = true;
            this.btnConstituerEquipe.Click += new System.EventHandler(this.btnConstituerEquipe_Click);
            // 
            // pnlDecisions
            // 
            this.pnlDecisions.BackColor = System.Drawing.Color.White;
            this.pnlDecisions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecisions.Controls.Add(this.cboCaserne);
            this.pnlDecisions.Controls.Add(this.cboNatureSinitre);
            this.pnlDecisions.Controls.Add(this.lblCaserne);
            this.pnlDecisions.Controls.Add(this.lblNatureSinistre);
            this.pnlDecisions.Controls.Add(this.lblDecisions);
            this.pnlDecisions.Location = new System.Drawing.Point(22, 17);
            this.pnlDecisions.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDecisions.Name = "pnlDecisions";
            this.pnlDecisions.Size = new System.Drawing.Size(301, 195);
            this.pnlDecisions.TabIndex = 6;
            // 
            // cboCaserne
            // 
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(18, 154);
            this.cboCaserne.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(204, 31);
            this.cboCaserne.TabIndex = 4;
            // 
            // cboNatureSinitre
            // 
            this.cboNatureSinitre.FormattingEnabled = true;
            this.cboNatureSinitre.Location = new System.Drawing.Point(18, 81);
            this.cboNatureSinitre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboNatureSinitre.Name = "cboNatureSinitre";
            this.cboNatureSinitre.Size = new System.Drawing.Size(262, 31);
            this.cboNatureSinitre.TabIndex = 3;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(14, 128);
            this.lblCaserne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(172, 23);
            this.lblCaserne.TabIndex = 2;
            this.lblCaserne.Text = "Caserne mobilisée";
            // 
            // lblNatureSinistre
            // 
            this.lblNatureSinistre.AutoSize = true;
            this.lblNatureSinistre.Location = new System.Drawing.Point(14, 55);
            this.lblNatureSinistre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNatureSinistre.Name = "lblNatureSinistre";
            this.lblNatureSinistre.Size = new System.Drawing.Size(163, 23);
            this.lblNatureSinistre.TabIndex = 1;
            this.lblNatureSinistre.Text = "Nature du sinistre";
            // 
            // lblDecisions
            // 
            this.lblDecisions.AutoSize = true;
            this.lblDecisions.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecisions.Location = new System.Drawing.Point(15, 14);
            this.lblDecisions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDecisions.Name = "lblDecisions";
            this.lblDecisions.Size = new System.Drawing.Size(240, 27);
            this.lblDecisions.TabIndex = 0;
            this.lblDecisions.Text = "Décisions générales";
            // 
            // pnlInfosUsagers
            // 
            this.pnlInfosUsagers.BackColor = System.Drawing.Color.White;
            this.pnlInfosUsagers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfosUsagers.Controls.Add(this.txtCp);
            this.pnlInfosUsagers.Controls.Add(this.txtVille);
            this.pnlInfosUsagers.Controls.Add(this.txtRue);
            this.pnlInfosUsagers.Controls.Add(this.lblAdr);
            this.pnlInfosUsagers.Controls.Add(this.txtMotif);
            this.pnlInfosUsagers.Controls.Add(this.lblTitrePanel);
            this.pnlInfosUsagers.Location = new System.Drawing.Point(22, 235);
            this.pnlInfosUsagers.Margin = new System.Windows.Forms.Padding(2);
            this.pnlInfosUsagers.Name = "pnlInfosUsagers";
            this.pnlInfosUsagers.Size = new System.Drawing.Size(335, 452);
            this.pnlInfosUsagers.TabIndex = 0;
            // 
            // txtCp
            // 
            this.txtCp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCp.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCp.Location = new System.Drawing.Point(20, 384);
            this.txtCp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(114, 30);
            this.txtCp.TabIndex = 5;
            this.txtCp.Text = "Code postal";
            this.txtCp.Enter += new System.EventHandler(this.txtMotif_Enter);
            this.txtCp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCp_KeyPress);
            this.txtCp.Leave += new System.EventHandler(this.txtCp_Leave);
            // 
            // txtVille
            // 
            this.txtVille.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVille.ForeColor = System.Drawing.Color.DarkGray;
            this.txtVille.Location = new System.Drawing.Point(20, 335);
            this.txtVille.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(292, 30);
            this.txtVille.TabIndex = 4;
            this.txtVille.Text = "Ville";
            this.txtVille.Enter += new System.EventHandler(this.txtMotif_Enter);
            this.txtVille.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVille_KeyPress);
            this.txtVille.Leave += new System.EventHandler(this.txtVille_Leave);
            // 
            // txtRue
            // 
            this.txtRue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRue.ForeColor = System.Drawing.Color.DarkGray;
            this.txtRue.Location = new System.Drawing.Point(22, 286);
            this.txtRue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(290, 30);
            this.txtRue.TabIndex = 3;
            this.txtRue.Text = "Rue";
            this.txtRue.Enter += new System.EventHandler(this.txtMotif_Enter);
            this.txtRue.Leave += new System.EventHandler(this.txtRue_Leave);
            // 
            // lblAdr
            // 
            this.lblAdr.AutoSize = true;
            this.lblAdr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdr.Location = new System.Drawing.Point(14, 246);
            this.lblAdr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdr.Name = "lblAdr";
            this.lblAdr.Size = new System.Drawing.Size(178, 23);
            this.lblAdr.TabIndex = 2;
            this.lblAdr.Text = "Adresse du sinistre";
            // 
            // txtMotif
            // 
            this.txtMotif.AccessibleDescription = "";
            this.txtMotif.AccessibleName = "";
            this.txtMotif.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotif.ForeColor = System.Drawing.Color.DarkGray;
            this.txtMotif.Location = new System.Drawing.Point(20, 63);
            this.txtMotif.Margin = new System.Windows.Forms.Padding(2);
            this.txtMotif.Multiline = true;
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(292, 157);
            this.txtMotif.TabIndex = 1;
            this.txtMotif.Text = "Motif";
            this.txtMotif.Enter += new System.EventHandler(this.txtMotif_Enter);
            this.txtMotif.Leave += new System.EventHandler(this.txtMotif_Leave);
            // 
            // lblTitrePanel
            // 
            this.lblTitrePanel.AutoSize = true;
            this.lblTitrePanel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitrePanel.Location = new System.Drawing.Point(15, 17);
            this.lblTitrePanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitrePanel.Name = "lblTitrePanel";
            this.lblTitrePanel.Size = new System.Drawing.Size(315, 27);
            this.lblTitrePanel.TabIndex = 0;
            this.lblTitrePanel.Text = "Informations sur la mission";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "rouge_onglet_volet2.png");
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.BackColor = System.Drawing.Color.Transparent;
            this.lblHeure.Location = new System.Drawing.Point(290, 30);
            this.lblHeure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(67, 23);
            this.lblHeure.TabIndex = 6;
            this.lblHeure.Text = "00H00";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Location = new System.Drawing.Point(160, 30);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(128, 23);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "00.00.2025   ";
            // 
            // pnlDate
            // 
            this.pnlDate.BackColor = System.Drawing.Color.Transparent;
            this.pnlDate.Controls.Add(this.lblDeclenche);
            this.pnlDate.Controls.Add(this.lblDate);
            this.pnlDate.Controls.Add(this.lblHeure);
            this.pnlDate.Location = new System.Drawing.Point(1029, 65);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(419, 55);
            this.pnlDate.TabIndex = 7;
            // 
            // lblDeclenche
            // 
            this.lblDeclenche.AutoSize = true;
            this.lblDeclenche.BackColor = System.Drawing.Color.Transparent;
            this.lblDeclenche.Location = new System.Drawing.Point(2, 30);
            this.lblDeclenche.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeclenche.Name = "lblDeclenche";
            this.lblDeclenche.Size = new System.Drawing.Size(145, 23);
            this.lblDeclenche.TabIndex = 7;
            this.lblDeclenche.Text = "Déclenchée le :";
            // 
            // erpErreurSaisie
            // 
            this.erpErreurSaisie.ContainerControl = this;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogo.Image = global::PimPomBro.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(4, -5);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(95, 78);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 11;
            this.picLogo.TabStop = false;
            // 
            // frmMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PimPomBro.Properties.Resources.Fond_Form_volet2;
            this.ClientSize = new System.Drawing.Size(1463, 908);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.pnlDate);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmMission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouvelle mission";
            this.Load += new System.EventHandler(this.frmMission_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpMission.ResumeLayout(false);
            this.pnlDecisions.ResumeLayout(false);
            this.pnlDecisions.PerformLayout();
            this.pnlInfosUsagers.ResumeLayout(false);
            this.pnlInfosUsagers.PerformLayout();
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpErreurSaisie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpMission;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlInfosUsagers;
        private System.Windows.Forms.Label lblTitrePanel;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Label lblAdr;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.Panel pnlDecisions;
        private System.Windows.Forms.Label lblDecisions;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.ComboBox cboNatureSinitre;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblNatureSinistre;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.Label lblDeclenche;
        private System.Windows.Forms.ErrorProvider erpErreurSaisie;
        private System.Windows.Forms.Button btnConstituerEquipe;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.PictureBox picLogo;
    }
}

