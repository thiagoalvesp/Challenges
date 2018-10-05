using System;

namespace Challenge_Cap3
{
    class Program
    {
        static void Main(string[] args)
        {
            Transformer transformer = new Jet();
            transformer.Run();
            transformer = new Car();
            transformer.Run();
            transformer = new Boat();
            transformer.Run();

            Console.ReadKey();
        }
    }
}
