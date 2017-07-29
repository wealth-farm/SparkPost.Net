using System.Threading.Tasks;

namespace WealthFarm.SparkPost
{
    /// <summary>
    ///     Interface for SparkPost client implementations.
    /// </summary>
    public interface IClient
    {
        /// <summary>
        ///     Gets the SparkPost API configuration.
        /// </summary>
        /// <value>The SparkPost API configuration.</value>
        Configuration Configuration { get; }

        /// <summary>
        ///     Sends a client request.
        /// </summary>
        /// <returns>A client response.</returns>
        /// <param name="request">The request.</param>
        /// <typeparam name="IContentType">The response entity type.</typeparam>
        Task<Response> SendAsync(Request request);
    }
}