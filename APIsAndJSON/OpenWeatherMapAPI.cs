using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public static void Weather()
        {
            var client = new HttpClient();

            var key = "3f846f21acb988ad0e5321f0a03fa7c0";
            var city = "Fayetteville";

            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?lat={36.0626}&lon={-94.1574}&appid={key}&units=imperial";
            var response = client.GetStringAsync(weatherURL).Result;
                       

            JObject formattedResponse = JObject.Parse(response);
            var temp = formattedResponse["main"]["temp"];

            Console.WriteLine($"The currect temperature in {city} is {temp} degrees fahrenheit.");

        }
    }
}
