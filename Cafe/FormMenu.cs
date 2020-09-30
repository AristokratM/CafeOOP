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
    public partial class FormMenu : Form
    {
        public List<Data.Menu> Menu = new List<Data.Menu>();
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            Menu.Add(new Data.Menu { Name = tbMenuName.Text });
            LBMenuRefresh();
        }

        private void LBMenuRefresh()
        {
            lbMenu.DataSource = null;
            lbMenu.DataSource = Menu;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            LBMenuRefresh();
        }
    }
}
