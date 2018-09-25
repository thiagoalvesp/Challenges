using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_Cap2
{
    public class CelsiusTemperature
    {
        public decimal Value { get; set; }

        public CelsiusTemperature(decimal value)
        {
            Value = value;
        }
        public static implicit operator FahrenheitTemperature(CelsiusTemperature temperature)
        {
            return new FahrenheitTemperature(temperature.Value * 1.8m + 32);
        }
    }
}
