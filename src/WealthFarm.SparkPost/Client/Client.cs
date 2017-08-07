using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace WealthFarm.SparkPost
{
    /// <summary>
    ///     SparkPost API client.
    /// </summary>
    public class Client : IClient
    {
        private readonly HttpClient _http;
        private readonly JsonSerializer _serializer;

        /// <summary>
        ///     Initializes a new instance of the <see cref="T:WealthFarm.SparkPost.Client.Client" /> class.
        /// </summary>
        /// <param name="config">Config.</param>
        public Client(Configuration config)
        {
            Configuration = config;
            _serializer = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                }
            };

            var handler = new HttpClientHandler
            {
                Proxy = config.Proxy,
                UseProxy = config.Proxy != null
            };

            _http = new HttpClient(handler);
            _http.BaseAddress = config.Endpoint;
            _http.DefaultRequestHeaders.Add("Authorization", config.ApiKey);
        }

        /// <summary>
        ///     Gets the configuration.
        /// </summary>
        /// <value>The configuration.</value>
        public Configuration Configuration { get; }

        /// <summary>
        ///     Sends a client request.
        /// </summary>
        /// <returns>A client response.</returns>
        /// <param name="request">The request.</param>
        public async Task<Response> SendAsync(Request request)
        {
            var message = new HttpRequestMessage
            {
                Method = request.Method,
                RequestUri = request.Uri,
                Content = request.Content.ToJsonContent(_serializer)
            };

            var response = await _http.SendAsync(message, request.CompletionOption, request.CancellationToken);
            var result = new Response(response.StatusCode, response.Content);

            if (!response.IsSuccessStatusCode && response.StatusCode != HttpStatusCode.NotFound)
            {
                using (var stream = await response.Content.ReadAsStreamAsync())
                using (var reader = new JsonTextReader(new StreamReader(stream)))
                {
                    var error = _serializer.Deserialize<ErrorResponse>(reader);
                    result.WithErrors(error.Errors);
                }
            }

            return result;
        }
    }
}