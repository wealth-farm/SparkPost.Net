using Newtonsoft.Json;

namespace WealthFarm.SparkPost.Transmission
{
    /// <summary>
    ///     RecipientList represents a list of transmission recipients.
    /// </summary>
    public class RecipientList
    {
        /// <summary>
        ///     Gets or sets the list identifier for use with a stored recipient list.
        /// </summary>
        /// <value>The list identifier.</value>
        [JsonProperty("list_id")]
        public string ListId { get; set; }
    }
}