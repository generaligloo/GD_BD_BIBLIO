
namespace GD_BD_BIBLIO
{
    partial class EcranCategorie
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranCategorie));
            this.DGV_cat = new System.Windows.Forms.DataGridView();
            this.ID_cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat_pegi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_ajout_cat = new System.Windows.Forms.Button();
            this.B_edit_cat = new System.Windows.Forms.Button();
            this.B_supp_cat = new System.Windows.Forms.Button();
            this.TB_ID_cat = new System.Windows.Forms.TextBox();
            this.TB_nom_cat = new System.Windows.Forms.TextBox();
            this.CB_pegi_cat = new System.Windows.Forms.CheckBox();
            this.B_conf_cat = new System.Windows.Forms.Button();
            this.B_ann_cat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_cat)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_cat
            // 
            this.DGV_cat.AllowUserToAddRows = false;
            this.DGV_cat.AllowUserToDeleteRows = false;
            this.DGV_cat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_cat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_cat,
            this.cat_nom,
            this.cat_pegi});
            this.DGV_cat.Location = new System.Drawing.Point(17, 12);
            this.DGV_cat.MultiSelect = false;
            this.DGV_cat.Name = "DGV_cat";
            this.DGV_cat.ReadOnly = true;
            this.DGV_cat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_cat.Size = new System.Drawing.Size(233, 150);
            this.DGV_cat.TabIndex = 0;
            // 
            // ID_cat
            // 
            this.ID_cat.DataPropertyName = "ID_categorie";
            this.ID_cat.HeaderText = "N°";
            this.ID_cat.Name = "ID_cat";
            this.ID_cat.ReadOnly = true;
            // 
            // cat_nom
            // 
            this.cat_nom.DataPropertyName = "Nom";
            this.cat_nom.HeaderText = "Nom";
            this.cat_nom.Name = "cat_nom";
            this.cat_nom.ReadOnly = true;
            // 
            // cat_pegi
            // 
            this.cat_pegi.DataPropertyName = "Pegi";
            this.cat_pegi.HeaderText = "+18";
            this.cat_pegi.Name = "cat_pegi";
            this.cat_pegi.ReadOnly = true;
            // 
            // B_ajout_cat
            // 
            this.B_ajout_cat.Location = new System.Drawing.Point(14, 170);
            this.B_ajout_cat.Name = "B_ajout_cat";
            this.B_ajout_cat.Size = new System.Drawing.Size(75, 23);
            this.B_ajout_cat.TabIndex = 1;
            this.B_ajout_cat.Text = "Ajout";
            this.B_ajout_cat.UseVisualStyleBackColor = true;
            this.B_ajout_cat.Click += new System.EventHandler(this.B_ajout_cat_Click);
            // 
            // B_edit_cat
            // 
            this.B_edit_cat.Location = new System.Drawing.Point(94, 170);
            this.B_edit_cat.Name = "B_edit_cat";
            this.B_edit_cat.Size = new System.Drawing.Size(75, 23);
            this.B_edit_cat.TabIndex = 2;
            this.B_edit_cat.Text = "Éditer";
            this.B_edit_cat.UseVisualStyleBackColor = true;
            this.B_edit_cat.Click += new System.EventHandler(this.B_edit_cat_Click);
            // 
            // B_supp_cat
            // 
            this.B_supp_cat.Location = new System.Drawing.Point(175, 170);
            this.B_supp_cat.Name = "B_supp_cat";
            this.B_supp_cat.Size = new System.Drawing.Size(75, 23);
            this.B_supp_cat.TabIndex = 3;
            this.B_supp_cat.Text = "Supprimer";
            this.B_supp_cat.UseVisualStyleBackColor = true;
            this.B_supp_cat.Click += new System.EventHandler(this.B_supp_cat_Click);
            // 
            // TB_ID_cat
            // 
            this.TB_ID_cat.Location = new System.Drawing.Point(41, 199);
            this.TB_ID_cat.Name = "TB_ID_cat";
            this.TB_ID_cat.ReadOnly = true;
            this.TB_ID_cat.Size = new System.Drawing.Size(44, 20);
            this.TB_ID_cat.TabIndex = 4;
            // 
            // TB_nom_cat
            // 
            this.TB_nom_cat.Location = new System.Drawing.Point(147, 200);
            this.TB_nom_cat.Name = "TB_nom_cat";
            this.TB_nom_cat.Size = new System.Drawing.Size(103, 20);
            this.TB_nom_cat.TabIndex = 5;
            // 
            // CB_pegi_cat
            // 
            this.CB_pegi_cat.AutoSize = true;
            this.CB_pegi_cat.Location = new System.Drawing.Point(13, 227);
            this.CB_pegi_cat.Name = "CB_pegi_cat";
            this.CB_pegi_cat.Size = new System.Drawing.Size(44, 17);
            this.CB_pegi_cat.TabIndex = 6;
            this.CB_pegi_cat.Text = "+18";
            this.CB_pegi_cat.UseVisualStyleBackColor = true;
            // 
            // B_conf_cat
            // 
            this.B_conf_cat.Location = new System.Drawing.Point(13, 250);
            this.B_conf_cat.Name = "B_conf_cat";
            this.B_conf_cat.Size = new System.Drawing.Size(76, 23);
            this.B_conf_cat.TabIndex = 7;
            this.B_conf_cat.Text = "Confimer";
            this.B_conf_cat.UseVisualStyleBackColor = true;
            this.B_conf_cat.Click += new System.EventHandler(this.B_conf_cat_Click);
            // 
            // B_ann_cat
            // 
            this.B_ann_cat.Location = new System.Drawing.Point(175, 250);
            this.B_ann_cat.Name = "B_ann_cat";
            this.B_ann_cat.Size = new System.Drawing.Size(75, 23);
            this.B_ann_cat.TabIndex = 8;
            this.B_ann_cat.Text = "Annuler";
            this.B_ann_cat.UseVisualStyleBackColor = true;
            this.B_ann_cat.Click += new System.EventHandler(this.B_ann_cat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nom:";
            // 
            // EcranCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(268, 281);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_ann_cat);
            this.Controls.Add(this.B_conf_cat);
            this.Controls.Add(this.CB_pegi_cat);
            this.Controls.Add(this.TB_nom_cat);
            this.Controls.Add(this.TB_ID_cat);
            this.Controls.Add(this.B_supp_cat);
            this.Controls.Add(this.B_edit_cat);
            this.Controls.Add(this.B_ajout_cat);
            this.Controls.Add(this.DGV_cat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranCategorie";
            this.Text = "Gestion de stock \"Biblio\"";
            this.Load += new System.EventHandler(this.EcranPrincipale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_cat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_cat;
        private System.Windows.Forms.Button B_ajout_cat;
        private System.Windows.Forms.Button B_edit_cat;
        private System.Windows.Forms.Button B_supp_cat;
        private System.Windows.Forms.TextBox TB_ID_cat;
        private System.Windows.Forms.TextBox TB_nom_cat;
        private System.Windows.Forms.CheckBox CB_pegi_cat;
        private System.Windows.Forms.Button B_conf_cat;
        private System.Windows.Forms.Button B_ann_cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat_pegi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

