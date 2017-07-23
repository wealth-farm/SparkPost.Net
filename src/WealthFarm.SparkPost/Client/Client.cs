using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WealthFarm.SparkPost.Client
{
    /// <summary>
    /// SparkPost API client.
    /// </summary>
    public class Client : IClient
    {
        private readonly Configuration _config;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:WealthFarm.SparkPost.Client.Client"/> class.
        /// </summary>
        /// <param name="config">Config.</param>
        public Client(Configuration config)
        {
            _config = config;

            var handler = new HttpClientHandler
            {
                Proxy = config.Proxy,
                UseProxy = config.Proxy != null
            };

            Http = new HttpClient
            {
                BaseAddress = config.Endpoint,
                DefaultRequestHeaders = 
                {
                    Authorization = new AuthenticationHeaderValue(string.Empty, config.ApiKey)
                }
            };
        }

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>The configuration.</value>
        public Configuration Configuration => _config;

        /// <summary>
        /// Gets the HTTP client.
        /// </summary>
        /// <value>The HTTP client.</value>
        public HttpClient Http { get; private set; }
    }
}
