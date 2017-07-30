using Newtonsoft.Json;

namespace WealthFarm.SparkPost
{
    /// <summary>
    ///     Error is the representation of an error returned from SparkPost.
    /// </summary>
    public class Error
    {
        /// <summary>
        ///     Gets or sets the message.
        /// </summary>
        /// <value>A message indicating what went wrong.</value>
        [JsonProperty("message")]
        public string Message { get; internal set; }

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        /// <value>A more detailed description of the error.</value>
        [JsonProperty("description")]
        public string Description { get; internal set; }

        /// <summary>
        ///     Gets or sets the API error code.
        /// </summary>
        /// <value>The API error code.</value>
        [JsonProperty("code")]
        public string Code { get; internal set; }

        /// <summary>
        ///     Gets or sets the parameter.
        /// </summary>
        /// <value>The parameter that caused an error.</value>
        [JsonProperty("param")]
        public string Param { get; set; }

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        /// <value>The value of the bad parameter.</value>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}