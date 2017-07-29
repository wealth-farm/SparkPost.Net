namespace WealthFarm.SparkPost.Transmission
{
    /// <summary>
    ///     Address represents a recipient's full email address.
    /// </summary>
    public class Address
    {
        /// <summary>
        ///     Gets or sets the recipient's email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        ///     Gets or sets the recipient's name.
        /// </summary>
        public string Name { get; set; }
    }
}