using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Data
{
    public class Dish:BaseClass<Dish>
    {
        //static public List<Dish> Dishes = new List<Dish>();

        public float Price { get; set; }

        public float Weight { get; set; }

        public String Ingredients { get; set; }

        public List<DishInMenu> DishInMenus
        {
            get
            {
                return DishInMenu.Items.Where(dm => dm.Dish == this).ToList();
            }
        }
        public List<Menu> Menus
        {
            get {
                return DishInMenu.Items.Where(dm => dm.Dish == this).Select(dm => dm.Menu).ToList();
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

        public bool Validate_Price()
        {
            return this.Price > 0;
        }

        public bool Validate_Weight()
        {
            return this.Weight > 0;
        }
    }
}
