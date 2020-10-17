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
    public partial class FormMenus : Form
    {
        public FormMenus()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            new FormMenu(null).ShowDialog();
            LBMenusRefresh();

        }

        private void LBMenusRefresh()
        {
            lbMenus.DataSource = null;
            lbMenus.DataSource = Data.Menu.Items;
        }




        private void FormDishes_Load(object sender, EventArgs e)
        {
            LBMenusRefresh();
        }

        private void btnMenuDishes_Click(object sender, EventArgs e)
        {
            new FormDishInMenu((Data.Menu)lbMenus.SelectedItem).ShowDialog();
        }

        private void btnMenuInfo_Click(object sender, EventArgs e)
        {
            new FormMenu((Data.Menu)lbMenus.SelectedItem).ShowDialog();
            LBMenusRefresh();
        }

        private void btnEditMenu_Click(object sender, EventArgs e)
        {
            new FormMenu((Data.Menu)lbMenus.SelectedItem).ShowDialog();
            LBMenusRefresh();
        }

        private void btnRemoveMenu_Click(object sender, EventArgs e)
        {
            Data.Menu.Items.Remove((Data.Menu)lbMenus.SelectedItem);
            LBMenusRefresh();
        }
    }
}
