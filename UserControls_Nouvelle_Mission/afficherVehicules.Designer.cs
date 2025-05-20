namespace UserControls_Nouvelle_Mission
{
    partial class affichageVehicules
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
            this.pctEngin = new System.Windows.Forms.PictureBox();
            this.lblCodeEngin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctEngin)).BeginInit();
            this.SuspendLayout();
            // 
            // pctEngin
            // 
            this.pctEngin.Location = new System.Drawing.Point(0, -13);
            this.pctEngin.Name = "pctEngin";
            this.pctEngin.Size = new System.Drawing.Size(83, 101);
            this.pctEngin.TabIndex = 0;
            this.pctEngin.TabStop = false;
            // 
            // lblCodeEngin
            // 
            this.lblCodeEngin.AutoSize = true;
            this.lblCodeEngin.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeEngin.Location = new System.Drawing.Point(84, 23);
            this.lblCodeEngin.Name = "lblCodeEngin";
            this.lblCodeEngin.Size = new System.Drawing.Size(54, 19);
            this.lblCodeEngin.TabIndex = 1;
            this.lblCodeEngin.Text = "Type :";
            // 
            // affichageVehicules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblCodeEngin);
            this.Controls.Add(this.pctEngin);
            this.Name = "affichageVehicules";
            this.Size = new System.Drawing.Size(146, 63);
            ((System.ComponentModel.ISupportInitialize)(this.pctEngin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctEngin;
        private System.Windows.Forms.Label lblCodeEngin;
    }
}
