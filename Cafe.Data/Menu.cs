using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cafe.Data
{
    [DataContract]
    public class Menu : Base<Menu>
    {
        //  static public List<Menu> Menus = new List<Menu>();
        [DataMember]
        public string Name
        {
            get { if (_row["NAME"] != DBNull.Value) { return Convert.ToString(_row["NAME"]); } else return ""; }
            set { _row["NAME"] = value; }
        }
        public Menu(DataRow dr):base(dr)
        {
      
        }
        public Menu():base()
        {

        }
        [DataMember]
        public int NumberOfDishes
        {
            get { return Dishes.Count(); }
            set { }
        }
        [JsonIgnore]
        public List<DishInMenu> DishInMenus
        {
            get { return DishInMenu.Items.Where(dm => dm.Menu.Id == this.Id).ToList(); }
        }
        [JsonIgnore]
        public List<Dish> Dishes
        {
            get { return DishInMenu.Items.Where(dm => dm.Menu.Id == this.Id).Select(dm => dm.Dish).ToList(); }
        }

        public void Add_Dishes(List<Dish> dishes)
        {
            foreach (var dish in dishes)
            {
                // DishInMenu.Items.Add(new DishInMenu { Menu = this, Dish = dish });
                (new DishInMenu { Menu = this, Dish = dish }).Save();
            }

        }
        public void Remove_Dishes(List<Dish> dishes)
        {
            foreach (var dish in dishes)
            {
                // DishInMenu.Items.Remove(dish.DishInMenus.Where(dm => dm.Menu == this).FirstOrDefault());
                dish.DishInMenus.Where(dm => dm.Menu.Id == this.Id).FirstOrDefault().Delete();
            }
           
        }
        public void Delete_All_Dishes()
        {
            foreach (var dm in this.DishInMenus)
            {
                //DishInMenu.Items.Remove(dm);
                dm.Delete();
            }
        }

        public static List<Menu> Get_Menues_With_Minimum_Number_Of_Selected_Dishes(List<Dish> selected_dishes, int n)
        {
            List<Menu> finded = new List<Menu>();
            foreach (var menu in Menu.Items)
            {
                int count = 0;
                foreach (var dish in selected_dishes)
                {
                    if (menu.Dishes.Contains(dish))
                    {
                        count += 1;
                        if (count >= n)
                        {
                            finded.Add(menu);
                            break;
                        }
                    }
                }


            }

            return finded;
        }

        public bool Validate_Name()
        {
             return !this.Name.Equals("") && this.Name.Length < 50;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
