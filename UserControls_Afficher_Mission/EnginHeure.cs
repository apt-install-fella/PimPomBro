using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimPomBro
{
    public partial class EnginHeure : UserControl
    {
        public EnginHeure()
        {
            InitializeComponent();
        }

        public EnginHeure(string type, string num, string Heure)
        {
            InitializeComponent();
            lblType.Text = type;
            lblNumero.Text = num;
            lblHeure.Text = Heure;
        }
    }
}
