using Challenges_Cap1;
using System;
using System.Linq;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //bool CalcAgain = false;
            //do
            //{
            //    var calc = new Calculator();
            //    calc.SetOperation();
            //    calc.SetValue1();
            //    calc.SetValue2();
            //    calc.ShowResult();

            //    string inputAnswer;
            //    do
            //    {
            //        Console.WriteLine("Do you want to continue again (Y/N)?");
            //        inputAnswer = Console.ReadLine();
            //    } while (inputAnswer.ToUpper() != "Y" && inputAnswer.ToUpper() != "N");

            //    CalcAgain = inputAnswer == "Y";

            //} while (CalcAgain);
            #endregion
            #region 2
            bool repeat = true;
            int totalStudents = 0;
            do
            {
                try
                {
                    Console.Write("Enter Total Students : ");
                    totalStudents = Int32.Parse(Console.ReadLine());
                    repeat = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    repeat = true;
                }
            } while (repeat);

            RowReport[] report = new RowReport[totalStudents];  
            for (int i = 0; i < totalStudents; i++)
            {
                Console.Write("Enter Student Name : ");
                string name = Console.ReadLine();
                int total = 0;
                string[] subjects = new string[]{ "English", "Math", "Computer" };
                for (int j = 0; j < subjects.Length; j++)
                {
                    repeat = true;
                    do
                    {
                        try
                        {
                            Console.Write($"Enter {subjects[j]} Marks (Out Of 100) : ");
                            int marks = Int32.Parse(Console.ReadLine());
                            if (marks > 100)
                                throw new InvalidOperationException("The marks is the bigger than 100");

                            total += marks;
                            repeat = false;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            repeat = true;
                        }
                    } while (repeat);
                }

                report[i] = new RowReport(name, total);
               
            }

            report.OrderByDescending(x => x.Score);
            Console.WriteLine("Report Card");
            for (int i = 0; i < report.Length; i++)
            {
                Console.WriteLine($"Student Name: {report[i].StudentName}, Position: {i+1}, Total: {report[i].Score}/300");
            }

            #endregion

        }
    }
}
