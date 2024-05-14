using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeGarden.Plants
{
    public class Vegetable : Plant
    {
        public override string Type { get { return "Vegetable"; } set { } }
        public string Size { get; set; }

        public Vegetable(string name, string size, string species, string location, string shortDesciption, string level)
       : base(name, species, location, shortDesciption, level)
        {
            Size = size;
        }

        public Vegetable() { }
    }
}
