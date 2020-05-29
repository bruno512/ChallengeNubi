using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeNubi.Core.Entities
{
    public class Currency 
    {
        public string id { get; set; }
        public string symbol { get; set; }
        public string description { get; set; }
        public int decimal_places { get; set; }
        public float toDolar { get; set; }
    }
}
