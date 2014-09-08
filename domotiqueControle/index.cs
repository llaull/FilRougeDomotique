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

        //public new void ActivateMdiChild(Form child)
        //{
        //    base.ActivateMdiChild(child);
        //}
    }
}
