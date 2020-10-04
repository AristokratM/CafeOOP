﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Data
{
    public class DishInMenu:BaseClass
    {
        static public List<DishInMenu> DishInMenus = new List<DishInMenu>();

        private Guid _dishId;

        public Dish Dish

        {
            get { return Dish.Dishes.Where(d => d.Id == _dishId).FirstOrDefault(); }
            set { _dishId = value.Id; }
        }

        private Guid _menuId;

        public Menu Menu
        {
            get { return Menu.Menus.Where(m => m.Id == _menuId).FirstOrDefault(); }
            set { _menuId = value.Id; }
        }



    }
}