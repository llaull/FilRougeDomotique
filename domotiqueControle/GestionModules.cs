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
    public partial class GestionModules_Form : MdiDirector<GestionModules_Form> //pour l'heritage
    //public partial class GestionModules_Form : Form //debug pour le mode designer 
    {
        //connexion à la DB
        DBConnect MyConnexion = new DBConnect();
        //DBConnect dataAdap = new DBConnect();
                
        public GestionModules_Form()
        {
            InitializeComponent();
        }

        /**/
        // class sans heritage
        //private static GestionModules_Form _instance = null;
        /*private static WeakReference<GestionModules_Form> _instance = null;

        public static void ShowUnique(index parent)
        {
            GC.Collect();
            GestionModules_Form formulaire;
            if (_instance == null)//
            {
                formulaire = new GestionModules_Form();
                formulaire.MdiParent = parent;
                formulaire.Show();
                _instance = new WeakReference<GestionModules_Form>(formulaire);
            }
            else
            {
                if(!_instance.TryGetTarget(out formulaire))
                {
                    formulaire = new GestionModules_Form();
                    formulaire.MdiParent = parent;
                    formulaire.Show();
                    _instance.SetTarget(formulaire);
                }
                else
                {
                    formulaire.Focus();
                    formulaire.Show();
                    //parent.ActivateMdiChild(formulaire);
                    formulaire.WindowState = FormWindowState.Normal;
                }
            }
        }*/

        private void GestionModules_Form_Load(object sender, EventArgs e)
        {
            
            //commande pour le SELECT
            MyConnexion.dataAdap.SelectCommand = MyConnexion.connex.CreateCommand();
            MyConnexion.dataAdap.SelectCommand.CommandText = "SELECT * FROM domotique. module_infos;";

            //commande pour le DELETE
            MyConnexion.dataAdap.DeleteCommand = MyConnexion.connex.CreateCommand();
            MyConnexion.dataAdap.DeleteCommand.CommandText = "DELETE FROM domotique.module_infos WHERE infos_ID=@infos_ID;";
            MyConnexion.dataAdap.DeleteCommand.Parameters.Add(new MySqlParameter("@infos_ID", MySqlDbType.Int32, 0, "infos_ID"));

            //commande pour l'UPDATE
            MyConnexion.dataAdap.UpdateCommand = MyConnexion.connex.CreateCommand();
            MyConnexion.dataAdap.UpdateCommand.CommandText = "UPDATE domotique.module_infos SET module_ref=@module_ref,module_nom=@module_nom,emplacement_id=@emplacement_id,nrf_ref=@nrf_ref,module_type=@module_type WHERE infos_ID=@infos_ID;";
            MyConnexion.dataAdap.UpdateCommand.Parameters.Add(new MySqlParameter("@infos_ID", MySqlDbType.Int32, 0, "infos_ID"));
            MyConnexion.dataAdap.UpdateCommand.Parameters.Add(new MySqlParameter("@module_ref", MySqlDbType.Int32, 0, "module_ref"));
            MyConnexion.dataAdap.UpdateCommand.Parameters.Add(new MySqlParameter("@module_nom", MySqlDbType.VarChar, 0, "module_nom"));
            MyConnexion.dataAdap.UpdateCommand.Parameters.Add(new MySqlParameter("@emplacement_id", MySqlDbType.VarChar, 0, "emplacement_id"));
            MyConnexion.dataAdap.UpdateCommand.Parameters.Add(new MySqlParameter("@nrf_ref", MySqlDbType.Int32, 0, "nrf_ref"));
            MyConnexion.dataAdap.UpdateCommand.Parameters.Add(new MySqlParameter("@module_type", MySqlDbType.VarChar, 0, "module_type"));

            //commande pour l'INSERT
            MyConnexion.dataAdap.InsertCommand = MyConnexion.connex.CreateCommand();
            MyConnexion.dataAdap.InsertCommand.CommandText = "INSERT INTO domotique.module_infos (module_ref,module_nom,emplacement_id,nrf_ref,module_type) VALUES (@module_ref,@module_nom,@emplacement_id,@nrf_ref,@module_type);";// select @infos_ID=LAST_INSERT_ID() AS infos_ID;
            //dataAdap.InsertCommand.Parameters.Add(new MySqlParameter("@infos_ID", MySqlDbType.Int32, 0, "infos_ID")).Direction = ParameterDirection.Output;
            MyConnexion.dataAdap.InsertCommand.Parameters.Add(new MySqlParameter("@module_ref", MySqlDbType.Int32, 0, "module_ref"));
            MyConnexion.dataAdap.InsertCommand.Parameters.Add(new MySqlParameter("@module_nom", MySqlDbType.VarChar, 0, "module_nom"));
            MyConnexion.dataAdap.InsertCommand.Parameters.Add(new MySqlParameter("@emplacement_id", MySqlDbType.VarChar, 0, "emplacement_id"));
            MyConnexion.dataAdap.InsertCommand.Parameters.Add(new MySqlParameter("@nrf_ref", MySqlDbType.Int32, 0, "nrf_ref"));
            MyConnexion.dataAdap.InsertCommand.Parameters.Add(new MySqlParameter("@module_type", MySqlDbType.VarChar, 0, "module_type"));

            //envoie le resultat du SELECT dans un DataTable en créant les colonnes dans le bon type de données
            DataTable table = new DataTable("TableModule");
            MyConnexion.dataAdap.FillSchema(table, SchemaType.Source);
            MyConnexion.dataAdap.Fill(table);

            //attache la DataTable dans le Navigator
            BindingSource binder = new BindingSource(table, null);
            dataGridModules.DataSource = binder;
            NavigatorModules.BindingSource = binder;

            //function sur les actions effectué sur la datatable
            //Permet d'effectuer un enregistrement automatique des changements pendant la saisie
            table.RowChanged += table_RowChanged;
            table.RowDeleted += table_RowChanged;

            //Gestion des érreurs de saisie
            dataGridModules.DataError += dataGridModules_DataError;
            
        }
        /**/
        void dataGridModules_DataError(object sender, DataGridViewDataErrorEventArgs e)
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
            MyConnexion.dataAdap.Update((DataTable)((BindingSource)dataGridModules.DataSource).DataSource);
        }
    }
}
