using System;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            QuoteGenerator.KanyeQuote();

            QuoteGenerator.RonQuote();

            //Exercise 2
            string key = File.ReadAllText("appsettings.json");
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.WriteLine("Please enter your zip code");
            var zipCode = Console.ReadLine();

            var apiCall = $"http://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";

            Console.WriteLine("");

            Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} degrees F in your location");
        }
    }
}
