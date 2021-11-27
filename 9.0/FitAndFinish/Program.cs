using System;
using System.Collections.Generic;

namespace FitAndFinish
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example-1
            List<WeatherObservation> _observations = new();

            //Example-2
            WeatherObservation weatherObservations = new() { Temprature = 90 };
            var forecast = weatherObservations.ForecastFor(DateTime.Now, new());
        }
    }

    public class WeatherObservation
    {
        public int Temprature { get; set; }

        public WeatherForecast ForecastFor(DateTime forecastDate, WeatherForecastOptions options)
        {
            return new() { Date = forecastDate, Temprature = Temprature, WeatherForecastOptions = options };
        }
    }

    public class WeatherForecast
    {
        public int Temprature { get; set; }
        public DateTime Date { get; set; }
        public WeatherForecastOptions WeatherForecastOptions { get; set; }
    }

    public class WeatherForecastOptions
    {

    }
}
