namespace WebApplication1.Models
{
    public class OrderMessage
    {
        public string OrderMsgId { get; set; }
        public string From { get; set; }
        public string PartnerID { get; set; }
        public string ProductType { get; set; }
        public string ProductID { get; set; }
        public string ServiceList { get; set; }
        public string UpdateType { get; set; }
        public string UpdateTime { get; set; }
        public string EffectiveTime { get; set; }
        public string ExpiryTime { get; set; }
        public string ChannelID { get; set; }
        public string ShortMessage { get; set; }
        public string Status { get; set; }
        public string IsFree { get; set; }
        public string RateCode { get; set; }
        public string ProductPeriodType { get; set; }
        public string ActualValidate { get; set; }
        public string NextChargingTime { get; set; }
    }

}
