namespace PimPomBro
{
    partial class frmEtatVehicule
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
            this.pctEngin = new System.Windows.Forms.PictureBox();
            this.lblEngin = new System.Windows.Forms.Label();
            this.chkPanne = new System.Windows.Forms.CheckBox();
            this.txtReparations = new System.Windows.Forms.TextBox();
            this.lblReparations = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctEngin)).BeginInit();
            this.SuspendLayout();
            // 
            // pctEngin
            // 
            this.pctEngin.Location = new System.Drawing.Point(30, 25);
            this.pctEngin.Name = "pctEngin";
            this.pctEngin.Size = new System.Drawing.Size(174, 124);
            this.pctEngin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctEngin.TabIndex = 0;
            this.pctEngin.TabStop = false;
            // 
            // lblEngin
            // 
            this.lblEngin.AutoSize = true;
            this.lblEngin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngin.Location = new System.Drawing.Point(246, 36);
            this.lblEngin.Name = "lblEngin";
            this.lblEngin.Size = new System.Drawing.Size(97, 27);
            this.lblEngin.TabIndex = 2;
            this.lblEngin.Text = "Etat du ";
            // 
            // chkPanne
            // 
            this.chkPanne.AutoSize = true;
            this.chkPanne.Location = new System.Drawing.Point(251, 95);
            this.chkPanne.Name = "chkPanne";
            this.chkPanne.Size = new System.Drawing.Size(101, 23);
            this.chkPanne.TabIndex = 3;
            this.chkPanne.Text = "En panne";
            this.chkPanne.UseVisualStyleBackColor = true;
            this.chkPanne.CheckedChanged += new System.EventHandler(this.chkPanne_CheckedChanged);
            // 
            // txtReparations
            // 
            this.txtReparations.Location = new System.Drawing.Point(206, 182);
            this.txtReparations.Multiline = true;
            this.txtReparations.Name = "txtReparations";
            this.txtReparations.Size = new System.Drawing.Size(446, 102);
            this.txtReparations.TabIndex = 4;
            this.txtReparations.Visible = false;
            // 
            // lblReparations
            // 
            this.lblReparations.AutoSize = true;
            this.lblReparations.Location = new System.Drawing.Point(10, 223);
            this.lblReparations.Name = "lblReparations";
            this.lblReparations.Size = new System.Drawing.Size(190, 19);
            this.lblReparations.TabIndex = 5;
            this.lblReparations.Text = "Réparations à effectuer :";
            this.lblReparations.Visible = false;
            // 
            // btnValider
            // 
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(499, 89);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(153, 34);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // frmEtatVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 320);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblReparations);
            this.Controls.Add(this.txtReparations);
            this.Controls.Add(this.chkPanne);
            this.Controls.Add(this.lblEngin);
            this.Controls.Add(this.pctEngin);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEtatVehicule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Etat du véhicule";
            ((System.ComponentModel.ISupportInitialize)(this.pctEngin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctEngin;
        private System.Windows.Forms.Label lblEngin;
        private System.Windows.Forms.CheckBox chkPanne;
        private System.Windows.Forms.TextBox txtReparations;
        private System.Windows.Forms.Label lblReparations;
        private System.Windows.Forms.Button btnValider;
    }
}