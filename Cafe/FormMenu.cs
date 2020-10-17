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
        public Boolean IsExist { get; private set; }
        public FormMenu(Data.Menu menu)
        {
            InitializeComponent();
            _menu = menu;
            if(_menu != null)
            {
                IsExist = true;
                tbMenuName.Text = _menu.Name;
            }
            else
            {
                _menu = new Data.Menu();
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            RTBMenuInfoRefresh();
        }

        private void RTBMenuInfoRefresh()
        {
            string dishes = "";
            int i = 0;
            foreach (var dish in _menu.Dishes)
            {
                i += 1;
                dishes += i + ")" + dish + " " + dish.Price + " ua, " + dish.Weight + " grams.\n";
            }
            if (_menu.Name == null && dishes.Equals(""))
            {
                rtbMenuInfo.Text = "Is empty.";
            }
            else if (dishes.Equals(""))
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

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            _menu.Name = tbMenuName.Text;
            if(!IsExist)
            {
                Data.Menu.Items.Add(_menu);
                IsExist = true;
            }
            RTBMenuInfoRefresh();
        }
    }
}
