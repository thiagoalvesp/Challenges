using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

namespace Challenge_Cap_12_WS
{
    /// <summary>
    /// Descrição resumida de SchoolService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class SchoolService : System.Web.Services.WebService
    {
        [WebMethod]
        public string GetStudents()
        {
            JavaScriptSerializer dataContract = new JavaScriptSerializer();
            string serializedDataInStringFormat = dataContract.Serialize(DalHelper.GetStudents());
            return serializedDataInStringFormat;
        }

        [WebMethod]
        public void Add(int studentID, string studentName)
        {
            DalHelper.Add(
                new Student() { StudentID = studentID, StudentName = studentName }
                );
        }
    }
}
