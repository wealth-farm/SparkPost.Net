using System.Collections.Generic;
using Newtonsoft.Json;

namespace WealthFarm.SparkPost
{
    /// <summary>
    ///     InlineContent allows HTML and text content to be specified inline.
    /// </summary>
    /// <remarks>The maximum allowable content size is 20MB.</remarks>
    public class InlineContent : TransmissionContent
    {
        /// <summary>
        ///     Gets or sets the from address.
        /// </summary>
        [JsonProperty("from")]
        public Address From { get; set; }

        /// <summary>
        ///     Gets or sets the subject line.
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        ///     Gets or sets the reply-to value.
        /// </summary>
        [JsonProperty("reply_to")]
        public string ReplyTo { get; set; }

        /// <summary>
        ///     Gets or sets the transmission headers.
        /// </summary>
        [JsonProperty("headers")]
        public IDictionary<string, string> Headers { get; set; }

        /// <summary>
        ///     Gets or sets a list of attachments
        /// </summary>
        [JsonProperty("attachments")]
        public IEnumerable<Attachment> Attachments { get; set; }

        /// <summary>
        ///     Gets or set a list of inline images.
        /// </summary>
        [JsonProperty("inline_images")]
        public IEnumerable<Attachment> InlineImages { get; set; }

        /// <summary>
        ///     Gets or sets the HTML content.
        /// </summary>
        [JsonProperty("html")]
        public string Html { get; set; }

        /// <summary>
        ///     Gets or sets the text content.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}