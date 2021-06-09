
namespace GD_BD_BIBLIO
{
    partial class EcranAjoutDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranAjoutDetail));
            this.CB_livre_detail = new System.Windows.Forms.ComboBox();
            this.ChB_limite = new System.Windows.Forms.CheckBox();
            this.B_conf_aj_detail = new System.Windows.Forms.Button();
            this.B_ann_aj_detail = new System.Windows.Forms.Button();
            this.DTP_limite = new System.Windows.Forms.DateTimePicker();
            this.DGV_detail = new System.Windows.Forms.DataGridView();
            this.cID_details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTitre_ID_livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDat_limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_livre_detail
            // 
            this.CB_livre_detail.FormattingEnabled = true;
            this.CB_livre_detail.Location = new System.Drawing.Point(13, 168);
            this.CB_livre_detail.Name = "CB_livre_detail";
            this.CB_livre_detail.Size = new System.Drawing.Size(200, 21);
            this.CB_livre_detail.TabIndex = 1;
            // 
            // ChB_limite
            // 
            this.ChB_limite.AutoSize = true;
            this.ChB_limite.Location = new System.Drawing.Point(265, 170);
            this.ChB_limite.Name = "ChB_limite";
            this.ChB_limite.Size = new System.Drawing.Size(84, 17);
            this.ChB_limite.TabIndex = 2;
            this.ChB_limite.Text = "Date limite ?";
            this.ChB_limite.UseVisualStyleBackColor = true;
            this.ChB_limite.CheckedChanged += new System.EventHandler(this.ChB_limite_CheckedChanged);
            // 
            // B_conf_aj_detail
            // 
            this.B_conf_aj_detail.Location = new System.Drawing.Point(13, 195);
            this.B_conf_aj_detail.Name = "B_conf_aj_detail";
            this.B_conf_aj_detail.Size = new System.Drawing.Size(106, 23);
            this.B_conf_aj_detail.TabIndex = 4;
            this.B_conf_aj_detail.Text = "Confirmer";
            this.B_conf_aj_detail.UseVisualStyleBackColor = true;
            this.B_conf_aj_detail.Click += new System.EventHandler(this.B_conf_aj_detail_Click);
            // 
            // B_ann_aj_detail
            // 
            this.B_ann_aj_detail.Location = new System.Drawing.Point(426, 194);
            this.B_ann_aj_detail.Name = "B_ann_aj_detail";
            this.B_ann_aj_detail.Size = new System.Drawing.Size(106, 23);
            this.B_ann_aj_detail.TabIndex = 5;
            this.B_ann_aj_detail.Text = "Annuler";
            this.B_ann_aj_detail.UseVisualStyleBackColor = true;
            this.B_ann_aj_detail.Click += new System.EventHandler(this.B_ann_aj_detail_Click);
            // 
            // DTP_limite
            // 
            this.DTP_limite.Enabled = false;
            this.DTP_limite.Location = new System.Drawing.Point(355, 168);
            this.DTP_limite.Name = "DTP_limite";
            this.DTP_limite.Size = new System.Drawing.Size(177, 20);
            this.DTP_limite.TabIndex = 6;
            // 
            // DGV_detail
            // 
            this.DGV_detail.AllowUserToAddRows = false;
            this.DGV_detail.AllowUserToDeleteRows = false;
            this.DGV_detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_detail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DGV_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID_details,
            this.cTitre_ID_livre,
            this.cDat_limite});
            this.DGV_detail.Location = new System.Drawing.Point(13, 12);
            this.DGV_detail.MultiSelect = false;
            this.DGV_detail.Name = "DGV_detail";
            this.DGV_detail.ReadOnly = true;
            this.DGV_detail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGV_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_detail.Size = new System.Drawing.Size(519, 150);
            this.DGV_detail.TabIndex = 7;
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
            // EcranAjoutDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(544, 228);
            this.Controls.Add(this.DGV_detail);
            this.Controls.Add(this.DTP_limite);
            this.Controls.Add(this.B_ann_aj_detail);
            this.Controls.Add(this.B_conf_aj_detail);
            this.Controls.Add(this.ChB_limite);
            this.Controls.Add(this.CB_livre_detail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranAjoutDetail";
            this.Text = "Ajout détail";
            this.Load += new System.EventHandler(this.EcranAjoutDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CB_livre_detail;
        private System.Windows.Forms.CheckBox ChB_limite;
        private System.Windows.Forms.Button B_conf_aj_detail;
        private System.Windows.Forms.Button B_ann_aj_detail;
        private System.Windows.Forms.DateTimePicker DTP_limite;
        private System.Windows.Forms.DataGridView DGV_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID_details;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTitre_ID_livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDat_limite;
    }
}