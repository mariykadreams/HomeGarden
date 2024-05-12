using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace HomeGarden
{
    public static class MyApplicationService
    {
        public static List<User> Users { get; set; } = new List<User>();

        public static void AddUser(User user)
        {
            Users.Add(user);
        }

        public static void DeleteUser(User user)
        {
            Users.Remove(user);
        }
    }
}
