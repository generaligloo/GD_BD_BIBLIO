using Projet_bibliotheque.Classes;
using Projet_bibliotheque.Gestion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GD_BD_BIBLIO
{
    public partial class EcranAjoutDetail : Form
    {
        #region Données membres
        private string sConnect;
        private short maj;
        private int ID_loca;
        private int ID_conf_livre;
        private DataTable DT_details;
        private BindingSource BS_details;
        private List<C_TB_livre> CBlivre;
        #endregion

        #region Constructeur
        public EcranAjoutDetail(string sC, int lID)
        {
            //initialisation de la fenêtre (chaine de connexion, ID de la location)
            InitializeComponent();
            sConnect = sC;
            ID_loca = lID;
        }
        #endregion

        #region Méthodes
        private void RemplirDGVdetail()
        {
            DT_details = new DataTable();
            //initialisation de toutes les colonnes dans notre table de données
            DT_details.Columns.Add(new DataColumn("ID_details", System.Type.GetType("System.Int32")));
            DT_details.Columns.Add(new DataColumn("Titre_ID_livre"));
            DT_details.Columns.Add(new DataColumn("Dat_limite", System.Type.GetType("System.DateTime")));
            //liste tmp de détails
            List<C_TB_details> tmp = new G_TB_details(sConnect).Lire("ID_details");
            string titre_livre;
            //pour chaque détails où l'id locataire est le même que celui recherché
            foreach (C_TB_details c in tmp.Where(n => n.ID_location == ID_loca))
            {
                //on récupère le titre et l'auteur du livre associé à ce détail pour pouvoir les afficher dans le DGV
                C_TB_livre liv_Tmp = new G_TB_livre(sConnect).Lire_ID((int)c.ID_livre);
                titre_livre = liv_Tmp.titre;
                //On l'ajoute à notre table de données
                DT_details.Rows.Add(c.ID_details, titre_livre, c.dat_limite);
            }
            //lien table de données / DGV / source
            BS_details = new BindingSource();
            BS_details.DataSource = DT_details;
            DGV_detail.DataSource = BS_details;
        }

        private void EcranAjoutDetail_Load(object sender, EventArgs e)
        {
            //remplit le DGV
            RemplirDGVdetail();
            C_TB_location LocaTMP = new G_TB_location(sConnect).Lire_ID(ID_loca);
            C_TB_client clientTMP = new G_TB_client(sConnect).Lire_ID(LocaTMP.ID_client);
            //client majeur ou pas
            if (DateTime.Today.Year - clientTMP.client_nai.Year >= 18)
                maj = 1;
            else
                maj = 0;
            CBlivre = new G_TB_livre(sConnect).Lire("ID_livre");
            //ajoute les livres disponibles au combobox
            foreach (C_TB_livre c in CBlivre)
            {
                if (c.statut != 1)
                    CB_livre_detail.Items.Add(c.titre);
            }
        }

        private void ChB_limite_CheckedChanged(object sender, EventArgs e)
        {
            //date limite ou pas
            DTP_limite.Enabled = ChB_limite.Checked;
        }

        private void B_ann_aj_detail_Click(object sender, EventArgs e)
        {
            //annuler ajout
            this.Close();
        }

        private void B_conf_aj_detail_Click(object sender, EventArgs e)
        {
            //confirmer l'ajout
            bool age_valide = true;
            string CBtitre = CB_livre_detail.GetItemText(CB_livre_detail.SelectedItem);
            foreach (C_TB_livre l in CBlivre)
            {
                if (l.titre == CBtitre)
                {
                    ID_conf_livre = l.ID_livre;
                    if (l.ID_categorie != null)
                    {
                        C_TB_categorie verif_pegi = new G_TB_categorie(sConnect).Lire_ID((int)l.ID_categorie);
                        //verification de l'age requis
                        if (verif_pegi.Pegi == 1 && maj == 0)
                        {
                            age_valide = false;
                        }
                    }
                    if (age_valide == true)
                    {
                        //rendre le livre ajouté indisponible dans le stock
                        new G_TB_livre(sConnect).Modifier(l.ID_livre, l.titre, l.auteur, l.ID_categorie, 1, l.Ann_pub);
                    }
                }
            }
            if (age_valide == true)
            {
                //date limite ou pas
                if (ChB_limite.Checked == true)
                {
                    new G_TB_details(sConnect).Ajouter(ID_loca, ID_conf_livre, DateTime.Today, DTP_limite.Value, null, null);
                }
                else
                {
                    new G_TB_details(sConnect).Ajouter(ID_loca, ID_conf_livre, DateTime.Today, null, null, null);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Âge non valide ! Choissisez un autre livre.");
            }
        }
        #endregion
    }
}