using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace domotiqueControle
{
  public partial class GestionTypes_Form : MdiDirector<GestionTypes_Form> //pour l'heritage
  //  public partial class GestionTypes_Form : Form
    {
        DBConnect MyConnexion = new DBConnect();
        public GestionTypes_Form()
        {
            InitializeComponent();
        }

        private void GestionTypes_Form_Load(object sender, EventArgs e)
        {
            //commande pour le SELECT
            MyConnexion.dataAdap.SelectCommand = MyConnexion.connex.CreateCommand();
            MyConnexion.dataAdap.SelectCommand.CommandText = "SELECT * FROM domotique.sonde_type;";

            //commande pour le DELETE
            MyConnexion.dataAdap.DeleteCommand = MyConnexion.connex.CreateCommand();
            MyConnexion.dataAdap.DeleteCommand.CommandText = "DELETE FROM domotique.sonde_type WHERE type_ID=@type_ID;";
            MyConnexion.dataAdap.DeleteCommand.Parameters.Add(new MySqlParameter("@type_ID", MySqlDbType.Int32, 0, "type_ID"));

            //commande pour l'UPDATE
            MyConnexion.dataAdap.UpdateCommand = MyConnexion.connex.CreateCommand();
            MyConnexion.dataAdap.UpdateCommand.CommandText = "UPDATE domotique.sonde_type SET nom=@nom WHERE type_ID=@type_ID;";
            MyConnexion.dataAdap.UpdateCommand.Parameters.Add(new MySqlParameter("@type_ID", MySqlDbType.Int32, 0, "type_ID"));
            MyConnexion.dataAdap.UpdateCommand.Parameters.Add(new MySqlParameter("@nom", MySqlDbType.VarChar, 0, "nom"));

            //commande pour l'INSERT
            MyConnexion.dataAdap.InsertCommand = MyConnexion.connex.CreateCommand();
            MyConnexion.dataAdap.InsertCommand.CommandText = "INSERT INTO domotique.sonde_type (nom) VALUES (@nom);";
            MyConnexion.dataAdap.InsertCommand.Parameters.Add(new MySqlParameter("@nom", MySqlDbType.VarChar, 0, "nom"));


            //envoie le resultat du SELECT dans un DataTable en créant les colonnes dans le bon type de données
            DataTable table = new DataTable("TableTypes");
            MyConnexion.dataAdap.FillSchema(table, SchemaType.Source);
            MyConnexion.dataAdap.Fill(table);

            //attache la DataTable dans le Navigator
            BindingSource binder = new BindingSource(table, null);
            dataGridTypes.DataSource = binder;
            NavigatorTypes.BindingSource = binder;

            //function sur les actions effectué sur la datatable
            //Permet d'effectuer un enregistrement automatique des changements pendant la saisie
            table.RowChanged += table_RowChanged;
            table.RowDeleted += table_RowChanged;

            //Gestion des érreurs de saisie
            dataGridTypes.DataError += dataGridTypes_DataError;
        }

        private void dataGridTypes_DataError(object sender, DataGridViewDataErrorEventArgs e)
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
            MyConnexion.dataAdap.Update((DataTable)((BindingSource)dataGridTypes.DataSource).DataSource);
        }




    }
}
