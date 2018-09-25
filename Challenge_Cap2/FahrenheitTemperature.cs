using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_Cap2
{
    public class FahrenheitTemperature
    {
        public decimal Value { get; set; }

        public FahrenheitTemperature(decimal value)
        {
            Value = value;
        }

        public static implicit operator CelsiusTemperature(FahrenheitTemperature temperature)
        {
            return new CelsiusTemperature((temperature.Value - 32) / 1.8m);
        }
    }
}
