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
        private Data.Menu _menu;
        public FormMenu(Data.Menu menu)
        {
            InitializeComponent();
            _menu = menu;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            string dishes = "";
            int i = 0;
            foreach (var dish in _menu.Dishes)
            {
                i += 1;
                dishes += i + ")" + dish + " " + dish.Price + " ua, " + dish.Weight + " grams.\n";
            }
            if (dishes.Equals(""))
            {
                rtbMenuInfo.Text = _menu + " is empty.";
            }
            else
            {
                rtbMenuInfo.Text = "Menu: " + _menu + "\n" +
                    "Dishes in menu: \n" +
                    dishes;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
