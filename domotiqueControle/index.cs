using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace domotiqueControle
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void GestionModules_Click(object sender, EventArgs e)
        {
            GestionModules_Form.ShowUnique(this); 
        }

        private void MenuContPannelInfos_Click(object sender, EventArgs e)
        {

        }

        private void GestionEmplacements_Click(object sender, EventArgs e)
        {
            GestionEmplacements_Form.ShowUnique(this); 
        }

        private void GestionModulesType_Click(object sender, EventArgs e)
        {
            GestionTypes_Form.ShowUnique(this); 
        }

        private void GestionModulesUnitees_Click(object sender, EventArgs e)
        {
            GestionUnit_Form.ShowUnique(this); 
        }

        private void rapport24h_Click(object sender, EventArgs e)
        {
            rapport24h fenetre = new rapport24h();
            fenetre.Show();
        }

        private void rapportToday_Click(object sender, EventArgs e)
        {

        }

        private void rapportWeek_Click(object sender, EventArgs e)
        {
            rapport7j fenetre = new rapport7j();
            fenetre.Show();
        }

    }
}
