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

        }
        private void LBStaffsRefresh()
        {
            lbStaffs.DataSource = null;
            lbStaffs.DataSource = Data.Staff.Items;
        }
    }
}
