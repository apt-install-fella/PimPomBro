namespace PimPomBro
{
    partial class frmCompteRendu
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
            this.lblCloture = new System.Windows.Forms.Label();
            this.txtCompteRendu = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblCompteRendu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCloture
            // 
            this.lblCloture.AutoSize = true;
            this.lblCloture.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloture.Location = new System.Drawing.Point(12, 20);
            this.lblCloture.Name = "lblCloture";
            this.lblCloture.Size = new System.Drawing.Size(284, 27);
            this.lblCloture.TabIndex = 0;
            this.lblCloture.Text = "Clôture de la mission n° ";
            // 
            // txtCompteRendu
            // 
            this.txtCompteRendu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompteRendu.ForeColor = System.Drawing.Color.Black;
            this.txtCompteRendu.Location = new System.Drawing.Point(32, 98);
            this.txtCompteRendu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompteRendu.Multiline = true;
            this.txtCompteRendu.Name = "txtCompteRendu";
            this.txtCompteRendu.Size = new System.Drawing.Size(469, 189);
            this.txtCompteRendu.TabIndex = 1;
            this.txtCompteRendu.TextChanged += new System.EventHandler(this.txtCompteRendu_TextChanged);
            // 
            // btnValider
            // 
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.Enabled = false;
            this.btnValider.Location = new System.Drawing.Point(351, 311);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(150, 39);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(32, 311);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(181, 39);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Sans compte rendu";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblCompteRendu
            // 
            this.lblCompteRendu.AutoSize = true;
            this.lblCompteRendu.Location = new System.Drawing.Point(28, 75);
            this.lblCompteRendu.Name = "lblCompteRendu";
            this.lblCompteRendu.Size = new System.Drawing.Size(122, 19);
            this.lblCompteRendu.TabIndex = 4;
            this.lblCompteRendu.Text = "Compte rendu :";
            // 
            // frmCompteRendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(521, 365);
            this.Controls.Add(this.lblCompteRendu);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtCompteRendu);
            this.Controls.Add(this.lblCloture);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCompteRendu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Compte rendu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCloture;
        private System.Windows.Forms.TextBox txtCompteRendu;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblCompteRendu;
    }
}