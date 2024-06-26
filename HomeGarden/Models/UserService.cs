﻿using HomeGarden.Plants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeGarden.Models
{
    public static class UserService
    {
        public static List<User> Users { get; set; } = new List<User>();

        public static void AddUser(User user)
        {
            Users.Add(user);
            SaveUsersToXml(); 
        }

        public static void DeleteUser(User user)
        {
            Users.Remove(user);
            SaveUsersToXml();
        }
        private static void SaveUsersToXml()
        {
            FileStream fs = File.Open("Users.xml", FileMode.Create, FileAccess.Write); 
            var serializer = new XmlSerializer(typeof(UsersList));
            serializer.Serialize(fs, new UsersList { Users = Users });
            fs.Close();
        }

        public static void UserLoadData()
        {
            FileStream fs = File.OpenRead("Users.xml");
            var serializer = new XmlSerializer(typeof(UsersList)); 

            UsersList usersList = serializer.Deserialize(fs) as UsersList; 
            Users = usersList.Users; 
            fs.Close();
        }

        [XmlRoot(ElementName = "UsersList")]
        public class UsersList
        {
            [XmlElement(ElementName = "User")]
            public List<User> Users { get; set; }
        }

        public static User GetUserByEmail(string email)
        {
            return Users.FirstOrDefault(u => u.Email == email);
        }

        public static void AddPlantToUser(User user, UserPlantInfo userPlantInfo)
        {
            Plant plant = userPlantInfo.Plant;
            userPlantInfo.LastWatered = DateTime.Now; 
            user.MyPlants.Add(plant);
            SaveUsersToXml();
        }



        public static void DeletePlantFromUser(User user, Plant plant)
        {
            if (user != null && plant != null && user.MyPlants.Contains(plant))
            {
                user.MyPlants.Remove(plant);
                SaveUsersToXml();
            }
            else
            {
                Console.WriteLine("Error: User or plant is null, or the plant is not found in the user's list.");
            }
        }

        #region sort
        public static void SortPlantsByName(User user)
        {
            user.MyPlants = user.MyPlants.OrderBy(plant => plant.Name).ToList();
        }

        public static void SortPlantsBySpecies(User user)
        {
            user.MyPlants = user.MyPlants.OrderBy(plant => plant.Species).ToList();
        }

        public static void SortPlantsByLocation(User user)
        {
            user.MyPlants = user.MyPlants.OrderBy(plant => plant.Location).ToList();
        }

        public static void SortPlantsByStatus(User user)
        {
            user.MyPlants = user.MyPlants.OrderBy(plant => plant.Status).ToList();
        }

        public static void SortPlantsByLevel(User user)
        {
            user.MyPlants = user.MyPlants.OrderBy(plant => plant.Level).ToList();
        }

        public static void SortPlantsByWateringFrequency(User user)
        {
            user.MyPlants = user.MyPlants.OrderBy(plant => plant.WateringFrequency).ToList();
        }

        public static void SortPlantsByType(User user)
        {
            user.MyPlants = user.MyPlants.OrderBy(plant => plant.Type).ToList();
        }
        #endregion






    }
}
