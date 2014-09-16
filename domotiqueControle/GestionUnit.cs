using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace domotiqueControle
{
     public partial class GestionUnit_Form : MdiDirector<GestionUnit_Form>
    //public partial class GestionUnit_Form : Form
    {
        DBConnect MyConnexion = new DBConnect();

        public GestionUnit_Form()
        {
            InitializeComponent();
        }

        private void GestionUnit_Form_Load(object sender, System.EventArgs e)
        {
            //commande pour le SELECT
            MyConnexion.dataAdap.SelectCommand = MyConnexion.connex.CreateCommand();
            MyConnexion.dataAdap.SelectCommand.CommandText = "SELECT * FROM domotique.sonde_unit;";

            //commande pour le DELETE
            MyConnexion.dataAdap.DeleteCommand = MyConnexion.connex.CreateCommand();
            MyConnexion.dataAdap.DeleteCommand.CommandText = "DELETE FROM domotique.sonde_unit WHERE unit_ID=@unit_ID;";
            MyConnexion.dataAdap.DeleteCommand.Parameters.Add(new MySqlParameter("@unit_ID", MySqlDbType.Int32, 0, "unit_ID"));

            //commande pour l'UPDATE
            MyConnexion.dataAdap.UpdateCommand = MyConnexion.connex.CreateCommand();
            MyConnexion.dataAdap.UpdateCommand.CommandText = "UPDATE domotique.sonde_unit SET symbole=@symbole,nom=@nom,nom_lien=@nom_lien WHERE unit_ID=@unit_ID;";
            MyConnexion.dataAdap.UpdateCommand.Parameters.Add(new MySqlParameter("@unit_ID", MySqlDbType.Int32, 0, "unit_ID"));
            MyConnexion.dataAdap.UpdateCommand.Parameters.Add(new MySqlParameter("@symbole", MySqlDbType.VarChar, 0, "symbole"));
            MyConnexion.dataAdap.UpdateCommand.Parameters.Add(new MySqlParameter("@nom", MySqlDbType.VarChar, 0, "nom"));
            MyConnexion.dataAdap.UpdateCommand.Parameters.Add(new MySqlParameter("@nom_lien", MySqlDbType.VarChar, 0, "nom_lien"));

            //commande pour l'INSERT
            MyConnexion.dataAdap.InsertCommand = MyConnexion.connex.CreateCommand();
            MyConnexion.dataAdap.InsertCommand.CommandText = "INSERT INTO domotique.sonde_unit (symbole,nom,nom_lien) VALUES (@symbole,@nom,@nom_lien);";
            MyConnexion.dataAdap.InsertCommand.Parameters.Add(new MySqlParameter("@symbole", MySqlDbType.VarChar, 0, "symbole"));
            MyConnexion.dataAdap.InsertCommand.Parameters.Add(new MySqlParameter("@nom", MySqlDbType.VarChar, 0, "nom"));
            MyConnexion.dataAdap.InsertCommand.Parameters.Add(new MySqlParameter("@nom_lien", MySqlDbType.VarChar, 0, "nom_lien"));

            //envoie le resultat du SELECT dans un DataTable en créant les colonnes dans le bon type de données
            DataTable table = new DataTable("TableUnit");
            MyConnexion.dataAdap.FillSchema(table, SchemaType.Source);
            MyConnexion.dataAdap.Fill(table);

            //attache la DataTable dans le Navigator
            BindingSource binder = new BindingSource(table, null);
            dataGridUnit.DataSource = binder;
            NavigatorUnit.BindingSource = binder;

            //function sur les actions effectué sur la datatable
            //Permet d'effectuer un enregistrement automatique des changements pendant la saisie
            table.RowChanged += table_RowChanged;
            table.RowDeleted += table_RowChanged;

            //Gestion des érreurs de saisie
            dataGridUnit.DataError += dataGridUnit_DataError;
        }

        private void dataGridUnit_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Tu te fous de moi!");
        }

        /// <summary>
        /// appeler si un changement à lieu sur une ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void table_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            //connex.CancelQuery(0);
            MyConnexion.dataAdap.Update((DataTable)((BindingSource)dataGridUnit.DataSource).DataSource);
        }

    }
}
