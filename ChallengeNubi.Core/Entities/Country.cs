using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeNubi.Core.Entities
{
    public partial class Country
    {        
        public string id { get; set; }
        public string name { get; set; }
        public string locale { get; set; }
        public string currency_id { get; set; }
        public string decimal_separator { get; set; }
        public string thousands_separator { get; set; }
        public string time_zone { get; set; }
        public Geo_Information geo_information { get; set; }
        public State[] states { get; set; }        

        public class Geo_Information
        {
            public Location location { get; set; }
        }

        public class Location
        {
            public float latitude { get; set; }
            public float longitude { get; set; }
        }

        public class State
        {
            public string id { get; set; }
            public string name { get; set; }
        }

    }
}
