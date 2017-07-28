using System;
using Newtonsoft.Json;

namespace WealthFarm.SparkPost
{
	/// <summary>
	///     SparkPost account.
	/// </summary>
	public class Account
    {
	    /// <summary>
	    ///     Gets or sets the name of the company.
	    /// </summary>
	    /// <value>The Account holder company name.</value>
	    [JsonProperty("company_name")]
        public string CompanyName { get; set; }

	    /// <summary>
	    ///     Gets or sets the country code.
	    /// </summary>
	    /// <value>The account holder 2-letter country code..</value>
	    [JsonProperty("country_code")]
        public string CountryCode { get; set; }

	    /// <summary>
	    ///     Gets or sets the created date.
	    /// </summary>
	    /// <value>The date when the account was created.</value>
	    public DateTime Created { get; set; }

	    /// <summary>
	    ///     Gets or sets the updated date.
	    /// </summary>
	    /// <value>The date that account details were last updated.</value>
	    public DateTime Updated { get; set; }

	    /// <summary>
	    ///     Gets or sets the anniversary date.
	    /// </summary>
	    /// <value>The date of billing anniversary.</value>
	    [JsonProperty("anniversary_date")]
        public DateTime AnniversaryDate { get; set; }

	    /// <summary>
	    ///     Gets or sets the account status.
	    /// </summary>
	    /// <value>The account status.</value>
	    public string Status { get; set; }

	    /// <summary>
	    ///     The datetime that account status was last updated.
	    /// </summary>
	    [JsonProperty("status_updated")]
        public DateTime StatusUpdated { get; set; }

	    /// <summary>
	    ///     Gets or sets the status reason code.
	    /// </summary>
	    /// <value>The current subscription details.</value>
	    [JsonProperty("status_reason_code")]
        public string StatusReasonCode { get; set; }

	    /// <summary>
	    ///     Gets or sets the subscription.
	    /// </summary>
	    /// <value>The subscription details.</value>
	    public AccountSubscription Subscription { get; set; }

	    /// <summary>
	    ///     Gets or sets the pending subscription.
	    /// </summary>
	    /// <value>The pending subscription.</value>
	    [JsonProperty("pending_subscription")]
        public AccountSubscription PendingSubscription { get; set; }

	    /// <summary>
	    ///     Gets or sets the options.
	    /// </summary>
	    /// <value>The account-level tracking settings.</value>
	    public AccountOptions Options { get; set; }

	    /// <summary>
	    ///     Gets or sets the account usage.
	    /// </summary>
	    /// <value>
	    ///     The account quota usage details. Specify <c>true</c> for <c>includeUsage</c>
	    ///     in account query to include usage info.
	    /// </value>
	    public AccountUsage Usage { get; set; }
    }
}