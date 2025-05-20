using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls_Nouvelle_Mission
{
    public partial class afficherPompiers : UserControl
    {
        public afficherPompiers()
        {
            InitializeComponent();
        }

        public afficherPompiers(string matricule, string nomHab, string sexe, string nom)
        {
            InitializeComponent();
            lblMatricule.Text = matricule + " (" + nom + ")";
            lblHab.Text = nomHab;
            pctPompier.SizeMode = PictureBoxSizeMode.Zoom;

            switch (sexe)
            {
                case "m":
                    pctPompier.Image = Image.FromFile(@"../../Images/ImagesPompiers/homme.png");
                    break;
                case "f":
                    pctPompier.Image = Image.FromFile(@"../../Images/ImagesPompiers/femme.png");
                    break;
            }
        }
    }
}
