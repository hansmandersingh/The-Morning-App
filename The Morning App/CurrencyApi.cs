using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Morning_App
{
    class CurrencyApi
    {
        [JsonProperty("rates")]
        public Rates Rates { get; set; }
    }

    class Rates
    {
        public float USD { get; set; }
    }
}
