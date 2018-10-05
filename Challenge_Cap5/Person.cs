using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Challenge_Cap5
{
    public class Person : INotifyPropertyChanged
    {
        private string name;
        public event PropertyChangedEventHandler PropertyChanged;

        public Person()
        {

        }

        public Person(string value)
        {
            this.name = value;
        }

        public string PersonName
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("PersonName");
            }
        }

        private void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
