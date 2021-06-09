
namespace GD_BD_BIBLIO
{
    partial class EcranPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranPrincipal));
            this.DGV_client = new System.Windows.Forms.DataGridView();
            this.cID_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNom_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNai_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_cat = new System.Windows.Forms.Button();
            this.GB_client = new System.Windows.Forms.GroupBox();
            this.B_affic_loca = new System.Windows.Forms.Button();
            this.B_supp_location = new System.Windows.Forms.Button();
            this.B_Modifier_location = new System.Windows.Forms.Button();
            this.B_add_loca = new System.Windows.Forms.Button();
            this.DGV_location = new System.Windows.Forms.DataGridView();
            this.cID_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDat_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChB_majeur = new System.Windows.Forms.CheckBox();
            this.B_gestion_client = new System.Windows.Forms.Button();
            this.B_generer_bordereau = new System.Windows.Forms.Button();
            this.GB_livre = new System.Windows.Forms.GroupBox();
            this.ChB_retard = new System.Windows.Forms.CheckBox();
            this.ChB_pegi = new System.Windows.Forms.CheckBox();
            this.b_stock_html = new System.Windows.Forms.Button();
            this.ChB_dispo = new System.Windows.Forms.CheckBox();
            this.B_edition_livre = new System.Windows.Forms.Button();
            this.DGV_livre = new System.Windows.Forms.DataGridView();
            this.cID_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNom_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCat_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPub_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_client)).BeginInit();
            this.GB_client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_location)).BeginInit();
            this.GB_livre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_livre)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_client
            // 
            this.DGV_client.AllowUserToAddRows = false;
            this.DGV_client.AllowUserToDeleteRows = false;
            this.DGV_client.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID_client,
            this.cNom_client,
            this.cNai_client});
            this.DGV_client.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_client.Location = new System.Drawing.Point(6, 19);
            this.DGV_client.MultiSelect = false;
            this.DGV_client.Name = "DGV_client";
            this.DGV_client.ReadOnly = true;
            this.DGV_client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_client.Size = new System.Drawing.Size(348, 150);
            this.DGV_client.TabIndex = 1;
            this.DGV_client.SelectionChanged += new System.EventHandler(this.DGV_client_SelectionChanged);
            // 
            // cID_client
            // 
            this.cID_client.DataPropertyName = "ID_client";
            this.cID_client.HeaderText = "N°";
            this.cID_client.Name = "cID_client";
            this.cID_client.ReadOnly = true;
            // 
            // cNom_client
            // 
            this.cNom_client.DataPropertyName = "Aff_nom_prenom";
            this.cNom_client.HeaderText = "Nom et Prénom";
            this.cNom_client.Name = "cNom_client";
            this.cNom_client.ReadOnly = true;
            // 
            // cNai_client
            // 
            this.cNai_client.DataPropertyName = "client_nai";
            this.cNai_client.HeaderText = "Date de naissance";
            this.cNai_client.Name = "cNai_client";
            this.cNai_client.ReadOnly = true;
            // 
            // B_cat
            // 
            this.B_cat.Location = new System.Drawing.Point(6, 367);
            this.B_cat.Name = "B_cat";
            this.B_cat.Size = new System.Drawing.Size(347, 23);
            this.B_cat.TabIndex = 3;
            this.B_cat.Text = "Configurer les catégories";
            this.B_cat.UseVisualStyleBackColor = true;
            this.B_cat.Click += new System.EventHandler(this.B_cat_Click);
            // 
            // GB_client
            // 
            this.GB_client.Controls.Add(this.B_affic_loca);
            this.GB_client.Controls.Add(this.B_supp_location);
            this.GB_client.Controls.Add(this.B_Modifier_location);
            this.GB_client.Controls.Add(this.B_add_loca);
            this.GB_client.Controls.Add(this.DGV_location);
            this.GB_client.Controls.Add(this.ChB_majeur);
            this.GB_client.Controls.Add(this.B_gestion_client);
            this.GB_client.Controls.Add(this.DGV_client);
            this.GB_client.Location = new System.Drawing.Point(12, 13);
            this.GB_client.Name = "GB_client";
            this.GB_client.Size = new System.Drawing.Size(360, 425);
            this.GB_client.TabIndex = 4;
            this.GB_client.TabStop = false;
            this.GB_client.Text = "Section Clients";
            // 
            // B_affic_loca
            // 
            this.B_affic_loca.Location = new System.Drawing.Point(187, 390);
            this.B_affic_loca.Name = "B_affic_loca";
            this.B_affic_loca.Size = new System.Drawing.Size(167, 23);
            this.B_affic_loca.TabIndex = 13;
            this.B_affic_loca.Text = "Afficher la location";
            this.B_affic_loca.UseVisualStyleBackColor = true;
            this.B_affic_loca.Click += new System.EventHandler(this.B_affic_loca_Click);
            // 
            // B_supp_location
            // 
            this.B_supp_location.Location = new System.Drawing.Point(6, 390);
            this.B_supp_location.Name = "B_supp_location";
            this.B_supp_location.Size = new System.Drawing.Size(168, 23);
            this.B_supp_location.TabIndex = 12;
            this.B_supp_location.Text = "Supprimer la location";
            this.B_supp_location.UseVisualStyleBackColor = true;
            this.B_supp_location.Click += new System.EventHandler(this.B_supp_location_Click);
            // 
            // B_Modifier_location
            // 
            this.B_Modifier_location.Location = new System.Drawing.Point(187, 361);
            this.B_Modifier_location.Name = "B_Modifier_location";
            this.B_Modifier_location.Size = new System.Drawing.Size(167, 23);
            this.B_Modifier_location.TabIndex = 10;
            this.B_Modifier_location.Text = "Modifier la location";
            this.B_Modifier_location.UseVisualStyleBackColor = true;
            this.B_Modifier_location.Click += new System.EventHandler(this.B_Modifier_location_Click);
            // 
            // B_add_loca
            // 
            this.B_add_loca.Location = new System.Drawing.Point(6, 361);
            this.B_add_loca.Name = "B_add_loca";
            this.B_add_loca.Size = new System.Drawing.Size(168, 23);
            this.B_add_loca.TabIndex = 9;
            this.B_add_loca.Text = "Ajouter une location";
            this.B_add_loca.UseVisualStyleBackColor = true;
            this.B_add_loca.Click += new System.EventHandler(this.B_add_loca_Click);
            // 
            // DGV_location
            // 
            this.DGV_location.AllowUserToAddRows = false;
            this.DGV_location.AllowUserToDeleteRows = false;
            this.DGV_location.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_location.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID_location,
            this.cDat_location});
            this.DGV_location.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_location.Location = new System.Drawing.Point(6, 204);
            this.DGV_location.MultiSelect = false;
            this.DGV_location.Name = "DGV_location";
            this.DGV_location.ReadOnly = true;
            this.DGV_location.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_location.Size = new System.Drawing.Size(348, 150);
            this.DGV_location.TabIndex = 8;
            // 
            // cID_location
            // 
            this.cID_location.DataPropertyName = "ID_location";
            this.cID_location.HeaderText = "ID de location";
            this.cID_location.Name = "cID_location";
            this.cID_location.ReadOnly = true;
            // 
            // cDat_location
            // 
            this.cDat_location.DataPropertyName = "dat_location";
            this.cDat_location.HeaderText = "Date de location";
            this.cDat_location.Name = "cDat_location";
            this.cDat_location.ReadOnly = true;
            // 
            // ChB_majeur
            // 
            this.ChB_majeur.AutoCheck = false;
            this.ChB_majeur.AutoSize = true;
            this.ChB_majeur.Location = new System.Drawing.Point(7, 178);
            this.ChB_majeur.Name = "ChB_majeur";
            this.ChB_majeur.Size = new System.Drawing.Size(67, 17);
            this.ChB_majeur.TabIndex = 7;
            this.ChB_majeur.Text = "Majeur ?";
            this.ChB_majeur.UseVisualStyleBackColor = true;
            // 
            // B_gestion_client
            // 
            this.B_gestion_client.Location = new System.Drawing.Point(79, 175);
            this.B_gestion_client.Name = "B_gestion_client";
            this.B_gestion_client.Size = new System.Drawing.Size(275, 23);
            this.B_gestion_client.TabIndex = 7;
            this.B_gestion_client.Text = "Gestion des clients";
            this.B_gestion_client.UseVisualStyleBackColor = true;
            this.B_gestion_client.Click += new System.EventHandler(this.B_gestion_client_Click);
            // 
            // B_generer_bordereau
            // 
            this.B_generer_bordereau.Location = new System.Drawing.Point(386, 415);
            this.B_generer_bordereau.Name = "B_generer_bordereau";
            this.B_generer_bordereau.Size = new System.Drawing.Size(360, 23);
            this.B_generer_bordereau.TabIndex = 11;
            this.B_generer_bordereau.Text = "Générer bordereau d\'emprunt";
            this.B_generer_bordereau.UseVisualStyleBackColor = true;
            this.B_generer_bordereau.Click += new System.EventHandler(this.B_generer_bordereau_Click);
            // 
            // GB_livre
            // 
            this.GB_livre.Controls.Add(this.ChB_retard);
            this.GB_livre.Controls.Add(this.ChB_pegi);
            this.GB_livre.Controls.Add(this.b_stock_html);
            this.GB_livre.Controls.Add(this.ChB_dispo);
            this.GB_livre.Controls.Add(this.B_edition_livre);
            this.GB_livre.Controls.Add(this.DGV_livre);
            this.GB_livre.Controls.Add(this.B_cat);
            this.GB_livre.Location = new System.Drawing.Point(386, 13);
            this.GB_livre.Name = "GB_livre";
            this.GB_livre.Size = new System.Drawing.Size(360, 396);
            this.GB_livre.TabIndex = 5;
            this.GB_livre.TabStop = false;
            this.GB_livre.Text = "Section Livres";
            // 
            // ChB_retard
            // 
            this.ChB_retard.AutoCheck = false;
            this.ChB_retard.AutoSize = true;
            this.ChB_retard.Location = new System.Drawing.Point(148, 286);
            this.ChB_retard.Name = "ChB_retard";
            this.ChB_retard.Size = new System.Drawing.Size(67, 17);
            this.ChB_retard.TabIndex = 8;
            this.ChB_retard.Text = "Retard ?";
            this.ChB_retard.UseVisualStyleBackColor = true;
            // 
            // ChB_pegi
            // 
            this.ChB_pegi.AutoCheck = false;
            this.ChB_pegi.AutoSize = true;
            this.ChB_pegi.Location = new System.Drawing.Point(297, 286);
            this.ChB_pegi.Name = "ChB_pegi";
            this.ChB_pegi.Size = new System.Drawing.Size(56, 17);
            this.ChB_pegi.TabIndex = 7;
            this.ChB_pegi.Text = "+ 18 ?";
            this.ChB_pegi.UseVisualStyleBackColor = true;
            // 
            // b_stock_html
            // 
            this.b_stock_html.Location = new System.Drawing.Point(6, 309);
            this.b_stock_html.Name = "b_stock_html";
            this.b_stock_html.Size = new System.Drawing.Size(347, 23);
            this.b_stock_html.TabIndex = 6;
            this.b_stock_html.Text = "Générer état du stock (HTML)";
            this.b_stock_html.UseVisualStyleBackColor = true;
            this.b_stock_html.Click += new System.EventHandler(this.b_stock_html_Click);
            // 
            // ChB_dispo
            // 
            this.ChB_dispo.AutoCheck = false;
            this.ChB_dispo.AutoSize = true;
            this.ChB_dispo.Location = new System.Drawing.Point(7, 286);
            this.ChB_dispo.Name = "ChB_dispo";
            this.ChB_dispo.Size = new System.Drawing.Size(84, 17);
            this.ChB_dispo.TabIndex = 5;
            this.ChB_dispo.Text = "Disponible ?";
            this.ChB_dispo.UseVisualStyleBackColor = true;
            // 
            // B_edition_livre
            // 
            this.B_edition_livre.Location = new System.Drawing.Point(6, 338);
            this.B_edition_livre.Name = "B_edition_livre";
            this.B_edition_livre.Size = new System.Drawing.Size(347, 23);
            this.B_edition_livre.TabIndex = 4;
            this.B_edition_livre.Text = "Configurer le stock de livre";
            this.B_edition_livre.UseVisualStyleBackColor = true;
            this.B_edition_livre.Click += new System.EventHandler(this.B_edition_livre_Click);
            // 
            // DGV_livre
            // 
            this.DGV_livre.AllowUserToAddRows = false;
            this.DGV_livre.AllowUserToDeleteRows = false;
            this.DGV_livre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_livre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID_livre,
            this.cNom_livre,
            this.cCat_livre,
            this.cPub_livre});
            this.DGV_livre.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_livre.Location = new System.Drawing.Point(5, 19);
            this.DGV_livre.MultiSelect = false;
            this.DGV_livre.Name = "DGV_livre";
            this.DGV_livre.ReadOnly = true;
            this.DGV_livre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_livre.Size = new System.Drawing.Size(348, 261);
            this.DGV_livre.TabIndex = 1;
            this.DGV_livre.SelectionChanged += new System.EventHandler(this.DGV_livre_SelectionChanged);
            // 
            // cID_livre
            // 
            this.cID_livre.DataPropertyName = "ID_livre";
            this.cID_livre.HeaderText = "N°";
            this.cID_livre.Name = "cID_livre";
            this.cID_livre.ReadOnly = true;
            // 
            // cNom_livre
            // 
            this.cNom_livre.DataPropertyName = "Aff_auteur_nom";
            this.cNom_livre.HeaderText = "Auteur - Nom";
            this.cNom_livre.Name = "cNom_livre";
            this.cNom_livre.ReadOnly = true;
            // 
            // cCat_livre
            // 
            this.cCat_livre.DataPropertyName = "livre_cat";
            this.cCat_livre.HeaderText = "Catégorie";
            this.cCat_livre.Name = "cCat_livre";
            this.cCat_livre.ReadOnly = true;
            // 
            // cPub_livre
            // 
            this.cPub_livre.DataPropertyName = "livre_ann_pub";
            this.cPub_livre.HeaderText = "Année de publication";
            this.cPub_livre.Name = "cPub_livre";
            this.cPub_livre.ReadOnly = true;
            // 
            // EcranPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.GB_livre);
            this.Controls.Add(this.B_generer_bordereau);
            this.Controls.Add(this.GB_client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranPrincipal";
            this.Text = "Tableau de bord";
            this.Load += new System.EventHandler(this.EcranPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_client)).EndInit();
            this.GB_client.ResumeLayout(false);
            this.GB_client.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_location)).EndInit();
            this.GB_livre.ResumeLayout(false);
            this.GB_livre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_livre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_client;
        private System.Windows.Forms.Button B_cat;
        private System.Windows.Forms.GroupBox GB_client;
        private System.Windows.Forms.GroupBox GB_livre;
        private System.Windows.Forms.DataGridView DGV_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNom_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNai_client;
        private System.Windows.Forms.Button B_edition_livre;
        private System.Windows.Forms.CheckBox ChB_dispo;
        private System.Windows.Forms.Button b_stock_html;
        private System.Windows.Forms.Button B_gestion_client;
        private System.Windows.Forms.CheckBox ChB_majeur;
        private System.Windows.Forms.DataGridView DGV_location;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID_location;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDat_location;
        private System.Windows.Forms.Button B_supp_location;
        private System.Windows.Forms.Button B_generer_bordereau;
        private System.Windows.Forms.Button B_Modifier_location;
        private System.Windows.Forms.Button B_add_loca;
        private System.Windows.Forms.CheckBox ChB_pegi;
        private System.Windows.Forms.Button B_affic_loca;
        private System.Windows.Forms.CheckBox ChB_retard;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNom_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCat_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPub_livre;
    }
}