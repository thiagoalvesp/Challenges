using System;

namespace Challenge_Cap2
{
    class Program
    {
        static void Main(string[] args)
        {
            CelsiusTemperature celsius1 = new CelsiusTemperature(21m);
            FahrenheitTemperature Fahrenheit1 = celsius1;
            Console.WriteLine($"Celsius: {celsius1.Value} - Fahrenheit: {Fahrenheit1.Value}");

            FahrenheitTemperature Fahrenheit2 = new FahrenheitTemperature(69.8m);
            CelsiusTemperature celsius2 = Fahrenheit2;
            Console.WriteLine($"Celsius: {celsius2.Value} - Fahrenheit: {Fahrenheit2.Value}");
            Console.ReadKey();

        }
    }
}
