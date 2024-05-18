using System;

namespace HomeGarden.Plants
{
    public class Other : Plant
    {
        public override string Type { get { return "Other"; } set { } }

        public Other() { }

        public Other(string name, string species, string location, string shortDesciption, string level, int wateringFrequency)
        : base(name, species, location, shortDesciption, level, wateringFrequency)
        {
        }
    }
}
