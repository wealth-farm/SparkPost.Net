using System.Net.Http;

namespace WealthFarm.SparkPost.Client
{
    /// <summary>
    /// Interface for SparkPost client implementations.
    /// </summary>
    public interface IClient
    {
		/// <summary>
		/// Gets the SparkPost API configuration.
		/// </summary>
		/// <value>The SparkPost API configuration.</value>
		Configuration Configuration { get; }

        /// <summary>
        /// Gets the client HTTP client.
        /// </summary>
        /// <value>The HTTP client.</value>
        HttpClient Http { get; }
    }
}
