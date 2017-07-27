using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WealthFarm.SparkPost.Client;

namespace WealthFarm.SparkPost.Transmission
{
    public static class TransmissionExtensions
    {
        private const string TransmissionPath = "/transmission";

        private static Transmission WithRecipients(this Transmission transmission, IEnumerable<Recipient> recipients)
        {
            transmission.Recipients = recipients;
            return transmission;
        }

		private static Transmission WithRecipientList(this Transmission transmission, string listId)
		{
            transmission.Recipients = new RecipientList { ListId = listId };
			return transmission;
		}

        /// <summary>
        /// Creates a transmission.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="transmisison">The transmisison.</param>
        /// <param name="maxRecipientErrors">The max number of recipient errors.</param>
        public static async Task CreateTransmission(this IClient client, Transmission transmisison, int? maxRecipientErrors = null)
        {
            //         var uri = new Uri($"{TransmissionPath}?num_rcpt_errors={maxRecipientErrors}");
            //         var response = await client.Http.PostAsync(uri, transmisison.ToJsonContent());

            //using (var stream = await response.Content.ReadAsStreamAsync())
            //using (var reader = new JsonTextReader(new StreamReader(stream)))
            //{
            //	var serializer = new JsonSerializer();

            //	//if (response.IsSuccessStatusCode)
            //	//{
            //	//	return serializer.Deserialize<Account>(reader);
            //	//}
            //	//else if (response.StatusCode == HttpStatusCode.NotFound)
            //	//{
            //	//	return null;
            //	//}

            //	//var error = serializer.Deserialize<ErrorResponse>(reader);
            //	//throw new SparkPostException("Get account failed", (int)response.StatusCode, error.Errors);
            //}
            throw new NotImplementedException();
        }
    }
}
