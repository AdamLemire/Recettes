namespace ideesouper
{
    partial class RecetteControl
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
            this.nomRecetteLabel = new System.Windows.Forms.Label();
            this.EtapeRecetteTextBox = new System.Windows.Forms.TextBox();
            this.difficulteLabel = new System.Windows.Forms.Label();
            this.tempsCuissonLabel = new System.Windows.Forms.Label();
            this.tempsPreparationLabel = new System.Windows.Forms.Label();
            this.typeRepasLabel = new System.Windows.Forms.Label();
            this.nombrePersonneLabel = new System.Windows.Forms.Label();
            this.nomPersonneValeurLabel = new System.Windows.Forms.Label();
            this.tempsPreparationValeurLabel = new System.Windows.Forms.Label();
            this.tempsCuissonValeurLabel = new System.Windows.Forms.Label();
            this.typeRepasValeurLabel = new System.Windows.Forms.Label();
            this.difficulteValeurLabel = new System.Windows.Forms.Label();
            this.ingredientsListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // nomRecetteLabel
            // 
            this.nomRecetteLabel.AutoSize = true;
            this.nomRecetteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.nomRecetteLabel.Location = new System.Drawing.Point(10, 10);
            this.nomRecetteLabel.Name = "nomRecetteLabel";
            this.nomRecetteLabel.Size = new System.Drawing.Size(107, 22);
            this.nomRecetteLabel.TabIndex = 120;
            this.nomRecetteLabel.Text = "Nom recette";
            // 
            // EtapeRecetteTextBox
            // 
            this.EtapeRecetteTextBox.Location = new System.Drawing.Point(14, 266);
            this.EtapeRecetteTextBox.MaximumSize = new System.Drawing.Size(407, 300);
            this.EtapeRecetteTextBox.MinimumSize = new System.Drawing.Size(407, 300);
            this.EtapeRecetteTextBox.Multiline = true;
            this.EtapeRecetteTextBox.Name = "EtapeRecetteTextBox";
            this.EtapeRecetteTextBox.Size = new System.Drawing.Size(407, 300);
            this.EtapeRecetteTextBox.TabIndex = 119;
            this.EtapeRecetteTextBox.Text = "Étapes";
            // 
            // difficulteLabel
            // 
            this.difficulteLabel.AutoSize = true;
            this.difficulteLabel.Location = new System.Drawing.Point(324, 63);
            this.difficulteLabel.Name = "difficulteLabel";
            this.difficulteLabel.Size = new System.Drawing.Size(54, 13);
            this.difficulteLabel.TabIndex = 125;
            this.difficulteLabel.Text = "Difficulté :";
            // 
            // tempsCuissonLabel
            // 
            this.tempsCuissonLabel.AutoSize = true;
            this.tempsCuissonLabel.Location = new System.Drawing.Point(168, 63);
            this.tempsCuissonLabel.Name = "tempsCuissonLabel";
            this.tempsCuissonLabel.Size = new System.Drawing.Size(109, 13);
            this.tempsCuissonLabel.TabIndex = 124;
            this.tempsCuissonLabel.Text = "Temps cuisson (min) :";
            // 
            // tempsPreparationLabel
            // 
            this.tempsPreparationLabel.AutoSize = true;
            this.tempsPreparationLabel.Location = new System.Drawing.Point(11, 63);
            this.tempsPreparationLabel.Name = "tempsPreparationLabel";
            this.tempsPreparationLabel.Size = new System.Drawing.Size(126, 13);
            this.tempsPreparationLabel.TabIndex = 123;
            this.tempsPreparationLabel.Text = "Temps préparation (min) :";
            // 
            // typeRepasLabel
            // 
            this.typeRepasLabel.AutoSize = true;
            this.typeRepasLabel.Location = new System.Drawing.Point(168, 41);
            this.typeRepasLabel.Name = "typeRepasLabel";
            this.typeRepasLabel.Size = new System.Drawing.Size(81, 13);
            this.typeRepasLabel.TabIndex = 122;
            this.typeRepasLabel.Text = "Type de repas :";
            // 
            // nombrePersonneLabel
            // 
            this.nombrePersonneLabel.AutoSize = true;
            this.nombrePersonneLabel.Location = new System.Drawing.Point(11, 41);
            this.nombrePersonneLabel.Name = "nombrePersonneLabel";
            this.nombrePersonneLabel.Size = new System.Drawing.Size(112, 13);
            this.nombrePersonneLabel.TabIndex = 121;
            this.nombrePersonneLabel.Text = "Nombre de personne :";
            // 
            // nomPersonneValeurLabel
            // 
            this.nomPersonneValeurLabel.AutoSize = true;
            this.nomPersonneValeurLabel.Location = new System.Drawing.Point(137, 41);
            this.nomPersonneValeurLabel.Name = "nomPersonneValeurLabel";
            this.nomPersonneValeurLabel.Size = new System.Drawing.Size(13, 13);
            this.nomPersonneValeurLabel.TabIndex = 126;
            this.nomPersonneValeurLabel.Text = "0";
            // 
            // tempsPreparationValeurLabel
            // 
            this.tempsPreparationValeurLabel.AutoSize = true;
            this.tempsPreparationValeurLabel.Location = new System.Drawing.Point(137, 63);
            this.tempsPreparationValeurLabel.Name = "tempsPreparationValeurLabel";
            this.tempsPreparationValeurLabel.Size = new System.Drawing.Size(13, 13);
            this.tempsPreparationValeurLabel.TabIndex = 127;
            this.tempsPreparationValeurLabel.Text = "0";
            // 
            // tempsCuissonValeurLabel
            // 
            this.tempsCuissonValeurLabel.AutoSize = true;
            this.tempsCuissonValeurLabel.Location = new System.Drawing.Point(277, 63);
            this.tempsCuissonValeurLabel.Name = "tempsCuissonValeurLabel";
            this.tempsCuissonValeurLabel.Size = new System.Drawing.Size(13, 13);
            this.tempsCuissonValeurLabel.TabIndex = 128;
            this.tempsCuissonValeurLabel.Text = "0";
            // 
            // typeRepasValeurLabel
            // 
            this.typeRepasValeurLabel.AutoSize = true;
            this.typeRepasValeurLabel.Location = new System.Drawing.Point(255, 41);
            this.typeRepasValeurLabel.Name = "typeRepasValeurLabel";
            this.typeRepasValeurLabel.Size = new System.Drawing.Size(32, 13);
            this.typeRepasValeurLabel.TabIndex = 129;
            this.typeRepasValeurLabel.Text = "types";
            // 
            // difficulteValeurLabel
            // 
            this.difficulteValeurLabel.AutoSize = true;
            this.difficulteValeurLabel.Location = new System.Drawing.Point(375, 63);
            this.difficulteValeurLabel.Name = "difficulteValeurLabel";
            this.difficulteValeurLabel.Size = new System.Drawing.Size(46, 13);
            this.difficulteValeurLabel.TabIndex = 130;
            this.difficulteValeurLabel.Text = "difficulté";
            // 
            // ingredientsListView
            // 
            this.ingredientsListView.Location = new System.Drawing.Point(14, 100);
            this.ingredientsListView.Name = "ingredientsListView";
            this.ingredientsListView.Size = new System.Drawing.Size(407, 160);
            this.ingredientsListView.TabIndex = 131;
            this.ingredientsListView.UseCompatibleStateImageBehavior = false;
            // 
            // RecetteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ingredientsListView);
            this.Controls.Add(this.difficulteValeurLabel);
            this.Controls.Add(this.typeRepasValeurLabel);
            this.Controls.Add(this.tempsCuissonValeurLabel);
            this.Controls.Add(this.tempsPreparationValeurLabel);
            this.Controls.Add(this.nomPersonneValeurLabel);
            this.Controls.Add(this.difficulteLabel);
            this.Controls.Add(this.tempsCuissonLabel);
            this.Controls.Add(this.tempsPreparationLabel);
            this.Controls.Add(this.typeRepasLabel);
            this.Controls.Add(this.nombrePersonneLabel);
            this.Controls.Add(this.nomRecetteLabel);
            this.Controls.Add(this.EtapeRecetteTextBox);
            this.Name = "RecetteControl";
            this.Size = new System.Drawing.Size(442, 569);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomRecetteLabel;
        private System.Windows.Forms.TextBox EtapeRecetteTextBox;
        private System.Windows.Forms.Label difficulteLabel;
        private System.Windows.Forms.Label tempsCuissonLabel;
        private System.Windows.Forms.Label tempsPreparationLabel;
        private System.Windows.Forms.Label typeRepasLabel;
        private System.Windows.Forms.Label nombrePersonneLabel;
        private System.Windows.Forms.Label nomPersonneValeurLabel;
        private System.Windows.Forms.Label tempsPreparationValeurLabel;
        private System.Windows.Forms.Label tempsCuissonValeurLabel;
        private System.Windows.Forms.Label typeRepasValeurLabel;
        private System.Windows.Forms.Label difficulteValeurLabel;
        private System.Windows.Forms.ListView ingredientsListView;
    }
}
