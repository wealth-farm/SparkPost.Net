using System;
using System.Net;

namespace WealthFarm.SparkPost
{
    /// <summary>
    /// SparkPost client configuration.
    /// </summary>
    public sealed class Configuration
    {
        private const string SparkPostEndpoint = "https://api.sparkpost.com";

        /// <summary>
        /// Initializes a new instance of the <see cref="T:WealthFarm.SparkPost.Client.Configuration"/> class.
        /// </summary>
        /// <param name="endpoint">SparkPost endpoint.</param>
        public Configuration(string endpoint = SparkPostEndpoint)
        {
            Endpoint = new Uri(endpoint);
        }

        /// <summary>
        /// Gets the endpoint.
        /// </summary>
        /// <value>The SparkPost endpoint.</value>
        public Uri Endpoint { get; private set; }

        /// <summary>
        /// Gets or sets the API key.
        /// </summary>
        /// <value>Your SparkPost API key.</value>
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the web proxy, if a proxy is to be used.
        /// </summary>
        /// <value>The web proxy.</value>
        public IWebProxy Proxy { get; set; }
    }
}
