using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Morning_App
{
    class WeatherApi
    {
        [JsonProperty("main")]
        public Main Main { get; set; }

    }

    public class Main
    {
        public double temp { get; set; }
    }
}
