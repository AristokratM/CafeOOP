using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cafe.Data
{
    [DataContract]
    public class JSONSerializer
    {
        private static JSONSerializer _instance;

        public static JSONSerializer Instance
        {
            get {
                if(_instance == null)
                {
                    _instance = new JSONSerializer();
                }
                return _instance;
            }

        }

        private JSONSerializer() {}

     //   [DataMember]
        public Staff[] Staffs
        {
            get { return Staff.Items; }

        }
     //   [DataMember]
        public Worker[] Workers
        {
            get { return Worker.Items; }

        }

    //    [DataMember]
        public Menu[] Menues
        {
            get { return Menu.Items; }

        }
   //     [DataMember]
        public Dish[] Dishes
        {
            get { return Dish.Items; }

        }
     //   [DataMember]
        public DishInMenu[] DishInMenus
        {
            get { return DishInMenu.Items; }

        }
        public static void Write(String filename)
        {
            var options = new JsonSerializerOptions()
            {
                MaxDepth = 0,
                IgnoreNullValues = true,
                IgnoreReadOnlyProperties = true,
                WriteIndented = true,

            };
            var jsonString = JsonSerializer.Serialize(Instance, options);
            File.WriteAllText(filename, jsonString);
        }
    }
}
