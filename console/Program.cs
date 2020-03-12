using System;
using api.Service;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {

            WeatherForecastService a = new WeatherForecastService();

            var resultado = a.Get();

            foreach (var clima in resultado)
            {
                Console.WriteLine("Clima: " + clima.Summary
                + " Data: " + clima.Date
                + " Temperatura C " + clima.TemperatureC
                + " Temperatura F " + clima.TemperatureF);

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
