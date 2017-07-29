namespace WealthFarm.SparkPost.Transmission
{
    public class TemplateContent : TransmissionContent
    {
        /// <summary>
        ///     Gets or sets the template ID of the stored template to use.
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether to use the draft template version.
        /// </summary>
        public bool UseDraftTemplate { get; set; }
    }
}