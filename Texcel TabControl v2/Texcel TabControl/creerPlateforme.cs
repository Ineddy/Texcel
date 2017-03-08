using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texcel_TabControl
{
    public partial class creerPlateforme : Form
    {
        public creerPlateforme()
        {
            InitializeComponent();
        }

        private void creerPlateforme_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouterSE_Click(object sender, EventArgs e)
        {
            creerSE FrmCreerSE = new creerSE();
            FrmCreerSE.StartPosition = FormStartPosition.CenterScreen;
            FrmCreerSE.Show();
        }
    }
}
