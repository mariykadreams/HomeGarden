using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HomeGarden.Plants
{
    public class Flower : Plant
    {
        public override string Type { get { return "Flower"; } set { } }
        public string Color { get; set; }
        public Flower() { }

        public Flower(string name, string color, string species, string location, string shortDesciption, string level)
        : base(name, species, location, shortDesciption, level)
        {
            Color = color;
        }
    }
}
