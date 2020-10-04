using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cafe.Data;
namespace Cafe
{
    public partial class FormDishes : Form
    {
        public FormDishes()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            Data.Menu.Menus.Add(new Data.Menu { Name = tbMenuName.Text }) ;
            LBMenusRefresh();
        }

        private void LBMenusRefresh()
        {
            lbMenus.DataSource = null;
            lbMenus.DataSource = Data.Menu.Menus;
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            Dish.Dishes.Add(new Dish {Name = tbDishName.Text, Price = float.Parse(tbDishPrice.Text), Weight = float.Parse(tbDishWeight.Text) });
            LBMDishesRefresh();
        }

        private void LBMDishesRefresh()
        {
            lbDishes.DataSource = null;
            lbDishes.DataSource = Dish.Dishes;
        }

        private void FormDishes_Load(object sender, EventArgs e)
        {
            LBMenusRefresh();
            LBMDishesRefresh();
        }

        private void btnMenuDishes_Click(object sender, EventArgs e)
        {
            new FormDishInMenu((Data.Menu)lbMenus.SelectedItem).ShowDialog();
        }

        private void btnMenuInfo_Click(object sender, EventArgs e)
        {
            new FormMenu((Data.Menu)lbMenus.SelectedItem).ShowDialog();
        }
    }
}
