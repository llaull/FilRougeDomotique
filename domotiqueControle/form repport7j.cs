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
    public partial class rapport7j : Form
    {
        public rapport7j()
        {
            InitializeComponent();
        }

        private void form_repport7j_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'domotiqueDataSet.semaine'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.semaineTableAdapter.Fill(this.domotiqueDataSet.semaine);

            this.reportViewer1.RefreshReport();
        }
    }
}
