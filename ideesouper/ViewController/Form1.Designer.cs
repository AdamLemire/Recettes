﻿namespace ideesouper
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
            this.recherchePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.recetteResultatPanel = new System.Windows.Forms.Panel();
            this.suivanteButton = new System.Windows.Forms.Button();
            this.precedenteButton = new System.Windows.Forms.Button();
            this.nouvelleRecettePanel = new System.Windows.Forms.Panel();
            this.nouvelIngredientPanel = new System.Windows.Forms.Panel();
            this.nouvelIngredient1 = new ideesouper.ViewController.Controls.NouvelIngredient();
            this.nouveauRepas1 = new ideesouper.ViewController.Controls.NouveauRepas();
            this.recetteControl1 = new ideesouper.RecetteControl();
            this.nouvelleRecetteControl1 = new ideesouper.NouvelleRecetteControl();
            this.menuStrip.SuspendLayout();
            this.ideePanel.SuspendLayout();
            this.recherchePanel.SuspendLayout();
            this.recetteResultatPanel.SuspendLayout();
            this.nouvelleRecettePanel.SuspendLayout();
            this.nouvelIngredientPanel.SuspendLayout();
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
            this.ouvrirRepasToolStripMenuItem.Enabled = false;
            this.ouvrirRepasToolStripMenuItem.Name = "ouvrirRepasToolStripMenuItem";
            this.ouvrirRepasToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ouvrirRepasToolStripMenuItem.Text = "Ouvrir repas";
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Enabled = false;
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
            this.catalogueToolStripMenuItem1.Enabled = false;
            this.catalogueToolStripMenuItem1.Name = "catalogueToolStripMenuItem1";
            this.catalogueToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.catalogueToolStripMenuItem1.Text = "Catalogue";
            // 
            // favorisToolStripMenuItem
            // 
            this.favorisToolStripMenuItem.Enabled = false;
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
            this.nouvelIngrédientToolStripMenuItem.Click += new System.EventHandler(this.nouvelIngrédientToolStripMenuItem_Click);
            // 
            // catalogueToolStripMenuItem2
            // 
            this.catalogueToolStripMenuItem2.Enabled = false;
            this.catalogueToolStripMenuItem2.Name = "catalogueToolStripMenuItem2";
            this.catalogueToolStripMenuItem2.Size = new System.Drawing.Size(169, 22);
            this.catalogueToolStripMenuItem2.Text = "Catalogue";
            // 
            // ideePanel
            // 
            this.ideePanel.Controls.Add(this.recherchePanel);
            this.ideePanel.Controls.Add(this.recetteResultatPanel);
            this.ideePanel.Controls.Add(this.suivanteButton);
            this.ideePanel.Controls.Add(this.precedenteButton);
            this.ideePanel.Location = new System.Drawing.Point(0, 27);
            this.ideePanel.Name = "ideePanel";
            this.ideePanel.Size = new System.Drawing.Size(931, 619);
            this.ideePanel.TabIndex = 58;
            this.ideePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ideePanel_Paint);
            // 
            // recherchePanel
            // 
            this.recherchePanel.Controls.Add(this.button1);
            this.recherchePanel.Controls.Add(this.button2);
            this.recherchePanel.Controls.Add(this.nouveauRepas1);
            this.recherchePanel.Location = new System.Drawing.Point(4, 1);
            this.recherchePanel.Name = "recherchePanel";
            this.recherchePanel.Size = new System.Drawing.Size(469, 560);
            this.recherchePanel.TabIndex = 123;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 122;
            this.button1.Text = "Recommencer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.annuler_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 124;
            this.button2.Text = "Trouver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.trouver_Click);
            // 
            // recetteResultatPanel
            // 
            this.recetteResultatPanel.Controls.Add(this.recetteControl1);
            this.recetteResultatPanel.Location = new System.Drawing.Point(479, 0);
            this.recetteResultatPanel.Name = "recetteResultatPanel";
            this.recetteResultatPanel.Size = new System.Drawing.Size(452, 578);
            this.recetteResultatPanel.TabIndex = 122;
            // 
            // suivanteButton
            // 
            this.suivanteButton.Location = new System.Drawing.Point(751, 584);
            this.suivanteButton.Name = "suivanteButton";
            this.suivanteButton.Size = new System.Drawing.Size(156, 23);
            this.suivanteButton.TabIndex = 119;
            this.suivanteButton.Text = "Suivante";
            this.suivanteButton.UseVisualStyleBackColor = true;
            this.suivanteButton.Click += new System.EventHandler(this.suivanteButton_Click);
            // 
            // precedenteButton
            // 
            this.precedenteButton.Location = new System.Drawing.Point(498, 584);
            this.precedenteButton.Name = "precedenteButton";
            this.precedenteButton.Size = new System.Drawing.Size(156, 23);
            this.precedenteButton.TabIndex = 118;
            this.precedenteButton.Text = "Précédente";
            this.precedenteButton.UseVisualStyleBackColor = true;
            this.precedenteButton.Click += new System.EventHandler(this.precedenteButton_Click);
            // 
            // nouvelleRecettePanel
            // 
            this.nouvelleRecettePanel.Controls.Add(this.nouvelleRecetteControl1);
            this.nouvelleRecettePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nouvelleRecettePanel.Location = new System.Drawing.Point(0, 0);
            this.nouvelleRecettePanel.Name = "nouvelleRecettePanel";
            this.nouvelleRecettePanel.Size = new System.Drawing.Size(931, 619);
            this.nouvelleRecettePanel.TabIndex = 122;
            this.nouvelleRecettePanel.Visible = false;
            // 
            // nouvelIngredientPanel
            // 
            this.nouvelIngredientPanel.Controls.Add(this.nouvelIngredient1);
            this.nouvelIngredientPanel.Location = new System.Drawing.Point(0, 27);
            this.nouvelIngredientPanel.Name = "nouvelIngredientPanel";
            this.nouvelIngredientPanel.Size = new System.Drawing.Size(515, 558);
            this.nouvelIngredientPanel.TabIndex = 125;
            this.nouvelIngredientPanel.Visible = false;
            // 
            // nouvelIngredient1
            // 
            this.nouvelIngredient1.Location = new System.Drawing.Point(-154, 0);
            this.nouvelIngredient1.Name = "nouvelIngredient1";
            this.nouvelIngredient1.Size = new System.Drawing.Size(928, 619);
            this.nouvelIngredient1.TabIndex = 0;
            // 
            // nouveauRepas1
            // 
            this.nouveauRepas1.Location = new System.Drawing.Point(0, 0);
            this.nouveauRepas1.Name = "nouveauRepas1";
            this.nouveauRepas1.Size = new System.Drawing.Size(434, 507);
            this.nouveauRepas1.TabIndex = 121;
            // 
            // recetteControl1
            // 
            this.recetteControl1.Location = new System.Drawing.Point(0, 0);
            this.recetteControl1.Name = "recetteControl1";
            this.recetteControl1.Size = new System.Drawing.Size(442, 619);
            this.recetteControl1.TabIndex = 120;
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
            this.Controls.Add(this.nouvelIngredientPanel);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.ideePanel);
            this.Controls.Add(this.nouvelleRecettePanel);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Idées de repas";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ideePanel.ResumeLayout(false);
            this.recherchePanel.ResumeLayout(false);
            this.recetteResultatPanel.ResumeLayout(false);
            this.nouvelleRecettePanel.ResumeLayout(false);
            this.nouvelIngredientPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel recetteResultatPanel;
        private System.Windows.Forms.Panel recherchePanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel nouvelIngredientPanel;
        private ViewController.Controls.NouvelIngredient nouvelIngredient1;
    }
}

