using System;
namespace WealthFarm.SparkPost.Transmission
{
    /// <summary>
    /// Transmission options.
    /// </summary>
    public class TransmissionOptions
    {
		/// <summary>
		/// Gets or sets the start time.
		/// </summary>
		/// <value>Delay generation of messages until this datetime.</value>
		public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not to enable
        /// <see cref="T:WealthFarm.SparkPost.Transmission.TransmissionOptions"/> open tracking
        /// for this transmission (defaults to true). If not present, the value at the template
        /// level is used.
        /// </summary>
        /// <value><c>true</c> to enable open tracking; <c>false</c> to disable.</value>
        public bool? OpenTracking { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not
		/// <see cref="T:WealthFarm.SparkPost.Transmission.TransmissionOptions"/> click tracking.
        /// is enabled for this transmission (defaults to true). If not present, the value at the
        /// template level is used.
		/// </summary>
		/// <value><c>true</c> to enable click tracking; <c>false</c> to disable.</value>
		public bool? ClickTracking { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the message
		/// <see cref="T:WealthFarm.SparkPost.Transmission.TransmissionOptions"/> is transactional
        /// for unsubscribe and suppression purposes.
		/// </summary>
		/// <value><c>true</c> if transactional; otherwise, <c>false</c>.</value>
		public bool? Transactional { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not to use the sandbox sending domain.
        /// </summary>
        /// <value><c>true</c> if sandbox; otherwise, <c>false</c>.</value>
        public bool? Sandbox { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to
		/// <see cref="T:WealthFarm.SparkPost.Transmission.TransmissionOptions"/> skip customer
		/// suppression rules for this transmission.
		/// </summary>
		/// <value><c>true</c> to skip suppression rules; otherwise, <c>false</c>.</value>
		public bool? SkipSuppression { get; set; }

		/// <summary>
		/// Gets or sets the ID of a dedicated IP pool associated with the account.
		/// </summary>
		/// <value>The ID of a dedicated IP pool associated with the account.</value>
		public string IpPool { get; set; }

		/// <summary>
		/// Gets or sets whether or not to perform CSS inlining in HTML content.
		/// </summary>
		/// <value>The inline css.</value>
		public bool? InlineCss { get; set; }
    }
}
