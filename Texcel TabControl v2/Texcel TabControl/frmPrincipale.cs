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
    public partial class frmTexcel : Form
    {
        DBProvider dbprovider = new DBProvider();

       
        public frmTexcel()
        {
            InitializeComponent();

            afficheLesJeux();
            afficheLesOS();
            afficheLesPlateformes();
            afficheEmploye();
           
        }

        private void btnAdminTemp_Click(object sender, EventArgs e)
        {
            interfaceAdmin();


        }

        private void btnDirecteurTemp_Click(object sender, EventArgs e)
        {
            interfaceDirecteur();

        }

        private void interfaceAdmin()
        {
            tabControlFonctionnalites.Enabled = true;
            tabControlFonctionnalites.Visible = true;
            lblBienvenue.Text = "Bienvenue Administrateur";

            //il peut creer un jeu, une plateforme, un OS
            btnCreerJeu.Enabled = true;
            btnCreerJeu.Visible = true;
            btnCreerPlateforme.Enabled = true;
            btnCreerPlateforme.Visible = true;
            btnCreerSE.Enabled = true;
            btnCreerSE.Visible = true;
            btnCreerEmploye.Enabled = true;
            btnCreerEmploye.Visible = true;

            //un administrateur ne peut pas former d'équipe
            btnFormerEquipe.Enabled = false;
            btnFormerEquipe.Visible = false;
        }
        private void interfaceDirecteur()
        {
            tabControlFonctionnalites.Enabled = true;
            tabControlFonctionnalites.Visible = true;
            lblBienvenue.Text = "Bienvenue M. le directeur";
            
            //un directeur ne peut pas cree un jeu, un OS ou une plateforme
            btnCreerJeu.Enabled = false;
            btnCreerJeu.Visible = false;
            btnCreerPlateforme.Enabled = false;
            btnCreerPlateforme.Visible = false;
            btnCreerSE.Enabled = false;
            btnCreerSE.Visible = false;
            btnCreerEmploye.Enabled = false;
            btnCreerEmploye.Visible = false;

            //il peut former une equipe
            btnFormerEquipe.Enabled = true;
            btnFormerEquipe.Visible = true;

        }

        private void btnSeDeconnecter_Click(object sender, EventArgs e)
        {
            tabControlFonctionnalites.Enabled = false;
            tabControlFonctionnalites.Visible = false;
            
        }

       

        private void btnCreerSE_Click(object sender, EventArgs e)
        {
            creerSE FrmCreerSE = new creerSE();
            FrmCreerSE.StartPosition=FormStartPosition.CenterScreen;
            //FrmCreerSE.PointToScreen(new Point(200,200));
            FrmCreerSE.Show();
        }

        private void btnCreerPlateforme_Click(object sender, EventArgs e)
        {
            creerPlateforme FrmCreerPlateforne = new creerPlateforme();
            FrmCreerPlateforne.StartPosition = FormStartPosition.CenterScreen;
            FrmCreerPlateforne.Show();
        }

        private void btnCreerJeu_Click(object sender, EventArgs e)
        {
            creerJeu FrmJeu = new creerJeu();
            FrmJeu.StartPosition = FormStartPosition.CenterScreen;
            FrmJeu.Show();
        }

        //private void afficheJeuxOptionnel()
        //{
        //    List<List<string>> jeux = dbprovider.listeDesJeuxOptionnel();

        //    foreach(List<string> jeu in jeux)
        //    {
        //        string texte = "";

        //        foreach(string colonne in jeu)
        //        {
        //            texte = texte + colonne + " ";
        //        }

        //        listBoxJeux.Items.Add(texte);

        //    }
        //}

        private void afficheLesJeux()
        {
            List<string[]> jeux = dbprovider.listeDesJeux();

            foreach(string[] jeu in jeux)
            {
                dgvListeJeux.Rows.Add(jeu[1],jeu[2]);
            }

        }

        private void afficheLesOS()
        {

            List<string[]> lesOS = dbprovider.listeDesOS();

            foreach (string[] OS in lesOS)
            {
                dgvOS.Rows.Add(OS[1], OS[2]);
            }

        }

        private void afficheLesPlateformes()
        {
            List<string[]> lesPlateformes = dbprovider.listeDesPlateformesAvecType();

            foreach (string[] plateforme in lesPlateformes)
            {
                dgvPlateformes.Rows.Add(plateforme[1], plateforme[6]);
            }
        }

        private void afficheEmploye()
        {
            List<string[]> listeEmployes = dbprovider.listeDesEmployes();

            foreach (string[] employe in listeEmployes)
            {
                dgvEmployes.Rows.Add(employe[0], employe[1], employe[2]);
            }
        }


        private void frmTexcel_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdTexcelDataSet.tblSE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.tblSETableAdapter.Fill(this.bdTexcelDataSet.tblSE);

        }

        private void dgvEmployes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Test
            lblNom.Text = "Testtttt";

            /*
            List<string[]> listeEmployes = dbprovider.listeDesEmployes();
            int index = e.RowIndex;
            MessageBox.Show(index.ToString());
            lblNom.Text = index.ToString() ;
            */
        }

        private void dgvEmployes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
