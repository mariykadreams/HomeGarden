using System;

namespace HomeGarden.Plants
{
    public class Flower : Plant
    {
        public override string Type { get { return "Flower"; } set { } }
        public string Color { get; set; }

        public Flower() { }

        public Flower(string name, string color, string species, string location, string shortDesciption, string level, int wateringFrequency)
        : base(name, species, location, shortDesciption, level, wateringFrequency)
        {
            Color = color;
        }
    }
}
