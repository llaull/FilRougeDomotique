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
    public partial class rapport24h : Form
    {
        public rapport24h()
        {
            InitializeComponent();
        }

        private void rapport_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'domotiqueDataSet._24h'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this._24hTableAdapter.Fill(this.domotiqueDataSet._24h);

            this.reportViewer1.RefreshReport();
        }

    }
}
