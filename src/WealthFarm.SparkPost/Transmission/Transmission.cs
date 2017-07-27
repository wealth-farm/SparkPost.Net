using System;
using System.Collections.Generic;

namespace WealthFarm.SparkPost.Transmission
{
	/// <summary>
	/// A transmission is a collection of messages belonging to the same campaign.
	/// </summary>
	public class Transmission
    {
        public TransmissionOptions Options { get; set; }
        public string Description { get; set; }     // TODO max-length 64
		public string CampaignId { get; set; }      // TODO max-length 1024
        public string ReturnPath { get; set; }
        public IDictionary<string, object> Metadata { get; set; }
        public IDictionary<string, object> SubstitutionData { get; set; }
        public object Recipients { get; internal set; }
		// TODO inline_images
	    // TODO attachments
    }
}
