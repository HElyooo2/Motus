namespace motus
{
    partial class frmMotus
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
            this.cbxnbLettres = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.tbxProposition = new System.Windows.Forms.TextBox();
            this.dgvMotus = new System.Windows.Forms.DataGridView();
            this.btnNouvellePartie = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblLose = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxnbLettres
            // 
            this.cbxnbLettres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxnbLettres.FormattingEnabled = true;
            this.cbxnbLettres.Location = new System.Drawing.Point(225, 25);
            this.cbxnbLettres.Name = "cbxnbLettres";
            this.cbxnbLettres.Size = new System.Drawing.Size(121, 21);
            this.cbxnbLettres.TabIndex = 0;
            this.cbxnbLettres.SelectedIndexChanged += new System.EventHandler(this.cbxnbLettres_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choisie le nombre de lettres du mot:";
            // 
            // btnValider
            // 
            this.btnValider.Enabled = false;
            this.btnValider.Location = new System.Drawing.Point(356, 69);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(120, 60);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // tbxProposition
            // 
            this.tbxProposition.Enabled = false;
            this.tbxProposition.Location = new System.Drawing.Point(124, 90);
            this.tbxProposition.Name = "tbxProposition";
            this.tbxProposition.Size = new System.Drawing.Size(149, 20);
            this.tbxProposition.TabIndex = 4;
            this.tbxProposition.TextChanged += new System.EventHandler(this.tbxProposition_TextChanged);
            this.tbxProposition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxProposition_KeyDown);
            // 
            // dgvMotus
            // 
            this.dgvMotus.AllowUserToAddRows = false;
            this.dgvMotus.AllowUserToDeleteRows = false;
            this.dgvMotus.AllowUserToResizeColumns = false;
            this.dgvMotus.AllowUserToResizeRows = false;
            this.dgvMotus.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvMotus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotus.Enabled = false;
            this.dgvMotus.Location = new System.Drawing.Point(59, 149);
            this.dgvMotus.MultiSelect = false;
            this.dgvMotus.Name = "dgvMotus";
            this.dgvMotus.ReadOnly = true;
            this.dgvMotus.Size = new System.Drawing.Size(236, 315);
            this.dgvMotus.TabIndex = 5;
            this.dgvMotus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMotus_CellContentClick);
            // 
            // btnNouvellePartie
            // 
            this.btnNouvellePartie.Location = new System.Drawing.Point(46, 528);
            this.btnNouvellePartie.Name = "btnNouvellePartie";
            this.btnNouvellePartie.Size = new System.Drawing.Size(120, 60);
            this.btnNouvellePartie.TabIndex = 6;
            this.btnNouvellePartie.Text = "Nouvelle Partie";
            this.btnNouvellePartie.UseVisualStyleBackColor = true;
            this.btnNouvellePartie.Click += new System.EventHandler(this.btnNouvellePartie_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Enabled = false;
            this.btnAnnuler.Location = new System.Drawing.Point(204, 528);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(120, 60);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.Location = new System.Drawing.Point(356, 528);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(120, 60);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.Location = new System.Drawing.Point(272, 490);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(0, 13);
            this.lblLose.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(411, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(239, 315);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Visible = false;
            // 
            // frmMotus
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuitter;
            this.ClientSize = new System.Drawing.Size(662, 613);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnNouvellePartie);
            this.Controls.Add(this.dgvMotus);
            this.Controls.Add(this.tbxProposition);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxnbLettres);
            this.Name = "frmMotus";
            this.Text = "Motus";
            this.Load += new System.EventHandler(this.frmMotus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxnbLettres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox tbxProposition;
        private System.Windows.Forms.DataGridView dgvMotus;
        private System.Windows.Forms.Button btnNouvellePartie;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

