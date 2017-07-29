using System;
using System.Collections.Generic;

namespace WealthFarm.SparkPost.Exceptions
{
    /// <summary>
    ///     SparkPostException is an exception for errors resulting from SparkPost
    ///     API errors.
    /// </summary>
    public class SparkPostException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:WealthFarm.SparkPost.Exceptions.SparkPostException" /> class.
        /// </summary>
        /// <param name="message">A message.</param>
        public SparkPostException(string message)
            : base(message)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="T:WealthFarm.SparkPost.Exceptions.SparkPostException" /> class.
        /// </summary>
        /// <param name="message">A message.</param>
        /// <param name="innerException">Inner exception.</param>
        public SparkPostException(string message, Exception innerException = null)
            : base(message, innerException)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="T:WealthFarm.SparkPost.Exceptions.SparkPostException" /> class.
        /// </summary>
        /// <param name="message">A message.</param>
        /// <param name="status">HTTP status code.</param>
        /// <param name="errors">Errors.</param>
        /// <param name="innerException">Inner exception.</param>
        public SparkPostException(string message, int status, IEnumerable<Error> errors,
            Exception innerException = null)
            : base(message, innerException)
        {
            Status = status;
            Errors = errors;
        }

        /// <summary>
        ///     Gets the status.
        /// </summary>
        /// <value>The HTTP status returned by SparkPost.</value>
        public int? Status { get; }

        /// <summary>
        ///     Gets the errors.
        /// </summary>
        /// <value>A list of errors returned by SparkPost.</value>
        public IEnumerable<Error> Errors { get; }
    }
}