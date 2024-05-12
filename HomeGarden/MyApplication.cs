using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace HomeGarden
{
    public static class MyApplication
    {
        public enum Mode
        {
            User,
            Admin
        }
        public enum PlantType
        {
            Vegetable,
            Flower,
            Tree,
            Bush
        } 

        public static User NowUser { get; set; }
        public static Mode UserMode { get; set; }
       
    }
}
