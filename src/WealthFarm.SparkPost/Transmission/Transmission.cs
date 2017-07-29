using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WealthFarm.SparkPost.Transmission
{
    /// <summary>
    ///     A transmission is a collection of messages belonging to the same campaign.
    /// </summary>
    public class Transmission
    {
        private string _campaignId;
        private string _description;

	    /// <summary>
	    ///     Gets or sets the description.
	    /// </summary>
	    /// <remarks>The maximum allowable length is 1024 bytes.</remarks>
	    /// <exception cref="ArgumentException">Thrown if value is longer the 1024 bytes.</exception>
	    public string Description
        {
            get => _description;
            set
            {
                if (Encoding.Unicode.GetByteCount(value) > 1024)
                    throw new ArgumentException("maximum allowable length is 1024 bytes", "Description");

                _description = value;
            }
        }

	    /// <summary>
	    ///     Gets or sets the campaign ID.
	    /// </summary>
	    /// <remarks>The maximum allowable length is 64 bytes.</remarks>
	    /// <exception cref="ArgumentException">Thrown if value is longer than 64 bytes.</exception>
	    [JsonProperty("campaign_id")]
        public string CampaignId
        {
            get => _campaignId;
            set
            {
                if (Encoding.Unicode.GetByteCount(value) > 64)
                    throw new ArgumentException("maximum allowable length is 64 bytes", "CampaignId");

                _campaignId = value;
            }
        }

	    /// <summary>
	    ///     Gets or sets the transmission options.
	    /// </summary>
	    public TransmissionOptions Options { get; set; }

	    /// <summary>
	    ///     Gets or sets the return path.
	    /// </summary>
	    /// <value>The email address to use for envelope FROM.</value>
	    [JsonProperty("return_path")]
        public string ReturnPath { get; set; }

	    /// <summary>
	    ///     Gets or sets metadata.
	    /// </summary>
	    public IDictionary<string, object> Metadata { get; set; }

	    /// <summary>
	    ///     Gets or sets substitution data.
	    /// </summary>
	    [JsonProperty("substitution_data")]
        public IDictionary<string, object> SubstitutionData { get; set; }

	    /// <summary>
	    ///     Gets or sets recipients.
	    /// </summary>
	    /// <remarks>
	    ///     The type of <c>Recipients</c> changes depending on the receipient type.
	    ///     Transmissions to a recipient list should contain a <see cref="RecipientList" />
	    ///     object. Individual recipients can be speicified by using a list of <see cref="Recipient" />s.
	    /// </remarks>
	    public object Recipients { get; internal set; }

	    /// <summary>
	    ///     Gets or sets the content.
	    /// </summary>
	    public TransmissionContent Content { get; set; }
    }
}