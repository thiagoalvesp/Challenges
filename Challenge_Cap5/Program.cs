using System;
using System.ComponentModel;

namespace Challenge_Cap5
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            student.ShowMessage += Message;
            student.SetName("Thiago");
            student.SetComputer(100);
            student.SetScience(25);
            student.SetEnglish(25);
            Console.WriteLine("---------------");
            var person = new Person();
            person.PropertyChanged += OnPropertyChanged;
            person.PersonName = "Thiago";
            person.PersonName = "Joyce";
            Console.ReadKey();
        }

        public static void Message(Student o)
        {
            var total = o.GetScience() + o.GetEnglish() + o.GetComputer();
            if (total > 75)
            {
                Console.WriteLine($"Congratulation {o.GetName()} your Makrs {total}/150");
            }
            else
            {
                Console.WriteLine($"{o.GetName()} - F");
            }
        }

        private static void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Person person = (Person)sender;
            Console.WriteLine($"Property [{e.PropertyName}] has a new value = [{person.PersonName}]");
        }

    }
}
