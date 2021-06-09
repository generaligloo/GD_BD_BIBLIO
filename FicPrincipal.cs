using iTextSharp.text;
using iTextSharp.text.pdf;
using Projet_bibliotheque.Classes;
using Projet_bibliotheque.Gestion;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GD_BD_BIBLIO
{
    public partial class EcranPrincipal : Form
    {
        #region Données membres
        private string sConnexion;
        public bool encore = true;
        private DataTable DT_client, DT_livre, DT_location; 
        private BindingSource BS_client, BS_livres, BS_location;
        public List<C_TB_client> Lst_retard_cot = new List<C_TB_client>(); //liste des retard de cotisation
        #endregion

        #region Constructeur
        public EcranPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region Méthodes
        private void EcranPrincipal_Load(object sender, EventArgs e)
        {
            //crée la chaine de connexion à notre base de données
            sConnexion = ConfigurationManager.ConnectionStrings["GD_BD_BIBLIO.Properties.Settings.BDConnectionString_Couche_Biblio"].ConnectionString;
            //remplit le DGV client
            RemplirClient();
            //remplit le DGV livre
            RemplirLivre();
            //s'occupe des alertes de retard de cotisation
            foreach (C_TB_client r in Lst_retard_cot)
            {
                int Mois_retard = (DateTime.Today.Month - r.client_cotisation.Month) + 12 * (DateTime.Today.Year - r.client_cotisation.Year);
                MessageBox.Show("Le client ID: " + r.ID_client + " est en retard de cotisation de plus de " + Mois_retard + " mois.", "Retard", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //vérifie tout les détails de notre base de données pour vérifier si il y a des retards de rentrée
            //il donne une amende en fonction de la longueur du retard (10+[1*nombre de mois de retard] euros)
            List<C_TB_details> lst_verif_rendu = new G_TB_details(sConnexion).Lire("ID_details");
            foreach (C_TB_details rr in lst_verif_rendu)
            {
                if (rr.dat_limite != null)
                {
                    int rComp = DateTime.Compare(rr.dat_limite.Value, DateTime.Today);
                    if (rComp < 0)
                    {
                        int montant_amende = 10 + (DateTime.Today.Month - rr.dat_limite.Value.Month) + 12 * (DateTime.Today.Year - rr.dat_limite.Value.Year);
                        C_TB_location LocaTMP = new G_TB_location(sConnexion).Lire_ID(rr.ID_location);
                        C_TB_client clientTMP = new G_TB_client(sConnexion).Lire_ID(LocaTMP.ID_client);
                        MessageBox.Show("Une amende est dressé pour: " + clientTMP.client_nom + " " + clientTMP.client_prenom + " d'un montant de : " + montant_amende + " euros (10+[1*nombre de mois de retard]).");
                        new G_TB_details(sConnexion).Modifier(rr.ID_details, rr.ID_location, rr.ID_livre, rr.dat_emprunt, rr.dat_limite, rr.dat_rentre, montant_amende);
                    }
                }
            }
        }

        private void B_edition_livre_Click(object sender, EventArgs e)
        {
            //gestion des livres
            EcranLivre EL = new EcranLivre(sConnexion);
            EL.ShowDialog();
            //remplit à nouveau le DGV des livres
            RemplirLivre();
        }

        private void DGV_livre_SelectionChanged(object sender, EventArgs e)
        {
            //à chaque fois qu'un livre est sélectionné on met à jour les vérificateur d'état/... (Checked_box)
            if (DGV_livre.SelectedRows.Count > 0)
            {
                int nID = int.Parse(DGV_livre.SelectedRows[0].Cells["cID_livre"].Value.ToString());
                C_TB_livre check_livre = new G_TB_livre(sConnexion).Lire_ID(nID);
                if (check_livre.statut == 0)
                {
                    ChB_dispo.Checked = true;
                }
                else
                {
                    ChB_dispo.Checked = false;
                }
                if (check_livre.ID_categorie != null)
                {
                    C_TB_categorie check_cat = new G_TB_categorie(sConnexion).Lire_ID((int)check_livre.ID_categorie);
                    if (check_cat.Pegi == 1)
                    {
                        ChB_pegi.Checked = true;
                    }
                    else
                    {
                        ChB_pegi.Checked = false;
                    }
                }
                List<C_TB_details> lst_verif_rendu = new G_TB_details(sConnexion).Lire("ID_details");
                foreach(C_TB_details d in lst_verif_rendu.Where(n=>n.ID_livre==nID))
                {
                    if (d.dat_limite != null)
                    {
                        int rComp = DateTime.Compare(d.dat_limite.Value, DateTime.Today);
                        if (rComp < 0)
                        {
                            ChB_retard.Checked = true;
                        }
                        else
                        {
                            ChB_retard.Checked = false;
                        }
                    }
                    else
                    {
                        ChB_retard.Checked = false;
                    }
                }
            }
        }

        private void DGV_client_SelectionChanged(object sender, EventArgs e)
        {
            //à chaque fois qu'un client est sélectionné on met à jour le vérificateur d'âge (Checked_box)
            //les locations du client sélectionné seront affichés dans un DGV
            if (DGV_client.SelectedRows.Count > 0)
            {
                int cID = int.Parse(DGV_client.SelectedRows[0].Cells["cID_client"].Value.ToString());
                C_TB_client check_client_majeur = new G_TB_client(sConnexion).Lire_ID(cID);
                if (DateTime.Today.Year - check_client_majeur.client_nai.Year >= 18)
                {
                    ChB_majeur.Checked = true;
                }
                else
                {
                    ChB_majeur.Checked = false;
                }
                RemplirLocation(cID);
            }
        }

        private void B_cat_Click(object sender, EventArgs e)
        {
            //gestion des catégories
            EcranCategorie EC = new EcranCategorie(sConnexion);
            EC.ShowDialog();
        }

        private void b_stock_html_Click(object sender, EventArgs e)
        {
            //création du ficher HTML
            List<C_TB_livre> lTmp = new G_TB_livre(sConnexion).Lire("ID_livre");
            StreamWriter sw;
            sw = File.CreateText("livre_stock.html");
            sw.Write("<html>");
            sw.Write("<title> Stock de la bibliothèque </title>");
            sw.Write("<link rel='shortcut icon' href='F:\\COURS\\POO\\GD_BD_BIBLIO\\bin\\Debug\\39859.png'>");
            sw.Write("<link rel='stylesheet' href='F:\\COURS\\POO\\GD_BD_BIBLIO\\bin\\Debug\\index.css'>");
            sw.Write("<body>");
            sw.Write("<table class='content-table'>");
            sw.Write("<thead>");
            sw.Write("<tr><th>Auteur</th><th>Titre</th><th>Statut (dispo = 0)</th></tr>");
            sw.Write("</thead>");
            sw.Write("<tbody>");
            //rajouter une ligne au tableau pour chaque livres existants
            foreach (C_TB_livre l in lTmp)
            {
                if (l.statut == 1)
                {
                    sw.Write("<tr><td>" + l.auteur + "</td><td>" + l.titre + "</td><td>" + l.statut + "</td></tr>");
                }
                else
                {
                    sw.Write("<tr><td>" + l.auteur + "</td><td>" + l.titre + "</td><td>" + l.statut + "</td></tr>");
                }
            }
            sw.Write("</tbody>");
            sw.Write("</table>");
            sw.Write("</body>");
            sw.Write("</html>");
            sw.Close();
            //on ouvre le navigateur
            HTML_view HV = new HTML_view();
            HV.ShowDialog();
        }

        private void B_gestion_client_Click(object sender, EventArgs e)
        {
            //gestion des client
            EcranClient EC = new EcranClient(sConnexion);
            EC.ShowDialog();
            RemplirClient();
        }

        private void B_add_loca_Click(object sender, EventArgs e)
        {
            //ajout d'une location à un client
            if (DGV_client.SelectedRows.Count > 0) //si une ligne est sélectionné
            {
                int lID = int.Parse(DGV_client.SelectedRows[0].Cells["cId_client"].Value.ToString()); //récupère l'id_client
                C_TB_client ajout_loca = new G_TB_client(sConnexion).Lire_ID(lID); //récupère le client avec son ID
                bool retard_client = false; //vérif cotisation
                foreach (C_TB_client ret in Lst_retard_cot)
                {
                    if (ajout_loca.ID_client == ret.ID_client)
                    {
                        retard_client = true;
                    }
                }
                if (retard_client == true)
                {
                    MessageBox.Show("Impossible d'ajouter une location car ce client est en retard de cotisation.");
                }
                else
                {
                    if (MessageBox.Show("Ajouter une location au client: " + ajout_loca.ID_client + "?", "Ajout location ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int ajoutID = new G_TB_location(sConnexion).Ajouter(lID, DateTime.Today);
                        DT_location.Rows.Add(ajoutID, DateTime.Today);
                        if (MessageBox.Show("Ajouter un emprunt ?", "Ajout emprunt ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            while (encore == true)
                            {
                                //ajout d'un détail
                                EcranAjoutDetail EAD = new EcranAjoutDetail(sConnexion, ajoutID);
                                EAD.ShowDialog();
                                if (MessageBox.Show("Ajouter encore un détail ?", "Ajout détail ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    encore = true;
                                }
                                else
                                {
                                    encore = false;
                                }
                            }
                            encore = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Sélectionner un client !");
            }
        }

        private void B_Modifier_location_Click(object sender, EventArgs e)
        {
            //modification des emprunts d'une location
            if (DGV_location.SelectedRows.Count > 0)
            {
                int lID = int.Parse(DGV_client.SelectedRows[0].Cells["cId_client"].Value.ToString());
                int lID2 = int.Parse(DGV_location.SelectedRows[0].Cells["cID_location"].Value.ToString());
                C_TB_client modif_locat_client = new G_TB_client(sConnexion).Lire_ID(lID);
                C_TB_location modif_locat = new G_TB_location(sConnexion).Lire_ID(lID2);
                //vérification de cotisation
                bool retard_client = false;
                foreach (C_TB_client ret in Lst_retard_cot)
                {
                    if (modif_locat_client.ID_client == ret.ID_client)
                    {
                        retard_client = true;
                    }
                }
                if (retard_client == true)
                {
                    MessageBox.Show("Impossible de modifier la location car ce client est en retard de cotisation.");
                }
                else
                {
                    if (MessageBox.Show("Modifier la location N°" + modif_locat.ID_location + " du client: " + modif_locat_client.ID_client, "Modification location ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool mod = false;
                        List<C_TB_details> verif = new G_TB_details(sConnexion).Lire("ID_details");
                        //on cherche si la location contient un détail
                        foreach (C_TB_details d in verif)
                        {
                            if (d.ID_location == lID2)
                            {
                                mod = true;
                            }
                        }
                        if (mod == true)
                        {
                            //modif
                            EcranModifDetail EMD = new EcranModifDetail(sConnexion, lID2);
                            EMD.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("La location ne contient pas d'emprunt !");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Sélectionner une location !");
            }
        }

        private void B_affic_loca_Click(object sender, EventArgs e)
        {
            //affiche la location et ses emprunts
            if (DGV_location.SelectedRows.Count > 0)
            {
                int lID2 = int.Parse(DGV_location.SelectedRows[0].Cells["cID_location"].Value.ToString());
                EcranAfficDetail EAFD = new EcranAfficDetail(sConnexion, lID2);
                EAFD.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sélectionner une location !");
            }
        }

        private void B_generer_bordereau_Click(object sender, EventArgs e)
        {
            //bordeareau d'emprunt de la location sélectionné
            if (DGV_location.SelectedRows.Count > 0)
            {
                int lID = int.Parse(DGV_client.SelectedRows[0].Cells["cId_client"].Value.ToString());
                int lID2 = int.Parse(DGV_location.SelectedRows[0].Cells["cID_location"].Value.ToString());
                C_TB_location loca_bordeau = new G_TB_location(sConnexion).Lire_ID(lID2);
                C_TB_client loca_bordeau_client = new G_TB_client(sConnexion).Lire_ID(lID);
                List<C_TB_details> list_det_bor = new G_TB_details(sConnexion).Lire("ID_details");
                var PDF = new Document();
                string chemin = "F:\\COURS\\POO\\GD_BD_BIBLIO\\bin\\debug";
                string fichier = chemin + "\\Bordereau" + loca_bordeau_client.ID_client.ToString() + "_" + loca_bordeau.ID_location.ToString() + ".pdf";
                PdfWriter.GetInstance(PDF, new FileStream(fichier, FileMode.Create));
                PDF.Open();

                Image Logo = Image.GetInstance("F:\\COURS\\POO\\GD_BD_BIBLIO\\bin\\debug\\39859.png");
                Logo.Alignment = Image.TEXTWRAP | Image.ALIGN_RIGHT;
                Logo.ScaleAbsolute(50f, 50f);
                PDF.Add(Logo);
                Paragraph titre = new Paragraph("Bordereau d'emprunt de la bibliothèque")
                {
                    Alignment = Element.ALIGN_CENTER
                };
                PDF.Add(titre);

                Paragraph space = new Paragraph("")
                {
                    SpacingAfter = 10f,
                    SpacingBefore = 10f
                };
                PDF.Add(space);
                string info = "Nom: " + loca_bordeau_client.client_nom.ToString() + "  Prénom: " + loca_bordeau_client.client_prenom.ToString() + "                Date de location : " + loca_bordeau.dat_location.ToString();

                Paragraph Nom = new Paragraph(info)
                {
                    Alignment = Element.ALIGN_LEFT
                };
                PDF.Add(Nom);

                Paragraph space2 = new Paragraph("")
                {
                    SpacingAfter = 20f,
                    SpacingBefore = 20f
                };
                PDF.Add(space2);

                List lst = new List(List.UNORDERED);
                foreach (C_TB_details d in list_det_bor.Where(n => n.ID_location == lID2))
                {
                    C_TB_livre ltmp = new G_TB_livre(sConnexion).Lire_ID((int)d.ID_livre);
                    if (d.dat_limite == null)
                    {
                        string Detail = "  ID livre: " + d.ID_livre + " Titre: " + ltmp.titre + " Auteur: " + ltmp.auteur + " Date limite: N/A";
                        lst.Add(Detail);
                    }
                    else
                    {
                        string Detail = "  ID livre: " + d.ID_livre + " Titre: " + ltmp.titre + " Auteur: " + ltmp.auteur + " Date limite: " + d.dat_limite.ToString();
                        lst.Add(Detail);
                    }
                }


                PDF.Add(lst);
                PDF.Close();
                MessageBox.Show("PDF généré dans le dossier " + chemin + " !");
            }
        }

        private void B_supp_location_Click(object sender, EventArgs e)
        {
            //supprimer une location
            if (DGV_location.SelectedRows.Count > 0)
            {
                int lID = int.Parse(DGV_client.SelectedRows[0].Cells["cId_client"].Value.ToString());
                int lID2 = int.Parse(DGV_location.SelectedRows[0].Cells["cID_location"].Value.ToString());
                C_TB_client supp_locat_client = new G_TB_client(sConnexion).Lire_ID(lID);
                C_TB_location supp_locat = new G_TB_location(sConnexion).Lire_ID(lID2);
                bool retard_client = false;
                foreach(C_TB_client ret in Lst_retard_cot)
                {
                    if(supp_locat_client.ID_client == ret.ID_client)
                    {
                        retard_client = true;
                    }
                }
                if (retard_client == true)
                {
                    MessageBox.Show("Impossible de supprimer la location car ce client est en retard de cotisation.");
                }
                else
                {
                    if (MessageBox.Show("Supprimer la location N°" + supp_locat.ID_location + " du client: " + supp_locat_client.ID_client, "supprimer la location ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //vérifier que cette location n'a pas de livre non rentré
                        bool rentre = true;
                        List<C_TB_details> dTmp = new G_TB_details(sConnexion).Lire("ID_details");
                        foreach (C_TB_details d in dTmp.Where(n => n.ID_location == lID2))
                        {
                            if (d.dat_rentre == null)
                            {
                                rentre = false;
                            }
                        }
                        if (rentre == false)
                        {
                            MessageBox.Show("Livre(s) non rentré(s) ! Impossible de supprimer la location");
                        }
                        else
                        {
                            //supprime d'abord les détails pour éviter les erreurs puis la location
                            foreach (C_TB_details d in dTmp.Where(n => n.ID_location == lID2))
                            {
                                new G_TB_details(sConnexion).Supprimer(d.ID_details);
                            }
                            new G_TB_location(sConnexion).Supprimer(lID2);
                            BS_location.RemoveCurrent();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Sélectionner une location !");
            }
        }

        private void RemplirLocation(int lID)
        {
            //remplit location DGV avec l'id du client en paramètre
            DT_location = new DataTable();
            DT_location.Columns.Add(new DataColumn("ID_location", System.Type.GetType("System.Int32")));
            DT_location.Columns.Add(new DataColumn("dat_location", System.Type.GetType("System.DateTime")));
            List<C_TB_location> lTmp = new G_TB_location(sConnexion).Lire("ID_location");
            foreach (C_TB_location l in lTmp.Where(n => n.ID_client == lID))
            {
                DT_location.Rows.Add(l.ID_location, l.dat_location);
            }
            BS_location = new BindingSource();
            BS_location.DataSource = DT_location;
            DGV_location.DataSource = BS_location;
        }

        private void RemplirClient()
        {
            //remplit client DGV
            Lst_retard_cot.Clear();
            DT_client = new DataTable();
            DT_client.Columns.Add(new DataColumn("ID_client", System.Type.GetType("System.Int32")));
            DT_client.Columns.Add(new DataColumn("Aff_nom_prenom"));
            DT_client.Columns.Add(new DataColumn("client_nai", System.Type.GetType("System.DateTime")));
            List<C_TB_client> cTmp = new G_TB_client(sConnexion).Lire("client_nom");
            foreach (C_TB_client c in cTmp)
            {
                DT_client.Rows.Add(c.ID_client, c.client_nom + " " + c.client_prenom, c.client_nai);
                if (DateTime.Today.Month - c.client_cotisation.Month >= 1)
                {
                    Lst_retard_cot.Add((C_TB_client)c);
                }
            }
            BS_client = new BindingSource();
            BS_client.DataSource = DT_client;
            DGV_client.DataSource = BS_client;
        }

        private void RemplirLivre()
        {
            //remplit livre DGV
            DT_livre = new DataTable();
            DT_livre.Columns.Add(new DataColumn("ID_livre", System.Type.GetType("System.Int32")));
            DT_livre.Columns.Add(new DataColumn("Aff_auteur_nom"));
            DT_livre.Columns.Add(new DataColumn("livre_cat"));
            DT_livre.Columns.Add(new DataColumn("livre_ann_pub"));
            List<C_TB_livre> lTmp = new G_TB_livre(sConnexion).Lire("ID_livre");
            foreach (C_TB_livre l in lTmp)
            {
                //récupère le nom de la catégorie associé à id_livre.id_categorie
                string nom_cat;
                if (l.ID_categorie != null)
                {
                    C_TB_categorie Cat_Tmp = new G_TB_categorie(sConnexion).Lire_ID((int)l.ID_categorie);
                    nom_cat = Cat_Tmp.Nom;
                    DT_livre.Rows.Add(l.ID_livre, l.auteur + "-" + l.titre, nom_cat.ToString(), l.Ann_pub);
                }
                else
                {
                    DT_livre.Rows.Add(l.ID_livre, l.auteur + "-" + l.titre, "Aucune", l.Ann_pub);
                }
            }
            BS_livres = new BindingSource();
            BS_livres.DataSource = DT_livre;
            DGV_livre.DataSource = BS_livres;
        }
        #endregion
    }
}