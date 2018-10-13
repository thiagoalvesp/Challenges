using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Web;

/// <summary>
/// Classe de acesso ao banco de dados
/// </summary>
public class DalHelper
{
    private static SQLiteConnection sqliteConnection;

    public DalHelper()
    {}

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
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS Student(StudentID int, StudentName Varchar(50))";
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static List<Student> GetStudents()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();
        try
        {
            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Student";
                da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                da.Fill(dt);

                return (from rw in dt.AsEnumerable()
                        select new Student()
                        {
                            StudentID = rw.Field<int>("StudentID"),
                            StudentName = rw.Field<string>("StudentName")
                        }).ToList();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static void Add(Student student)
    {
        try
        {
            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Student(StudentID, StudentName ) values ( @StudentID, @StudentName)";
                cmd.Parameters.AddWithValue("@StudentID", student.StudentID);
                cmd.Parameters.AddWithValue("@StudentName", student.StudentName);
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

}