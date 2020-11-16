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

        private void FormDishes_Load(object sender, EventArgs e)
        {
            LBDishesRefresh();
        }
        private void LBDishesRefresh()
        {
            lbDishes.DataSource = null;
            lbDishes.DataSource = Dish.Items;
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            new FormDish(null).ShowDialog();
            LBDishesRefresh();
        }

        private void btnEditDish_Click(object sender, EventArgs e)
        {
            new FormDish((Dish)lbDishes.SelectedItem).ShowDialog();
            LBDishesRefresh();
        }

        private void btnDishInfo_Click(object sender, EventArgs e)
        {
            new FormDish((Dish)lbDishes.SelectedItem).ShowDialog();
            LBDishesRefresh();
        }

        private void btnRemoveDish_Click(object sender, EventArgs e)
        {
            //  Dish.Items.Remove((Dish)lbDishes.SelectedItem);
            Dish selectedDish = ((Dish)lbDishes.SelectedItem);
            selectedDish.Delete_All_Menues();
            selectedDish.Delete();
            LBDishesRefresh();
        }
    }
}
