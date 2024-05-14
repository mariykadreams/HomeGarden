using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeGarden.Plants
{
    [XmlInclude(typeof(Vegetable)), XmlInclude(typeof(Flower))]
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

        public Plant()
        {
            Id = Guid.NewGuid();
        }

        public Plant(string name, string species, string location, string shortDesciption, string level)
        {
            Id = Guid.NewGuid();
            Name = name;
            Species = species;
            Location = location;
            Status = "Healthy";
            ShortDesciption = shortDesciption;
            Level = level;
        }
    }

}
