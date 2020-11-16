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
    public partial class FormWorkers : Form
    {

        public FormWorkers()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            new FormWorker(null).ShowDialog();
            LBWorkersRefresh();
        }

        private void LBWorkersRefresh()
        {
            lbWorkers.DataSource = null;
            lbWorkers.DataSource = Worker.Items;
        }


        private void FormWorker_Load(object sender, EventArgs e)
        {
            LBWorkersRefresh();


        }

        private void btnWorkerInfo_Click(object sender, EventArgs e)
        {
            new FormWorker((Worker)lbWorkers.SelectedItem).ShowDialog();
            LBWorkersRefresh();
        }

        private void btnEditWorker_Click(object sender, EventArgs e)
        {
            new FormWorker((Worker)lbWorkers.SelectedItem).ShowDialog();
            LBWorkersRefresh();
        }

        private void btnRemoveWorker_Click(object sender, EventArgs e)
        {
            //Worker.Items.Remove((Worker)lbWorkers.SelectedItem);
            ((Worker)lbWorkers.SelectedItem).Delete();
            LBWorkersRefresh();
        }
    }
}
