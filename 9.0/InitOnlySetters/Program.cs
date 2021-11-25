using System;

namespace InitOnlySetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WithGetSetProperties();
            WithGetProperties();
            WithInitProperties();
        }

        private static void WithGetSetProperties()
        {
            var weather = new Weather1()
            {
                RecordedAt = DateTime.Now,
                TemperatureInCelsius = 20,
                PressureInMillibars = 998.0m
            };

            //Drawback: object properties are mutable as below
            weather.RecordedAt = DateTime.Now;
        }

        private static void WithGetProperties()
        {
            //You can't create object like below, instead you need a constructor
            //var weather = new Weather2()
            //{
            //    RecordedAt = DateTime.Now,
            //    TemperatureInCelsius = 20,
            //    PressureInMillibars = 998.0m
            //};

            var weather = new Weather2(DateTime.Now, 20, 998.0m);
        }

        private static void WithInitProperties()
        {
            var weather = new Weather3
            {
                RecordedAt = DateTime.Now,
                TemperatureInCelsius = 20,
                PressureInMillibars = 998.0m
            };

            //This preservers immutability, below line give compile error
            //weather.RecordedAt = DateTime.Now;
        }
    }

    //With Get/Set properties
    public class Weather1
    {
        public DateTime RecordedAt { get; set; }
        public decimal TemperatureInCelsius { get; set; }
        public decimal PressureInMillibars { get; set; }
    }

    //With only Get Properties
    public class Weather2
    {
        public DateTime RecordedAt { get; }
        public decimal TemperatureInCelsius { get; }
        public decimal PressureInMillibars { get; }

        public Weather2(
            DateTime recordedAt,
            decimal temperatureInCelsius,
            decimal pressureInMillibars)
        {
            RecordedAt = recordedAt;
            TemperatureInCelsius = temperatureInCelsius;
            PressureInMillibars = pressureInMillibars;
        }
    }

    //With Init Properties
    public class Weather3
    {
        public DateTime RecordedAt { get; init; }
        public decimal TemperatureInCelsius { get; init; }
        public decimal PressureInMillibars { get; init; }
    }
}
