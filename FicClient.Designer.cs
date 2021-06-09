
namespace GD_BD_BIBLIO
{
    partial class EcranClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranClient));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.B_ann_client = new System.Windows.Forms.Button();
            this.B_conf_client = new System.Windows.Forms.Button();
            this.TB_nom_client = new System.Windows.Forms.TextBox();
            this.TB_ID_client = new System.Windows.Forms.TextBox();
            this.B_supp_client = new System.Windows.Forms.Button();
            this.B_edit_client = new System.Windows.Forms.Button();
            this.B_ajout_client = new System.Windows.Forms.Button();
            this.DGV_client = new System.Windows.Forms.DataGridView();
            this.cID_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAfficher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCrea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCoti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_prenom_client = new System.Windows.Forms.TextBox();
            this.DTP_nai = new System.Windows.Forms.DateTimePicker();
            this.DTP_crea = new System.Windows.Forms.DateTimePicker();
            this.DTP_cot = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.B_cot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_client)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nom:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID:";
            // 
            // B_ann_client
            // 
            this.B_ann_client.Location = new System.Drawing.Point(94, 373);
            this.B_ann_client.Name = "B_ann_client";
            this.B_ann_client.Size = new System.Drawing.Size(75, 23);
            this.B_ann_client.TabIndex = 19;
            this.B_ann_client.Text = "Annuler";
            this.B_ann_client.UseVisualStyleBackColor = true;
            this.B_ann_client.Click += new System.EventHandler(this.B_ann_client_Click);
            // 
            // B_conf_client
            // 
            this.B_conf_client.Location = new System.Drawing.Point(12, 373);
            this.B_conf_client.Name = "B_conf_client";
            this.B_conf_client.Size = new System.Drawing.Size(76, 23);
            this.B_conf_client.TabIndex = 18;
            this.B_conf_client.Text = "Confimer";
            this.B_conf_client.UseVisualStyleBackColor = true;
            this.B_conf_client.Click += new System.EventHandler(this.B_conf_client_Click);
            // 
            // TB_nom_client
            // 
            this.TB_nom_client.Location = new System.Drawing.Point(142, 200);
            this.TB_nom_client.Name = "TB_nom_client";
            this.TB_nom_client.Size = new System.Drawing.Size(103, 20);
            this.TB_nom_client.TabIndex = 16;
            // 
            // TB_ID_client
            // 
            this.TB_ID_client.Location = new System.Drawing.Point(36, 199);
            this.TB_ID_client.Name = "TB_ID_client";
            this.TB_ID_client.ReadOnly = true;
            this.TB_ID_client.Size = new System.Drawing.Size(44, 20);
            this.TB_ID_client.TabIndex = 15;
            // 
            // B_supp_client
            // 
            this.B_supp_client.Location = new System.Drawing.Point(174, 168);
            this.B_supp_client.Name = "B_supp_client";
            this.B_supp_client.Size = new System.Drawing.Size(75, 23);
            this.B_supp_client.TabIndex = 14;
            this.B_supp_client.Text = "Supprimer";
            this.B_supp_client.UseVisualStyleBackColor = true;
            this.B_supp_client.Click += new System.EventHandler(this.B_supp_client_Click);
            // 
            // B_edit_client
            // 
            this.B_edit_client.Location = new System.Drawing.Point(93, 168);
            this.B_edit_client.Name = "B_edit_client";
            this.B_edit_client.Size = new System.Drawing.Size(75, 23);
            this.B_edit_client.TabIndex = 13;
            this.B_edit_client.Text = "Éditer";
            this.B_edit_client.UseVisualStyleBackColor = true;
            this.B_edit_client.Click += new System.EventHandler(this.B_edit_client_Click);
            // 
            // B_ajout_client
            // 
            this.B_ajout_client.Location = new System.Drawing.Point(12, 168);
            this.B_ajout_client.Name = "B_ajout_client";
            this.B_ajout_client.Size = new System.Drawing.Size(75, 23);
            this.B_ajout_client.TabIndex = 12;
            this.B_ajout_client.Text = "Ajout";
            this.B_ajout_client.UseVisualStyleBackColor = true;
            this.B_ajout_client.Click += new System.EventHandler(this.B_ajout_client_Click);
            // 
            // DGV_client
            // 
            this.DGV_client.AllowUserToAddRows = false;
            this.DGV_client.AllowUserToDeleteRows = false;
            this.DGV_client.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGV_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID_client,
            this.cAfficher,
            this.cNai,
            this.cCrea,
            this.cCoti});
            this.DGV_client.Location = new System.Drawing.Point(12, 12);
            this.DGV_client.MultiSelect = false;
            this.DGV_client.Name = "DGV_client";
            this.DGV_client.ReadOnly = true;
            this.DGV_client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_client.Size = new System.Drawing.Size(237, 150);
            this.DGV_client.TabIndex = 11;
            // 
            // cID_client
            // 
            this.cID_client.DataPropertyName = "ID_client";
            this.cID_client.HeaderText = "N°";
            this.cID_client.Name = "cID_client";
            this.cID_client.ReadOnly = true;
            this.cID_client.Width = 44;
            // 
            // cAfficher
            // 
            this.cAfficher.DataPropertyName = "Afficher";
            this.cAfficher.HeaderText = "Nom Prénom";
            this.cAfficher.Name = "cAfficher";
            this.cAfficher.ReadOnly = true;
            this.cAfficher.Width = 86;
            // 
            // cNai
            // 
            this.cNai.DataPropertyName = "client_nai";
            this.cNai.HeaderText = "Date de naissance";
            this.cNai.Name = "cNai";
            this.cNai.ReadOnly = true;
            this.cNai.Width = 111;
            // 
            // cCrea
            // 
            this.cCrea.DataPropertyName = "client_crea";
            this.cCrea.HeaderText = "Création du compte";
            this.cCrea.Name = "cCrea";
            this.cCrea.ReadOnly = true;
            this.cCrea.Width = 82;
            // 
            // cCoti
            // 
            this.cCoti.DataPropertyName = "client_coti";
            this.cCoti.HeaderText = "Dernier payement";
            this.cCoti.Name = "cCoti";
            this.cCoti.ReadOnly = true;
            this.cCoti.Width = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Prénom:";
            // 
            // TB_prenom_client
            // 
            this.TB_prenom_client.Location = new System.Drawing.Point(142, 224);
            this.TB_prenom_client.Name = "TB_prenom_client";
            this.TB_prenom_client.Size = new System.Drawing.Size(103, 20);
            this.TB_prenom_client.TabIndex = 23;
            // 
            // DTP_nai
            // 
            this.DTP_nai.Location = new System.Drawing.Point(12, 269);
            this.DTP_nai.Name = "DTP_nai";
            this.DTP_nai.Size = new System.Drawing.Size(174, 20);
            this.DTP_nai.TabIndex = 24;
            // 
            // DTP_crea
            // 
            this.DTP_crea.Location = new System.Drawing.Point(12, 308);
            this.DTP_crea.Name = "DTP_crea";
            this.DTP_crea.Size = new System.Drawing.Size(174, 20);
            this.DTP_crea.TabIndex = 25;
            // 
            // DTP_cot
            // 
            this.DTP_cot.Location = new System.Drawing.Point(12, 347);
            this.DTP_cot.Name = "DTP_cot";
            this.DTP_cot.Size = new System.Drawing.Size(174, 20);
            this.DTP_cot.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Date de naissance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Date Création du compte :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Date de la dernière cotisation (Mois):";
            // 
            // B_cot
            // 
            this.B_cot.Location = new System.Drawing.Point(174, 373);
            this.B_cot.Name = "B_cot";
            this.B_cot.Size = new System.Drawing.Size(75, 23);
            this.B_cot.TabIndex = 30;
            this.B_cot.Text = "Payement";
            this.B_cot.UseVisualStyleBackColor = true;
            this.B_cot.Click += new System.EventHandler(this.B_cot_Click);
            // 
            // EcranClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(260, 404);
            this.Controls.Add(this.B_cot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTP_cot);
            this.Controls.Add(this.DTP_crea);
            this.Controls.Add(this.DTP_nai);
            this.Controls.Add(this.TB_prenom_client);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_ann_client);
            this.Controls.Add(this.B_conf_client);
            this.Controls.Add(this.TB_nom_client);
            this.Controls.Add(this.TB_ID_client);
            this.Controls.Add(this.B_supp_client);
            this.Controls.Add(this.B_edit_client);
            this.Controls.Add(this.B_ajout_client);
            this.Controls.Add(this.DGV_client);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranClient";
            this.Text = "Gestion des clients";
            this.Load += new System.EventHandler(this.Ecranclient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_ann_client;
        private System.Windows.Forms.Button B_conf_client;
        private System.Windows.Forms.TextBox TB_nom_client;
        private System.Windows.Forms.TextBox TB_ID_client;
        private System.Windows.Forms.Button B_supp_client;
        private System.Windows.Forms.Button B_edit_client;
        private System.Windows.Forms.Button B_ajout_client;
        private System.Windows.Forms.DataGridView DGV_client;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_prenom_client;
        private System.Windows.Forms.DateTimePicker DTP_nai;
        private System.Windows.Forms.DateTimePicker DTP_crea;
        private System.Windows.Forms.DateTimePicker DTP_cot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button B_cot;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAfficher;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCrea;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCoti;
    }
}