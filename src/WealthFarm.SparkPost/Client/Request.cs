using System;
using System.Net.Http;
using System.Threading;

namespace WealthFarm.SparkPost
{
    /// <summary>
    ///     Request is a generic envelope used to describe a SparkPost request.
    /// </summary>
    public class Request
    {
        /// <summary>
        ///     Gets or sets the HTTP method.
        /// </summary>
        public HttpMethod Method { get; set; }

        /// <summary>
        ///     Gets or sets the relative URI for the request.
        /// </summary>
        public Uri Uri { get; set; }

        /// <summary>
        ///     Gets or sets an optional content entity.
        /// </summary>
        public object Content { get; set; }

        /// <summary>
        ///     Gets or sets an optional cancellation token.
        /// </summary>
        public CancellationToken CancellationToken { get; set; }

        /// <summary>
        ///     Gets or sets the HTTP completion option.
        /// </summary>
        public HttpCompletionOption CompletionOption { get; set; }
    }
}