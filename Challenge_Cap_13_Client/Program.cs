using ServiceReference1;
using System;
using System.Threading.Tasks;
using static ServiceReference1.SchoolServiceSoapClient;

namespace Challenge_Cap_13_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAllStudents();
            Console.ReadLine();
        }

        public static async void GetAllStudents()
        {
            SchoolServiceSoapClient proxy = new SchoolServiceSoapClient(EndpointConfiguration.SchoolServiceSoap);
            AddResponse add = await proxy.AddAsync(10, "Vitor");
            GetStudentsResponse get = await proxy.GetStudentsAsync();
            Console.WriteLine(get.Body.GetStudentsResult); 
        }
    }
}
