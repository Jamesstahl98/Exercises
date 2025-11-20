using DemoUnitTest3.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest3.Core.Helpers
{
    public class WeatherAnalyzer
    {
        private readonly IWeatherService _weatherService;

        public WeatherAnalyzer(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public string GetTemperatureCategory(string city)
        {
            int temp = _weatherService.GetCurrentTemperature(city);

            if (temp <= 0)
                return "Cold";
            else if (temp >= 25)
                return "Hot";
            else
                return "Mild";
        }
    }
}
