
namespace GD_BD_BIBLIO
{
    partial class EcranModifDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranModifDetail));
            this.DGV_detail = new System.Windows.Forms.DataGridView();
            this.cID_details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTitre_ID_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDat_limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDat_emprunt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDat_rentre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTP_limite = new System.Windows.Forms.DateTimePicker();
            this.ChB_limite = new System.Windows.Forms.CheckBox();
            this.B_changer_limite = new System.Windows.Forms.Button();
            this.B_rendu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_detail
            // 
            this.DGV_detail.AllowUserToAddRows = false;
            this.DGV_detail.AllowUserToDeleteRows = false;
            this.DGV_detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_detail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID_details,
            this.cTitre_ID_livre,
            this.cDat_limite,
            this.cDat_emprunt,
            this.cDat_rentre});
            this.DGV_detail.Location = new System.Drawing.Point(12, 12);
            this.DGV_detail.MultiSelect = false;
            this.DGV_detail.Name = "DGV_detail";
            this.DGV_detail.ReadOnly = true;
            this.DGV_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_detail.Size = new System.Drawing.Size(321, 150);
            this.DGV_detail.TabIndex = 8;
            this.DGV_detail.SelectionChanged += new System.EventHandler(this.DGV_detail_SelectionChanged);
            // 
            // cID_details
            // 
            this.cID_details.DataPropertyName = "ID_details";
            this.cID_details.HeaderText = "N°";
            this.cID_details.Name = "cID_details";
            this.cID_details.ReadOnly = true;
            this.cID_details.Width = 44;
            // 
            // cTitre_ID_livre
            // 
            this.cTitre_ID_livre.DataPropertyName = "Titre_ID_livre";
            this.cTitre_ID_livre.HeaderText = "Titre";
            this.cTitre_ID_livre.Name = "cTitre_ID_livre";
            this.cTitre_ID_livre.ReadOnly = true;
            this.cTitre_ID_livre.Width = 53;
            // 
            // cDat_limite
            // 
            this.cDat_limite.DataPropertyName = "dat_limite";
            this.cDat_limite.HeaderText = "Date limite de location";
            this.cDat_limite.Name = "cDat_limite";
            this.cDat_limite.ReadOnly = true;
            this.cDat_limite.Width = 136;
            // 
            // cDat_emprunt
            // 
            this.cDat_emprunt.DataPropertyName = "dat_emprunt";
            this.cDat_emprunt.HeaderText = "Date d\'emprunt";
            this.cDat_emprunt.Name = "cDat_emprunt";
            this.cDat_emprunt.ReadOnly = true;
            this.cDat_emprunt.Width = 104;
            // 
            // cDat_rentre
            // 
            this.cDat_rentre.DataPropertyName = "dat_rentre";
            this.cDat_rentre.HeaderText = "Date de rendu";
            this.cDat_rentre.Name = "cDat_rentre";
            this.cDat_rentre.ReadOnly = true;
            // 
            // DTP_limite
            // 
            this.DTP_limite.Enabled = false;
            this.DTP_limite.Location = new System.Drawing.Point(102, 165);
            this.DTP_limite.Name = "DTP_limite";
            this.DTP_limite.Size = new System.Drawing.Size(231, 20);
            this.DTP_limite.TabIndex = 10;
            // 
            // ChB_limite
            // 
            this.ChB_limite.AutoSize = true;
            this.ChB_limite.Location = new System.Drawing.Point(12, 168);
            this.ChB_limite.Name = "ChB_limite";
            this.ChB_limite.Size = new System.Drawing.Size(84, 17);
            this.ChB_limite.TabIndex = 9;
            this.ChB_limite.Text = "Date limite ?";
            this.ChB_limite.UseVisualStyleBackColor = true;
            this.ChB_limite.CheckedChanged += new System.EventHandler(this.ChB_limite_CheckedChanged);
            // 
            // B_changer_limite
            // 
            this.B_changer_limite.Location = new System.Drawing.Point(12, 191);
            this.B_changer_limite.Name = "B_changer_limite";
            this.B_changer_limite.Size = new System.Drawing.Size(321, 23);
            this.B_changer_limite.TabIndex = 11;
            this.B_changer_limite.Text = "Changer la date limite";
            this.B_changer_limite.UseVisualStyleBackColor = true;
            this.B_changer_limite.Click += new System.EventHandler(this.B_changer_limite_Click);
            // 
            // B_rendu
            // 
            this.B_rendu.Location = new System.Drawing.Point(12, 220);
            this.B_rendu.Name = "B_rendu";
            this.B_rendu.Size = new System.Drawing.Size(321, 23);
            this.B_rendu.TabIndex = 12;
            this.B_rendu.Text = "Rendre le livre";
            this.B_rendu.UseVisualStyleBackColor = true;
            this.B_rendu.Click += new System.EventHandler(this.B_rendu_Click);
            // 
            // EcranModifDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(348, 255);
            this.Controls.Add(this.B_rendu);
            this.Controls.Add(this.B_changer_limite);
            this.Controls.Add(this.DTP_limite);
            this.Controls.Add(this.ChB_limite);
            this.Controls.Add(this.DGV_detail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranModifDetail";
            this.Text = "Modification des détails";
            this.Load += new System.EventHandler(this.EcranModifDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID_details;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTitre_ID_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDat_limite;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDat_emprunt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDat_rentre;
        private System.Windows.Forms.DateTimePicker DTP_limite;
        private System.Windows.Forms.CheckBox ChB_limite;
        private System.Windows.Forms.Button B_changer_limite;
        private System.Windows.Forms.Button B_rendu;
    }
}