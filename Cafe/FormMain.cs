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

        private void FormMain_Load(object sender, EventArgs e)
        {
            Staff staff1 = new Staff { Name = "Kitchen", Description = "Some info" };
            Staff staff2 = new Staff { Name = "Accounting", Description = "Some another info" };
            Staff.Staffs.Add(staff1);
            Staff.Staffs.Add(staff2);
            Worker worker1 = new Worker { Name = "Oleh", SName = "Tonkoshkur", PName = "Ruslanovych", Birthday = new DateTime(2002, 5, 13), Gender = Gender.Male, Staff = staff1, Salary = 1500 };
            Worker worker2 = new Worker { Name = "Ivan", SName = "Ivanov", PName = "Ivanovych", Birthday = new DateTime(2000, 5, 13), Gender = Gender.Male, Staff = staff2, Salary = 1000 };
            Worker.Workers.Add(worker1);
            Worker.Workers.Add(worker2);
        }
    }
}
