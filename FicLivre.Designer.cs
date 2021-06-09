
namespace GD_BD_BIBLIO
{
    partial class EcranLivre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranLivre));
            this.DGV_livre = new System.Windows.Forms.DataGridView();
            this.cID_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAffiche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAnn_pub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.B_ann_livre = new System.Windows.Forms.Button();
            this.B_conf_livre = new System.Windows.Forms.Button();
            this.TB_titre = new System.Windows.Forms.TextBox();
            this.TB_ID_livre = new System.Windows.Forms.TextBox();
            this.B_supp_livre = new System.Windows.Forms.Button();
            this.B_edit_livre = new System.Windows.Forms.Button();
            this.B_ajout_livre = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_auteur = new System.Windows.Forms.TextBox();
            this.CB_cat_livre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NUD_ann_pub = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_livre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_ann_pub)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_livre
            // 
            this.DGV_livre.AllowUserToAddRows = false;
            this.DGV_livre.AllowUserToDeleteRows = false;
            this.DGV_livre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGV_livre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID_livre,
            this.cAffiche,
            this.cCategorie,
            this.cAnn_pub});
            this.DGV_livre.Location = new System.Drawing.Point(12, 12);
            this.DGV_livre.MultiSelect = false;
            this.DGV_livre.Name = "DGV_livre";
            this.DGV_livre.ReadOnly = true;
            this.DGV_livre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_livre.Size = new System.Drawing.Size(233, 150);
            this.DGV_livre.TabIndex = 1;
            // 
            // cID_livre
            // 
            this.cID_livre.DataPropertyName = "ID_livre";
            this.cID_livre.HeaderText = "N°";
            this.cID_livre.Name = "cID_livre";
            this.cID_livre.ReadOnly = true;
            this.cID_livre.Width = 44;
            // 
            // cAffiche
            // 
            this.cAffiche.DataPropertyName = "Afficher";
            this.cAffiche.HeaderText = "Auteur - Livre";
            this.cAffiche.Name = "cAffiche";
            this.cAffiche.ReadOnly = true;
            this.cAffiche.Width = 95;
            // 
            // cCategorie
            // 
            this.cCategorie.DataPropertyName = "ID_categorie";
            this.cCategorie.HeaderText = "Catégorie";
            this.cCategorie.Name = "cCategorie";
            this.cCategorie.ReadOnly = true;
            this.cCategorie.Width = 77;
            // 
            // cAnn_pub
            // 
            this.cAnn_pub.DataPropertyName = "ann_pub";
            this.cAnn_pub.HeaderText = "Année de publication";
            this.cAnn_pub.Name = "cAnn_pub";
            this.cAnn_pub.ReadOnly = true;
            this.cAnn_pub.Width = 132;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Titre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID:";
            // 
            // B_ann_livre
            // 
            this.B_ann_livre.Location = new System.Drawing.Point(172, 324);
            this.B_ann_livre.Name = "B_ann_livre";
            this.B_ann_livre.Size = new System.Drawing.Size(75, 23);
            this.B_ann_livre.TabIndex = 18;
            this.B_ann_livre.Text = "Annuler";
            this.B_ann_livre.UseVisualStyleBackColor = true;
            this.B_ann_livre.Click += new System.EventHandler(this.B_ann_livre_Click);
            // 
            // B_conf_livre
            // 
            this.B_conf_livre.Location = new System.Drawing.Point(12, 324);
            this.B_conf_livre.Name = "B_conf_livre";
            this.B_conf_livre.Size = new System.Drawing.Size(76, 23);
            this.B_conf_livre.TabIndex = 17;
            this.B_conf_livre.Text = "Confimer";
            this.B_conf_livre.UseVisualStyleBackColor = true;
            this.B_conf_livre.Click += new System.EventHandler(this.B_conf_livre_Click);
            // 
            // TB_titre
            // 
            this.TB_titre.Location = new System.Drawing.Point(144, 204);
            this.TB_titre.Name = "TB_titre";
            this.TB_titre.Size = new System.Drawing.Size(103, 20);
            this.TB_titre.TabIndex = 15;
            // 
            // TB_ID_livre
            // 
            this.TB_ID_livre.Location = new System.Drawing.Point(38, 203);
            this.TB_ID_livre.Name = "TB_ID_livre";
            this.TB_ID_livre.ReadOnly = true;
            this.TB_ID_livre.Size = new System.Drawing.Size(44, 20);
            this.TB_ID_livre.TabIndex = 14;
            // 
            // B_supp_livre
            // 
            this.B_supp_livre.Location = new System.Drawing.Point(170, 174);
            this.B_supp_livre.Name = "B_supp_livre";
            this.B_supp_livre.Size = new System.Drawing.Size(75, 23);
            this.B_supp_livre.TabIndex = 13;
            this.B_supp_livre.Text = "Supprimer";
            this.B_supp_livre.UseVisualStyleBackColor = true;
            this.B_supp_livre.Click += new System.EventHandler(this.B_supp_livre_Click);
            // 
            // B_edit_livre
            // 
            this.B_edit_livre.Location = new System.Drawing.Point(89, 174);
            this.B_edit_livre.Name = "B_edit_livre";
            this.B_edit_livre.Size = new System.Drawing.Size(75, 23);
            this.B_edit_livre.TabIndex = 12;
            this.B_edit_livre.Text = "Éditer";
            this.B_edit_livre.UseVisualStyleBackColor = true;
            this.B_edit_livre.Click += new System.EventHandler(this.B_edit_livre_Click);
            // 
            // B_ajout_livre
            // 
            this.B_ajout_livre.Location = new System.Drawing.Point(11, 174);
            this.B_ajout_livre.Name = "B_ajout_livre";
            this.B_ajout_livre.Size = new System.Drawing.Size(75, 23);
            this.B_ajout_livre.TabIndex = 11;
            this.B_ajout_livre.Text = "Ajout";
            this.B_ajout_livre.UseVisualStyleBackColor = true;
            this.B_ajout_livre.Click += new System.EventHandler(this.B_ajout_livre_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Auteur:";
            // 
            // TB_auteur
            // 
            this.TB_auteur.Location = new System.Drawing.Point(144, 230);
            this.TB_auteur.Name = "TB_auteur";
            this.TB_auteur.Size = new System.Drawing.Size(103, 20);
            this.TB_auteur.TabIndex = 21;
            // 
            // CB_cat_livre
            // 
            this.CB_cat_livre.FormattingEnabled = true;
            this.CB_cat_livre.Location = new System.Drawing.Point(126, 256);
            this.CB_cat_livre.Name = "CB_cat_livre";
            this.CB_cat_livre.Size = new System.Drawing.Size(121, 21);
            this.CB_cat_livre.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Catégorie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Année de publication:";
            // 
            // NUD_ann_pub
            // 
            this.NUD_ann_pub.Location = new System.Drawing.Point(127, 283);
            this.NUD_ann_pub.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NUD_ann_pub.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.NUD_ann_pub.Name = "NUD_ann_pub";
            this.NUD_ann_pub.Size = new System.Drawing.Size(120, 20);
            this.NUD_ann_pub.TabIndex = 27;
            this.NUD_ann_pub.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // EcranLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(257, 355);
            this.Controls.Add(this.NUD_ann_pub);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_cat_livre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_auteur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_ann_livre);
            this.Controls.Add(this.B_conf_livre);
            this.Controls.Add(this.TB_titre);
            this.Controls.Add(this.TB_ID_livre);
            this.Controls.Add(this.B_supp_livre);
            this.Controls.Add(this.B_edit_livre);
            this.Controls.Add(this.B_ajout_livre);
            this.Controls.Add(this.DGV_livre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranLivre";
            this.Text = "Édition du stock";
            this.Load += new System.EventHandler(this.EcranLivre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_livre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_ann_pub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_livre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_ann_livre;
        private System.Windows.Forms.Button B_conf_livre;
        private System.Windows.Forms.TextBox TB_titre;
        private System.Windows.Forms.TextBox TB_ID_livre;
        private System.Windows.Forms.Button B_supp_livre;
        private System.Windows.Forms.Button B_edit_livre;
        private System.Windows.Forms.Button B_ajout_livre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_auteur;
        private System.Windows.Forms.ComboBox CB_cat_livre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NUD_ann_pub;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAffiche;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAnn_pub;
    }
}