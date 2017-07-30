using System.IO;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace WealthFarm.SparkPost
{
    /// <summary>
    ///     Network utility extensions.
    /// </summary>
    public static class NetworkUtilityExtensions
    {
        /// <summary>
        ///     Creates an <code>HttpContent</code> containing the JSON representation of the provided entity.
        /// </summary>
        /// <returns>A JSON-y content.</returns>
        /// <param name="entity">Entity.</param>
        /// <param name="serializer">The serializer to use.</param>
        public static StringContent ToJsonContent(this object entity, JsonSerializer serializer)
        {
            if (entity == null)
                return null;

            using (var sw = new StringWriter())
            using (var writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, entity);
                return new StringContent(sw.ToString(), Encoding.UTF8, "application/json");
            }
        }
    }
}