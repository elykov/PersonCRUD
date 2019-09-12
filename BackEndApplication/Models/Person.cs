namespace BackEndApplication.Models
{
    public class BackboneElement
    {
        public string Reference { get; set; } // Literal reference, Relative, internal or absolute URL
        public string Type { get; set; } // Type the reference refers to (e.g. "Patient")
        public string Display { get; set; } //Text alternative for the resource
    }

    public class Person
    {
        public bool Active { get; set; }
        public uint Id { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }
        public string ResourceType { get; set; }
        public HumanName Name { get; set; }
        public ContactPoint Telecom { get; set; }
        public HumanAddress Address { get; set; }
        public BackboneElement Link { get; set; }
    }
}
