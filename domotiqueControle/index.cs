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
            //GestionModules fenetre = new GestionModules();
            //fenetre.MdiParent = this;
            //fenetre.Show();

            GestionModules_Form.ShowUnique(this); 
        }

        private void MenuContPannelInfos_Click(object sender, EventArgs e)
        {

        }

        public new void ActivateMdiChild(Form child)
        {
            base.ActivateMdiChild(child);
        }
    }
}
