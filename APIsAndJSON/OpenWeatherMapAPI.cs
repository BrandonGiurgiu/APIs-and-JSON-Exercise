using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class WeatherMap
    {
        public static double GetTemp(string apiCAll)
        {
            var client = new HttpClient();

            var response = client.GetStringAsync(apiCAll).Result;

            var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());

            return temp;

        }
    }
}
