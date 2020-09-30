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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAboutForm_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }

        private void btnWorkersForm_Click(object sender, EventArgs e)
        {
            new FormWorkers().ShowDialog();
        }

        private void btnDishesForm_Click(object sender, EventArgs e)
        {
            new FormDishes().ShowDialog();
        }

        private void btnMenuForm_Click(object sender, EventArgs e)
        {
            new FormMenu().ShowDialog();
        }

    }
}
