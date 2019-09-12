namespace BackEndApplication.Models
{
    public class HumanName
    {
        public string Use { get; set; } // usual | official | temp | nickname | anonymous | old | maiden
        public string Text { get; set; }
        public string Family { get; set; }
        public string[] Given { get; set; }
        public string[] Prefix { get; set; }
        public string[] Suffix { get; set; }
        public TimePeriod Period { get; set; }
    }
}
