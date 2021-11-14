using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    static public class AppConfiguration
    {
        private static IConfiguration configuration;
        public static string GetValue(string key)
        {
           if(configuration == null)
           {
                initConfig();
           }
            return configuration.GetValue<string>(key);
        }
        private static void initConfig()
        {
            configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").AddUserSecrets("f4f5746e-d24c-4697-b6cd-935a16b16033").Build();
        }
    }
}
