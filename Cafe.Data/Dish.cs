using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Data
{
    public class Dish:BaseClass
    {
        static public List<Dish> Dishes = new List<Dish>();
        private Guid _menuId;

        public float Price { get; set; }

        public float Weight { get; set; }

        public String Ingredients { get; set; }

        public List<DishInMenu> DishInMenus
        {
            get
            {
                return DishInMenu.DishInMenus.Where(dm => dm.Dish == this).ToList();
            }
        }
        public List<Menu> Menus
        {
            get {
                return DishInMenu.DishInMenus.Where(dm => dm.Dish == this).Select(dm => dm.Menu).ToList();
            }

        }
        public static List<Dish> GetDishesExceptMenu(Menu menu)
        {
            return Dish.Dishes.Where(d => !menu.Dishes.Contains(d)).ToList();
        }
    }
}
