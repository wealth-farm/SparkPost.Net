﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WealthFarm.SparkPost.Exceptions;

namespace WealthFarm.SparkPost.Transmission
{
    public static class TransmissionExtensions
    {
        private const string TransmissionPath = "/transmission";

        /// <summary>
        ///     Sets the recipients for a transmission.
        /// </summary>
        /// <param name="transmission">The transmission.</param>
        /// <param name="recipients">A list of recipients.</param>
        /// <returns>The transmission instance, which can be used for chaining.</returns>
        private static Transmission WithRecipients(this Transmission transmission, IEnumerable<Recipient> recipients)
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
        private static Transmission WithRecipientList(this Transmission transmission, string listId)
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
            var request = new Request
            {
                Uri = new Uri($"{TransmissionPath}?num_rcpt_errors={maxRecipientErrors}"),
                Method = HttpMethod.Post,
                Content = transmisison.ToJsonContent()
            };

            var response = await client.SendAsync(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new SparkPostException("Get account failed", (int) response.StatusCode, response.Errors);

            return await response.ReadContentAsync<TransmissionResult>();
        }
    }
}