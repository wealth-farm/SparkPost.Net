using System.Collections.Generic;

namespace WealthFarm.SparkPost
{
    /// <summary>
    ///     ErrorResponse is the API error response.
    /// </summary>
    public class ErrorResponse
    {
        /// <summary>
        ///     Gets or sets the response errors.
        /// </summary>
        /// <value>A list of API errors.</value>
        public IEnumerable<Error> Errors { get; internal set; }
    }
}