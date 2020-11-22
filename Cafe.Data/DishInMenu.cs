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
    public class DishInMenu:Base<DishInMenu>
    {
        // static public List<DishInMenu> DishInMenus = new List<DishInMenu>();
        [DataMember]
        private Guid _dishId {
            get
            {
                if (_row["IDDISH"] != DBNull.Value)
                {
                    return  new Guid(_row["IDDISH"].ToString());
                }
                return Guid.Empty;
            }
            set { }
        }

        public DishInMenu():base()
        {

        }
        public DishInMenu(DataRow dr) : base(dr)
        {

        }
        public Dish Dish

        {
           get { //if (_row["IDDISH"] != DBNull.Value)
               // {
                  //  _dishId = new Guid(_row["IDDISH"].ToString());
                  if(_dishId != Guid.Empty) { 
                    return Dish.GetById(_dishId);
                }
                else return null; }
            set { if (value != null) { _row["IDDISH"] = value.Id; } else { _row["IDDISH"] = DBNull.Value; } }
        }
        [DataMember]
        private Guid _menuId
        {
            get
            {
                if(_row["IDMENU"] != DBNull.Value)
                {
                    return new Guid(_row["IDMENU"].ToString());
                }
                return Guid.Empty;
            }
            set { }
        }

        public Menu Menu
        {
            get
            {
              //  if (_row["IDMENU"] != DBNull.Value)
              //  {
                  if(_menuId != Guid.Empty) { 
                    _menuId = new Guid(_row["IDMENU"].ToString());
                    return Menu.GetById(_menuId);
                }
                else return null;
            }
            set { if (value != null) { _row["IDMENU"]  = value.Id; } else { _row["IDMENU"] = DBNull.Value; } }
        }



    }
}
