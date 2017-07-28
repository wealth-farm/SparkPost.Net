using System.Collections.Generic;

namespace WealthFarm.SparkPost.Transmission
{
    public class TransmissionContent
    {
        public Address From { get; set; }
        public string Subject { get; set; }
        public string ReplyTo { get; set; }
        public IDictionary<string, string> Headers { get; set; }
        public string Html { get; set; }
        public string Text { get; set; }
        public string TemplateId { get; set; }
        public bool UseDraftTemplate { get; set; }
    }
}