using System;
namespace WealthFarm.SparkPost
{
    /// <summary>
    /// Account options.
    /// </summary>
    public class AccountOptions
    {
		/// <summary>
		/// Gets or sets the SMTP tracking default.
		/// </summary>
		/// <value>Account-level default for SMTP engagement tracking.</value>
		public bool SmtpTrackingDefault { get; set; }

		/// <summary>
		/// Gets or sets the rest tracking default.
		/// </summary>
		/// <value>Account-level default for REST API engagement tracking.</value>
		public bool RestTrackingDefault { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:WealthFarm.SparkPost.AccountOptions"/>
		/// transactional unsub.
		/// </summary>
		/// <value><c>true</c> to include List-Unsubscribe header for all transactional messages by default.</value>
		public bool TransactionalUnsub { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:WealthFarm.SparkPost.AccountOptions"/>
		/// transactional default.
		/// </summary>
		/// <value><c>true</c> to send messages as transactional by default.</value>
		public bool TransactionalDefault { get; set; }
	}
}
