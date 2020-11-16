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
    public partial class FormStaffs : Form
    {
        public FormStaffs()
        {
            InitializeComponent();
        }

        private void FormStaffs_Load(object sender, EventArgs e)
        {
            LBStaffsRefresh();
        }
        private void LBStaffsRefresh()
        {
            lbStaffs.DataSource = null;
            lbStaffs.DataSource = Data.Staff.Items;
        }

        private void btnStaffInfo_Click(object sender, EventArgs e)
        {
            new FormStaff((Staff)lbStaffs.SelectedItem).ShowDialog();
            LBStaffsRefresh();
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            new FormStaff((Staff)lbStaffs.SelectedItem).ShowDialog();
            LBStaffsRefresh();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            new FormStaff(null).ShowDialog();
            LBStaffsRefresh();
        }

        private void btnRemoveStaff_Click(object sender, EventArgs e)
        {
            //   Staff.Items.Remove((Staff)lbStaffs.SelectedItem);
            ((Staff)lbStaffs.SelectedItem).Delete();
            LBStaffsRefresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
