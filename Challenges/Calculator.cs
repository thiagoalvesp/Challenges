using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges_Cap1
{
    public class Calculator
    {
        private decimal Value1 { get; set; }
        private decimal Value2 { get; set; }
        private int Operation { get; set; }

        public void SetOperation()
        {
            Console.WriteLine("Press any following key to perform an arithmetic operation:");
            Console.WriteLine();
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multipliation");
            Console.WriteLine("4 - Division");
            Console.WriteLine();

            var op = 0;
            do
            {
                string inputOption = Console.ReadLine();
                int.TryParse(inputOption, out op);
                if (op == 0 || op > 4)
                    Console.WriteLine("Wrong option!");

            } while (op == 0 || op > 4);
            Operation = op;

        }

        public void SetValue1()
        {
            bool replyMsg = false;
            do
            {
                try
                {
                    Console.Write("Enter Value 1:");
                    Value1 = decimal.Parse(Console.ReadLine());
                    replyMsg = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    replyMsg = true;
                }
            } while (replyMsg);
        }

        public void SetValue2()
        {
            bool replyMsg = false;
            do
            {
                try
                {
                    Console.Write("Enter Value 2:");
                    Value2 = decimal.Parse(Console.ReadLine());
                    replyMsg = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    replyMsg = true;
                }
            } while (replyMsg);
        }

        public void ShowResult()
        {
            try
            {
                switch (Operation)
                {
                    case 1:
                        Console.WriteLine("{0} + {1} = {2}", Value1, Value2, Value1 + Value2);
                        break;
                    case 2:
                        Console.WriteLine("{0} - {1} = {2}", Value1, Value2, Value1 - Value2);
                        break;
                    case 3:
                        Console.WriteLine("{0} * {1} = {2}", Value1, Value2, Value1 * Value2);
                        break;
                    case 4:
                        Console.WriteLine("{0} / {1} = {2}", Value1, Value2, Value1 / Value2);
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
