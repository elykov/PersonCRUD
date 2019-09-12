namespace BackEndApplication.Models
{
    public class ContactPoint
    {
        public string System { get; set; }
        public string Value { get; set; }
        public string Use { get; set; }
        public byte? Rank { get; set; }
        public TimePeriod Period { get; set; }
    }
}
