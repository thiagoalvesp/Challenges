using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Descrição resumida de SchoolService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
// [System.Web.Script.Services.ScriptService]
public class SchoolService : System.Web.Services.WebService
{

    public SchoolService()
    {
        //Remova os comentários da linha a seguir se usar componentes designados 
        //InitializeComponent(); 
        DalHelper.CriarBancoSQLite();
        DalHelper.CriarTabelaSQlite();
    }

    [WebMethod]
    public List<Student> GetStudents()
    {
        return DalHelper.GetStudents();
    }

    [WebMethod]
    public void Add(Student student)
    {
        DalHelper.Add(student);
    }

}
