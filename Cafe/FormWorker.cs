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
    public partial class FormWorker : Form
    {
        private Worker _worker;
        public FormWorker(Worker worker)
        {
            InitializeComponent();
            _worker = worker;
        }

        private void FormWorker_Load(object sender, EventArgs e)
        {
            rtbWorkerInfo.Text = "Name: " + _worker.Name + "\n"
                + "Surname: " + _worker.SName + "\n"
                + "Parentname: " + _worker.PName + "\n"
                + "Staff: " + _worker.Staff + "\n"
                + "Gender: " + _worker.Gender + "\n"
                + "Age: " + _worker.Age + "\n"
                + "Birhday: " + _worker.Birthday.ToShortDateString() + "\n"
                + "Salary: " + _worker.Salary +"\n";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
