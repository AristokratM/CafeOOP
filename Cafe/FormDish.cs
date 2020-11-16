using Cafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class FormDish : Form
    {
        private Dish _dish;
        public Boolean IsExist { get; private set; }

        public FormDish(Dish dish)
        {
            InitializeComponent();
            _dish = dish;
            if(_dish != null)
            {
                IsExist = true;
                tbDishName.Text = _dish.Name;
                tbDishPrice.Text = dish.Price.ToString();
                tbDishWeight.Text = dish.Weight.ToString();
            } else
            {
                _dish = new Dish();
            }
        }

        private void FormDish_Load(object sender, EventArgs e)
        {
            RTBDishInfoRefresh();
        }
        private void RTBDishInfoRefresh()
        {
            string menus = "";
            int i = 0;
            foreach (var menu in _dish.Menus)
            {
                i += 1;
                menus += i + ")" + menu + "\n";
            }
            if (_dish.Name == null && menus.Equals(""))
            {
                rtbDishInfo.Text = "No Info";
            }
            else if (menus.Equals(""))
            {
                rtbDishInfo.Text = "Dish: " + _dish + "\n" +
                    "Price: " + _dish.Price + " ua\n" +
                    "Weight: " + _dish.Weight + " grams\n" +
                    "Dish doesn't belong to any menu. \n";
            
            }
            else
            {
                rtbDishInfo.Text = "Dish: " + _dish + "\n" +
                    "Price: " + _dish.Price +" ua\n" +
                    "Weight: " + _dish.Weight + " grams\n" +
                    "Dish belong to menus: \n" +
                    menus;
            }
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            _dish.Name = tbDishName.Text;
            _dish.Price = float.Parse(tbDishPrice.Text);
            _dish.Weight = float.Parse(tbDishWeight.Text);
            if(!IsExist)
            {
              //  Dish.Items.Add(_dish);
                IsExist = true;
            }
            _dish.Save();
            RTBDishInfoRefresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
