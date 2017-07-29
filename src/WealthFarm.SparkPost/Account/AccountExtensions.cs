using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WealthFarm.SparkPost.Exceptions;

namespace WealthFarm.SparkPost
{
    /// <summary>
    ///     Extensions for account-related operations.
    /// </summary>
    public static class AccountExtensions
    {
        private const string AccountPath = "/api/v1/account";

        /// <summary>
        ///     Retrieve account information.
        /// </summary>
        /// <returns>Details about a SparkPost account.</returns>
        /// <param name="client">SparkPost Client.</param>
        /// <param name="includeUsage">If set to <c>true</c> include usage details.</param>
        public static async Task<Account> GetAccountAsync(this IClient client, bool includeUsage = false)
        {
            var request = new Request
            {
                Method = HttpMethod.Get,
                Uri = new Uri(client.Configuration.Endpoint, $"{AccountPath}?usage={includeUsage}")
            };

            var response = await client.SendAsync(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new SparkPostException("Get account failed", (int) response.StatusCode, response.Errors);

            var result = await response.ReadContentAsync<SingleResult<Account>>();
            return result.Results;
        }

        /// <summary>
        ///     Retrieve account information.
        /// </summary>
        /// <returns>Details about a SparkPost account.</returns>
        /// <param name="client">SparkPost Client.</param>
        /// <param name="includeUsage">If set to <c>true</c> include usage details.</param>
        public static Account GetAccount(this IClient client, bool includeUsage = false)
        {
            return client.GetAccountAsync(includeUsage).GetAwaiter().GetResult();
        }

        /// <summary>
        ///     Updates account options
        /// </summary>
        /// <remarks>Updates only apply to account options. Any other changes will be ignored.</remarks>
        /// <returns>A task.</returns>
        /// <param name="client">Client.</param>
        /// <param name="account">Updated Account.</param>
        public static async Task UpdateAccountAsync(this IClient client, Account account)
        {
            var request = new Request
            {
                Method = HttpMethod.Put,
                Uri = new Uri(client.Configuration.Endpoint, AccountPath),
                Content = account.ToJsonContent()
            };

            var response = await client.SendAsync(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new SparkPostException("Get account failed", (int) response.StatusCode, response.Errors);
        }

        /// <summary>
        ///     Updates account options
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