using System;

namespace HomeGarden.Plants
{
    public class Vegetable : Plant
    {
        public override string Type { get { return "Vegetable"; } set { } }
        public string Size { get; set; }

        public Vegetable() { }

        public Vegetable(string name, string size, string species, string location, string shortDesciption, string level, int wateringFrequency)
        : base(name, species, location, shortDesciption, level, wateringFrequency)
        {
            Size = size;
        }
    }
}
