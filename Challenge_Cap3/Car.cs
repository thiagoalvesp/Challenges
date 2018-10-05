using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_Cap3
{
    public class Car : Transformer
    {
        public override void Run()
        {
            Console.WriteLine("Car");
            base.Wheels = 4;
            base.MaxSpeed = 350;
            base.Landscape = Landscapes.Road;
            base.Run();
        }
    }
}
