using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_Cap3
{
    public class Boat : Transformer
    {
        public override void Run()
        {
            Console.WriteLine("Boat");
            base.Wheels = 0;
            base.MaxSpeed = 200;
            base.Landscape = Landscapes.Water;
            base.Run();
        }
    }
}
