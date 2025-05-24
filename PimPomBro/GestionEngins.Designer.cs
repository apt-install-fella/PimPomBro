namespace PimPomBro
{
    partial class frmGestionEngins
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionEngins));
            this.pnlCaserne = new System.Windows.Forms.Panel();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.pctEngin = new System.Windows.Forms.PictureBox();
            this.pnlInfosEngin = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.chkMission = new System.Windows.Forms.CheckBox();
            this.chkPanne = new System.Windows.Forms.CheckBox();
            this.lblReparations = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.pnlCaserne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEngin)).BeginInit();
            this.pnlInfosEngin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCaserne
            // 
            this.pnlCaserne.BackColor = System.Drawing.Color.Transparent;
            this.pnlCaserne.BackgroundImage = global::PimPomBro.Properties.Resources.fond_onglet_volet2;
            this.pnlCaserne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCaserne.Controls.Add(this.cboCaserne);
            this.pnlCaserne.Controls.Add(this.lblCaserne);
            this.pnlCaserne.Location = new System.Drawing.Point(821, 41);
            this.pnlCaserne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCaserne.Name = "pnlCaserne";
            this.pnlCaserne.Size = new System.Drawing.Size(473, 75);
            this.pnlCaserne.TabIndex = 1;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserne.Location = new System.Drawing.Point(14, 25);
            this.lblCaserne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(196, 24);
            this.lblCaserne.TabIndex = 0;
            this.lblCaserne.Text = "Choix de la caserne";
            // 
            // cboCaserne
            // 
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(208, 22);
            this.cboCaserne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(252, 31);
            this.cboCaserne.TabIndex = 1;
            this.cboCaserne.SelectionChangeCommitted += new System.EventHandler(this.cboCaserne_SelectionChangeCommitted);
            // 
            // pctEngin
            // 
            this.pctEngin.BackColor = System.Drawing.Color.Transparent;
            this.pctEngin.Location = new System.Drawing.Point(30, 41);
            this.pctEngin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctEngin.Name = "pctEngin";
            this.pctEngin.Size = new System.Drawing.Size(353, 275);
            this.pctEngin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctEngin.TabIndex = 2;
            this.pctEngin.TabStop = false;
            // 
            // pnlInfosEngin
            // 
            this.pnlInfosEngin.BackColor = System.Drawing.Color.Transparent;
            this.pnlInfosEngin.BackgroundImage = global::PimPomBro.Properties.Resources.fond_onglet_volet2;
            this.pnlInfosEngin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlInfosEngin.Controls.Add(this.chkPanne);
            this.pnlInfosEngin.Controls.Add(this.chkMission);
            this.pnlInfosEngin.Controls.Add(this.lblDate);
            this.pnlInfosEngin.Controls.Add(this.lblID);
            this.pnlInfosEngin.Location = new System.Drawing.Point(404, 41);
            this.pnlInfosEngin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlInfosEngin.Name = "pnlInfosEngin";
            this.pnlInfosEngin.Size = new System.Drawing.Size(399, 275);
            this.pnlInfosEngin.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(17, 30);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(107, 23);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Identifiant :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(17, 97);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(145, 23);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date d\'arrivée :";
            // 
            // chkMission
            // 
            this.chkMission.AutoSize = true;
            this.chkMission.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMission.Location = new System.Drawing.Point(17, 160);
            this.chkMission.Name = "chkMission";
            this.chkMission.Size = new System.Drawing.Size(126, 27);
            this.chkMission.TabIndex = 2;
            this.chkMission.Text = "En mission";
            this.chkMission.UseVisualStyleBackColor = true;
            // 
            // chkPanne
            // 
            this.chkPanne.AutoSize = true;
            this.chkPanne.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPanne.Location = new System.Drawing.Point(17, 222);
            this.chkPanne.Name = "chkPanne";
            this.chkPanne.Size = new System.Drawing.Size(114, 27);
            this.chkPanne.TabIndex = 3;
            this.chkPanne.Text = "En panne";
            this.chkPanne.UseVisualStyleBackColor = true;
            // 
            // lblReparations
            // 
            this.lblReparations.AutoSize = true;
            this.lblReparations.BackColor = System.Drawing.Color.Transparent;
            this.lblReparations.Location = new System.Drawing.Point(835, 171);
            this.lblReparations.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblReparations.Name = "lblReparations";
            this.lblReparations.Size = new System.Drawing.Size(245, 23);
            this.lblReparations.TabIndex = 4;
            this.lblReparations.Text = "Réparations nécessaires : ";
            this.lblReparations.Visible = false;
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Transparent;
            this.btnFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFirst.BackgroundImage")));
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFirst.Location = new System.Drawing.Point(784, 419);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(101, 91);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.BackColor = System.Drawing.Color.Transparent;
            this.btnSuivant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuivant.BackgroundImage")));
            this.btnSuivant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuivant.Location = new System.Drawing.Point(1029, 419);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(103, 91);
            this.btnSuivant.TabIndex = 5;
            this.btnSuivant.UseVisualStyleBackColor = false;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.BackColor = System.Drawing.Color.Transparent;
            this.btnPrecedent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrecedent.BackgroundImage")));
            this.btnPrecedent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrecedent.Location = new System.Drawing.Point(916, 419);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(102, 91);
            this.btnPrecedent.TabIndex = 6;
            this.btnPrecedent.UseVisualStyleBackColor = false;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Transparent;
            this.btnLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLast.BackgroundImage")));
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLast.Location = new System.Drawing.Point(1168, 419);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(98, 91);
            this.btnLast.TabIndex = 7;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(30, 495);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(198, 40);
            this.btnRetour.TabIndex = 8;
            this.btnRetour.Text = "Retour au menu";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // frmGestionEngins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::PimPomBro.Properties.Resources.Fond_Form_volet2;
            this.ClientSize = new System.Drawing.Size(1294, 563);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblReparations);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.pnlInfosEngin);
            this.Controls.Add(this.pctEngin);
            this.Controls.Add(this.pnlCaserne);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGestionEngins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventaire des engins";
            this.Load += new System.EventHandler(this.frmGestionEngins_Load);
            this.pnlCaserne.ResumeLayout(false);
            this.pnlCaserne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEngin)).EndInit();
            this.pnlInfosEngin.ResumeLayout(false);
            this.pnlInfosEngin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlCaserne;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.PictureBox pctEngin;
        private System.Windows.Forms.Panel pnlInfosEngin;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.CheckBox chkPanne;
        private System.Windows.Forms.CheckBox chkMission;
        private System.Windows.Forms.Label lblReparations;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnRetour;
    }
}