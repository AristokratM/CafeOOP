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

        public string Recipe { get; set; }
        public Menu Menu
        {
            get { return Menu.Menus.Where(m => m.Id == _menuId).FirstOrDefault(); }
            set { _menuId = value.Id; }
        }
    }
}
