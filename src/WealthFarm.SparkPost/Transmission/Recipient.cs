using System.Collections.Generic;

namespace WealthFarm.SparkPost.Transmission
{
    /// <summary>
    ///     Recipient represents a single recipient.
    /// </summary>
    public class Recipient
    {
        /// <summary>
        ///     Gets or sets the recipient's address.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        ///     Gets or sets any tags.
        /// </summary>
        public string[] Tags { get; set; }

        /// <summary>
        ///     Gets or sets metadata.
        /// </summary>
        public IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        ///     Gets or sets substitution data.
        /// </summary>
        public IDictionary<string, object> SubstitutionData { get; set; }
    }
}