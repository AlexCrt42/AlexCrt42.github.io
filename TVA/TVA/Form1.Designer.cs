namespace TVA
{
    partial class frmTVA
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_HT = new System.Windows.Forms.Label();
            this.tbx_HT = new System.Windows.Forms.TextBox();
            this.lbl_TVA = new System.Windows.Forms.Label();
            this.tbx_TVA = new System.Windows.Forms.TextBox();
            this.lbl_TTC = new System.Windows.Forms.Label();
            this.tbx_TTC = new System.Windows.Forms.TextBox();
            this.btn_calcul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // lbl_HT
            // 
            this.lbl_HT.AutoSize = true;
            this.lbl_HT.Location = new System.Drawing.Point(22, 164);
            this.lbl_HT.Name = "lbl_HT";
            this.lbl_HT.Size = new System.Drawing.Size(76, 16);
            this.lbl_HT.TabIndex = 1;
            this.lbl_HT.Text = "Montant HT";
            this.lbl_HT.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbx_HT
            // 
            this.tbx_HT.Location = new System.Drawing.Point(152, 157);
            this.tbx_HT.Name = "tbx_HT";
            this.tbx_HT.Size = new System.Drawing.Size(533, 22);
            this.tbx_HT.TabIndex = 2;
            // 
            // lbl_TVA
            // 
            this.lbl_TVA.AutoSize = true;
            this.lbl_TVA.Location = new System.Drawing.Point(22, 211);
            this.lbl_TVA.Name = "lbl_TVA";
            this.lbl_TVA.Size = new System.Drawing.Size(114, 16);
            this.lbl_TVA.TabIndex = 3;
            this.lbl_TVA.Text = "Pourcentage TVA";
            this.lbl_TVA.Click += new System.EventHandler(this.lbl_TVA_Click);
            // 
            // tbx_TVA
            // 
            this.tbx_TVA.Location = new System.Drawing.Point(152, 205);
            this.tbx_TVA.Name = "tbx_TVA";
            this.tbx_TVA.Size = new System.Drawing.Size(533, 22);
            this.tbx_TVA.TabIndex = 4;
            // 
            // lbl_TTC
            // 
            this.lbl_TTC.AutoSize = true;
            this.lbl_TTC.Location = new System.Drawing.Point(22, 303);
            this.lbl_TTC.Name = "lbl_TTC";
            this.lbl_TTC.Size = new System.Drawing.Size(59, 16);
            this.lbl_TTC.TabIndex = 5;
            this.lbl_TTC.Text = "Prix TTC";
            // 
            // tbx_TTC
            // 
            this.tbx_TTC.Location = new System.Drawing.Point(152, 297);
            this.tbx_TTC.Name = "tbx_TTC";
            this.tbx_TTC.Size = new System.Drawing.Size(533, 22);
            this.tbx_TTC.TabIndex = 6;
            // 
            // btn_calcul
            // 
            this.btn_calcul.Location = new System.Drawing.Point(294, 368);
            this.btn_calcul.Name = "btn_calcul";
            this.btn_calcul.Size = new System.Drawing.Size(196, 59);
            this.btn_calcul.TabIndex = 7;
            this.btn_calcul.Text = "Calculer";
            this.btn_calcul.UseVisualStyleBackColor = true;
            this.btn_calcul.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 439);
            this.Controls.Add(this.btn_calcul);
            this.Controls.Add(this.tbx_TTC);
            this.Controls.Add(this.lbl_TTC);
            this.Controls.Add(this.tbx_TVA);
            this.Controls.Add(this.lbl_TVA);
            this.Controls.Add(this.tbx_HT);
            this.Controls.Add(this.lbl_HT);
            this.Controls.Add(this.label1);
            this.Name = "frmTVA";
            this.Text = "frmTVA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_HT;
        private System.Windows.Forms.TextBox tbx_HT;
        private System.Windows.Forms.Label lbl_TVA;
        private System.Windows.Forms.TextBox tbx_TVA;
        private System.Windows.Forms.Label lbl_TTC;
        private System.Windows.Forms.TextBox tbx_TTC;
        private System.Windows.Forms.Button btn_calcul;
    }
}

