using Newtonsoft.Json;

namespace WealthFarm.SparkPost
{
    public class TemplateContent : TransmissionContent
    {
        /// <summary>
        ///     Gets or sets the template ID of the stored template to use.
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether to use the draft template version.
        /// </summary>
        [JsonProperty("use_draft_template")]
        public bool UseDraftTemplate { get; set; }
    }
}