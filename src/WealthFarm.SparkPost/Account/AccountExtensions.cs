﻿using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WealthFarm.SparkPost.Client;
using WealthFarm.SparkPost.Exceptions;

namespace WealthFarm.SparkPost
{
    /// <summary>
    /// Extensions for account-related operations.
    /// </summary>
    public static class AccountExtensions
    {
        private const string AccountPath = "/account";

        /// <summary>
        /// Retrieve account information.
        /// </summary>
        /// <returns>Details about a SparkPost account.</returns>
        /// <param name="client">SparkPost Client.</param>
        /// <param name="includeUsage">If set to <c>true</c> include usage details.</param>
        public static async Task<Account> GetAccountAsync(this IClient client, bool includeUsage = false)
        {
            var uri = new Uri($"{AccountPath}?usage={includeUsage}");
            var response = await client.Http.GetAsync(uri);

            using (var stream = await response.Content.ReadAsStreamAsync())
			using (var reader = new JsonTextReader(new StreamReader(stream)))
			{
				var serializer = new JsonSerializer();

				if (response.IsSuccessStatusCode)
				{
                    return serializer.Deserialize<Account>(reader);
                } 
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                var error = serializer.Deserialize<ErrorResponse>(reader);
                throw new SparkPostException("Get account failed", (int)response.StatusCode, error.Errors); 
			}
        }

		/// <summary>
		/// Retrieve account information.
		/// </summary>
		/// <returns>Details about a SparkPost account.</returns>
		/// <param name="client">SparkPost Client.</param>
		/// <param name="includeUsage">If set to <c>true</c> include usage details.</param>
		public static Account GetAccount(this IClient client, bool includeUsage = false)
        {
            return client.GetAccountAsync(includeUsage).GetAwaiter().GetResult();
        }

		/// <summary>
		/// Updates account options
		/// </summary>
        /// <remarks>Updates only apply to account options. Any other changes will be ignored.</remarks>
		/// <returns>A task.</returns>
		/// <param name="client">Client.</param>
		/// <param name="account">Updated Account.</param>
		public static async Task UpdateAccountAsync(this IClient client, Account account)
        {
			var uri = new Uri(AccountPath);
            var response = await client.Http.PutAsync(uri, account.ToJsonContent());

			if (!response.IsSuccessStatusCode)
			{
				using (var stream = await response.Content.ReadAsStreamAsync())
				using (var reader = new JsonTextReader(new StreamReader(stream)))
				{
					var serializer = new JsonSerializer();
					var error = serializer.Deserialize<ErrorResponse>(reader);
					throw new SparkPostException("Get account failed", (int)response.StatusCode, error.Errors);
				}	
			}
        }

		/// <summary>
		/// Updates account options
		/// </summary>
		/// <remarks>Updates only apply to account options. Any other changes will be ignored.</remarks>
		/// <returns>A task.</returns>
		/// <param name="client">Client.</param>
		/// <param name="account">Updated Account.</param>
		public static void UpdateAccount(this IClient client, Account account)
		{
            client.UpdateAccountAsync(account).Wait();
		}
    }
}
