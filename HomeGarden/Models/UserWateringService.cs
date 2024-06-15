using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace HomeGarden.Models
{
    public class UserWateringService
    {
        public string UserId { get; set; }
        public string PlantId { get; set; }
        public string OperationId { get; set; }
        public DateTime LastWatered { get; set; } = DateTime.MinValue;

        private static readonly string DataPath = "UserWateringData.xml";

        public static void SaveWateringInfo(UserWateringService wateringService)
        {
            List<UserWateringService> services = LoadWateringInfo();

            services.RemoveAll(w => w.UserId == wateringService.UserId && w.PlantId == wateringService.PlantId);

            services.Add(wateringService);

            XmlSerializer serializer = new XmlSerializer(typeof(List<UserWateringService>));
            using (FileStream fs = new FileStream(DataPath, FileMode.Create))
            {
                serializer.Serialize(fs, services);
            }
        }

        public static List<UserWateringService> LoadWateringInfo()
        {
            if (!File.Exists(DataPath))
                return new List<UserWateringService>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<UserWateringService>));
            using (FileStream fs = new FileStream(DataPath, FileMode.Open))
            {
                return (List<UserWateringService>)serializer.Deserialize(fs);
            }
        }

        public static UserWateringService GetWateringInfo(string userId, string plantId)
        {
            List<UserWateringService> services = LoadWateringInfo();
            return services.FirstOrDefault(w => w.UserId == userId && w.PlantId == plantId);
        }

        public static List<UserWateringService> GetWateringInfoByPlant(string plantId)
        {
            List<UserWateringService> services = LoadWateringInfo();
            return services.Where(w => w.PlantId == plantId).ToList();
        }

        public static void DeleteWateringInfoByUser(string userId)
        {
            List<UserWateringService> services = LoadWateringInfo();

            services.RemoveAll(w => w.UserId == userId);

            XmlSerializer serializer = new XmlSerializer(typeof(List<UserWateringService>));
            using (FileStream fs = new FileStream(DataPath, FileMode.Create))
            {
                serializer.Serialize(fs, services);
            }
        }

        public static void DeleteWateringInfo(string userId, string plantId)
        {
            List<UserWateringService> services = LoadWateringInfo();

            services.RemoveAll(w => w.UserId == userId && w.PlantId == plantId);

            XmlSerializer serializer = new XmlSerializer(typeof(List<UserWateringService>));
            using (FileStream fs = new FileStream(DataPath, FileMode.Create))
            {
                serializer.Serialize(fs, services);
            }

        }



    }
}
