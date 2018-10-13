using System;
using System.IO;
using System.Xml.Serialization;

namespace Challenge_Cap_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = null;
            using (var stream = new FileStream("Sample.xml", FileMode.Open))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Teacher));
                teacher = (Teacher)xml.Deserialize(stream);
            }

            Console.WriteLine($"ID: {teacher.ID} - Name: {teacher.Name} - Salary: {teacher.Salary}");
            Console.ReadLine();
        }
    }

    [Serializable]
    public class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public long Salary { get; set; }
    }

}
