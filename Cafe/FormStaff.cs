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
    public partial class FormStaff : Form
    {
        private Staff _staff;
        public FormStaff(Staff staff)
        {
            InitializeComponent();
            _staff = staff;
        }


        private void FormStaff_Load(object sender, EventArgs e)
        {
            string workers = "";
            int i = 0;
            foreach(Worker worker in _staff.Workers)
            {
                i++;
                workers += i.ToString()+") "+ worker.ToString()+"\n";
            }
            rtbStaffInfo.Text = "Staf Name: " + _staff.Name + "\n"
                + "Staff Description: " + _staff.Description + "\n"
                + "Number of Workers: "+_staff.NumberOfWorkers+"\n"
                + "Workers:\n"
                + workers;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
