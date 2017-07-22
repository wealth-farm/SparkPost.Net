using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace WealthFarm.SparkPost
{
    /// <summary>
    /// Network utility extensions.
    /// </summary>
    public static class NetworkUtilityExtensions
    {
		/// <summary>
		/// Creates an <code>HttpContent</code> containing the JSON representation of the provided entity.
		/// </summary>
		/// <returns>A JSON-y content.</returns>
		/// <param name="entity">Entity.</param>
		public static StringContent ToJsonContent(this object entity)
        {
            return new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");
        }
    }
}
