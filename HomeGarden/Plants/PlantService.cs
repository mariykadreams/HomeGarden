using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeGarden.Plants
{
    public static class PlantService
    {
        public static List<Plant> Plants { get; set; } = new List<Plant>();

        public static void AddPlant(Plant plant)
        {
            Plants.Add(plant);
            SavePlantsToXml();
        }

        public static void DeletePlant(Plant plant)
        {
            Plants.Remove(plant);
            SavePlantsToXml();
        }

        private static void SavePlantsToXml()
        {
            FileStream fs = File.Open("Plants.xml", FileMode.Create, FileAccess.Write);
            var serializer = new XmlSerializer(typeof(PlantsList));
            serializer.Serialize(fs, new PlantsList { Plants = Plants });
            fs.Close();
        }

        public static void LoadPlantsFromXml()
        {
            if (File.Exists("Plants.xml"))
            {
                FileStream fs = File.OpenRead("Plants.xml");
                var serializer = new XmlSerializer(typeof(PlantsList));

                PlantsList plantsList = serializer.Deserialize(fs) as PlantsList;
                Plants = plantsList.Plants;
                fs.Close();
            }
        }

        [XmlRoot(ElementName = "PlantsList")]
        public class PlantsList
        {
            [XmlElement(ElementName = "Plant")]
            public List<Plant> Plants { get; set; }
        }


    }

}
