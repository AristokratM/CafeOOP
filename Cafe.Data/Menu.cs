using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Data
{
    public class Menu:BaseClass
    {
        static public List<Menu> Menus = new List<Menu>();
        
        public int NumberOfDishes
        {
            get { return Dishes.Count(); }
        }
        public List<DishInMenu> DishInMenus
        {
            get { return DishInMenu.DishInMenus.Where(dm => dm.Menu == this).ToList(); }
        }
        public List<Dish> Dishes
        {
            get { return DishInMenu.DishInMenus.Where(dm => dm.Menu == this).Select(dm => dm.Dish).ToList(); }
        }
    }
}
