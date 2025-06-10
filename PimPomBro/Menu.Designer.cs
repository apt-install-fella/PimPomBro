namespace MenuPrincipal
{
    partial class frmTabBord
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
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnGestionDuPersonnel = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnStatistiques = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGestionDesEngins = new System.Windows.Forms.Button();
            this.btnNouvelleMission = new System.Windows.Forms.Button();
            this.btnrecherche = new System.Windows.Forms.Button();
            this.chkEnCours = new System.Windows.Forms.CheckBox();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(398, 123);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1072, 719);
            this.panel.TabIndex = 9;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.BackgroundImage = global::PimPomBro.Properties.Resources.fond_onglet_volet2;
            this.groupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox.Controls.Add(this.btnGestionDuPersonnel);
            this.groupBox.Controls.Add(this.button5);
            this.groupBox.Controls.Add(this.btnQuit);
            this.groupBox.Controls.Add(this.button4);
            this.groupBox.Controls.Add(this.btnStatistiques);
            this.groupBox.Controls.Add(this.button3);
            this.groupBox.Controls.Add(this.button2);
            this.groupBox.Controls.Add(this.btnGestionDesEngins);
            this.groupBox.Controls.Add(this.btnNouvelleMission);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox.Location = new System.Drawing.Point(12, 160);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(367, 453);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Menu";
            // 
            // btnGestionDuPersonnel
            // 
            this.btnGestionDuPersonnel.BackColor = System.Drawing.Color.White;
            this.btnGestionDuPersonnel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionDuPersonnel.ForeColor = System.Drawing.Color.Navy;
            this.btnGestionDuPersonnel.Location = new System.Drawing.Point(74, 202);
            this.btnGestionDuPersonnel.Name = "btnGestionDuPersonnel";
            this.btnGestionDuPersonnel.Size = new System.Drawing.Size(272, 49);
            this.btnGestionDuPersonnel.TabIndex = 3;
            this.btnGestionDuPersonnel.Text = "Gestion du personnel";
            this.btnGestionDuPersonnel.UseVisualStyleBackColor = false;
            this.btnGestionDuPersonnel.Click += new System.EventHandler(this.btnGestionDuPersonnel_Click);
            this.btnGestionDuPersonnel.MouseEnter += new System.EventHandler(this.btnTableauDeBord_MouseEnter);
            this.btnGestionDuPersonnel.MouseLeave += new System.EventHandler(this.btnTableauDeBord_MouseLeave);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.ForeColor = System.Drawing.Color.Navy;
            this.button5.Location = new System.Drawing.Point(23, 268);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 49);
            this.button5.TabIndex = 9;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.DarkGray;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnQuit.Location = new System.Drawing.Point(20, 373);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(123, 60);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.ForeColor = System.Drawing.Color.Navy;
            this.button4.Location = new System.Drawing.Point(23, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 49);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnStatistiques
            // 
            this.btnStatistiques.BackColor = System.Drawing.Color.White;
            this.btnStatistiques.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistiques.ForeColor = System.Drawing.Color.Navy;
            this.btnStatistiques.Location = new System.Drawing.Point(74, 268);
            this.btnStatistiques.Name = "btnStatistiques";
            this.btnStatistiques.Size = new System.Drawing.Size(272, 49);
            this.btnStatistiques.TabIndex = 4;
            this.btnStatistiques.Text = "Statistiques";
            this.btnStatistiques.UseVisualStyleBackColor = false;
            this.btnStatistiques.Click += new System.EventHandler(this.btnStatistiques_Click);
            this.btnStatistiques.MouseEnter += new System.EventHandler(this.btnTableauDeBord_MouseEnter);
            this.btnStatistiques.MouseLeave += new System.EventHandler(this.btnTableauDeBord_MouseLeave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(23, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 49);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(23, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 49);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnGestionDesEngins
            // 
            this.btnGestionDesEngins.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGestionDesEngins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionDesEngins.ForeColor = System.Drawing.Color.Navy;
            this.btnGestionDesEngins.Location = new System.Drawing.Point(74, 134);
            this.btnGestionDesEngins.Name = "btnGestionDesEngins";
            this.btnGestionDesEngins.Size = new System.Drawing.Size(272, 49);
            this.btnGestionDesEngins.TabIndex = 2;
            this.btnGestionDesEngins.Text = "Inventaire des engins";
            this.btnGestionDesEngins.UseVisualStyleBackColor = false;
            this.btnGestionDesEngins.Click += new System.EventHandler(this.btnGestionDesEngins_Click);
            this.btnGestionDesEngins.MouseEnter += new System.EventHandler(this.btnTableauDeBord_MouseEnter);
            this.btnGestionDesEngins.MouseLeave += new System.EventHandler(this.btnTableauDeBord_MouseLeave);
            // 
            // btnNouvelleMission
            // 
            this.btnNouvelleMission.BackColor = System.Drawing.Color.White;
            this.btnNouvelleMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNouvelleMission.ForeColor = System.Drawing.Color.Navy;
            this.btnNouvelleMission.Location = new System.Drawing.Point(74, 65);
            this.btnNouvelleMission.Name = "btnNouvelleMission";
            this.btnNouvelleMission.Size = new System.Drawing.Size(272, 49);
            this.btnNouvelleMission.TabIndex = 1;
            this.btnNouvelleMission.Text = "Nouvelle mission";
            this.btnNouvelleMission.UseVisualStyleBackColor = false;
            this.btnNouvelleMission.Click += new System.EventHandler(this.btnNouvelleMission_Click);
            this.btnNouvelleMission.MouseEnter += new System.EventHandler(this.btnTableauDeBord_MouseEnter);
            this.btnNouvelleMission.MouseLeave += new System.EventHandler(this.btnTableauDeBord_MouseLeave);
            // 
            // btnrecherche
            // 
            this.btnrecherche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrecherche.Location = new System.Drawing.Point(1420, 55);
            this.btnrecherche.Name = "btnrecherche";
            this.btnrecherche.Size = new System.Drawing.Size(37, 31);
            this.btnrecherche.TabIndex = 11;
            this.btnrecherche.UseVisualStyleBackColor = true;
            this.btnrecherche.Click += new System.EventHandler(this.btnrecherche_Click);
            // 
            // chkEnCours
            // 
            this.chkEnCours.AutoSize = true;
            this.chkEnCours.Font = new System.Drawing.Font("Arial", 15.75F);
            this.chkEnCours.Location = new System.Drawing.Point(447, 55);
            this.chkEnCours.Name = "chkEnCours";
            this.chkEnCours.Size = new System.Drawing.Size(144, 36);
            this.chkEnCours.TabIndex = 12;
            this.chkEnCours.Text = "En cours";
            this.chkEnCours.UseVisualStyleBackColor = true;
            this.chkEnCours.CheckedChanged += new System.EventHandler(this.chkEnCours_CheckedChanged);
            // 
            // txtRecherche
            // 
            this.txtRecherche.ForeColor = System.Drawing.Color.Black;
            this.txtRecherche.Location = new System.Drawing.Point(1277, 53);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(139, 37);
            this.txtRecherche.TabIndex = 7;
            this.txtRecherche.TextChanged += new System.EventHandler(this.btnrecherche_Click);
            this.txtRecherche.Enter += new System.EventHandler(this.txtRecherche_Enter);
            this.txtRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecherche_KeyPress);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogo.Image = global::PimPomBro.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(86, -17);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(213, 190);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 10;
            this.picLogo.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 15.75F);
            this.lblID.Location = new System.Drawing.Point(1214, 56);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 32);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID :";
            // 
            // frmTabBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 854);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.chkEnCours);
            this.Controls.Add(this.btnrecherche);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.picLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmTabBord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnStatistiques;
        private System.Windows.Forms.Button btnGestionDuPersonnel;
        private System.Windows.Forms.Button btnGestionDesEngins;
        private System.Windows.Forms.Button btnNouvelleMission;
        private System.Windows.Forms.Button btnrecherche;
        private System.Windows.Forms.CheckBox chkEnCours;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblID;
    }
}

