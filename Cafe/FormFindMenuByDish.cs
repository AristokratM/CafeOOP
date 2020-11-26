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
    public partial class FormFindMenuByDish : Form
    {
        public FormFindMenuByDish()
        {
            InitializeComponent();
        }

        private void FormFindMenuByDish_Load(object sender, EventArgs e)
        {
            LBDishRefresh();
        }

        private void LBDishRefresh()
        {
            lbDish.DataSource = null;
            lbDish.DataSource = Dish.Items;
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFindMenu_Click(object sender, EventArgs e)
        {
            int n = int.Parse(tbDishCount.Text);

            List<Dish> selected_dishes = new List<Dish>();
            foreach (var dish in lbDish.SelectedItems)
            {
                selected_dishes.Add((Dish)dish);
            }

            lbMenues.DataSource = null;
            lbMenues.DataSource = Data.Menu.Get_Menues_With_Minimum_Number_Of_Selected_Dishes(selected_dishes, n);
        }

        private void btnMenuInfo_Click(object sender, EventArgs e)
        {
            new FormMenu((Data.Menu)lbMenues.SelectedItem).ShowDialog();
        }
    }
}
