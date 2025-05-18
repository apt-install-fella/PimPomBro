using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls_volet2
{
    public partial class affichageVehicules: UserControl
    {
        public affichageVehicules()
        {
            InitializeComponent();
        }

        public affichageVehicules(string codeEngin, int numero)
        {
            string cheminImage = @"../../../ImagesEngins/";
            InitializeComponent();
            lblCodeEngin.Text = codeEngin + " n°" + numero;
            pctEngin.SizeMode = PictureBoxSizeMode.Zoom;

            switch (codeEngin)
            {
                case "VSAV":
                    pctEngin.Image = Image.FromFile(cheminImage + "VSAV.png") ; //Mettre l'image du VSAV
                    break;
                case "FPT":
                    pctEngin.Image = Image.FromFile(cheminImage + "FPT.png");
                    break;
                case "BRS":
                    pctEngin.Image = Image.FromFile(cheminImage + "BRS.jpg");
                    break;
                case "CCF":
                    pctEngin.Image = Image.FromFile(cheminImage + "CCF.png");
                    break;
                case "EPA":
                    pctEngin.Image = Image.FromFile(cheminImage + "EPA.png");
                    break;
                case "VSR":
                    pctEngin.Image = Image.FromFile(cheminImage + "VSR.png");
                    break;
                case "FCYN":
                    pctEngin.Image = Image.FromFile(cheminImage + "FCYN.png");
                    break;
                case "VID":
                    pctEngin.Image = Image.FromFile(cheminImage + "VID.png");
                    break;
                case "VPC":
                    pctEngin.Image = Image.FromFile(cheminImage + "VPC.png");
                    break;
                case "VSS":
                    pctEngin.Image = Image.FromFile(cheminImage + "VSS.jpg");
                    break;
            }
        }
    }
}
