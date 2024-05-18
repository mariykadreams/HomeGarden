using System;
using System.Xml.Serialization;

namespace HomeGarden.Plants
{
    [XmlInclude(typeof(Vegetable))]
    [XmlInclude(typeof(Flower))]
    [XmlInclude(typeof(Other))]
    public class Plant
    {
        public Guid Id { get; set; }
        public virtual string Type { get { return "plant"; } set { } }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public string ShortDesciption { get; set; }
        public string Level { get; set; }
        public int WateringFrequency { get; set; }

        public Plant()
        {
            Id = Guid.NewGuid();
            Status = "Healthy";
        }

        public Plant(string name, string species, string location, string shortDesciption, string level, int wateringFrequency)
        {
            Id = Guid.NewGuid();
            Name = name;
            Species = species;
            Location = location;
            Status = "Healthy";
            ShortDesciption = shortDesciption;
            Level = level;
            WateringFrequency = wateringFrequency;
        }
    }
}
