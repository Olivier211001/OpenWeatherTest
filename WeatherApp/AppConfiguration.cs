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
        static private IConfiguration configuration;
        static public string GetValue(string key)
        {
            return key;
        }
        static private void initConfig()
        {
            configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").AddUserSecrets("f4f5746e-d24c-4697-b6cd-935a16b16033").Build();
        }
    }
}
