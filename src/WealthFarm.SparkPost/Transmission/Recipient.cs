using System.Collections.Generic;
using Newtonsoft.Json;

namespace WealthFarm.SparkPost
{
    /// <summary>
    ///     Recipient represents a single recipient.
    /// </summary>
    public class Recipient
    {
        /// <summary>
        ///     Gets or sets the recipient's address.
        /// </summary>
        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        ///     Gets or sets any tags.
        /// </summary>
        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        /// <summary>
        ///     Gets or sets metadata.
        /// </summary>
        [JsonProperty("metadata")]
        public IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        ///     Gets or sets substitution data.
        /// </summary>
        [JsonProperty("substitution_data")]
        public IDictionary<string, object> SubstitutionData { get; set; }
    }
}