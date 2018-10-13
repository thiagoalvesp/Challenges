using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Challenge_Cap_12_WS
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "SchoolService2" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione SchoolService2.svc ou SchoolService2.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class SchoolService2 : ISchoolService2
    {
        public List<Student> GetStudents()
        {
            return DalHelper.GetStudents();
        }

        public void Add(int studentID, string studentName)
        {
            DalHelper.Add(
                new Student() { StudentID = studentID, StudentName = studentName }
                );
        }
    }
}
