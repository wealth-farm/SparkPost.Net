using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WealthFarm.SparkPost.Exceptions;

namespace WealthFarm.SparkPost
{
    /// <summary>
    ///     Extension methods for transmissions.
    /// </summary>
    public static class TransmissionExtensions
    {
        private const string TransmissionPath = "/api/v1/transmissions";

        /// <summary>
        ///     Sets the recipients for a transmission.
        /// </summary>
        /// <param name="transmission">The transmission.</param>
        /// <param name="recipients">A list of recipients.</param>
        /// <returns>The transmission instance, which can be used for chaining.</returns>
        public static Transmission WithRecipients(this Transmission transmission, IEnumerable<Recipient> recipients)
        {
            transmission.Recipients = recipients;
            return transmission;
        }

        /// <summary>
        ///     Sets the ID of the stored recipient list to use.
        /// </summary>
        /// <param name="transmission">The transmission.</param>
        /// <param name="listId">The recipient list ID.</param>
        /// <returns>The transmission instance, which can be used for chaining.</returns>
        public static Transmission WithRecipientList(this Transmission transmission, string listId)
        {
            transmission.Recipients = new RecipientList {ListId = listId};
            return transmission;
        }

        /// <summary>
        ///     Creates a transmission.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="transmisison">The transmisison.</param>
        /// <param name="maxRecipientErrors">The max number of recipient errors.</param>
        public static async Task<TransmissionResult> CreateTransmission(this IClient client, Transmission transmisison,
            int? maxRecipientErrors = null)
        {
            var query = maxRecipientErrors.HasValue? $"?num_rcpt_errors={maxRecipientErrors}" : string.Empty;
            var request = new Request
            {
                Uri = new Uri(client.Configuration.Endpoint, $"{TransmissionPath}{query}"),
                Method = HttpMethod.Post,
                Content = transmisison
            };

            var response = await client.SendAsync(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new SparkPostException("Create transmission failed", (int) response.StatusCode, response.Errors);

            return (await response.ReadContentAsync<SingleResult<TransmissionResult>>()).Results;
        }
    }
}