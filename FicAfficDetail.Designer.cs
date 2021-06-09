
namespace GD_BD_BIBLIO
{
    partial class EcranAfficDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranAfficDetail));
            this.DGV_detail = new System.Windows.Forms.DataGridView();
            this.cID_details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTitre_ID_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDat_limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDat_emprunt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDat_rentre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAmende = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_detail
            // 
            this.DGV_detail.AllowUserToAddRows = false;
            this.DGV_detail.AllowUserToDeleteRows = false;
            this.DGV_detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID_details,
            this.cTitre_ID_livre,
            this.cDat_limite,
            this.cDat_emprunt,
            this.cDat_rentre,
            this.cAmende});
            this.DGV_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_detail.Location = new System.Drawing.Point(0, 0);
            this.DGV_detail.MultiSelect = false;
            this.DGV_detail.Name = "DGV_detail";
            this.DGV_detail.ReadOnly = true;
            this.DGV_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_detail.Size = new System.Drawing.Size(574, 198);
            this.DGV_detail.TabIndex = 9;
            // 
            // cID_details
            // 
            this.cID_details.DataPropertyName = "ID_details";
            this.cID_details.HeaderText = "N°";
            this.cID_details.Name = "cID_details";
            this.cID_details.ReadOnly = true;
            // 
            // cTitre_ID_livre
            // 
            this.cTitre_ID_livre.DataPropertyName = "Titre_ID_livre";
            this.cTitre_ID_livre.HeaderText = "Titre";
            this.cTitre_ID_livre.Name = "cTitre_ID_livre";
            this.cTitre_ID_livre.ReadOnly = true;
            // 
            // cDat_limite
            // 
            this.cDat_limite.DataPropertyName = "dat_limite";
            this.cDat_limite.HeaderText = "Date limite de location";
            this.cDat_limite.Name = "cDat_limite";
            this.cDat_limite.ReadOnly = true;
            // 
            // cDat_emprunt
            // 
            this.cDat_emprunt.DataPropertyName = "dat_emprunt";
            this.cDat_emprunt.HeaderText = "Date d\'emprunt";
            this.cDat_emprunt.Name = "cDat_emprunt";
            this.cDat_emprunt.ReadOnly = true;
            // 
            // cDat_rentre
            // 
            this.cDat_rentre.DataPropertyName = "dat_rentre";
            this.cDat_rentre.HeaderText = "Date de rendu";
            this.cDat_rentre.Name = "cDat_rentre";
            this.cDat_rentre.ReadOnly = true;
            // 
            // cAmende
            // 
            this.cAmende.DataPropertyName = "amende";
            this.cAmende.HeaderText = "Amende";
            this.cAmende.Name = "cAmende";
            this.cAmende.ReadOnly = true;
            // 
            // EcranAfficDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 198);
            this.Controls.Add(this.DGV_detail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EcranAfficDetail";
            this.Text = "Affichage de la location";
            this.Load += new System.EventHandler(this.FicAfficDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_detail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID_details;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTitre_ID_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDat_limite;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDat_emprunt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDat_rentre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAmende;
    }
}