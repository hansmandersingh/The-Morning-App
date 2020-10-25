using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Morning_App
{
    class LocationApi
    {
        public string city { get; set; }
        public string region { get; set; }
        public string country_name { get; set; }
        public string ip { get; set; }
        [JsonProperty("currency")]
        public Currency Currency { get; set; }
    }

    class Currency
    {
        public string code { get; set; }
    }
}
