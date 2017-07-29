using Newtonsoft.Json;

namespace WealthFarm.SparkPost
{
    /// <summary>
    ///     Address represents a recipient's full email address.
    /// </summary>
    public class Address
    {
        /// <summary>
        ///     Gets or sets the recipient's email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        ///     Gets or sets the recipient's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}