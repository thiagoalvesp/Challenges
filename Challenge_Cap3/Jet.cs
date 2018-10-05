using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_Cap3
{
    public class Jet : Transformer
    {
        public override void Run()
        {
            Console.WriteLine("Jet");
            base.Wheels = 8;
            base.MaxSpeed = 900;
            base.Landscape = Landscapes.Air;
            base.Run();
        }
    }
}
