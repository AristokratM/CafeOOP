using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Data
{
    public class Menu:BaseClass<Menu>
    {
      //  static public List<Menu> Menus = new List<Menu>();
        
        public int NumberOfDishes
        {
            get { return Dishes.Count(); }
        }
        public List<DishInMenu> DishInMenus
        {
            get { return DishInMenu.Items.Where(dm => dm.Menu == this).ToList(); }
        }
        public List<Dish> Dishes
        {
            get { return DishInMenu.Items.Where(dm => dm.Menu == this).Select(dm => dm.Dish).ToList(); }
        }

        public void Add_Dishes(List<Dish> dishes)
        {
            foreach (var dish in dishes)
            {
                DishInMenu.Items.Add(new DishInMenu { Menu = this, Dish = dish });
            }
        }
        public void Remove_Dishes(List<Dish> dishes)
        {
            foreach (var dish in dishes)
            {
                DishInMenu.Items.Remove(dish.DishInMenus.Where(dm => dm.Menu == this).FirstOrDefault());
            }
           
        }
        public void Delete_All_Dishes()
        {
            foreach (var dm in this.DishInMenus)
            {
                DishInMenu.Items.Remove(dm);
            }
        }

        public bool Validate_Name()
        {
             return !this.Name.Equals("") && this.Name.Length < 50;
        }
    }
}
