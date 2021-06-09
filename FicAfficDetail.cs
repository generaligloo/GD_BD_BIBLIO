using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_bibliotheque.Classes;
using Projet_bibliotheque.Gestion;

namespace GD_BD_BIBLIO
{
    public partial class EcranAfficDetail : Form
    {
        #region Données membres
        private string sConnect;
        private int ID_loca;
        private DataTable DT_details;
        private BindingSource BS_details;
        #endregion

        #region Constructeur
        public EcranAfficDetail(string sC, int lID)
        {
            //initialisation de la fenêtre (chaine de connexion, ID de la location)
            InitializeComponent();
            sConnect = sC;
            ID_loca = lID;
        }
        #endregion

        #region Méthodes
        private void FicAfficDetail_Load(object sender, EventArgs e)
        {
            //remplit le DGV
            RemplirDGVdetail();
        }
        private void RemplirDGVdetail()
        {
            DT_details = new DataTable();
            //initialisation de toutes les colonnes dans notre table de données
            DT_details.Columns.Add(new DataColumn("ID_details", System.Type.GetType("System.Int32")));
            DT_details.Columns.Add(new DataColumn("Titre_ID_livre"));
            DT_details.Columns.Add(new DataColumn("Dat_limite", System.Type.GetType("System.DateTime")));
            DT_details.Columns.Add(new DataColumn("Dat_emprunt", System.Type.GetType("System.DateTime")));
            DT_details.Columns.Add(new DataColumn("Dat_rentre", System.Type.GetType("System.DateTime")));
            DT_details.Columns.Add(new DataColumn("amende", System.Type.GetType("System.Int32")));
            //liste tmp de détails
            List<C_TB_details> tmp = new G_TB_details(sConnect).Lire("ID_details");
            string titre_livre, auteur_livre;
            //pour chaque détails où l'id locataire est le même que celui recherché
            foreach (C_TB_details c in tmp.Where(n => n.ID_location == ID_loca))
            {
                //on récupère le titre et l'auteur du livre associé à ce détail pour pouvoir les afficher dans le DGV
                C_TB_livre liv_Tmp = new G_TB_livre(sConnect).Lire_ID((int)c.ID_livre);
                titre_livre = liv_Tmp.titre;
                auteur_livre = liv_Tmp.auteur;
                //On l'ajoute à notre table de données
                DT_details.Rows.Add(c.ID_details, titre_livre+" "+ auteur_livre, c.dat_limite, c.dat_emprunt, c.dat_rentre, c.amende);
            }
            //lien table de données / DGV / source
            BS_details = new BindingSource();
            BS_details.DataSource = DT_details;
            DGV_detail.DataSource = BS_details;
        }
        #endregion
    }
}
