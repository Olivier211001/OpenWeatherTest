using OpenWeatherAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp
{
    public class OpenWeatherService : IWindDataService
    {

        private static OpenWeatherProcessor owp;

        public WindDataModel LastwindData;

        public async Task<WindDataModel> GetDataAsync()
        {
            OWCurrentWeaterModel result = await owp.GetCurrentWeatherAsync();
            WindDataModel model = new WindDataModel();

            model.DateTime = DateTime.UnixEpoch.AddSeconds(result.DateTime);
            model.Direction = result.Wind.Deg;
            model.MetrePerSec = result.Wind.Speed;
            LastwindData = model;
            return LastwindData;
        }

        public OpenWeatherService(string apikey)
        {
            owp = OpenWeatherProcessor.Instance;
            owp.ApiKey = apikey;
        }
    }
}
