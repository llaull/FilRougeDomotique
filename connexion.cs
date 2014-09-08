using System;
using MySql.Data.MySqlClient;
using System.Data;

public class DBConnect
{
    public MySqlDataAdapter dataAdap;
    public MySqlConnection connex;

    private string serveur = "10.119.33.20";
    private string basedonnees = "app_domobox";
    private string utilisateur = "root";

    public DBConnect()
	{
        Authentification();

	}
    private void Authentification(){

        connex = new MySqlConnection("Server=" + serveur + ";Database=" + basedonnees + ";Uid=" + utilisateur + ";Pwd=;");
        dataAdap = new MySqlDataAdapter();

    }

}
