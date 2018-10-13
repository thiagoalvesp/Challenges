using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Challenge_Cap_12_WS
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "ISchoolService2" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface ISchoolService2
    {
        [OperationContract]
        List<Student> GetStudents();

        [OperationContract]
        void Add(int studentID, string studentName);


    }
}
