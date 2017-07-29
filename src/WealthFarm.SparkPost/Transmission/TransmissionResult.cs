using Newtonsoft.Json;

namespace WealthFarm.SparkPost.Transmission
{
    /// <summary>
    ///     The result from sending a transmission.
    /// </summary>
    public class TransmissionResult
    {
        /// <summary>
        ///     Gets or sets the transmission ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///     Gets or sets the number of rejected recipients.
        /// </summary>
        [JsonProperty("total_rejected_recipients")]
        public int TotalRejectedRecipients { get; set; }

        /// <summary>
        ///     Gets or sets the number of accepted recipients.
        /// </summary>
        [JsonProperty("total_accepted_recipients.")]
        public int TotalAcceptedRecipients { get; set; }
    }
}