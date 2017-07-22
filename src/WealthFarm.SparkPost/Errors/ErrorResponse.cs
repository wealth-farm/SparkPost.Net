using System.Collections.Generic;

namespace WealthFarm.SparkPost
{
    /// <summary>
    /// ErrorResponse is the API error response.
    /// </summary>
    public class ErrorResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:WealthFarm.SparkPost.Errors.ErrorResponse"/> class.
        /// </summary>
        public ErrorResponse()
        {
        }

        /// <summary>
        /// Gets or sets the response errors.
        /// </summary>
        /// <value>A list of API errors.</value>
        public IEnumerable<Error> Errors { get; internal set; }
    }
}
