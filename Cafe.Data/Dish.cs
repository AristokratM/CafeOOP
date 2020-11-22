using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Data
{
    [DataContract]
    public class Dish:Base<Dish>
    {
        //static public List<Dish> Dishes = new List<Dish>();
        [DataMember]
        public string Name
        {
            get { if (_row["NAME"] != DBNull.Value) { return Convert.ToString(_row["NAME"]); } else return ""; }
            set { _row["NAME"] = value; }
        }
        [DataMember]
        public double Price {
            get { if (_row["PRICE"] != DBNull.Value) { return Convert.ToDouble(_row["PRICE"]); } else return 0d; }
            set { _row["PRICE"] = Math.Round(value,2); }
        }
        [DataMember]
        public double Weight {
            get { if (_row["WEIGHT"] != DBNull.Value) { return Convert.ToDouble(_row["WEIGHT"]); } else return 0d; }
            set { _row["WEIGHT"] = Math.Round(value, 2); }
        }

        public Dish():base()
        {

        }
        public Dish(DataRow dr):base(dr)
        {

        }

        public List<DishInMenu> DishInMenus
        {
            get
            {
                return DishInMenu.Items.Where(dm => dm.Dish.Id == this.Id).ToList();
            }
        }
        public List<Menu> Menus
        {
            get {
                return DishInMenu.Items.Where(dm => dm.Dish.Id == this.Id).Select(dm => dm.Menu).ToList();
            }

        }
        public static List<Dish> GetDishesExceptMenu(Menu menu)
        {
            return Dish.Items.Where(d => !menu.Dishes.Contains(d)).ToList();
        }

        public bool Validate_Name()
        {
            return !this.Name.Equals("") && this.Name.Length < 50;
        }

        public void Delete_All_Menues()
        {
            foreach (var dm in this.DishInMenus)
            {
                //DishInMenu.Items.Remove(dm);
                dm.Delete();
            }
        }

        public bool Validate_Price()
        {
            return this.Price > 0;
        }

        public bool Validate_Weight()
        {
            return this.Weight > 0;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
