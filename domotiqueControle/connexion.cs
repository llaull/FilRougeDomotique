using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

public class DBConnect
{
    private MySqlDataAdapter _dataAdap;
    private MySqlConnection _connex;

    /// <summary>
    /// accesseur pour 
    /// </summary>
    public MySqlDataAdapter dataAdap
    {
        get { return _dataAdap; }
    }

    public MySqlConnection connex
    {
        get { return _connex; }
    }

    private string serveur = "127.0.0.1";
    private string basedonnees = "domotique";
    private string utilisateur = "root";

    public DBConnect()
	{
        Authentification();

	}
    private void Authentification(){

        _connex = new MySqlConnection("Server=" + serveur + ";Database=" + basedonnees + ";Uid=" + utilisateur + ";Pwd=;");
        _dataAdap = new MySqlDataAdapter();
        //function sur les actions effectué sur le dataadapter
        //Normalement pas nécessaire mais permet de palier au fait que lé r"cupération de l'id inséré bug avec Mysql
        this.dataAdap.RowUpdated += dataAdap_RowUpdated;
    }

    /// <summary>
    /// est appellé dès lors q'une ligne de la datatble à été traitée par le dataadapter
    /// (après que le dataadapter ait réalisé une opération de base de données)
    /// </summary>
    /// <param name="sender"> </param>
    /// <param name="e"></param>
    void dataAdap_RowUpdated(object sender, MySqlRowUpdatedEventArgs e)
    {
        if (e.RecordsAffected == 1 && e.Command == this.dataAdap.InsertCommand)//si une ligne a été modifiée et que la commande sql est un insert
        {   //Dans ce cas il me faut récupérer l'id qui a été généré pour cette nouvelle ligne
            MySqlCommand idQuery = this.connex.CreateCommand();
            idQuery.CommandText = "SELECT LAST_INSERT_ID();"; // requête renvoie l'id du dernier enregistement
            try
            {
                int id = (int)(ulong)idQuery.ExecuteScalar();     // lancement de cette requête avec récupération de la première valeur retournée (première valeur de la première ligne du premier jeu de résultat)
                //dataAdap.InsertCommand.Parameters["@id"].Value = id; //Pas utilisé dans la commande insert
                //e.Row["id"] = id; // affiche l'id dans la collone id
                foreach (DataColumn col in e.Row.Table.Columns)
                    if (col.AutoIncrement)
                        e.Row[col.Ordinal] = id;
            }
            catch(Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }
    }
}
