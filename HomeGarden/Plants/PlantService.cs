using System;
using System.Collections.Generic;
using System.IO;
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

        public static void UpdatePlant(Plant updatedPlant)
        {
            var existingPlant = Plants.FirstOrDefault(p => p.Id == updatedPlant.Id);
            if (existingPlant != null)
            {
                existingPlant.Name = updatedPlant.Name;
                existingPlant.Species = updatedPlant.Species;
                existingPlant.ShortDesciption = updatedPlant.ShortDesciption;
                existingPlant.Level = updatedPlant.Level;
                existingPlant.WateringFrequency = updatedPlant.WateringFrequency;
                existingPlant.Location = updatedPlant.Location;

                if (existingPlant is Flower existingFlower && updatedPlant is Flower updatedFlower)
                {
                    existingFlower.Color = updatedFlower.Color;
                }
                else if (existingPlant is Vegetable existingVegetable && updatedPlant is Vegetable updatedVegetable)
                {
                    existingVegetable.Size = updatedVegetable.Size;
                }
            }

            SavePlantsToXml();
        }

        private static void SavePlantsToXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PlantsList));
            using (FileStream fs = File.Open("Plants.xml", FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(fs, new PlantsList { Plants = Plants });
            }
        }

        public static void LoadPlantsFromXml()
        {
            if (File.Exists("Plants.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(PlantsList));
                using (FileStream fs = File.OpenRead("Plants.xml"))
                {
                    PlantsList plantsList = (PlantsList)serializer.Deserialize(fs);
                    Plants = plantsList.Plants;
                }
            }
        }

        [XmlRoot("PlantsList")]
        public class PlantsList
        {
            [XmlElement("Plant")]
            public List<Plant> Plants { get; set; }
        }

        #region sort
        public static void SortPlantsByName()
        {
            Plants = Plants.OrderBy(plant => plant.Name).ToList();
        }

        public static void SortPlantsBySpecies()
        {
            Plants = Plants.OrderBy(plant => plant.Species).ToList();
        }

        public static void SortPlantsByLocation()
        {
            Plants = Plants.OrderBy(plant => plant.Location).ToList();
        }

        public static void SortPlantsByStatus()
        {
            Plants = Plants.OrderBy(plant => plant.Status).ToList();
        }

        public static void SortPlantsByLevel()
        {
            Plants = Plants.OrderBy(plant => plant.Level).ToList();
        }

        public static void SortPlantsByWateringFrequency()
        {
            Plants = Plants.OrderBy(plant => plant.WateringFrequency).ToList();
        }

        public static void SortPlantsByType()
        {
            Plants = Plants.OrderBy(plant => plant.Type).ToList();
        }
        #endregion

        #region search

        public static List<Plant> SearchPlantsById(List<Plant> source, string partialId)
        {
            return source.Where(plant => plant.Id.ToString().Contains(partialId, StringComparison.OrdinalIgnoreCase)).ToList();
        }


        public static List<Plant> SearchPlantsByType(List<Plant> source, string type)
        {
            return source.Where(plant => plant.Type == type || type == String.Empty).ToList();
        }

        public static List<Plant> SearchPlantsByName(List<Plant> source, string name)
        {
            return source.Where(plant => plant.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static List<Plant> SearchPlantsBySpecies(List<Plant> source, string species)
        {
            return source.Where(plant => plant.Species.Contains(species, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static List<Plant> SearchPlantsByLocation(List<Plant> source, string location)
        {
            return source.Where(plant => plant.Location.Contains(location, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static List<Plant> SearchPlantsByStatus(List<Plant> source, string status)
        {
            return source.Where(plant => plant.Status.Contains(status, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static List<Plant> SearchPlantsByLevel(List<Plant> source, string level)
        {
            return source.Where(plant => plant.Level.Contains(level, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public static List<Plant> SearchPlantsByWateringFrequency(List<Plant> source, int wateringFrequency)
        {
            return source.Where(plant => plant.WateringFrequency <= wateringFrequency).ToList();
        }

        public static List<Plant> SearchPlantsBySize(List<Plant> source, string size)
        {
            return source.OfType<Vegetable>().Where(plant => plant.Size.Contains(size, StringComparison.OrdinalIgnoreCase)).ToList<Plant>();
        }

        public static List<Plant> SearchPlantsByColor(List<Plant> source, string color)
        {
            return source.OfType<Flower>().Where(plant => plant.Color.Contains(color, StringComparison.OrdinalIgnoreCase)).ToList<Plant>();
        }

        #endregion

    }
}
