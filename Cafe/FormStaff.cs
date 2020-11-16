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

        public Boolean IsExist { get; private set; }
        public FormStaff(Staff staff)
        {
            InitializeComponent();
            _staff = staff;
            if(_staff != null)
            {
                IsExist = true;
                tbStaffName.Text = _staff.Name;
                tbStaffDescription.Text = _staff.Description;
            } else
            {
                _staff = new Staff();
            }
        }


        private void FormStaff_Load(object sender, EventArgs e)
        {
            RTBStaffInfoRefresh();
        }
        private void RTBStaffInfoRefresh()
        {
            string workers = "";
            if(_staff.Name == null)
            {
                rtbStaffInfo.Text = "No Info";
                return;
            }
            int i = 0;
            foreach (Worker worker in _staff.Workers)
            {
                i++;
                workers += i.ToString() + ") " + worker.ToString() + "\n";
            }
            rtbStaffInfo.Text = "Staf Name: " + _staff.Name + "\n"
                + "Staff Description: " + _staff.Description + "\n"
                + "Number of Workers: " + _staff.NumberOfWorkers + "\n"
                + "Workers:\n"
                + workers;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            _staff.Name = tbStaffName.Text;
            _staff.Description = tbStaffDescription.Text;
            if(!IsExist)
            {
                //Staff.Items.Add(_staff);
                IsExist = true;
            }
            _staff.Save();
            RTBStaffInfoRefresh();
        }
    }
}
