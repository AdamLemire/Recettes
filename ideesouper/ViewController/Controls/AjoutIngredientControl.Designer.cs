namespace ideesouper.ViewController.Controls
{
    partial class AjoutIngredientControl
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
            this.ngredientLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.ingredientComboBox = new System.Windows.Forms.ComboBox();
            this.nombrePersonneNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.quantiteLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nombrePersonneNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ngredientLabel
            // 
            this.ngredientLabel.AutoSize = true;
            this.ngredientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngredientLabel.Location = new System.Drawing.Point(43, 13);
            this.ngredientLabel.Name = "ngredientLabel";
            this.ngredientLabel.Size = new System.Drawing.Size(107, 25);
            this.ngredientLabel.TabIndex = 0;
            this.ngredientLabel.Text = "Ingredient";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(15, 55);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(168, 21);
            this.typeComboBox.TabIndex = 1;
            this.typeComboBox.Text = "Catégorie";
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // ingredientComboBox
            // 
            this.ingredientComboBox.FormattingEnabled = true;
            this.ingredientComboBox.Location = new System.Drawing.Point(15, 82);
            this.ingredientComboBox.Name = "ingredientComboBox";
            this.ingredientComboBox.Size = new System.Drawing.Size(168, 21);
            this.ingredientComboBox.TabIndex = 2;
            this.ingredientComboBox.Text = "Ingrédient";
            // 
            // nombrePersonneNumericUpDown1
            // 
            this.nombrePersonneNumericUpDown1.Location = new System.Drawing.Point(96, 116);
            this.nombrePersonneNumericUpDown1.Name = "nombrePersonneNumericUpDown1";
            this.nombrePersonneNumericUpDown1.Size = new System.Drawing.Size(87, 20);
            this.nombrePersonneNumericUpDown1.TabIndex = 156;
            this.nombrePersonneNumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // quantiteLabel
            // 
            this.quantiteLabel.AutoSize = true;
            this.quantiteLabel.Location = new System.Drawing.Point(12, 118);
            this.quantiteLabel.Name = "quantiteLabel";
            this.quantiteLabel.Size = new System.Drawing.Size(53, 13);
            this.quantiteLabel.TabIndex = 155;
            this.quantiteLabel.Text = "Quantité :";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(108, 153);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 157;
            this.addButton.Text = "Ajouter";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(15, 153);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 158;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelClick);
            // 
            // AjoutIngredientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nombrePersonneNumericUpDown1);
            this.Controls.Add(this.quantiteLabel);
            this.Controls.Add(this.ingredientComboBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.ngredientLabel);
            this.Name = "AjoutIngredientControl";
            this.Size = new System.Drawing.Size(205, 461);
            ((System.ComponentModel.ISupportInitialize)(this.nombrePersonneNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ngredientLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox ingredientComboBox;
        private System.Windows.Forms.NumericUpDown nombrePersonneNumericUpDown1;
        private System.Windows.Forms.Label quantiteLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
