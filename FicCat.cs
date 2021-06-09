using Projet_bibliotheque.Classes;
using Projet_bibliotheque.Gestion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GD_BD_BIBLIO
{
    public partial class EcranCategorie : Form
    {
        #region Données membres
        //GD_BD_BIBLIO.Properties.Settings.BDConnectionString_Couche_Biblio
        private string sConnect;
        private bool verif_cat = true;
        private DataTable DT_categorie;
        private BindingSource BS_categorie;
        #endregion

        #region Constructeur
        public EcranCategorie(string sC)
        {
            InitializeComponent();
            sConnect = sC;
        }
        #endregion

        #region Méthodes
        private void Activer(bool Act)
        {
            DGV_cat.Enabled = Act;
            B_ajout_cat.Enabled = B_edit_cat.Enabled = B_supp_cat.Enabled = Act;
            TB_nom_cat.Enabled = CB_pegi_cat.Enabled = !Act;
            B_conf_cat.Enabled = B_ann_cat.Enabled = !Act;
        }

        private void RemplirDGVCat()
        {
            DT_categorie = new DataTable();
            DT_categorie.Columns.Add(new DataColumn("ID_categorie", System.Type.GetType("System.Int32")));
            DT_categorie.Columns.Add(new DataColumn("Nom"));
            DT_categorie.Columns.Add(new DataColumn("Pegi", System.Type.GetType("System.Int16")));
            List<C_TB_categorie> tmp = new G_TB_categorie(sConnect).Lire("Nom");
            foreach (C_TB_categorie c in tmp)
            {
                DT_categorie.Rows.Add(c.ID_categorie, c.Nom, c.Pegi);
            }
            BS_categorie = new BindingSource();
            BS_categorie.DataSource = DT_categorie;
            DGV_cat.DataSource = BS_categorie;
        }

        private void EcranPrincipale_Load(object sender, EventArgs e)
        {
            //sConnect = ConfigurationManager.ConnectionStrings["GD_BD_BIBLIO.Properties.Settings.BDConnectionString_Couche_Biblio"].ConnectionString;
            RemplirDGVCat();
            if (DGV_cat.Rows.Count > 0)
                Activer(true);
            else
                Activer(false);
        }

        private void B_ajout_cat_Click(object sender, EventArgs e)
        {
            TB_ID_cat.Text = TB_nom_cat.Text = "";
            CB_pegi_cat.Checked = false;
            TB_nom_cat.Focus();
            Activer(false);
        }

        private void B_edit_cat_Click(object sender, EventArgs e)
        {
            if (DGV_cat.SelectedRows.Count > 0)
            {
                TB_ID_cat.Text = DGV_cat.SelectedRows[0].Cells["ID_cat"].Value.ToString();
                C_TB_categorie cat_tmp = new G_TB_categorie(sConnect).Lire_ID(int.Parse(TB_ID_cat.Text));
                TB_nom_cat.Text = cat_tmp.Nom;
                if (cat_tmp.Pegi == 0)
                    CB_pegi_cat.Checked = false;
                else
                    CB_pegi_cat.Checked = true;
                Activer(false);
            }
            else
            {
                MessageBox.Show("Sélectionner un enregistrement avant modification !");
            }
        }

        private void B_supp_cat_Click(object sender, EventArgs e)
        {
            if (DGV_cat.SelectedRows.Count > 0)
            {
                int iID = (int)DGV_cat.SelectedRows[0].Cells["ID_cat"].Value;

                List<C_TB_livre> livretmp = new G_TB_livre(sConnect).Lire("ID_livre");
                for (int i = 0; i < livretmp.Count; i++)
                {
                    if (livretmp[i].ID_categorie == iID)
                    {
                        verif_cat = false;
                    }
                }
                if (verif_cat == true)
                {
                    if (MessageBox.Show("Supprimer ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        new G_TB_categorie(sConnect).Supprimer(iID);
                        BS_categorie.RemoveCurrent();
                    }
                }
                else
                {
                    MessageBox.Show("Des livres utilisent cette catégorie impossible de la supprimer !");
                }
                verif_cat = true;
            }
            else
            {
                MessageBox.Show("Sélectionner un enregistrement avant suppression !");
            }
        }

        private void B_conf_cat_Click(object sender, EventArgs e)
        {
            short ch;
            if (TB_nom_cat.Text.Trim() == "")
            {
                MessageBox.Show("renseigner le nom !");
            }
            else
            {
                if (TB_ID_cat.Text == "")
                {
                    if (CB_pegi_cat.Checked == true)
                        ch = 1;
                    else
                        ch = 0;
                    int iID = new G_TB_categorie(sConnect).Ajouter(TB_nom_cat.Text, ch);
                    TB_ID_cat.Text = iID.ToString();
                    DT_categorie.Rows.Add(iID, TB_nom_cat.Text, ch);
                }
                else
                {
                    if (CB_pegi_cat.Checked == true)
                        ch = 1;
                    else
                        ch = 0;
                    new G_TB_categorie(sConnect).Modifier(int.Parse(TB_ID_cat.Text), TB_nom_cat.Text, ch);
                    DGV_cat.SelectedRows[0].Cells["cat_nom"].Value = TB_nom_cat.Text;
                    BS_categorie.EndEdit();
                }
                Activer(true);
            }
        }

        private void B_ann_cat_Click(object sender, EventArgs e)
        {
            Activer(true);
        }
        #endregion
    }
}