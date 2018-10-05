using System;
using System.Collections;

namespace Challenge_Cap4
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new CustomGenericEnumerable<string>();
            a.Add("a")
            .Add("b")
            .Add("c")
            .Add("d")
            .Add("e");
      
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
          

            Console.ReadKey();
        }
    }
}

//174