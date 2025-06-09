namespace PimPomBro
{
    partial class dateHabilitation
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHab = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(16, 150);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(265, 22);
            this.dtpDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label1.Location = new System.Drawing.Point(16, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(267, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quelle est la date d\'obtention de cette habilitation ?\r\n";
            // 
            // lblHab
            // 
            this.lblHab.AutoSize = true;
            this.lblHab.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblHab.Location = new System.Drawing.Point(16, 38);
            this.lblHab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHab.MaximumSize = new System.Drawing.Size(267, 0);
            this.lblHab.Name = "lblHab";
            this.lblHab.Size = new System.Drawing.Size(98, 22);
            this.lblHab.TabIndex = 2;
            this.lblHab.Text = "habilitation";
            // 
            // btnValider
            // 
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.Font = new System.Drawing.Font("Arial", 11F);
            this.btnValider.Location = new System.Drawing.Point(91, 201);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(114, 37);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // dateHabilitation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 254);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblHab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dateHabilitation";
            this.Text = "Date habilitation";
            this.Load += new System.EventHandler(this.dateHabilitation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHab;
        private System.Windows.Forms.Button btnValider;
    }
}