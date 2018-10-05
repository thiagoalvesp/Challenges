using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_Cap5
{
    public class Student
    {
        private string _name;
        private int _computer;
        private int _science;
        private int _english;

        public string GetName()
        {
            return _name;
        }

        public void SetName(string value)
        {
            _name = value.ToUpper();
        }

        public int GetComputer()
        {
            return _computer;
        }

        public void SetComputer(int value)
        {
            _computer = value > 50 ? 50 : value;
            _showMessage();
        }

        public int GetScience()
        {
            return _science;
        }

        public void SetScience(int value)
        {
            _science = value > 50 ? 50 : value;
            _showMessage();
        }

        public int GetEnglish()
        {
            return _english;
        }

        public void SetEnglish(int value)
        {
            _english = value > 50 ? 50 : value;
            _showMessage();
        }

        public event Action<Student> ShowMessage;

        private void _showMessage()
        {
            if (this._computer > 0 && this._english > 0 && this._science > 0)
            {
                ShowMessage?.Invoke(this);
            }
        }

    }
}
