using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_Cap3
{
    public class Transformer
    {
        public int Wheels { get; protected set; }
        public int MaxSpeed { get; protected set; }
        public Landscapes Landscape { get; protected set; }

        public virtual void Run()
        {
            Console.WriteLine(
                $"Wheels: {Wheels}" + Environment.NewLine +
                $"MaxSpeed: {MaxSpeed}" + Environment.NewLine +
                $"Landscapes: {Enum.GetName(typeof(Landscapes), Landscape)}"
                );
            Console.WriteLine("*******************");
        }
    }
}
