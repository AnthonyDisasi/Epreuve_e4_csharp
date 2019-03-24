namespace rallyeLecture
{
    partial class Form1
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
            this.lb_csvIntegrer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LancerIntegration = new System.Windows.Forms.Button();
            this.niveauLabel = new System.Windows.Forms.ComboBox();
            this.anneeScolaire = new System.Windows.Forms.TextBox();
            this.parcourirLabel = new System.Windows.Forms.TextBox();
            this.parcourirButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Aleatoire = new System.Windows.Forms.RadioButton();
            this.construit = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lb_csvIntegrer
            // 
            this.lb_csvIntegrer.AutoSize = true;
            this.lb_csvIntegrer.Location = new System.Drawing.Point(200, 96);
            this.lb_csvIntegrer.Name = "lb_csvIntegrer";
            this.lb_csvIntegrer.Size = new System.Drawing.Size(144, 17);
            this.lb_csvIntegrer.TabIndex = 2;
            this.lb_csvIntegrer.Text = "fichier csv a integrer :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "année scolaire :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "mot de passe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "niveau :";
            // 
            // LancerIntegration
            // 
            this.LancerIntegration.Location = new System.Drawing.Point(379, 305);
            this.LancerIntegration.Name = "LancerIntegration";
            this.LancerIntegration.Size = new System.Drawing.Size(201, 31);
            this.LancerIntegration.TabIndex = 6;
            this.LancerIntegration.Text = "Lancer l\'integration";
            this.LancerIntegration.UseVisualStyleBackColor = true;
            this.LancerIntegration.Click += new System.EventHandler(this.LancerIntegration_Click);
            // 
            // niveauLabel
            // 
            this.niveauLabel.FormattingEnabled = true;
            this.niveauLabel.Location = new System.Drawing.Point(379, 212);
            this.niveauLabel.Name = "niveauLabel";
            this.niveauLabel.Size = new System.Drawing.Size(121, 24);
            this.niveauLabel.TabIndex = 11;
            this.niveauLabel.Text = "choisir le niveau";
            // 
            // anneeScolaire
            // 
            this.anneeScolaire.Location = new System.Drawing.Point(379, 168);
            this.anneeScolaire.Name = "anneeScolaire";
            this.anneeScolaire.Size = new System.Drawing.Size(121, 22);
            this.anneeScolaire.TabIndex = 12;
            // 
            // parcourirLabel
            // 
            this.parcourirLabel.Location = new System.Drawing.Point(379, 97);
            this.parcourirLabel.Name = "parcourirLabel";
            this.parcourirLabel.Size = new System.Drawing.Size(121, 22);
            this.parcourirLabel.TabIndex = 17;
            this.parcourirLabel.TextChanged += new System.EventHandler(this.parcourirButton_TextChanged);
            // 
            // parcourirButton
            // 
            this.parcourirButton.Location = new System.Drawing.Point(528, 96);
            this.parcourirButton.Name = "parcourirButton";
            this.parcourirButton.Size = new System.Drawing.Size(75, 23);
            this.parcourirButton.TabIndex = 18;
            this.parcourirButton.Text = "parcourir";
            this.parcourirButton.UseVisualStyleBackColor = true;
            this.parcourirButton.Click += new System.EventHandler(this.parcourirButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Aleatoire
            // 
            this.Aleatoire.AutoSize = true;
            this.Aleatoire.Checked = true;
            this.Aleatoire.Location = new System.Drawing.Point(369, 249);
            this.Aleatoire.Name = "Aleatoire";
            this.Aleatoire.Size = new System.Drawing.Size(85, 21);
            this.Aleatoire.TabIndex = 19;
            this.Aleatoire.TabStop = true;
            this.Aleatoire.Text = "Aleatoire";
            this.Aleatoire.UseVisualStyleBackColor = true;
            // 
            // construit
            // 
            this.construit.AutoSize = true;
            this.construit.Location = new System.Drawing.Point(502, 249);
            this.construit.Name = "construit";
            this.construit.Size = new System.Drawing.Size(85, 21);
            this.construit.TabIndex = 20;
            this.construit.Text = "Construit";
            this.construit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.construit);
            this.Controls.Add(this.Aleatoire);
            this.Controls.Add(this.parcourirButton);
            this.Controls.Add(this.parcourirLabel);
            this.Controls.Add(this.anneeScolaire);
            this.Controls.Add(this.niveauLabel);
            this.Controls.Add(this.LancerIntegration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_csvIntegrer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_csvIntegrer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button LancerIntegration;
        private System.Windows.Forms.ComboBox niveauLabel;
        private System.Windows.Forms.TextBox anneeScolaire;
        private System.Windows.Forms.TextBox parcourirLabel;
        private System.Windows.Forms.Button parcourirButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton Aleatoire;
        private System.Windows.Forms.RadioButton construit;
    }
}

