using System.Collections.Generic;
using Newtonsoft.Json;

namespace WealthFarm.SparkPost.Transmission
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
        public Address From { get; set; }

        /// <summary>
        ///     Gets or sets the subject line.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        ///     Gets or sets the reply-to value.
        /// </summary>
        public string ReplyTo { get; set; }

        /// <summary>
        ///     Gets or sets the transmission headers.
        /// </summary>
        public IDictionary<string, string> Headers { get; set; }

        /// <summary>
        ///     Gets or sets a list of attachments
        /// </summary>
        public IEnumerable<Attachment> Attachments { get; set; }

        /// <summary>
        ///     Gets or set a list of inline images.
        /// </summary>
        [JsonProperty("inline_images")]
        public IEnumerable<Attachment> InlineImages { get; set; }

        /// <summary>
        ///     Gets or sets the HTML content.
        /// </summary>
        public string Html { get; set; }

        /// <summary>
        ///     Gets or sets the text content.
        /// </summary>
        public string Text { get; set; }
    }
}