namespace WealthFarm.SparkPost
{
    /// <summary>
    /// SingleResult is a wrapper for a result entity returned by the API.
    /// </summary>
    /// <typeparam name="TItemType"></typeparam>
    public class SingleResult<TItemType>
    {   
        /// <summary>
        /// Gets or sets the response results field.
        /// </summary>
        public TItemType Results { get; set; }
    }
}