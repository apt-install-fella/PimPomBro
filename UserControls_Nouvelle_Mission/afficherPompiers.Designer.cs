namespace UserControls_Nouvelle_Mission
{
    partial class afficherPompiers
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pctPompier = new System.Windows.Forms.PictureBox();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.lblHab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctPompier)).BeginInit();
            this.SuspendLayout();
            // 
            // pctPompier
            // 
            this.pctPompier.Location = new System.Drawing.Point(3, 0);
            this.pctPompier.Name = "pctPompier";
            this.pctPompier.Size = new System.Drawing.Size(80, 101);
            this.pctPompier.TabIndex = 0;
            this.pctPompier.TabStop = false;
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricule.Location = new System.Drawing.Point(86, 12);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(85, 19);
            this.lblMatricule.TabIndex = 3;
            this.lblMatricule.Text = "Matricule :";
            this.lblMatricule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHab
            // 
            this.lblHab.AutoSize = true;
            this.lblHab.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHab.Location = new System.Drawing.Point(89, 52);
            this.lblHab.Name = "lblHab";
            this.lblHab.Size = new System.Drawing.Size(98, 19);
            this.lblHab.TabIndex = 4;
            this.lblHab.Text = "Habilitation :";
            this.lblHab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // afficherPompiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblHab);
            this.Controls.Add(this.lblMatricule);
            this.Controls.Add(this.pctPompier);
            this.Name = "afficherPompiers";
            this.Size = new System.Drawing.Size(218, 104);
            ((System.ComponentModel.ISupportInitialize)(this.pctPompier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctPompier;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label lblHab;
    }
}
