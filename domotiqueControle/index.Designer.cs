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
            this.MenuRapports = new System.Windows.Forms.ToolStripMenuItem();
            this.rapport24h = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportToday = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportWeek = new System.Windows.Forms.ToolStripMenuItem();
            this.dynamiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPannelControle.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPannelControle
            // 
            this.MenuPannelControle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuContPannelLogs,
            this.MenuContPannelGestion,
            this.MenuContPannelInfos,
            this.MenuRapports});
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
            this.GestionEmplacements.Click += new System.EventHandler(this.GestionEmplacements_Click);
            // 
            // GestionModulesType
            // 
            this.GestionModulesType.Name = "GestionModulesType";
            this.GestionModulesType.Size = new System.Drawing.Size(172, 22);
            this.GestionModulesType.Text = "Les &types";
            this.GestionModulesType.Click += new System.EventHandler(this.GestionModulesType_Click);
            // 
            // GestionModulesUnitees
            // 
            this.GestionModulesUnitees.Name = "GestionModulesUnitees";
            this.GestionModulesUnitees.Size = new System.Drawing.Size(172, 22);
            this.GestionModulesUnitees.Text = "Les &unitées";
            this.GestionModulesUnitees.Click += new System.EventHandler(this.GestionModulesUnitees_Click);
            // 
            // MenuContPannelInfos
            // 
            this.MenuContPannelInfos.Name = "MenuContPannelInfos";
            this.MenuContPannelInfos.Size = new System.Drawing.Size(45, 20);
            this.MenuContPannelInfos.Text = "&Infos";
            this.MenuContPannelInfos.Click += new System.EventHandler(this.MenuContPannelInfos_Click);
            // 
            // MenuRapports
            // 
            this.MenuRapports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapport24h,
            this.rapportToday,
            this.rapportWeek,
            this.dynamiqueToolStripMenuItem});
            this.MenuRapports.Name = "MenuRapports";
            this.MenuRapports.Size = new System.Drawing.Size(66, 20);
            this.MenuRapports.Text = "&Rapports";
            // 
            // rapport24h
            // 
            this.rapport24h.Name = "rapport24h";
            this.rapport24h.Size = new System.Drawing.Size(152, 22);
            this.rapport24h.Text = "24h";
            this.rapport24h.Click += new System.EventHandler(this.rapport24h_Click);
            // 
            // rapportToday
            // 
            this.rapportToday.Name = "rapportToday";
            this.rapportToday.Size = new System.Drawing.Size(152, 22);
            this.rapportToday.Text = "Aujourd\'hui";
            this.rapportToday.Click += new System.EventHandler(this.rapportToday_Click);
            // 
            // rapportWeek
            // 
            this.rapportWeek.Name = "rapportWeek";
            this.rapportWeek.Size = new System.Drawing.Size(152, 22);
            this.rapportWeek.Text = "Semaine";
            this.rapportWeek.Click += new System.EventHandler(this.rapportWeek_Click);
            // 
            // dynamiqueToolStripMenuItem
            // 
            this.dynamiqueToolStripMenuItem.Name = "dynamiqueToolStripMenuItem";
            this.dynamiqueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dynamiqueToolStripMenuItem.Text = "Dynamique";
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
        private System.Windows.Forms.ToolStripMenuItem MenuRapports;
        private System.Windows.Forms.ToolStripMenuItem rapportToday;
        private System.Windows.Forms.ToolStripMenuItem rapportWeek;
        private System.Windows.Forms.ToolStripMenuItem rapport24h;
        private System.Windows.Forms.ToolStripMenuItem dynamiqueToolStripMenuItem;
    }
}

