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
        public List<Dish> Dishes
        {
            get { return Dish.Dishes.Where(d => d.Menu == this).ToList(); }
            set { }
        }
    }
}
