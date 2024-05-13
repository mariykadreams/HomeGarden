using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Xml.Serialization;

namespace HomeGarden
{
    public static class MyApplicationService
    {
        public static List<User> Users { get; set; } = new List<User>();

        public static void AddUser(User user)
        {
            Users.Add(user);
            SaveUsersToXml(); // Save the updated list back to the XML file
        }

        public static void DeleteUser(User user)
        {
            Users.Remove(user);
        }
        private static void SaveUsersToXml()
        {
            FileStream fs = File.Open("Users.xml", FileMode.Create, FileAccess.Write); // Замените FileMode.Append на FileMode.Create
            var serializer = new XmlSerializer(typeof(UsersList));
            serializer.Serialize(fs, new UsersList { Users = Users });
            fs.Close();
        }



        public static void UserLoadData()
        {
            FileStream fs = File.OpenRead("Users.xml");
            var serializer = new XmlSerializer(typeof(UsersList)); // Change type to UsersList

            UsersList usersList = serializer.Deserialize(fs) as UsersList; // Deserialize into UsersList
            MyApplicationService.Users = usersList.Users; // Assign users from UsersList to MyApplicationService
            fs.Close();
        }

        // Define a class to represent the UsersList element
        [XmlRoot(ElementName = "UsersList")]
        public class UsersList
        {
            [XmlElement(ElementName = "User")]
            public List<User> Users { get; set; }
        }

    }
}
