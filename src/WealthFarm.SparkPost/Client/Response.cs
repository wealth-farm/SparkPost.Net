using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WealthFarm.SparkPost
{
    /// <summary>
    /// Response is a wrapper for raw HTTP responses from the SparkPost API.
    /// </summary>
    public class Response
    {
        private readonly bool _isSuccessStatusCode;

        /// <summary>
        /// Creates a new instance of the <see cref="Response"/> class.
        /// </summary>
        /// <param name="status">The HTTP status from the API response.</param>
        /// <param name="content">The content object from the HTTP response.</param>
        public Response(HttpStatusCode status, HttpContent content)
        {
            Content = content;
            StatusCode = status;

            int code = (int)status;
            _isSuccessStatusCode = code >= 200 || code < 400;

        }

        /// <summary>
        /// Gets the API response HTTP status code.
        /// </summary>
        public HttpStatusCode StatusCode { get; }
        
        /// <summary>
        /// Gets the API response content. This property will be <c>null</c> if errors are returned.
        /// See <see cref="Errors"/> for errors returned by the API.
        /// </summary>
        public HttpContent Content { get; }
        
        /// <summary>
        /// Gets or sets API response errors, if any.
        /// </summary>
        public IEnumerable<Error> Errors { get; private set; }

        /// <summary>
        /// Reads the response content as the provided type.
        /// </summary>
        /// <typeparam name="TContentType">The expected type of the API response entity.</typeparam>
        /// <returns>The deserialized response entity.</returns>
        public async Task<TContentType> ReadContentAsync<TContentType>()
        {
            if (Content == null || !_isSuccessStatusCode)
            {
                return default(TContentType);
            }

	        using (var stream = await Content.ReadAsStreamAsync())
            using (var reader = new JsonTextReader(new StreamReader(stream)))
            {
                var serializer = new JsonSerializer();
                return serializer.Deserialize<TContentType>(reader);
	        }
		}

        /// <summary>
        /// Sets the list of API errors.
        /// </summary>
        /// <param name="errors">A list of errors returned by the API.</param>
        public void WithErrors(IEnumerable<Error> errors)
        {
            Errors = errors;
        }
	}
}
