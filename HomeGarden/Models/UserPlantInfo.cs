using HomeGarden.Plants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeGarden.Models
{
    public class UserPlantInfo
    {
        public Plant Plant { get; set; }

        public DateTime LastWatered { get; set; }

        public UserPlantInfo()
        {
            LastWatered = DateTime.MinValue;
        }

        public UserPlantInfo(Plant plant)
        {
            Plant = plant;
            LastWatered = DateTime.MinValue;
        }

    }
}

