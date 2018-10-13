using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Web;

/// <summary>
/// Classe de acesso ao banco de dados
/// </summary>
public class DalHelper
{
    private static SQLiteConnection sqliteConnection;

    public DalHelper()
    { }

    private static SQLiteConnection DbConnection()
    {
        sqliteConnection = new SQLiteConnection("Data Source=c:\\dados\\Cadastro.sqlite; Version=3;");
        sqliteConnection.Open();
        return sqliteConnection;
    }

    public static void CriarBancoSQLite()
    {
        try
        {
            if (File.Exists(@"c:\dados\Cadastro.sqlite"))
            {
                return;
            }
            SQLiteConnection.CreateFile(@"c:\dados\Cadastro.sqlite");
        }
        catch
        {
            throw;
        }
    }
    public static void CriarTabelaSQlite()
    {
        try
        {
            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS Users(UserName Varchar(200), PasswordHashed Varchar(4000), Salt Varchar(4000))";
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static Tuple<string,string> GetUser(string user)
    {
        SQLiteDataReader dr = null;
        try
        {
            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Users where UserName = @UserName";
                cmd.Parameters.AddWithValue("@UserName", user);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    string psw = "";
                    string salt = "";
                    int pswIndex = dr.GetOrdinal("PasswordHashed");
                    int saltIndex = dr.GetOrdinal("Salt");

                    while (dr.Read())
                    {
                        psw = dr[pswIndex].ToString();
                        salt = dr[saltIndex].ToString();
                    }
                    return new Tuple<string, string>(psw, salt);
                       
                }
            }
            return new Tuple<string, string>(null,null);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static void Add(string user, string psw, string salt)
    {
        try
        {
            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = @"INSERT INTO Users(UserName, PasswordHashed, Salt ) 
                                    values (@UserName, @PasswordHashed, @Salt)";
                cmd.Parameters.AddWithValue("@UserName", user);
                cmd.Parameters.AddWithValue("@PasswordHashed", psw);
                cmd.Parameters.AddWithValue("@Salt", salt);
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

}