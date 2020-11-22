using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Cafe.Data
{
    [DataContract]
    public class XMLSerializer
    {
        private static XMLSerializer _instance;
        public static XMLSerializer Instance {
            get {
                if (_instance == null)
                {
                    _instance = new XMLSerializer();
                }
                return _instance;
            }
            private set { }
            }
        private XMLSerializer() { }
        [DataMember]
        public Staff[] Staffs
        {
            get { return Staff.Items; }

        }
        [DataMember]
        public Worker[] Workers
        {
            get { return Worker.Items; }

        }

        [DataMember]
        public Menu[] Menues
        {
            get { return Menu.Items; }

        }
        [DataMember]
        public Dish[] Dishes
        {
            get { return Dish.Items; }

        }
        [DataMember]
        public DishInMenu[] DishInMenus
        {
            get { return DishInMenu.Items; }

        }
        public static void Write(String filename)
        {
            var dcs = new DataContractSerializer(typeof(XMLSerializer));
            var xmlw = XmlWriter.Create(filename);
            dcs.WriteObject(xmlw, Instance);
            xmlw.Close();
        }
    }
}
