using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Data
{
    public class DishInMenu:Base<DishInMenu>
    {
        // static public List<DishInMenu> DishInMenus = new List<DishInMenu>();

        private Guid _dishId;

        public DishInMenu():base()
        {

        }
        public DishInMenu(DataRow dr) : base(dr)
        {

        }
        public Dish Dish

        {
           get { if (_row["IDDISH"] != DBNull.Value)
                {
                    _dishId = new Guid(_row["IDDISH"].ToString());
                    return Dish.GetById(_dishId);
                }
                else return null; }
            set { if (value != null) { _row["IDDISH"] = _dishId = value.Id; } else { _row["IDDISH"] = DBNull.Value; } }
        }

        private Guid _menuId;
        public Menu Menu
        {
            get
            {
                if (_row["IDMENU"] != DBNull.Value)
                {
                    _menuId = new Guid(_row["IDMENU"].ToString());
                    return Menu.GetById(_menuId);
                }
                else return null;
            }
            set { if (value != null) { _row["IDMENU"] = _menuId = value.Id; } else { _row["IDMENU"] = DBNull.Value; } }
        }



    }
}
