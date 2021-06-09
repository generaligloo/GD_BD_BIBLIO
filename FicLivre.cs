using Projet_bibliotheque.Classes;
using Projet_bibliotheque.Gestion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GD_BD_BIBLIO
{
    public partial class EcranLivre : Form
    {
        #region Données membres
        private int? ID_conf_cat;
        private string sConnect;
        private int idd;
        private DataTable DT_livre;
        private BindingSource BS_livre;
        private List<C_TB_categorie> CBCat; // liste des catégories
        #endregion

        #region Constructeurs
        public EcranLivre(string sC)
        {
            sConnect = sC;
            InitializeComponent();
        }
        #endregion

        #region Méthodes
        private void Activer(bool Act)
        {
            //gestion des boutons
            DGV_livre.Enabled = Act;
            B_ajout_livre.Enabled = B_edit_livre.Enabled = B_supp_livre.Enabled = Act;
            TB_auteur.Enabled = CB_cat_livre.Enabled = TB_titre.Enabled = NUD_ann_pub.Enabled = !Act;
            B_conf_livre.Enabled = B_ann_livre.Enabled = !Act;
        }

        private void EcranLivre_Load(object sender, EventArgs e)
        {
            RemplirDGVlivre(); //DGV
            if (DGV_livre.Rows.Count > 0) //bouton
                Activer(true);
            else
                Activer(false);
            CBCat = new G_TB_categorie(sConnect).Lire("ID_categorie"); //combobox de catégorie
            foreach (C_TB_categorie c in CBCat)
            {
                CB_cat_livre.Items.Add(c.Nom);
            }
        }

        private void RemplirDGVlivre()
        {
            //remplit le DGV
            DT_livre = new DataTable();
            DT_livre.Columns.Add(new DataColumn("ID_livre", System.Type.GetType("System.Int32")));
            DT_livre.Columns.Add(new DataColumn("Afficher"));
            DT_livre.Columns.Add(new DataColumn("ID_categorie"));
            DT_livre.Columns.Add(new DataColumn("ann_pub"));
            List<C_TB_livre> lTmp = new G_TB_livre(sConnect).Lire("ID_livre");
            //nom des catégories
            string nom_cat;
            foreach (C_TB_livre l in lTmp)
            {
                if (l.ID_categorie != null)
                {
                    C_TB_categorie Cat_Tmp = new G_TB_categorie(sConnect).Lire_ID((int)l.ID_categorie);
                    nom_cat = Cat_Tmp.Nom;
                    DT_livre.Rows.Add(l.ID_livre, l.auteur + "-" + l.titre, nom_cat, l.Ann_pub);
                }
                else
                {
                    DT_livre.Rows.Add(l.ID_livre, l.auteur + "-" + l.titre, "test", l.Ann_pub);
                }
            }
            BS_livre = new BindingSource();
            BS_livre.DataSource = DT_livre;
            DGV_livre.DataSource = BS_livre;
        }

        private void B_ajout_livre_Click(object sender, EventArgs e)
        {
            //Ajout d'un livre
            TB_ID_livre.Text = TB_auteur.Text = TB_titre.Text = "";
            NUD_ann_pub.Value = 2000;
            Activer(false);
            TB_titre.Focus();
        }

        private void B_edit_livre_Click(object sender, EventArgs e)
        {
            if (DGV_livre.SelectedRows.Count > 0)
            {
                //modification d'un livre
                TB_ID_livre.Text = DGV_livre.SelectedRows[0].Cells["cID_livre"].Value.ToString();
                C_TB_livre lTmp = new G_TB_livre(sConnect).Lire_ID(int.Parse(TB_ID_livre.Text)); //livre à modif
                TB_titre.Text = lTmp.titre;
                TB_auteur.Text = lTmp.auteur;
                NUD_ann_pub.Value = lTmp.Ann_pub == null ? DateTime.Today.Year : (int)lTmp.Ann_pub;
                //catégorie du livre
                string cStringTmp;
                if (lTmp.ID_categorie != null)
                {
                    C_TB_categorie cEdittmp = new G_TB_categorie(sConnect).Lire_ID((int)lTmp.ID_categorie);
                    cStringTmp = cEdittmp.Nom;
                    CB_cat_livre.SelectedItem = cStringTmp;
                }
                Activer(false);
            }
            else
            {
                MessageBox.Show("Aucun livre selectioné !");
            }
        }

        private void B_supp_livre_Click(object sender, EventArgs e)
        {
            if (DGV_livre.SelectedRows.Count > 0)
            {
                //supression d'un livre
                if (MessageBox.Show("Supprimer ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int iID = (int)DGV_livre.SelectedRows[0].Cells["cID_livre"].Value;
                    C_TB_livre TestDispo = new G_TB_livre(sConnect).Lire_ID(iID);
                    bool supp_poss = true;
                    List<C_TB_details> dTmp = new G_TB_details(sConnect).Lire("ID_details"); //parcourt les détails 
                    foreach (C_TB_details c in dTmp)
                    {
                        if(c.ID_livre == iID)
                        {
                            supp_poss = false;
                            idd = c.ID_details;
                        }
                    }
                    if (TestDispo.statut == 1) //seulement si le livre est disponible et que les details le concernant n'existe pas
                    {
                        MessageBox.Show("Erreur le livre n'est pas disponible !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (supp_poss == false) //détail avec ID_livre (éviter les erreurs)
                    {
                        MessageBox.Show("Un détail (ID:"+ idd +") utilise le livre !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        new G_TB_livre(sConnect).Supprimer(iID);
                        BS_livre.RemoveCurrent();
                    }
                }
            }
            else
            {
                MessageBox.Show("Aucun livre selectioné !");
            }
        }

        private void B_conf_livre_Click(object sender, EventArgs e)
        {
            //confirmation
            bool copie = false;
            if (TB_auteur.Text.Length == 0 || TB_titre.Text.Length == 0)
            {
                MessageBox.Show("Erreur de renseignement");
            }
            else
            {
                string cComp = CB_cat_livre.GetItemText(CB_cat_livre.SelectedItem); //nom catégorie
                if (TB_ID_livre.Text == "")
                {
                    //ajout d'un livre
                    foreach (C_TB_categorie c in CBCat) //cherche l'id de la catégorie
                    {
                        if (c.Nom == cComp)
                        {
                            ID_conf_cat = c.ID_categorie;
                        }
                    }
                    //vérifie que le livre n'existe pas déjà
                    List<C_TB_livre> lTmp = new G_TB_livre(sConnect).Lire("ID_livre");
                    foreach (C_TB_livre l in lTmp)
                    {
                        if (l.titre == TB_titre.Text && l.auteur == TB_auteur.Text)
                        {
                            copie = true;
                        }
                    }
                    if (copie == false)
                    {
                        //vérifie que la catégorie n'est pas null (possibilité)
                        if (!ID_conf_cat.HasValue)
                        {
                            int iID = new G_TB_livre(sConnect).Ajouter(TB_titre.Text, TB_auteur.Text, null, 0, (int)NUD_ann_pub.Value);
                            TB_ID_livre.Text = iID.ToString();
                            DT_livre.Rows.Add(iID, TB_auteur.Text + "-" + TB_titre.Text, "", (int)NUD_ann_pub.Value);
                        }
                        else
                        {
                            int iID = new G_TB_livre(sConnect).Ajouter(TB_titre.Text, TB_auteur.Text, ID_conf_cat, 0, (int)NUD_ann_pub.Value);
                            TB_ID_livre.Text = iID.ToString();
                            DT_livre.Rows.Add(iID, TB_auteur.Text + "-" + TB_titre.Text, cComp, (int)NUD_ann_pub.Value);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ce livre existe déja !");
                    }
                }
                else
                {
                    //modification d'un livre
                    int n_id = int.Parse(DGV_livre.SelectedRows[0].Cells["cID_livre"].Value.ToString());
                    foreach (C_TB_categorie c in CBCat)
                    {
                        if (c.Nom == cComp)
                        {
                            ID_conf_cat = c.ID_categorie;
                        }
                    }
                    C_TB_livre lTmp = new G_TB_livre(sConnect).Lire_ID(int.Parse(TB_ID_livre.Text));
                    new G_TB_livre(sConnect).Modifier(n_id, TB_titre.Text, TB_auteur.Text, ID_conf_cat, lTmp.statut, (int)NUD_ann_pub.Value);
                    DGV_livre.SelectedRows[0].Cells["cAffiche"].Value = TB_auteur.Text + "-" + TB_titre.Text;
                    BS_livre.EndEdit();
                }
                Activer(true);
            }
        }

        private void B_ann_livre_Click(object sender, EventArgs e)
        {
            //annulation
            Activer(true);
        }
        #endregion
    }
}