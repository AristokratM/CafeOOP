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
    public partial class FormDishInMenu : Form
    {
        private Data.Menu _menu;
        public FormDishInMenu(Data.Menu menu)
        {
            InitializeComponent();
            _menu = menu;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDishInMenu_Load(object sender, EventArgs e)
        {
            LBRefresh();
        }
        private void LBRefresh()
        {
            lbDishes.DataSource = null;
            lbDishes.DataSource = _menu.Dishes;

            lbOtherDishes.DataSource = null;
            lbOtherDishes.DataSource = Dish.GetDishesExceptMenu(_menu);
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<Dish> dishes = new List<Dish>();
            foreach (var dish in lbOtherDishes.SelectedItems)
            {
                dishes.Add((Dish)dish);
            }

            _menu.Add_Dishes(dishes);
            LBRefresh();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            List<Dish> dishes = new List<Dish>();
            foreach (var dish in lbDishes.SelectedItems)
            {
                dishes.Add((Dish)dish);
            }
            _menu.Remove_Dishes(dishes);
            LBRefresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _menu.Delete_All_Dishes();
            LBRefresh();
        }
    }
}
