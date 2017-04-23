namespace ideesouper.ViewController.Controls
{
    partial class NouvelIngredient
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.titreNouvelIngrendientLabel = new System.Windows.Forms.Label();
            this.categorieComboBox = new System.Windows.Forms.ComboBox();
            this.ingredientTexteBox = new System.Windows.Forms.TextBox();
            this.AnnulerBouton = new System.Windows.Forms.Button();
            this.ajouterBouton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titreNouvelIngrendientLabel
            // 
            this.titreNouvelIngrendientLabel.AutoSize = true;
            this.titreNouvelIngrendientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.titreNouvelIngrendientLabel.Location = new System.Drawing.Point(249, 72);
            this.titreNouvelIngrendientLabel.Name = "titreNouvelIngrendientLabel";
            this.titreNouvelIngrendientLabel.Size = new System.Drawing.Size(312, 22);
            this.titreNouvelIngrendientLabel.TabIndex = 0;
            this.titreNouvelIngrendientLabel.Text = "AJOUT D\'UN NOUVEL INGRÉDIENT";
            // 
            // categorieComboBox
            // 
            this.categorieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorieComboBox.FormattingEnabled = true;
            this.categorieComboBox.Location = new System.Drawing.Point(335, 161);
            this.categorieComboBox.Name = "categorieComboBox";
            this.categorieComboBox.Size = new System.Drawing.Size(121, 21);
            this.categorieComboBox.TabIndex = 1;
            this.categorieComboBox.SelectedIndexChanged += new System.EventHandler(this.categorieComboBox_SelectedIndexChanged);
            // 
            // ingredientTexteBox
            // 
            this.ingredientTexteBox.Location = new System.Drawing.Point(335, 203);
            this.ingredientTexteBox.Name = "ingredientTexteBox";
            this.ingredientTexteBox.Size = new System.Drawing.Size(121, 20);
            this.ingredientTexteBox.TabIndex = 2;
            this.ingredientTexteBox.Text = "Ingédient";
            this.ingredientTexteBox.TextChanged += new System.EventHandler(this.ingrédientTexteBox_TextChanged);
            // 
            // AnnulerBouton
            // 
            this.AnnulerBouton.Location = new System.Drawing.Point(275, 287);
            this.AnnulerBouton.Name = "AnnulerBouton";
            this.AnnulerBouton.Size = new System.Drawing.Size(75, 23);
            this.AnnulerBouton.TabIndex = 3;
            this.AnnulerBouton.Text = "Annuler";
            this.AnnulerBouton.UseVisualStyleBackColor = true;
            this.AnnulerBouton.Click += new System.EventHandler(this.AnnulerBouton_Click);
            // 
            // ajouterBouton
            // 
            this.ajouterBouton.Location = new System.Drawing.Point(443, 287);
            this.ajouterBouton.Name = "ajouterBouton";
            this.ajouterBouton.Size = new System.Drawing.Size(75, 23);
            this.ajouterBouton.TabIndex = 4;
            this.ajouterBouton.Text = "Ajouter";
            this.ajouterBouton.UseVisualStyleBackColor = true;
            this.ajouterBouton.Click += new System.EventHandler(this.ajouterBouton_Click);
            // 
            // NouvelIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ajouterBouton);
            this.Controls.Add(this.AnnulerBouton);
            this.Controls.Add(this.ingredientTexteBox);
            this.Controls.Add(this.categorieComboBox);
            this.Controls.Add(this.titreNouvelIngrendientLabel);
            this.Name = "NouvelIngredient";
            this.Size = new System.Drawing.Size(840, 542);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titreNouvelIngrendientLabel;
        private System.Windows.Forms.ComboBox categorieComboBox;
        private System.Windows.Forms.TextBox ingredientTexteBox;
        private System.Windows.Forms.Button AnnulerBouton;
        private System.Windows.Forms.Button ajouterBouton;
    }
}
