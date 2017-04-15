namespace ideesouper
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauRepasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirRepasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recetteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleRecetteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.favorisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelIngrédientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ideePanel = new System.Windows.Forms.Panel();
            this.nouveauRepas1 = new ideesouper.ViewController.Controls.NouveauRepas();
            this.recetteControl1 = new ideesouper.RecetteControl();
            this.suivanteButton = new System.Windows.Forms.Button();
            this.precedenteButton = new System.Windows.Forms.Button();
            this.nouvelleRecettePanel = new System.Windows.Forms.Panel();
            this.nouvelleRecetteControl1 = new ideesouper.NouvelleRecetteControl();
            this.menuStrip.SuspendLayout();
            this.ideePanel.SuspendLayout();
            this.nouvelleRecettePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu,
            this.recetteToolStripMenuItem,
            this.ingredientToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(937, 24);
            this.menuStrip.TabIndex = 41;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauRepasToolStripMenuItem,
            this.ouvrirRepasToolStripMenuItem,
            this.sauvegarderToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenu.Text = "Menu";
            // 
            // nouveauRepasToolStripMenuItem
            // 
            this.nouveauRepasToolStripMenuItem.Name = "nouveauRepasToolStripMenuItem";
            this.nouveauRepasToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.nouveauRepasToolStripMenuItem.Text = "Nouveau repas";
            this.nouveauRepasToolStripMenuItem.Click += new System.EventHandler(this.nouveauRepasToolStripMenuItem_Click);
            // 
            // ouvrirRepasToolStripMenuItem
            // 
            this.ouvrirRepasToolStripMenuItem.Name = "ouvrirRepasToolStripMenuItem";
            this.ouvrirRepasToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ouvrirRepasToolStripMenuItem.Text = "Ouvrir repas";
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // recetteToolStripMenuItem
            // 
            this.recetteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelleRecetteToolStripMenuItem1,
            this.catalogueToolStripMenuItem1,
            this.favorisToolStripMenuItem});
            this.recetteToolStripMenuItem.Name = "recetteToolStripMenuItem";
            this.recetteToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.recetteToolStripMenuItem.Text = "Recette";
            // 
            // nouvelleRecetteToolStripMenuItem1
            // 
            this.nouvelleRecetteToolStripMenuItem1.Name = "nouvelleRecetteToolStripMenuItem1";
            this.nouvelleRecetteToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.nouvelleRecetteToolStripMenuItem1.Text = "Nouvelle recette";
            this.nouvelleRecetteToolStripMenuItem1.Click += new System.EventHandler(this.nouvelleRecetteToolStripMenuItem1_Click);
            // 
            // catalogueToolStripMenuItem1
            // 
            this.catalogueToolStripMenuItem1.Name = "catalogueToolStripMenuItem1";
            this.catalogueToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.catalogueToolStripMenuItem1.Text = "Catalogue";
            // 
            // favorisToolStripMenuItem
            // 
            this.favorisToolStripMenuItem.Name = "favorisToolStripMenuItem";
            this.favorisToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.favorisToolStripMenuItem.Text = "Favoris";
            // 
            // ingredientToolStripMenuItem
            // 
            this.ingredientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelIngrédientToolStripMenuItem,
            this.catalogueToolStripMenuItem2});
            this.ingredientToolStripMenuItem.Name = "ingredientToolStripMenuItem";
            this.ingredientToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.ingredientToolStripMenuItem.Text = "Ingrédient";
            // 
            // nouvelIngrédientToolStripMenuItem
            // 
            this.nouvelIngrédientToolStripMenuItem.Name = "nouvelIngrédientToolStripMenuItem";
            this.nouvelIngrédientToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.nouvelIngrédientToolStripMenuItem.Text = "Nouvel ingrédient";
            // 
            // catalogueToolStripMenuItem2
            // 
            this.catalogueToolStripMenuItem2.Name = "catalogueToolStripMenuItem2";
            this.catalogueToolStripMenuItem2.Size = new System.Drawing.Size(169, 22);
            this.catalogueToolStripMenuItem2.Text = "Catalogue";
            // 
            // ideePanel
            // 
            this.ideePanel.Controls.Add(this.nouveauRepas1);
            this.ideePanel.Controls.Add(this.recetteControl1);
            this.ideePanel.Controls.Add(this.suivanteButton);
            this.ideePanel.Controls.Add(this.precedenteButton);
            this.ideePanel.Location = new System.Drawing.Point(0, 27);
            this.ideePanel.Name = "ideePanel";
            this.ideePanel.Size = new System.Drawing.Size(931, 619);
            this.ideePanel.TabIndex = 58;
            this.ideePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ideePanel_Paint);
            // 
            // nouveauRepas1
            // 
            this.nouveauRepas1.Location = new System.Drawing.Point(23, 12);
            this.nouveauRepas1.Name = "nouveauRepas1";
            this.nouveauRepas1.Size = new System.Drawing.Size(434, 536);
            this.nouveauRepas1.TabIndex = 121;
            // 
            // recetteControl1
            // 
            this.recetteControl1.Location = new System.Drawing.Point(485, 3);
            this.recetteControl1.Name = "recetteControl1";
            this.recetteControl1.Size = new System.Drawing.Size(442, 575);
            this.recetteControl1.TabIndex = 120;
            // 
            // suivanteButton
            // 
            this.suivanteButton.Location = new System.Drawing.Point(751, 584);
            this.suivanteButton.Name = "suivanteButton";
            this.suivanteButton.Size = new System.Drawing.Size(156, 23);
            this.suivanteButton.TabIndex = 119;
            this.suivanteButton.Text = "Suivante";
            this.suivanteButton.UseVisualStyleBackColor = true;
            // 
            // precedenteButton
            // 
            this.precedenteButton.Location = new System.Drawing.Point(498, 584);
            this.precedenteButton.Name = "precedenteButton";
            this.precedenteButton.Size = new System.Drawing.Size(156, 23);
            this.precedenteButton.TabIndex = 118;
            this.precedenteButton.Text = "Précédente";
            this.precedenteButton.UseVisualStyleBackColor = true;
            // 
            // nouvelleRecettePanel
            // 
            this.nouvelleRecettePanel.Controls.Add(this.nouvelleRecetteControl1);
            this.nouvelleRecettePanel.Location = new System.Drawing.Point(0, 0);
            this.nouvelleRecettePanel.Name = "nouvelleRecettePanel";
            this.nouvelleRecettePanel.Size = new System.Drawing.Size(931, 619);
            this.nouvelleRecettePanel.TabIndex = 122;
            this.nouvelleRecettePanel.Visible = false;
            // 
            // nouvelleRecetteControl1
            // 
            this.nouvelleRecetteControl1.Location = new System.Drawing.Point(3, 3);
            this.nouvelleRecetteControl1.Name = "nouvelleRecetteControl1";
            this.nouvelleRecetteControl1.Size = new System.Drawing.Size(925, 604);
            this.nouvelleRecetteControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 646);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.ideePanel);
            this.Controls.Add(this.nouvelleRecettePanel);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Idées de repas";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ideePanel.ResumeLayout(false);
            this.nouvelleRecettePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem nouveauRepasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirRepasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recetteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleRecetteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem catalogueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem favorisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingredientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelIngrédientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogueToolStripMenuItem2;
        private System.Windows.Forms.Panel ideePanel;
        private System.Windows.Forms.Button suivanteButton;
        private System.Windows.Forms.Button precedenteButton;
        private RecetteControl recetteControl1;
        private ViewController.Controls.NouveauRepas nouveauRepas1;
        private System.Windows.Forms.Panel nouvelleRecettePanel;
        private NouvelleRecetteControl nouvelleRecetteControl1;
    }
}

