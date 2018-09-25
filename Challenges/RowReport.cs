using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges_Cap1
{
    public class RowReport
    {
        public string StudentName{ get; private set; }
        public int Score { get; private set; }

        public RowReport(string studentName, int score)
        {
            StudentName = studentName;
            Score = score;
        }
    }
}
