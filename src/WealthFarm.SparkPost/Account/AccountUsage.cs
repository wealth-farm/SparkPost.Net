using System;
using Newtonsoft.Json;

namespace WealthFarm.SparkPost
{
	/// <summary>
	///     Account usage details.
	/// </summary>
	public class AccountUsage
    {
	    /// <summary>
	    ///     Gets or sets the timestamp.
	    /// </summary>
	    /// <value>The date usage data was retrieved.</value>
	    public DateTime Timestamp { get; set; }

	    /// <summary>
	    ///     Gets or sets the day.
	    /// </summary>
	    /// <value>Daily usage report.</value>
	    [JsonProperty("account_usage_period")]
        public AccountUsagePeriod Day { get; set; }

	    /// <summary>
	    ///     Gets or sets the month.
	    /// </summary>
	    /// <value>Monthly usage report.</value>
	    [JsonProperty("account_usage_period")]
        public AccountUsagePeriod Month { get; set; }
    }
}