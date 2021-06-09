using Projet_bibliotheque.Classes;
using Projet_bibliotheque.Gestion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GD_BD_BIBLIO
{
    public partial class EcranModifDetail : Form
    {

        #region Données membres
        private string sConnect;
        private int ID_loca;
        private DataTable DT_details;
        private BindingSource BS_details;
        #endregion

        #region Constructeur
        public EcranModifDetail(string sC, int lID)
        {
            InitializeComponent();
            sConnect = sC;
            ID_loca = lID;
        }
        #endregion

        #region Méthodes
        private void RemplirDGVdetail()
        {
            DT_details = new DataTable();
            DT_details.Columns.Add(new DataColumn("ID_details", System.Type.GetType("System.Int32")));
            DT_details.Columns.Add(new DataColumn("Titre_ID_livre"));
            DT_details.Columns.Add(new DataColumn("Dat_limite", System.Type.GetType("System.DateTime")));
            DT_details.Columns.Add(new DataColumn("Dat_emprunt", System.Type.GetType("System.DateTime")));
            DT_details.Columns.Add(new DataColumn("Dat_rentre", System.Type.GetType("System.DateTime")));
            List<C_TB_details> tmp = new G_TB_details(sConnect).Lire("ID_details");
            string titre_livre;
            foreach (C_TB_details c in tmp.Where(n => n.ID_location == ID_loca))
            {
                C_TB_livre liv_Tmp = new G_TB_livre(sConnect).Lire_ID((int)c.ID_livre);
                titre_livre = liv_Tmp.titre;
                DT_details.Rows.Add(c.ID_details, titre_livre, c.dat_limite, c.dat_emprunt, c.dat_rentre);
            }
            BS_details = new BindingSource();
            BS_details.DataSource = DT_details;
            DGV_detail.DataSource = BS_details;
        }

        private void EcranModifDetail_Load(object sender, EventArgs e)
        {
            RemplirDGVdetail();
        }

        private void B_changer_limite_Click(object sender, EventArgs e)
        {
            //changer la date limite
            if (DGV_detail.SelectedRows.Count > 0)
            {
                int dID = int.Parse(DGV_detail.SelectedRows[0].Cells["cID_details"].Value.ToString());
                C_TB_details dtmp = new G_TB_details(sConnect).Lire_ID(dID);
                if (dtmp.amende == null) //vérifie qu'il n'y a pas d'amende asscocié à ce détail
                {
                    //supprime ou modifie la date limite
                    if (ChB_limite.Checked == true)
                    {
                        if (MessageBox.Show("Souhaitez vous changer la date limite par " + DTP_limite.Value + " ?", "Rendu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            new G_TB_details(sConnect).Modifier(dID, dtmp.ID_location, dtmp.ID_livre, dtmp.dat_emprunt, DTP_limite.Value, dtmp.dat_rentre, dtmp.amende);
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Souhaitez vous supprimer la date limite ?", "Rendu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            new G_TB_details(sConnect).Modifier(dID, dtmp.ID_location, dtmp.ID_livre, dtmp.dat_emprunt, null, dtmp.dat_rentre, dtmp.amende);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vous ne pouvez pas allonger la date limite sans payer l'amende associée à ce détail !");
                }
            }
        }

        private void B_rendu_Click(object sender, EventArgs e)
        {
            if (DGV_detail.SelectedRows.Count > 0)
            {
                //rend le livre mais ne supprime pas le détail pour garder une trace de la location
                int dID = int.Parse(DGV_detail.SelectedRows[0].Cells["cID_details"].Value.ToString());
                C_TB_details rendu_detail = new G_TB_details(sConnect).Lire_ID(dID);
                if (rendu_detail.amende == null) //vérifie qu'il n'y a pas d'amende asscocié à ce détail
                {
                    if (MessageBox.Show("Souhaitez vous rendre le livre sélectionné ?", "Rendu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        new G_TB_details(sConnect).Modifier(dID, rendu_detail.ID_location, rendu_detail.ID_livre, rendu_detail.dat_emprunt, rendu_detail.dat_limite, DateTime.Today, null);
                        C_TB_livre rendu_livre = new G_TB_livre(sConnect).Lire_ID((int)rendu_detail.ID_livre);
                        new G_TB_livre(sConnect).Modifier((int)rendu_detail.ID_livre, rendu_livre.titre, rendu_livre.auteur, rendu_livre.ID_categorie, 0, rendu_livre.Ann_pub);
                        MessageBox.Show("Livre rendu !");
                    }
                }
                else //paye l'amende et actualise le detail
                {
                    MessageBox.Show("Le montant de " + rendu_detail.amende + " euros a été payé. Vous pouvez désormais allonger la date limite ou rendre le livre.");
                    if (MessageBox.Show("Souhaitez vous allonger la date limite d'un mois ?", "Date limite", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {//allonge la durée de la limite d'un moi après la date d'aujourd'hui
                        DateTime nouv_date = DateTime.Today.AddMonths(1);
                        new G_TB_details(sConnect).Modifier(dID, rendu_detail.ID_location, rendu_detail.ID_livre, rendu_detail.dat_emprunt, nouv_date, null, null);
                    }
                    else
                    {// sinon livre obligatoirement rendu
                        new G_TB_details(sConnect).Modifier(dID, rendu_detail.ID_location, rendu_detail.ID_livre, rendu_detail.dat_emprunt, rendu_detail.dat_limite, DateTime.Today, null);
                        C_TB_livre rendu_livre = new G_TB_livre(sConnect).Lire_ID((int)rendu_detail.ID_livre);
                        new G_TB_livre(sConnect).Modifier((int)rendu_detail.ID_livre, rendu_livre.titre, rendu_livre.auteur, rendu_livre.ID_categorie, 0, rendu_livre.Ann_pub);
                        MessageBox.Show("Livre rendu !");
                    }
                }
            }
        }

        private void DGV_detail_SelectionChanged(object sender, EventArgs e)
        {
            //verifie si une amende existe pour le détail sélectionné
            if (DGV_detail.SelectedRows.Count > 0)
            {
                int dID = int.Parse(DGV_detail.SelectedRows[0].Cells["cID_details"].Value.ToString());
                C_TB_details button = new G_TB_details(sConnect).Lire_ID(dID);
                if (button.amende == null)
                {
                    B_rendu.Text = "Rendre le livre";
                }
                else
                {
                    B_rendu.Text = "Payer l'amende";
                }
            }
        }

        private void ChB_limite_CheckedChanged(object sender, EventArgs e)
        {
            DTP_limite.Enabled = ChB_limite.Checked;
        } 
        #endregion
    }
}