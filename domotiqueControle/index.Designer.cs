namespace domotiqueControle
{
    partial class index
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
            this.MenuPannelControle = new System.Windows.Forms.MenuStrip();
            this.MenuContPannelLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuContPannelGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionModules = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionEmplacements = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionModulesType = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionModulesUnitees = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuContPannelInfos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPannelControle.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPannelControle
            // 
            this.MenuPannelControle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuContPannelLogs,
            this.MenuContPannelGestion,
            this.MenuContPannelInfos});
            this.MenuPannelControle.Location = new System.Drawing.Point(0, 0);
            this.MenuPannelControle.Name = "MenuPannelControle";
            this.MenuPannelControle.Size = new System.Drawing.Size(682, 24);
            this.MenuPannelControle.TabIndex = 0;
            this.MenuPannelControle.Text = "menuStrip1";
            // 
            // MenuContPannelLogs
            // 
            this.MenuContPannelLogs.Name = "MenuContPannelLogs";
            this.MenuContPannelLogs.Size = new System.Drawing.Size(44, 20);
            this.MenuContPannelLogs.Text = "&Logs";
            // 
            // MenuContPannelGestion
            // 
            this.MenuContPannelGestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GestionModules,
            this.GestionEmplacements,
            this.GestionModulesType,
            this.GestionModulesUnitees});
            this.MenuContPannelGestion.Name = "MenuContPannelGestion";
            this.MenuContPannelGestion.Size = new System.Drawing.Size(150, 20);
            this.MenuContPannelGestion.Text = "gestion via &DataGridView";
            // 
            // GestionModules
            // 
            this.GestionModules.Name = "GestionModules";
            this.GestionModules.Size = new System.Drawing.Size(172, 22);
            this.GestionModules.Text = "Les &modules";
            this.GestionModules.Click += new System.EventHandler(this.GestionModules_Click);
            // 
            // GestionEmplacements
            // 
            this.GestionEmplacements.Name = "GestionEmplacements";
            this.GestionEmplacements.Size = new System.Drawing.Size(172, 22);
            this.GestionEmplacements.Text = "Les &emplacements";
            // 
            // GestionModulesType
            // 
            this.GestionModulesType.Name = "GestionModulesType";
            this.GestionModulesType.Size = new System.Drawing.Size(172, 22);
            this.GestionModulesType.Text = "Les &types";
            // 
            // GestionModulesUnitees
            // 
            this.GestionModulesUnitees.Name = "GestionModulesUnitees";
            this.GestionModulesUnitees.Size = new System.Drawing.Size(172, 22);
            this.GestionModulesUnitees.Text = "Les &unitées";
            // 
            // MenuContPannelInfos
            // 
            this.MenuContPannelInfos.Name = "MenuContPannelInfos";
            this.MenuContPannelInfos.Size = new System.Drawing.Size(45, 20);
            this.MenuContPannelInfos.Text = "&Infos";
            this.MenuContPannelInfos.Click += new System.EventHandler(this.MenuContPannelInfos_Click);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 487);
            this.Controls.Add(this.MenuPannelControle);
            this.IsMdiContainer = true;
            this.Name = "index";
            this.Text = "Pannel Controle Domotique";
            this.MenuPannelControle.ResumeLayout(false);
            this.MenuPannelControle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPannelControle;
        private System.Windows.Forms.ToolStripMenuItem MenuContPannelLogs;
        private System.Windows.Forms.ToolStripMenuItem MenuContPannelGestion;
        private System.Windows.Forms.ToolStripMenuItem GestionModules;
        private System.Windows.Forms.ToolStripMenuItem GestionEmplacements;
        private System.Windows.Forms.ToolStripMenuItem GestionModulesType;
        private System.Windows.Forms.ToolStripMenuItem GestionModulesUnitees;
        private System.Windows.Forms.ToolStripMenuItem MenuContPannelInfos;
    }
}

