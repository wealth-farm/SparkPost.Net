using System;
using System.Collections.Generic;

namespace WealthFarm.SparkPost.Transmission
{
    public class Recipient
    {
        public Address Address { get; set; }
        public string[] Tags { get; set; }
        public IDictionary<string, object> Metadata { get; set; }
        public IDictionary<string, object> SubstitutionData { get; set; }
    }
}
