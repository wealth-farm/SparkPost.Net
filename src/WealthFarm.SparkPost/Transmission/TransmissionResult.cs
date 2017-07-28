namespace WealthFarm.SparkPost.Transmission
{
    public class TransmissionResult
    {
        public string Id { get; set; }
        public int TotalRejectedRecipients { get; set; }
        public int TotalAcceptedRecipients { get; set; }
    }
}