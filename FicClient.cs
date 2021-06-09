using Projet_bibliotheque.Classes;
using Projet_bibliotheque.Gestion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GD_BD_BIBLIO
{
    public partial class EcranClient : Form
    {
        #region Données membres
        private string sConnect;
        private DataTable DT_client;
        private BindingSource BS_client;
        #endregion

        #region constructeur
        public EcranClient(string sC)
        {
            InitializeComponent();
            sConnect = sC;
        }
        #endregion

        #region méthodes
        private void Activer(bool Act)
        {
            //gestion des boutons / DTP
            DGV_client.Enabled = Act;
            B_ajout_client.Enabled = B_edit_client.Enabled = B_supp_client.Enabled = B_cot.Enabled = Act;
            TB_nom_client.Enabled = TB_prenom_client.Enabled = DTP_cot.Enabled = DTP_crea.Enabled = DTP_nai.Enabled = !Act;
            B_conf_client.Enabled = B_ann_client.Enabled = !Act;
        }

        private void RemplirDGVClient()
        {
            //remplit DGV client
            DT_client = new DataTable();
            DT_client.Columns.Add(new DataColumn("ID_client", System.Type.GetType("System.Int32")));
            DT_client.Columns.Add(new DataColumn("Afficher"));
            DT_client.Columns.Add(new DataColumn("client_Nai", System.Type.GetType("System.DateTime")));
            DT_client.Columns.Add(new DataColumn("client_crea", System.Type.GetType("System.DateTime")));
            DT_client.Columns.Add(new DataColumn("client_coti", System.Type.GetType("System.DateTime")));
            List<C_TB_client> DGVtmp = new G_TB_client(sConnect).Lire("client_nom");
            foreach (C_TB_client cl in DGVtmp)
            {
                DT_client.Rows.Add(cl.ID_client, cl.client_nom + " " + cl.client_prenom, cl.client_nai, cl.client_crea, cl.client_cotisation);
            }
            BS_client = new BindingSource();
            BS_client.DataSource = DT_client;
            DGV_client.DataSource = BS_client;
        }

        private void B_ajout_client_Click(object sender, EventArgs e)
        {
            //Ajout d'un client
            TB_ID_client.Text = TB_nom_client.Text = TB_prenom_client.Text = "";
            DTP_cot.Value = DTP_crea.Value = DTP_nai.Value = DateTime.Today;
            TB_nom_client.Focus();
            Activer(false);
        }

        private void B_edit_client_Click(object sender, EventArgs e)
        {
            if (DGV_client.SelectedRows.Count > 0)
            {
                //modification du client sélectionné
                TB_ID_client.Text = DGV_client.SelectedRows[0].Cells["cId_client"].Value.ToString();
                C_TB_client clientEditTmp = new G_TB_client(sConnect).Lire_ID(int.Parse(TB_ID_client.Text));
                TB_nom_client.Text = clientEditTmp.client_nom;
                TB_prenom_client.Text = clientEditTmp.client_prenom;
                DTP_cot.Value = clientEditTmp.client_cotisation;
                DTP_crea.Value = clientEditTmp.client_crea;
                DTP_nai.Value = clientEditTmp.client_nai;
                Activer(false);
            }
            else
            {
                MessageBox.Show("Sélectionner un enregistrement avant modification !");
            }
        }

        private void B_supp_client_Click(object sender, EventArgs e)
        {
            if (DGV_client.SelectedRows.Count > 0)
            {
                //suppresion du client sélectionné
                if (MessageBox.Show("Supprimer ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int iID = (int)DGV_client.SelectedRows[0].Cells["cId_client"].Value;
                    new G_TB_client(sConnect).Supprimer(iID);
                    BS_client.RemoveCurrent();
                }
            }
            else
            {
                MessageBox.Show("Sélectionner un enregistrement avant suppression !");
            }
            RemplirDGVClient();
            DGV_client.Refresh();
        }

        private void B_conf_client_Click(object sender, EventArgs e)
        {
            //confirmation
            if (TB_nom_client.Text.Trim() == "" || TB_prenom_client.Text.Trim() == "")
            {
                MessageBox.Show("il manque des renseignements !");
            }
            else
            {
                if (TB_ID_client.Text == "")
                {
                    int iID = new G_TB_client(sConnect).Ajouter(TB_prenom_client.Text, TB_nom_client.Text, DTP_nai.Value, DTP_crea.Value, DTP_cot.Value);
                    TB_ID_client.Text = iID.ToString();
                    DT_client.Rows.Add(iID, TB_nom_client.Text + " " + TB_prenom_client.Text, DTP_nai.Value, DTP_crea.Value, DTP_cot.Value);
                }
                else
                {
                    new G_TB_client(sConnect).Modifier(int.Parse(TB_ID_client.Text), TB_prenom_client.Text, TB_nom_client.Text, DTP_nai.Value, DTP_crea.Value, DTP_cot.Value);
                    DGV_client.SelectedRows[0].Cells["cAfficher"].Value = TB_nom_client.Text + " " + TB_prenom_client.Text;
                    BS_client.EndEdit();
                }
            }
            Activer(true);
            RemplirDGVClient();
            DGV_client.Refresh();
        }

        private void B_ann_client_Click(object sender, EventArgs e)
        {
            //annulation
            Activer(true);
            RemplirDGVClient();
            DGV_client.Refresh();
        }

        private void B_cot_Click(object sender, EventArgs e)
        {
            //actualise la date de cotisation à aujourd'hui / payement
            if (MessageBox.Show("Actualiser la cotisation ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int iID = (int)DGV_client.SelectedRows[0].Cells["cId_client"].Value;
                C_TB_client clientEditTmp = new G_TB_client(sConnect).Lire_ID(iID);
                new G_TB_client(sConnect).Modifier(iID, clientEditTmp.client_prenom, clientEditTmp.client_nom, clientEditTmp.client_nai, clientEditTmp.client_crea, DateTime.Today);
                BS_client.EndEdit();
                RemplirDGVClient();
                DGV_client.Refresh();
            }
        }

        private void Ecranclient_Load(object sender, EventArgs e)
        {
            RemplirDGVClient();
            if (DGV_client.Rows.Count > 0)
                Activer(true);
            else
                Activer(false);
        }
        #endregion
    }
}