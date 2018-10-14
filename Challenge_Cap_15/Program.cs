using System;
using System.Diagnostics;

namespace Challenge_Cap_15
{
    class Program
    {
        private const string CategoryName = "Challenge_Cap_15_Counter";
        private const string CounterName = "Challenge_Cap_15_C1";

        static void Main(string[] args)
        {

            ///Challenge 1

            //try
            //{
            //    var zero = 0;
            //    var result = 1 / zero;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    string sourceName = "Sample Log - Challenge_Cap_15";
            //    string logName = "Challenge_Cap_15";
            //    string machineName = ".";// . means local machine
            //    string entryTowritten = ex.Message;
            //    if (!EventLog.SourceExists(sourceName, machineName))
            //    {
            //        EventLog.CreateEventSource(sourceName, logName);
            //    }
            //    EventLog.WriteEntry(
            //        sourceName, entryTowritten, EventLogEntryType.Information
            //        );
            //}


            //Challenge 2
            //Create a counter 
            if (!PerformanceCounterCategory.Exists(CategoryName))
            {
                CounterCreationDataCollection counters = new CounterCreationDataCollection();
                CounterCreationData totalOfNothing = new CounterCreationData();
                totalOfNothing.CounterName = CounterName;
                totalOfNothing.CounterHelp = "Counter of nothing kkk";
                totalOfNothing.CounterType = PerformanceCounterType.NumberOfItems32;
                counters.Add(totalOfNothing);
#pragma warning disable CS0618 // O tipo ou membro é obsoleto
                PerformanceCounterCategory.Create(CategoryName, "Ajuda", counters);
#pragma warning restore CS0618 // O tipo ou membro é obsoleto
                Console.WriteLine("Performance Counter Created.");
            }
            else
            {
                Console.WriteLine("Performance Counter already Created.");
            }

            PerformanceCounter successfullCounter = new PerformanceCounter();
            successfullCounter.CategoryName = CategoryName;
            successfullCounter.CounterName = CounterName;
            successfullCounter.MachineName = ".";
            successfullCounter.ReadOnly = false;

            var exit = false;
            var input = 0;

            do
            {
                Console.WriteLine("1-Input Increment");
                Console.WriteLine("2-Input Decrement");
                Console.WriteLine("3-Output");
                Console.WriteLine("4-Exit");
                var a = Console.ReadLine();
                switch (a)
                {
                    case "1":
                        successfullCounter.IncrementBy(100);
                        break;
                    case "2":
                        for (int i = 0; i < 100; i++)
                        {
                            successfullCounter.Decrement();
                        }
                        break;
                    case "3":
                        Console.WriteLine(successfullCounter.RawValue);
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Oh noo! it's wrong!");
                        break;
                }
            } while (!exit);
           
        
        }
    }
}
