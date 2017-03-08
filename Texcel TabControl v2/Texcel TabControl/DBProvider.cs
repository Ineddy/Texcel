using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Texcel_TabControl
{
    class DBProvider
    {
        SqlConnection ctn = new SqlConnection("Server=INFO-324-1A-122\\INSTANCE;Database=BdTexcel;Integrated Security=true");

        SqlCommand cmd;
        SqlDataReader lecteur;
        List<string[]> ligne = new List<string[]>();

        public DBProvider()
        {

        }



        //public List<List<string>> listeDesJeuxOptionnel()
        //{
        //    informations.Clear();

        //    int ligne = 0;

        //    string requetelisteDesJeux = "select * from tblJeu";

        //    List<String> listeJeux = new List<String>();

        //    ctn.Open();

        //    cmd = ctn.CreateCommand();

        //    cmd.CommandText = requetelisteDesJeux;

        //    lecteur = cmd.ExecuteReader();

        //    while (lecteur.Read())
        //    {


        //        listeJeux.Add(lecteur["idJeu"] + " " + lecteur["nomJeu"] + " " + lecteur["devellopeurJeu"] + " " + lecteur["descriptionJeu"] + " " + lecteur["configurationMinimaleJeu"] + " " + lecteur["idProjetTest"]);

        //        informations.Add(new List<string>());

        //        informations.ElementAt(ligne).Add(lecteur["idJeu"].ToString());
        //        informations.ElementAt(ligne).Add(lecteur["nomJeu"].ToString());
        //        informations.ElementAt(ligne).Add(lecteur["devellopeurJeu"].ToString());
        //        informations.ElementAt(ligne).Add(lecteur["descriptionJeu"].ToString());
        //        informations.ElementAt(ligne).Add(lecteur["configurationMinimaleJeu"].ToString());
        //        informations.ElementAt(ligne).Add(lecteur["idProjetTest"].ToString());

        //        ligne++;

        //    }
        //        lecteur.Close();

        //    ctn.Close();

        //    return informations;

        //}


        public List<string[]> listeDesJeux()
        {
            string requeteListeDesJeux = "select * from tblJeu";

            List<string[]> listeJeux = new List<string[]>();

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteListeDesJeux;

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                string[] jeu = new string[6];

                jeu[0] = lecteur["idJeu"].ToString();
                jeu[1] = lecteur["nomJeu"].ToString();
                jeu[2] = lecteur["devellopeurJeu"].ToString();
                jeu[3] = lecteur["descriptionJeu"].ToString();
                jeu[4] = lecteur["configurationMinimaleJeu"].ToString();
                jeu[5] = lecteur["idProjetTest"].ToString();

                listeJeux.Add(jeu);

                //listeOS.Add(lecteur["codeSE"] + " " + lecteur["nomSE"] + " " + lecteur["editionSE"] + " " + lecteur["versionSE"]);
            }

            lecteur.Close();

            ctn.Close();

            return listeJeux;

        }


        public List<string[]> listeDesOS()
        {
            string requetelisteDesOS = "select * from tblSE";

            List<string[]> listeOS = new List<string[]>();

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requetelisteDesOS;

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                string[] OS = new string[4];

                OS[0] = lecteur["codeSE"].ToString();
                OS[1] = lecteur["nomSE"].ToString();
                OS[2] = lecteur["editionSE"].ToString();
                OS[3] = lecteur["versionSE"].ToString();

                listeOS.Add(OS);

                //listeOS.Add(lecteur["codeSE"] + " " + lecteur["nomSE"] + " " + lecteur["editionSE"] + " " + lecteur["versionSE"]);
            }

            lecteur.Close();

            ctn.Close();

            return listeOS;

        }

        public List<string[]> listeDesPlateformes()
        {
            string requeteListePlateformes = "select * from tblPlateforme";

            List<string[]> listePlateformes = new List<string[]>();

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteListePlateformes;

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                string[] plateforme = new string[5];

                plateforme[0] = lecteur["idPlateforme"].ToString();
                plateforme[1] = lecteur["nomPlateforme"].ToString();
                plateforme[2] = lecteur["configurationPlateforme"].ToString();
                plateforme[3] = lecteur["idTypePlateforme"].ToString();
                plateforme[4] = lecteur["codeSE"].ToString();

                listePlateformes.Add(plateforme);
            }

            lecteur.Close();

            ctn.Close();

            return listePlateformes;
        }

        public List<string[]> listeDesEmployes()
        {
            string requeteListeEmploye = "select * from tblEmploye";

            List<string[]> listeEmploye = new List<string[]>();

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteListeEmploye;

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                string[] plateforme = new string[3];

                plateforme[0] = lecteur["idEmploye"].ToString();
                plateforme[1] = lecteur["nomEmploye"].ToString();
                plateforme[2] = lecteur["prenomEmploye"].ToString();

                listeEmploye.Add(plateforme);
            }

            lecteur.Close();

            ctn.Close();

            return listeEmploye;
        }

        public List<string[]> listeDesPlateformesAvecType()
        {

            string requeteListePlateformes = "SELECT * FROM tblPlateforme pla JOIN tblTypePlateforme tpla ON pla.idTypePlateforme = tpla.idTypePlateforme";

            List<string[]> listePlateformes = new List<string[]>();

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteListePlateformes;

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                string[] plateforme = new string[7];

                plateforme[0] = lecteur["idPlateforme"].ToString();
                plateforme[1] = lecteur["nomPlateforme"].ToString();
                plateforme[2] = lecteur["configurationPlateforme"].ToString();
                plateforme[3] = lecteur["idTypePlateforme"].ToString();
                plateforme[4] = lecteur["codeSE"].ToString();
                plateforme[5] = lecteur["idTypePlateforme"].ToString();
                plateforme[6] = lecteur["nomTypePlateforme"].ToString();

                listePlateformes.Add(plateforme);
            }

            lecteur.Close();

            ctn.Close();

            return listePlateformes;
        }







    }
}
