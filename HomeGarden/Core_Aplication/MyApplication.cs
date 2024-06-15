using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using HomeGarden.Models;

namespace HomeGarden.Core_Aplication
{
    public static class MyApplication
    {
        public enum Mode
        {
            User,
            SuperAdmin,
            Admin
        }
        public enum PlantType
        {
            Vegetable,
            Flower,
            Other,
            All
        }

        public static User NowUser { get; set; }
        public static Mode UserMode { get; set; }
        public static string CurrentUserId => NowUser?.Id.ToString();

    }
}
