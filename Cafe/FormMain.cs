﻿using System;
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

            Data.Menu menu1 = new Data.Menu { Name = "Cheff Menu" };
            Data.Menu menu2 = new Data.Menu { Name = "Tourist Menu" };
            Data.Menu menu3 = new Data.Menu { Name = "Du Jour Menu" };
            Data.Menu menu4 = new Data.Menu { Name = "Main Menu" };
            Data.Menu.Menus.Add(menu1);
            Data.Menu.Menus.Add(menu2);
            Data.Menu.Menus.Add(menu3);
            Data.Menu.Menus.Add(menu4);

            Dish dish1 = new Dish { Name = "Greek salad", Price=155, Weight=330 };
            Dish dish2 = new Dish { Name = "Garden fresh salad", Price = 100, Weight = 350 };
            Dish dish3 = new Dish { Name = "Bacon and eggs", Price = 90, Weight = 200 };
            Dish dish4 = new Dish { Name = "New-York steak", Price = 300, Weight = 230 };
            Dish dish5 = new Dish { Name = "Omelette", Price = 40, Weight = 100 };
            Dish dish6 = new Dish { Name = "Shish kebab", Price = 330, Weight = 400 };
            Dish.Dishes.Add(dish1);
            Dish.Dishes.Add(dish2);
            Dish.Dishes.Add(dish3);
            Dish.Dishes.Add(dish4);
            Dish.Dishes.Add(dish5);
            Dish.Dishes.Add(dish6);

            DishInMenu.DishInMenus.Add(new DishInMenu { Menu = menu2, Dish = dish4});
            DishInMenu.DishInMenus.Add(new DishInMenu { Menu = menu4, Dish = dish4 });
            DishInMenu.DishInMenus.Add(new DishInMenu { Menu = menu4, Dish = dish1 });
            DishInMenu.DishInMenus.Add(new DishInMenu { Menu = menu4, Dish = dish2 });
            DishInMenu.DishInMenus.Add(new DishInMenu { Menu = menu3, Dish = dish3 });
            DishInMenu.DishInMenus.Add(new DishInMenu { Menu = menu3, Dish = dish5 });
            DishInMenu.DishInMenus.Add(new DishInMenu { Menu = menu2, Dish = dish6 });
            DishInMenu.DishInMenus.Add(new DishInMenu { Menu = menu4, Dish = dish6 });
        }
    }
}
