using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace HomeGarden.Models
{
    public class UserPlantPreferences
    {
        public string PlantId { get; set; }
        public bool IsWateringChecked { get; set; }
        public string UserId { get; set; }
        public string OperationId { get; set; }
    }

    public static class UserWateringService
    {
        private static readonly string filePath = "userPreferences.json";

        public static Dictionary<string, UserPlantPreferences> LoadPreferences()
        {
            if (!File.Exists(filePath))
            {
                return new Dictionary<string, UserPlantPreferences>();
            }

            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Dictionary<string, UserPlantPreferences>>(json);
        }

        public static void SavePreferences(Dictionary<string, UserPlantPreferences> preferences)
        {
            var json = JsonConvert.SerializeObject(preferences, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
