using System;

namespace WealthFarm.SparkPost
{
	/// <summary>
	///     Account usage details over a period of time.
	/// </summary>
	public class AccountUsagePeriod
    {
	    /// <summary>
	    ///     Gets or sets the total messages sent in this period.
	    /// </summary>
	    /// <value>The total messages sent in this period.</value>
	    public long Used { get; set; }

	    /// <summary>
	    ///     Gets or sets the total available messages in this period.
	    /// </summary>
	    /// <value>The total available messages in this period.</value>
	    public long Limit { get; set; }

	    /// <summary>
	    ///     Gets or sets the date when this period started.
	    /// </summary>
	    /// <value>The date when this period started.</value>
	    public DateTime Start { get; set; }

	    /// <summary>
	    ///     Gets or sets the date when this period ended.
	    /// </summary>
	    /// <value>The date when this period ended.</value>
	    public DateTime End { get; set; }
    }
}