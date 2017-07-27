using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WealthFarm.SparkPost.Client
{
    /// <summary>
    /// SparkPost API client.
    /// </summary>
    public class Client : IClient
    {
        private readonly Configuration _config;
        private readonly HttpClient _http;

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

            _http = new HttpClient
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
		/// Sends a client request.
		/// </summary>
		/// <returns>A client response.</returns>
		/// <param name="request">The request.</param>
		/// <typeparam name="IContentType">The response entity type.</typeparam>
		public async Task<Response> SendAsync(Request request)
        {
            var message = new HttpRequestMessage
            {
                Method = request.Method,
                RequestUri = request.Uri,
                Content = request.Content.ToJsonContent()
            };

            var response = await _http.SendAsync(message, request.CompletionOption, request.CancellationToken);
            var result = new Response(response.StatusCode, response.Content);

			if (!response.IsSuccessStatusCode && response.StatusCode != HttpStatusCode.NotFound)
			{
				using (var stream = await response.Content.ReadAsStreamAsync())
				using (var reader = new JsonTextReader(new StreamReader(stream)))
				{
				    var serializer = new JsonSerializer();
					var error = serializer.Deserialize<ErrorResponse>(reader);
                    result.WithErrors(error.Errors);
			    }
			}

            return result;
		}
    }
}
