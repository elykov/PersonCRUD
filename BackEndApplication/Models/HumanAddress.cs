namespace BackEndApplication.Models
{
    public class HumanAddress
    {
        public string Use { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Line { get; set; }
        public TimePeriod Period { get; set; }
    }
}
